using FlyingCat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyAuth
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        string chatchannel = "testing"; // chat channel name

        private void Main_Load(object sender, EventArgs e)
        {
            Login.KeyAuthApp.check();
            guna2Panel1.Show();
            siticoneLabel1.Text = $"Current Session Validation Status: {Login.KeyAuthApp.response.success}";
            key.Text = "Username: " + Login.KeyAuthApp.user_data.username;
            expiry.Text = "Expiry: " + UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.subscriptions[0].expiry));
            subscription.Text = "Subscription: " + Login.KeyAuthApp.user_data.subscriptions[0].subscription;
            ip.Text = "IP Address: " + Login.KeyAuthApp.user_data.ip;
            hwid.Text = "HWID: " + Login.KeyAuthApp.user_data.hwid;
            createDate.Text = "Creation date: " + UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.createdate));
            lastLogin.Text = "Last login: " + UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.lastlogin));
            subscriptionDaysLabel.Text = "Expiry in Days: " + Login.KeyAuthApp.expirydaysleft();
            numUsers.Text = "Number of users: " + Login.KeyAuthApp.app_data.numUsers;
            numOnlineUsers.Text = "Number of online users: " + Login.KeyAuthApp.app_data.numOnlineUsers;
            numKeys.Text = "Number of licenses: " + Login.KeyAuthApp.app_data.numKeys;
            version.Text = "Current version: " + Login.KeyAuthApp.app_data.version;
        }

        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            return dtDateTime;
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            guna2Panel1.Show();
            Panel2.Hide();

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            switch (listBox1.Text)
            {
                case "CSGO":
                    MessageBox.Show("CSGO HAS BEEN LOADED");
                    this.TargetBox.Text = ("CSGO LOADED");
                    break;
                    
                        case "WARZONE":
                          MessageBox.Show("WARZONE HAS BEEN LOADED");
                          break;


                    }
            }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.guna2Panel1.Hide();
            this.Panel2.Show();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void key_Click(object sender, EventArgs e)
        {

        }

        private void expiry_Click(object sender, EventArgs e)
        {

        }

        private void subscription_Click(object sender, EventArgs e)
        {

        }

        private void ip_Click(object sender, EventArgs e)
        {

        }

        private void hwid_Click(object sender, EventArgs e)
        {

        }

        private void createDate_Click(object sender, EventArgs e)
        {

        }

        private void lastLogin_Click(object sender, EventArgs e)
        {

        }

        private void numUsers_Click(object sender, EventArgs e)
        {

        }

        private void numOnlineUsers_Click(object sender, EventArgs e)
        {

        }

        private void numKeys_Click(object sender, EventArgs e)
        {

        }

        private void version_Click(object sender, EventArgs e)
        {

        }

        private void subscriptionDaysLabel_Click(object sender, EventArgs e)
        {

        }

        private void siticoneLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            this.guna2Panel1.Hide();
            this.Panel2.Hide();
            this.Panel3.Show();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ProgressBar3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void MethodBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ProgressBar2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void TimeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void PortBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProgressBar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TargetBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox5_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox6_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneLabel3_Click(object sender, EventArgs e)
        {

        }

        private void siticoneLabel2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox7_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox8_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox9_Click(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.com/invite/Radiation");
        }

        private void guna2CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            var settings = SettingsManager.Load();
            settings.AppTopMost = guna2CheckBox4.Checked;
            settings.Save();
        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
    }



