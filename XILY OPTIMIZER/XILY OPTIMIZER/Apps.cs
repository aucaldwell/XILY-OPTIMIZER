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
using System.Security.Permissions;
using Microsoft.Win32;
using System.IO;
using System.Collections;


namespace XILY_OPTIMIZER
{
    public partial class Apps : Form
    {
        public Apps()
        {
            InitializeComponent();
        }
        ArrayList apps_name = new ArrayList();
        private void Apps_Load(object sender, EventArgs e)
        {
            GC.Collect();
        }
        private static void LaunchProcess(string uri, string args)
        {
            var psi = new ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.CreateNoWindow = false;
            psi.Arguments = args;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.FileName = uri;
            var proc = Process.Start(psi);

            proc.WaitForExit();
            var exitcode = proc.ExitCode;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Yellow;
            label1.Text = "Please wait don't close the window";
            if (checkBox1.Checked==true)
            {
                apps_name.Add("3dbuilder");
            }
            if (checkBox2.Checked == true)
            {
                apps_name.Add("windowsalarms");
            }
            if (checkBox3.Checked == true)
            {
                apps_name.Add("windowscalculator");
            }
            if (checkBox4.Checked == true)
            {
                apps_name.Add("windowscommunicationsapps");
            }
            if (checkBox5.Checked == true)
            {
                apps_name.Add("windowscamera");
            }
            if (checkBox6.Checked == true)
            {
                apps_name.Add("officehub");
            }
            if (checkBox7.Checked == true)
            {
                apps_name.Add("skypeapp");
            }
            if (checkBox8.Checked == true)
            {
                apps_name.Add("getstarted");
            }
            if (checkBox9.Checked == true)
            {
                apps_name.Add("zunemusic");
            }
            if (checkBox10.Checked == true)
            {
                apps_name.Add("windowsmaps");
            }
            if (checkBox11.Checked == true)
            {
                apps_name.Add("solitairecollection");
            }
            if (checkBox12.Checked == true)
            {
                apps_name.Add("bingfinance");
            }
            if (checkBox13.Checked == true)
            {
                apps_name.Add("zunevideo");
            }
            if (checkBox14.Checked == true)
            {
                apps_name.Add("bingnews");
            }
            if (checkBox15.Checked == true)
            {
                apps_name.Add("onenote");
            }
            if (checkBox16.Checked == true)
            {
                apps_name.Add("people");
            }
            if (checkBox17.Checked == true)
            {
                apps_name.Add("windowsphone");
            }
            if (checkBox18.Checked == true)
            {
                apps_name.Add("photos");
            }
            if (checkBox19.Checked == true)
            {
                apps_name.Add("windowsstore");
            }
            if (checkBox20.Checked == true)
            {
                apps_name.Add("bingsports");
            }
            if (checkBox21.Checked == true)
            {
                apps_name.Add("soundrecorder");
            }
            if (checkBox22.Checked == true)
            {
                apps_name.Add("bingweather");
            }
            if (checkBox23.Checked == true)
            {
                apps_name.Add("xboxapp");
            }
            if (checkBox24.Checked == true)
            {
                apps_name.Add("Reader");
            }
            if (checkBox25.Checked == true)
            {
                apps_name.Add("Messaging");
            }
            if (checkBox26.Checked == true)
            {
                apps_name.Add("CommsPhone");
            }
            if (checkBox27.Checked == true)
            {
                apps_name.Add("ConnectivityStore");
            }
            if (checkBox28.Checked == true)
            {
                apps_name.Add("Office.Sway");
            }
            if (checkBox29.Checked == true)
            {
                apps_name.Add("Twitter");
            }
            if (checkBox30.Checked == true)
            {
                apps_name.Add("TuneInRadio");
            }
            if (checkBox31.Checked == true)
            {
                apps_name.Add("Netflix");
            }
            if (checkBox32.Checked == true)
            {
                apps_name.Add("WindowsFeedbackHub");
            }
            if (checkBox33.Checked == true)
            {
                apps_name.Add("OneConnect");
            }
            if (checkBox34.Checked == true)
            {
                apps_name.Add("MicrosoftStickyNotes");
            }
            if (checkBox35.Checked == true)
            {
                apps_name.Add("GAMELOFTSA.Asphalt8Airborne");
            }
            if (checkBox36.Checked == true)
            {
                apps_name.Add("king.com.CandyCrushSodaSaga");
            }
            
            if (checkBox38.Checked == true)
            {
                apps_name.Add("Appconnector");
            }
            if (checkBox39.Checked == true)
            {
                apps_name.Add("StorePurchaseApp");
            }



            for (int i = 0; i < apps_name.Count; i++)
            {
                System.Threading.Thread.Sleep(1000);
                LaunchProcess("powershell.exe", "get-appxpackage *"+(apps_name[i]).ToString()+"* | remove-appxpackage");
            }
            //LaunchProcess("powershell.exe", "get-appxpackage *"++"* | remove-appxpackage");

            if (checkBox37.Checked == true)
            {
                LaunchProcess("powershell.exe", "Disable-WindowsOptionalFeature -Online -FeatureName Internet-Explorer-Optional-amd64");
            }

            if (checkBox39.Checked == true)
            {
                string code = "/";
                string codde = "3D Objects";
                LaunchProcess("powershell.exe", "Remove-Item $env:USERPROFILE"+code+codde+"");
            }
            label1.ForeColor = Color.Green;
            label1.Text = "Programs deleted";
        }

        

        private void checkBox41_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox41.Checked==true)
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
                checkBox4.Checked = true;
                checkBox5.Checked = true;
                checkBox6.Checked = true;
                checkBox7.Checked = true;
                checkBox8.Checked = true;
                checkBox9.Checked = true;
                checkBox10.Checked = true;
                checkBox11.Checked = true;
                checkBox12.Checked = true;
                checkBox13.Checked = true;
                checkBox14.Checked = true;
                checkBox15.Checked = true;
                checkBox16.Checked = true;
                checkBox17.Checked = true;
                checkBox18.Checked = true;
                checkBox19.Checked = true;
                checkBox20.Checked = true;
                checkBox21.Checked = true;
                checkBox22.Checked = true;
                checkBox23.Checked = true;
                checkBox24.Checked = true;
                checkBox25.Checked = true;
                checkBox26.Checked = true;
                checkBox27.Checked = true;
                checkBox28.Checked = true;
                checkBox29.Checked = true;
                checkBox30.Checked = true;
                checkBox31.Checked = true;
                checkBox32.Checked = true;
                checkBox33.Checked = true;
                checkBox34.Checked = true;
                checkBox35.Checked = true;
                checkBox36.Checked = true;
                checkBox37.Checked = true;
                checkBox38.Checked = true;
                checkBox39.Checked = true;
                checkBox40.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
                checkBox19.Checked = false;
                checkBox20.Checked = false;
                checkBox21.Checked = false;
                checkBox22.Checked = false;
                checkBox23.Checked = false;
                checkBox24.Checked = false;
                checkBox25.Checked = false;
                checkBox26.Checked = false;
                checkBox27.Checked = false;
                checkBox28.Checked = false;
                checkBox29.Checked = false;
                checkBox30.Checked = false;
                checkBox31.Checked = false;
                checkBox32.Checked = false;
                checkBox33.Checked = false;
                checkBox34.Checked = false;
                checkBox35.Checked = false;
                checkBox36.Checked = false;
                checkBox37.Checked = false;
                checkBox38.Checked = false;
                checkBox39.Checked = false;
                checkBox40.Checked = false;
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
