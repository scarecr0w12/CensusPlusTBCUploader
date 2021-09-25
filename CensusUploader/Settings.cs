using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Web;
using System.Collections.Specialized;
using System.Reflection;
using System.Text.RegularExpressions;

namespace TBCPopUploader
{
    public partial class Settings : Form
    {
        Properties.Settings settings = Properties.Settings.Default;
        HybridDictionary lastUpload = new HybridDictionary();
        HybridDictionary stats = new HybridDictionary();

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

            checkUpdate();
            checkRunAtStartup();

            if (settings.LastUpload != "")
            {
                lastUpload = JsonConvert.DeserializeObject<HybridDictionary>(settings.LastUpload);
            }

            if (settings.Stats == "")
            {
                stats["charsInserted"] = 0;
                stats["charsUpdated"] = 0;
                stats["timesInserted"] = 0;
                stats["lastCharsInserted"] = 0;
                stats["lastCharsUpdated"] = 0;
                stats["lastTimesInserted"] = 0;
                stats["lastUpload"] = "none";
            } else
            {
                stats = JsonConvert.DeserializeObject<HybridDictionary>(settings.Stats);
            }
            
            // Check registry for WowPath
            if (settings.WoWPath == "")
            {
                string regKey = @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\World of Warcraft Classic";
                using (RegistryKey uninstallKey = Registry.LocalMachine.OpenSubKey(regKey))
                {
                    if (uninstallKey != null)
                    {
                        string regWowPath = Path.Combine(uninstallKey.GetValue("InstallLocation").ToString(), "_classic_");
                        if (Directory.Exists(regWowPath))
                        {
                            setFileSystemWatcherPath(regWowPath);
                        }
                        
                    }

                }
            }

            // If its not in registry check in default path
            if (settings.WoWPath == "")
            {
                string defaultWoWPath = "C:\\Program Files (x86)\\World of Warcraft\\_classic_";
                if (Directory.Exists(defaultWoWPath))
                {
                    setFileSystemWatcherPath(defaultWoWPath);
                }
            }

            // if we still didn't find it, ask the user
            if (settings.WoWPath == "")
            {
                this.WindowState = FormWindowState.Normal;
                MessageBox.Show("Could't find WoW Classic directory, please set it manually", "TBCPopUploader", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    settings.WoWPath = folderBrowserDialog1.SelectedPath;
                }
            }

            if (settings.WoWPath != "")
            {
                string accountPath = Path.Combine(settings.WoWPath, "WTF", "Account");
                if (Directory.Exists(accountPath))
                {
                    setFileSystemWatcherPath(settings.WoWPath);
                } else
                {
                    MessageBox.Show("Could't find WoW Classic directory. Have you changed its location? Please set the new location manually.", "TBCPopUploader", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.WindowState = FormWindowState.Normal;
                }
            }
        }

        private void setFileSystemWatcherPath(string path)
        {
            settings.WoWPath = path;
            fileSystemWatcher1.Path = Path.Combine(path, "WTF", "Account");
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                if (checkPath())
                {
                    this.WindowState = FormWindowState.Minimized;
                }
                
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveSettings();
            Application.Exit();
        }

        private void saveSettings()
        {
            settings.LastUpload = JsonConvert.SerializeObject(lastUpload);
            settings.Stats = JsonConvert.SerializeObject(stats);
            settings.Save();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void fileSystemWatcher1_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            try
            {
                fileSystemWatcher1.EnableRaisingEvents = false;
                var split = e.Name.Split('\\');
                var second = split[1];
                var last = split[split.Length - 1];
                if (second == "SavedVariables" && last == "CensusPlusClassic.lua")
                {
                    long size = new FileInfo(e.FullPath).Length;
                    if (size > 3145728)
                    {
                        MessageBox.Show("Your CensusPlusTBC.lua is greater than 3 MB. Please consider using the prune/purge button within the addon.", "TBCPopUploader", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    uploadCensus(e.FullPath);
                }
            }
            finally
            {
                fileSystemWatcher1.EnableRaisingEvents = true;
            }
        }

        private void Settings_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
            }

            if (WindowState == FormWindowState.Normal)
            {
                this.ShowInTaskbar = true;
            }
        }

        private void Settings_Shown(object sender, EventArgs e)
        {
            tbWowPath.Text = settings.WoWPath;
            nudUploadTreshold.Value = Convert.ToDecimal(settings.UploadTreshold);
            cbAtStartup.Checked = settings.RunAtStartup;
            updateStats();
        }

        private void updateStats()
        {
            lblCharsIInserted.Text = stats["charsInserted"].ToString();
            lblCharsUpdated.Text = stats["charsUpdated"].ToString();
            lblTimesInserted.Text = stats["timesInserted"].ToString();
            lblLastCharsIInserted.Text = stats["lastCharsInserted"].ToString();
            lblLastCharsUpdated.Text = stats["lastCharsUpdated"].ToString();
            lblLastTimesInserted.Text = stats["lastTimesInserted"].ToString();
            lblLastUpload.Text = stats["lastUpload"].ToString();
        }

        private void btnChangePath_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbWowPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void nudUploadTreshold_ValueChanged(object sender, EventArgs e)
        {
            settings.UploadTreshold = (int)nudUploadTreshold.Value;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            checkPath();
            checkRunAtStartup();
            saveSettings();
        }

        private Boolean checkPath()
        {
            string accountPath = Path.Combine(tbWowPath.Text, "WTF", "Account");
            if (Directory.Exists(accountPath))
            {
                setFileSystemWatcherPath(tbWowPath.Text);
                this.WindowState = FormWindowState.Minimized;
                return true;
            }
            else
            {
                MessageBox.Show("Please select a valid ..\\World of Warcraft\\_classic_ directory", "Invalid directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void checkRunAtStartup()
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (settings.RunAtStartup)
            {
                registryKey.SetValue("TBCPopUploader", Application.ExecutablePath);
            }
            else
            {
                registryKey.DeleteValue("TBCPopUploader", false);
            }
        }

        private void checkUpdate()
        {
            try
            {
                WebClient client = new WebClient();
                client.Headers.Add("User-Agent", "TBCPopUploader");
                String response = client.DownloadString("https://api.github.com/repos/scarecr0w12/TBCPopUploader/releases/latest");
                GithubJson json = JsonConvert.DeserializeObject<GithubJson>(response);
                String currentVersion = Assembly.GetEntryAssembly().GetName().Version.ToString();
                if (json.tag_name != "v" + currentVersion)
                {
                    DialogResult result = MessageBox.Show(this, "There is a new version of TBCPopUploader available. Do you wanna open the download website?", "TBCPopUploader", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("https://github.com/scarecr0w12/TBCPopUploader/releases/latest");
                    }
                }
            } catch { }
        }

        private class GithubJson
        {
            public String tag_name { get; set; }
        }

        /// <summary>
        /// Checks if upload is due for specific file.
        /// </summary>
        /// <param name="filePath">Path to "CensusPlusClassic.lua" file.</param>
        /// <returns>True if upload is due, else false.</returns>
        private bool uploadIsDue(string filePath)
        {
            return lastUpload[filePath] == null ||
                DateTime.Compare(((DateTime)lastUpload[filePath]).AddMinutes(settings.UploadTreshold), DateTime.Now) < 0;
        }

        /// <summary>
        /// Checks if the CensusPlus lua file contains any data.
        /// </summary>
        /// <param name="filePath">Path to "CensusPlusClassic.lua" file.</param>
        /// <returns>True, if file contains census data, else false.</returns>
        private bool containsCensusData(string filePath)
        {
            string fileContent = File.ReadAllText(filePath);
            string pattern = "\\[\"TimesPlus\"\\]\\s*=\\s*{\\s*\\}"; //Matches empty TimesPlus object
            return !Regex.IsMatch(fileContent, pattern);
        }

        private void uploadCensus(string filePath)
        {
            if (uploadIsDue(filePath) && containsCensusData(filePath))
            {
                lastUpload[filePath] = DateTime.Now;
                stats["lastUpload"] = DateTime.Now;
                WebClient client = new WebClient();
                Uri url = new Uri("https://wowclassicpopulation.com/api/upload");

                client.UploadFileCompleted += new UploadFileCompletedEventHandler(UploadFileCallback);
                client.UploadFileAsync(url, filePath);
            }
        }

        private void UploadFileCallback(Object sender, UploadFileCompletedEventArgs e)
        {
            string reply = System.Text.Encoding.ASCII.GetString(e.Result);
            JsonObject json = JsonConvert.DeserializeObject<JsonObject>(reply);
            if (json.error == null)
            {
                if (json.updateDialog != "false")
                {
                    DialogResult result = MessageBox.Show(this, "Your CensusPlusClassic addon is outdated. Do you wanna open the download website with the latest version " + json.updateDialog + "?", "TBCPopUploader", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("https://github.com/christophrus/CensusPlusClassic/releases/latest");
                    }

                }
                stats["charsInserted"] = json.charstats.inserted + Convert.ToInt32(stats["charsInserted"]);
                stats["charsUpdated"] = json.charstats.updated + Convert.ToInt32(stats["charsUpdated"]);
                stats["timesInserted"] = json.timestats.inserted + Convert.ToInt32(stats["timesInserted"]);
                stats["lastCharsInserted"] = json.charstats.inserted;
                stats["lastCharsUpdated"] = json.charstats.updated;
                stats["lastTimesInserted"] = json.timestats.inserted;
                updateStats();
                saveSettings();
            } else
            {
                MessageBox.Show(this, "Upload Error: " + json.error, "TBCPopUploader", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private class JsonObject
        {
            public String error { get; set; }
            public CharStats charstats { get; set; }
            public TimeStats timestats { get; set; }
            public String updateDialog { get; set; }
        }

        private class CharStats
        {
            public int processed { get; set; }
            public int inserted { get; set; }
            public int updated { get; set; }
        }

        private class TimeStats
        {
            public int inserted { get; set; }
        }

        private void cbAtStartup_CheckedChanged(object sender, EventArgs e)
        {
            settings.RunAtStartup = cbAtStartup.Checked;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}
