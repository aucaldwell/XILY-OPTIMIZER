using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace XILY_OPTIMIZER
{
    public partial class Download : Form
    {
        public Download()
        {
            InitializeComponent();
        }
        Stopwatch sw = new Stopwatch();
        string link;
        string program_name;
        private void Download_Load(object sender, EventArgs e)
        {
            GC.Collect();
        }
        void apps_download()
        {
            File.Delete(program_name);

            Uri uri = new Uri(link);
            try
            {

                WebClient wc = new WebClient();

                wc.DownloadFileAsync(uri, program_name);
                File.SetAttributes(program_name, FileAttributes.Hidden);
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
                wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted);
                wc.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
                {
                    if (e.Error == null)
                    {
                        var process = Process.Start(program_name);
                        process.EnableRaisingEvents = true;
                        process.Exited += (_, args) =>
                        {
                            File.Delete(program_name);
                        };
                    }
                    else
                    {
                        MessageBox.Show("Unable to download exe, please check your connection", "Download failed!");
                    }



                }
                void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
                {
                    label1.Text = "Downloading " + ": %" + e.ProgressPercentage.ToString();
                    label2.Text = string.Format("{0} MB's / {1} MB's",
                    (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
                     (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));
                    sw.Start();

                    label3.Text = string.Format("{0} kb/s", (e.BytesReceived / 1024 / sw.Elapsed.TotalSeconds).ToString("0.00"));


                }
                void Completed(object sender, AsyncCompletedEventArgs e)
                {
                    label1.Text = ("Download Complete");

                }
                void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
                {
                    progressBar1.Value = e.ProgressPercentage;
                    if (progressBar1.Value == progressBar1.Maximum)
                    {
                        progressBar1.Value = 0;
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            link = "https://cdn.discordapp.com/attachments/824311410816712734/994998052085571594/NVCleanstall_1.13.0.exe";
            program_name = "NVCleanstall_1.13.0.exe";
            apps_download();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            link = "https://cdn.cloudflare.steamstatic.com/client/installer/SteamSetup.exe";
            program_name = "SteamSetup.exe";
            apps_download();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            link = "https://discord.com/api/downloads/distributions/app/installers/latest?channel=stable&platform=win&arch=x86";
            program_name = "DiscordSetup.exe";
            apps_download();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            link = "https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7BD24928CA-1019-9CA7-8A23-21BD84FD1BFE%7D%26lang%3Den%26browser%3D4%26usagestats%3D0%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26ap%3Dx64-stable-statsdef_1%26installdataindex%3Dempty/update2/installers/ChromeSetup.exe";
            program_name = "ChromeSetup.exe";
            apps_download();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            link = "https://valorant.secure.dyn.riotcdn.net/channels/public/x/installer/current/live.live.eu.exe";
            program_name = "ınstall valorant.exe";
            apps_download();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            link = "https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/installer/download/epicgameslauncherınstaller.msi?trackingıd=2151e984bd564406b34dde53fdda38ce";
            program_name = "epicınstaller-13.3.0-2151e984bd564406b34dde53fdda38ce.msi";
            apps_download();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            link = "https://download.scdn.co/SpotifySetup.exe";
            program_name = "SpotifySetup.exe";
            apps_download();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            link = "https://app.prntscr.com/build/setup-lightshot.exe";
            program_name = "setup-lightshot.exe";
            apps_download();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            link = "https://download.microsoft.com/download/1/7/1/1718CCC4-6315-4D8E-9543-8E28A4E18C4C/dxwebsetup.exe";
            program_name = "dxwebsetup.exe";
            apps_download();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            link = "https://www.win-rar.com/fileadmin/winrar-versions/winrar/winrar-x64-611.exe";
            program_name = "winrar-x64-611.exe";
            apps_download();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            link = "https://files1.majorgeeks.com/10afebdbffcd4742c81a3cb0f6ce4092156b4375/memory/MemoryCleaner-v1.6.7.zip";
            program_name = "MemoryCleaner-v1.6.7.zip";
            apps_download();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            link = "https://cdn.discordapp.com/attachments/824311410816712734/995630963675627600/MSI_util_v3.exe";
            program_name = "MSI_util_v3.exe";
            apps_download();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            link = "https://cdn.discordapp.com/attachments/824311410816712734/995631042184609882/Autoruns.exe";
            program_name = "Autoruns.exe";
            apps_download();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            link = "https://referrals.brave.com/latest/BraveBrowserSetup.exe";
            program_name = "BraveBrowserSetup.exe";
            apps_download();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            link = "https://github.com/amd64fox/SpotX/releases/download/1.0/Install.bat";
            program_name = "Install.bat";
            apps_download();
        }
    }
}
