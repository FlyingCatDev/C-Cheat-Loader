using FlyingCat;
using Loader;
using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyAuth
{
    public partial class Login : Form
    {
        public static api KeyAuthApp = new api(
            name: "Testing Shit",
            ownerid: "4yMb27lRmM",
            secret: "e0beec0642db1803715f0466d8394260fe99eda1fd09924d27c8697f36103c70",
            version: "1.0"
        );

        public Login()
        {
            Thread Splash = new Thread(new ThreadStart(StartSplash));
            Splash.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            Splash.Abort();
        }

        public void StartSplash()
        {
            Application.Run(new SplashScreen());
        }            

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            var settings = SettingsManager.Load();
            if (settings.RemeberMe)
            {
                Username.Text = settings.Username;
                Password.Text = settings.Password;
                Remebermecheck.Checked = true;
            }
            KeyAuthApp.init();

            if (KeyAuthApp.response.message == "invalidver")
            {
                if (!string.IsNullOrEmpty(KeyAuthApp.app_data.downloadLink))
                {
                    DialogResult dialogResult = MessageBox.Show("Yes to open file in browser\nNo to download file automatically", "Auto update", MessageBoxButtons.YesNo);
                    switch (dialogResult)
                    {
                        case DialogResult.Yes:
                            Process.Start(KeyAuthApp.app_data.downloadLink);
                            Environment.Exit(0);
                            break;
                        case DialogResult.No:
                            WebClient webClient = new WebClient();
                            string destFile = Application.ExecutablePath;

                            string rand = random_string();

                            destFile = destFile.Replace(".exe", $"-{rand}.exe");
                            webClient.DownloadFile(KeyAuthApp.app_data.downloadLink, destFile);

                            Process.Start(destFile);
                            Process.Start(new ProcessStartInfo()
                            {
                                Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
                                WindowStyle = ProcessWindowStyle.Hidden,
                                CreateNoWindow = true,
                                FileName = "cmd.exe"
                            });
                            Environment.Exit(0);

                            break;
                        default:
                            MessageBox.Show("Invalid option");
                            Environment.Exit(0);
                            break;
                    }
                }
                MessageBox.Show("Version of this program does not match the one online. Furthermore, the download link online isn't set. You will need to manually obtain the download link from the developer");
                Thread.Sleep(2500);
                Environment.Exit(0);
            }
            
            if (!KeyAuthApp.response.success)
            {
                MessageBox.Show(KeyAuthApp.response.message);
                Environment.Exit(0);
            }
            // if(KeyAuthApp.checkblack())
            // {
            //     MessageBox.Show("user is blacklisted");
            // }
            // else
            // {
            //     MessageBox.Show("user is not blacklisted");
            // }
            KeyAuthApp.check();
        }

        static string random_string()
        {
            string str = null;

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                str += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
            }
            return str;

        }

       

        private void username_TextChanged(object sender, EventArgs e)
        {

        }


        private void username_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2Button1.Text != "Login") return;

            guna2Button1.Text = "Signing you in...";
            Thread.Sleep(1000);
            KeyAuthApp.login(Username.Text, Password.Text);
            if (KeyAuthApp.response.success)
            {
                var settings = SettingsManager.Load();
                settings.Username = Username.Text;
                settings.Password = Password.Text;
                settings.RemeberMe = Remebermecheck.Checked;
                settings.Save();
                new ToastContentBuilder()
               .AddText("Successful")
               .AddText("Login Was Successful, Enjoy.")
                .Show();
                Thread.Sleep(1000);
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                if (guna2Button1.Text != "Signing you in...") return;

                guna2Button1.Text = "Login Rejected";
                new ToastContentBuilder()
               .AddText("Error")
               .AddText("Login Was Rejected, Please Restart Software To Login.")
               .Show();
            }
        }

        private void ShowRegBTN_Click(object sender, EventArgs e)
        {
            KeyAuthApp.register(Username.Text, Password.Text, Key.Text);
            if (KeyAuthApp.response.success)
            {
                var settings = SettingsManager.Load();
                settings.Username = Username.Text;
                settings.Password = Password.Text;
                settings.RemeberMe = Remebermecheck.Checked;
                settings.Save();
                new ToastContentBuilder()
                .AddText("Successful")
                .AddText("Register Was Successful, Enjoy.")
                .Show();
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                new ToastContentBuilder()
                .AddText("Error")
                .AddText("Information Was Rejected, Please Restart Software To Register.")
                .Show();
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            KeyAuthApp.register(Username.Text, Password.Text, Key.Text);
            if (KeyAuthApp.response.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                new ToastContentBuilder()
                .AddText("Error")
                .AddText("Information Was Rejected, Please Restart Software To Register.")
                .Show();
            }
        }
    }
}
