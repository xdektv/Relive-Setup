using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Microsoft.Win32;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ClassicSetup
{
    public partial class Wizard : Form
    {
<<<<<<< HEAD
<<<<<<< HEAD
        private readonly string logFilePath = @"C:\Classic Files\firsttime.log";
=======
        private readonly string logFilePath = @"C:\Programy\firsttime.log";
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
=======
        private readonly string logFilePath = @"C:\Programy\firsttime.log";
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
        private bool hasSimulatedWinR = false;

        public Wizard()
        {
            InitializeComponent();
            AddCommandLinkButtons();
        }

        private void AddCommandLinkButtons()
        {
<<<<<<< HEAD
<<<<<<< HEAD
            AddCommandLinkButton(cmdlinkpanel, "Windows 7 Ultimate branding", BrandingButton_Click);
            AddCommandLinkButton(cmdlinkpanel, "Windows 7 Professional branding", BrandingButton_Click);
            AddCommandLinkButton(cmdlinkpanel, "Windows 7 Home Premium branding", BrandingButton_Click);
            AddCommandLinkButton(cmdlinkpanel, "Windows 7 Home Basic branding", BrandingButton_Click);
            AddCommandLinkButton(cmdlinkpanel, "Windows 7 Starter branding", BrandingButton_Click);

            AddCommandLinkButton(bwsrlinkpanel, "Internet Explorer 11 style (BeautyFox)", BrowserButton_Click);
            AddCommandLinkButton(bwsrlinkpanel, "Firefox 14 - 28 style (Echelon)", BrowserButton_Click);
            AddCommandLinkButton(bwsrlinkpanel, "Chrome 23 style (Silverfox)", BrowserButton_Click);
            AddCommandLinkButton(bwsrlinkpanel, "Firefox 115 (Unmodified)", BrowserButton_Click);

            AddCommandLinkButton(rebootpanel, "Reboot now and finish the post-install stage", RebootButton_Click);
=======
=======
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
            AddCommandLinkButton(cmdlinkpanel, "Windows 7 Ultimate", BrandingButton_Click);
            AddCommandLinkButton(cmdlinkpanel, "Windows 7 Professional", BrandingButton_Click);
            AddCommandLinkButton(cmdlinkpanel, "Windows 7 Home Premium", BrandingButton_Click);
            AddCommandLinkButton(cmdlinkpanel, "Windows 7 Enterprise", BrandingButton_Click);

            AddCommandLinkButton(bwsrlinkpanel, "Styl Internet Explorer 9 (BeautyFox)", BrowserButton_Click);
            AddCommandLinkButton(bwsrlinkpanel, "Styl Firefox 14-28 (Echelon)", BrowserButton_Click);
            AddCommandLinkButton(bwsrlinkpanel, "Styl Chrome 25 (Geckium)", BrowserButton_Click);
            AddCommandLinkButton(bwsrlinkpanel, "Firefox 115", BrowserButton_Click);

            AddCommandLinkButton(rebootpanel, "Uruchom ponownie aby dokończyć ostatnie szlify", RebootButton_Click);
<<<<<<< HEAD
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
=======
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
            Log("Added buttons");
        }

        private void AddCommandLinkButton(Panel panel, string text, EventHandler clickHandler)
        {
            CommandLinkButton cmdLinkButton = new CommandLinkButton
            {
                Text = text,
                Size = new System.Drawing.Size(400, 42)
            };
            cmdLinkButton.Click += clickHandler;
            panel.Controls.Add(cmdLinkButton);
        }

        private void BrandingButton_Click(object sender, EventArgs e)
        {
            var button = (CommandLinkButton)sender;
            switch (button.Text)
            {
<<<<<<< HEAD
<<<<<<< HEAD
                case "Windows 7 Ultimate branding":
                    ApplyBranding("Ultimate");
                    break;
                case "Windows 7 Professional branding":
                    ApplyBranding("Professional");
                    break;
                case "Windows 7 Home Premium branding":
                    ApplyBranding("Premium");
                    break;
                case "Windows 7 Home Basic branding":
                    ApplyBranding("Basic");
                    break;
                case "Windows 7 Starter branding":
                    ApplyBranding("Starter");
=======
=======
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
                case "Windows 7 Ultimate":
                    ApplyBranding("Ultimate");
                    break;
                case "Windows 7 Professional":
                    ApplyBranding("Professional");
                    break;
                case "Windows 7 Home Premium":
                    ApplyBranding("Premium");
                    break;
                case "Windows 7 Enterprise":
                    ApplyBranding("Enterprise");
<<<<<<< HEAD
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
=======
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
                    break;
            }
            welcomeWizard.NextPage();
        }

        private void ApplyBranding(string edition)
        {
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string brandingSourcePath = Path.Combine(appDirectory, "Branding", edition);
            string brandingDestinationPath = @"C:\Windows\Branding";

            try
            {
                CopyDirectory(brandingSourcePath, brandingDestinationPath);
                Log($"Applied {edition} branding to {brandingDestinationPath}");

                RunCLHBranding($"\"{edition}\"");

                Log($"Executed branding.exe for {edition}");

<<<<<<< HEAD
<<<<<<< HEAD
                if (edition == "Starter")
                {
                    ApplyStarterWallpaper();
                }
=======
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
=======
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
            }
            catch (UnauthorizedAccessException uex)
            {
                MessageBox.Show($"Permission denied while applying {edition} branding: {uex.Message}");
                Log($"Permission denied: {uex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to apply {edition} branding: {ex.Message}");
                Log($"Error applying {edition} branding: {ex.Message}");
            }
        }

        private async void RunCLHBranding(string edition)
        {
            try
            {
<<<<<<< HEAD
<<<<<<< HEAD
                string executablePath = @"C:\Classic Files\Classic Setup\branding.exe";
=======
                string executablePath = @"C:\Programy\PostInstall\branding.exe";
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
=======
                string executablePath = @"C:\Programy\PostInstall\branding.exe";
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
                string arguments = $"-branding \"{edition}\"";

                var process = new System.Diagnostics.Process();
                process.StartInfo.FileName = executablePath;
                process.StartInfo.Arguments = arguments;      
                process.StartInfo.RedirectStandardOutput = true;  
                process.StartInfo.RedirectStandardError = true;   
                process.StartInfo.UseShellExecute = false;        
                process.StartInfo.CreateNoWindow = true;        

                process.Start();

                string output = await process.StandardOutput.ReadToEndAsync();
                string error = await process.StandardError.ReadToEndAsync();

                process.WaitForExit();

                if (!string.IsNullOrEmpty(output))
                {
                    Log($"Output: {output}");
                }
                if (!string.IsNullOrEmpty(error))
                {
                    Log($"Error: {error}");
                }
            }
            catch (Exception ex)
            {
                Log($"Exception: {ex.Message}");
            }
        }



        private void CopyDirectory(string sourceDir, string destinationDir)
        {
            if (!Directory.Exists(destinationDir))
            {
                Directory.CreateDirectory(destinationDir);
            }

            foreach (string filePath in Directory.GetFiles(sourceDir, "*", SearchOption.AllDirectories))
            {
                string relativePath = filePath.Substring(sourceDir.Length + 1);
                string destinationFilePath = Path.Combine(destinationDir, relativePath);

                string destinationFileDirectory = Path.GetDirectoryName(destinationFilePath);
                if (!Directory.Exists(destinationFileDirectory))
                {
                    Directory.CreateDirectory(destinationFileDirectory);
                }
                File.Copy(filePath, destinationFilePath, true);
            }
        }

<<<<<<< HEAD
<<<<<<< HEAD
        private void ApplyStarterWallpaper()
        {
            string wallpaperPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Branding", "Starter", "wallpaper.jpg");

            if (File.Exists(wallpaperPath))
            {
                SetWallpaper(wallpaperPath);
                Log("Applied Starter Wallpaper");
            }
        }

=======
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
=======
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
        const int SPI_SETDESKWALLPAPER = 0x0014;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDCHANGE = 0x02;

        private void SetWallpaper(string wallpaperPath)
        {
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, wallpaperPath, SPIF_UPDATEINIFILE | SPIF_SENDCHANGE);
        }

        private void BrowserButton_Click(object sender, EventArgs e)
        {
            var button = (CommandLinkButton)sender;
            switch (button.Text)
            {
<<<<<<< HEAD
<<<<<<< HEAD
                case "Internet Explorer 11 style (BeautyFox)":
                    ApplyIE11Style();
                    break;
                case "Firefox 14 - 28 style (Echelon)":
                    ApplyFirefox10To13Style();
                    break;
                case "Chrome 23 style (Silverfox)":
                    ApplyChrome2012Style();
                    break;
                case "Firefox 115 (Unmodified)":
=======
=======
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
                case "Styl Internet Explorer 9 (BeautyFox)":
                    ApplyIE9Style();
                    break;
                case "Styl Firefox 14-28 (Echelon)":
                    ApplyFirefox14To28Style();
                    break;
                case "Styl Chrome 25 (Geckium)":
                    ApplyChrome2012Style();
                    break;
                case "Firefox 115":
<<<<<<< HEAD
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
=======
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
                    ApplyFirefox115Style();
                    break;
            }

            RunIe4uinit();
            welcomeWizard.NextPage();
        }

<<<<<<< HEAD
<<<<<<< HEAD
        private void ApplyIE11Style()
=======
        private void ApplyIE9Style()
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
=======
        private void ApplyIE9Style()
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
        {
            ApplyBrowserStyle("BeautyFox");
            Log("Applied Internet Explorer 11 Style");
        }

<<<<<<< HEAD
<<<<<<< HEAD
        private void ApplyFirefox10To13Style()
=======
        private void ApplyFirefox14To28Style()
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
=======
        private void ApplyFirefox14To28Style()
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
        {
            ApplyBrowserStyle("Echelon");
            Log("Applied Firefox 14 - 28 Style");
        }

        private void ApplyChrome2012Style()
        {
<<<<<<< HEAD
<<<<<<< HEAD
            ApplyBrowserStyle("Silverfox");
=======
            ApplyBrowserStyle("Geckium");
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
=======
            ApplyBrowserStyle("Geckium");
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
            Log("Applied Chrome 23 Style");
        }

        private void ApplyFirefox115Style()
        {
            ApplyBrowserStyle("FF115");
            Log("Applied Default Firefox 115 Style");
        }

        private void ApplyBrowserStyle(string folderName)
        {
            string sourceFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Browser", folderName);
            string programFilesFolder = @"C:\Program Files\Mozilla Firefox";
            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string startMenuProgramsFolder = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs";

            if (Directory.Exists(sourceFolder))
            {
                CopyStyleFiles(sourceFolder, programFilesFolder, appDataFolder);
                CopyShortcutFiles(sourceFolder, startMenuProgramsFolder);
            }
            else
            {
                MessageBox.Show($"Source folder does not exist: {sourceFolder}");
                Log($"Error: Source folder does not exist: {sourceFolder}");
            }
        }

        private void CopyShortcutFiles(string sourceFolder, string destinationFolder)
        {
            foreach (var file in Directory.GetFiles(sourceFolder, "*.lnk"))
            {
                string fileName = Path.GetFileName(file);
                string destinationPath = Path.Combine(destinationFolder, fileName);
                File.Copy(file, destinationPath, true);
            }
        }

        private void CopyStyleFiles(string sourceFolder, string programFilesFolder, string appDataFolder)
        {
            string sourceFFFolder = Path.Combine(sourceFolder, "FFFolder");
            string sourceADFolder = Path.Combine(sourceFolder, "ADFolder");

            if (Directory.Exists(sourceFFFolder))
            {
                CopyFilesRecursively(new DirectoryInfo(sourceFFFolder), new DirectoryInfo(programFilesFolder));
            }
            else
            {
                MessageBox.Show($"FFFolder does not exist: {sourceFFFolder}");
            }

            if (Directory.Exists(sourceADFolder))
            {
                CopyFilesRecursively(new DirectoryInfo(sourceADFolder), new DirectoryInfo(appDataFolder));
            }
            else
            {
                MessageBox.Show($"ADFolder does not exist: {sourceADFolder}");
            }
        }

        private void RunIe4uinit()
        {
            try
            {
                string ie4uinitPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ie4uinit.exe");
                if (File.Exists(ie4uinitPath))
                {
                    System.Diagnostics.Process.Start(ie4uinitPath, "-show");
                }
                else
                {
                    MessageBox.Show("ie4uinit.exe not found in the application directory.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to run ie4uinit: {ex.Message}");
            }
        }

        private void CopyFilesRecursively(DirectoryInfo source, DirectoryInfo target)
        {
            foreach (var dir in source.GetDirectories())
            {
                CopyFilesRecursively(dir, target.CreateSubdirectory(dir.Name));
            }

            foreach (var file in source.GetFiles())
            {
                string path = Path.Combine(target.FullName, file.Name);
                file.CopyTo(path, true);
            }
        }

        private void RebootButton_Click(object sender, EventArgs e)
        {
            RebootSystem();
        }

        private void RebootSystem( )
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", true))
                {
                    if (key != null)
                    {
                        key.SetValue("EnableLUA", 1, RegistryValueKind.DWord);
                    }
                }
<<<<<<< HEAD
<<<<<<< HEAD
                Process.Start("shutdown", "/r /t 0");
=======
                Process.Start("shutdown", "/r /f /t 0");
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
=======
                Process.Start("shutdown", "/r /f /t 0");
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
            }
            catch
            {
                // nothing
            }
        }

        private void Log(string message)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"{DateTime.Now}: {message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to write log: {ex.Message}");
            }
<<<<<<< HEAD
<<<<<<< HEAD
        }
=======
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
=======
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
>>>>>>> parent of 1b0dcae (Delete ClassicSetup directory)
    }
}
