namespace KeyAuth
{
    public partial class Main : global::System.Windows.Forms.Form
    {
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Siticone.UI.AnimatorNS.Animation animation4 = new Siticone.UI.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneTransition1 = new Siticone.UI.WinForms.SiticoneTransition();
            this.label1 = new System.Windows.Forms.Label();
            this.key = new Siticone.UI.WinForms.SiticoneLabel();
            this.expiry = new Siticone.UI.WinForms.SiticoneLabel();
            this.subscription = new Siticone.UI.WinForms.SiticoneLabel();
            this.ip = new Siticone.UI.WinForms.SiticoneLabel();
            this.hwid = new Siticone.UI.WinForms.SiticoneLabel();
            this.createDate = new Siticone.UI.WinForms.SiticoneLabel();
            this.lastLogin = new Siticone.UI.WinForms.SiticoneLabel();
            this.numUsers = new Siticone.UI.WinForms.SiticoneLabel();
            this.numOnlineUsers = new Siticone.UI.WinForms.SiticoneLabel();
            this.numKeys = new Siticone.UI.WinForms.SiticoneLabel();
            this.version = new Siticone.UI.WinForms.SiticoneLabel();
            this.subscriptionDaysLabel = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.siticoneLabel3 = new Siticone.UI.WinForms.SiticoneLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.siticoneLabel2 = new Siticone.UI.WinForms.SiticoneLabel();
            this.Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CheckBox3 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox4 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ControlBox7 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox8 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox9 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ProgressBar3 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.MethodBox = new System.Windows.Forms.RichTextBox();
            this.guna2ProgressBar2 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.RichTextBox();
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.PortBox = new System.Windows.Forms.RichTextBox();
            this.ProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.TargetBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.guna2ControlBox4 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox6 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox5 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneTransition1
            // 
            this.siticoneTransition1.AnimationType = Siticone.UI.AnimatorNS.AnimationType.Rotate;
            this.siticoneTransition1.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(50);
            animation4.RotateCoeff = 1F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 1F;
            this.siticoneTransition1.DefaultAnimation = animation4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 22;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // key
            // 
            this.key.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.key, Siticone.UI.AnimatorNS.DecorationType.None);
            this.key.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.key.Location = new System.Drawing.Point(9, 10);
            this.key.Margin = new System.Windows.Forms.Padding(2);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(197, 39);
            this.key.TabIndex = 37;
            this.key.Text = "usernameLabel";
            this.key.Click += new System.EventHandler(this.key_Click);
            // 
            // expiry
            // 
            this.expiry.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.expiry, Siticone.UI.AnimatorNS.DecorationType.None);
            this.expiry.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.expiry.Location = new System.Drawing.Point(7, 50);
            this.expiry.Margin = new System.Windows.Forms.Padding(2);
            this.expiry.Name = "expiry";
            this.expiry.Size = new System.Drawing.Size(74, 19);
            this.expiry.TabIndex = 38;
            this.expiry.Text = "expiryLabel";
            this.expiry.Click += new System.EventHandler(this.expiry_Click);
            // 
            // subscription
            // 
            this.subscription.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.subscription, Siticone.UI.AnimatorNS.DecorationType.None);
            this.subscription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subscription.Location = new System.Drawing.Point(7, 71);
            this.subscription.Margin = new System.Windows.Forms.Padding(2);
            this.subscription.Name = "subscription";
            this.subscription.Size = new System.Drawing.Size(112, 19);
            this.subscription.TabIndex = 39;
            this.subscription.Text = "subscriptionLabel";
            this.subscription.Click += new System.EventHandler(this.subscription_Click);
            // 
            // ip
            // 
            this.ip.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.ip, Siticone.UI.AnimatorNS.DecorationType.None);
            this.ip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ip.Location = new System.Drawing.Point(7, 89);
            this.ip.Margin = new System.Windows.Forms.Padding(2);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(48, 19);
            this.ip.TabIndex = 44;
            this.ip.Text = "ipLabel";
            this.ip.Click += new System.EventHandler(this.ip_Click);
            // 
            // hwid
            // 
            this.hwid.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.hwid, Siticone.UI.AnimatorNS.DecorationType.None);
            this.hwid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hwid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hwid.Location = new System.Drawing.Point(7, 107);
            this.hwid.Margin = new System.Windows.Forms.Padding(2);
            this.hwid.Name = "hwid";
            this.hwid.Size = new System.Drawing.Size(66, 19);
            this.hwid.TabIndex = 45;
            this.hwid.Text = "hwidLabel";
            this.hwid.Click += new System.EventHandler(this.hwid_Click);
            // 
            // createDate
            // 
            this.createDate.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.createDate, Siticone.UI.AnimatorNS.DecorationType.None);
            this.createDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createDate.Location = new System.Drawing.Point(7, 125);
            this.createDate.Margin = new System.Windows.Forms.Padding(2);
            this.createDate.Name = "createDate";
            this.createDate.Size = new System.Drawing.Size(102, 19);
            this.createDate.TabIndex = 46;
            this.createDate.Text = "createDateLabel";
            this.createDate.Click += new System.EventHandler(this.createDate_Click);
            // 
            // lastLogin
            // 
            this.lastLogin.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.lastLogin, Siticone.UI.AnimatorNS.DecorationType.None);
            this.lastLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lastLogin.Location = new System.Drawing.Point(7, 143);
            this.lastLogin.Margin = new System.Windows.Forms.Padding(2);
            this.lastLogin.Name = "lastLogin";
            this.lastLogin.Size = new System.Drawing.Size(93, 19);
            this.lastLogin.TabIndex = 47;
            this.lastLogin.Text = "lastLoginLabel";
            this.lastLogin.Click += new System.EventHandler(this.lastLogin_Click);
            // 
            // numUsers
            // 
            this.numUsers.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.numUsers, Siticone.UI.AnimatorNS.DecorationType.None);
            this.numUsers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numUsers.Location = new System.Drawing.Point(4, 66);
            this.numUsers.Margin = new System.Windows.Forms.Padding(2);
            this.numUsers.Name = "numUsers";
            this.numUsers.Size = new System.Drawing.Size(97, 19);
            this.numUsers.TabIndex = 48;
            this.numUsers.Text = "numUsersLabel";
            this.numUsers.Click += new System.EventHandler(this.numUsers_Click);
            // 
            // numOnlineUsers
            // 
            this.numOnlineUsers.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.numOnlineUsers, Siticone.UI.AnimatorNS.DecorationType.None);
            this.numOnlineUsers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOnlineUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numOnlineUsers.Location = new System.Drawing.Point(4, 89);
            this.numOnlineUsers.Margin = new System.Windows.Forms.Padding(2);
            this.numOnlineUsers.Name = "numOnlineUsers";
            this.numOnlineUsers.Size = new System.Drawing.Size(138, 19);
            this.numOnlineUsers.TabIndex = 49;
            this.numOnlineUsers.Text = "numOnlineUsersLabel";
            this.numOnlineUsers.Click += new System.EventHandler(this.numOnlineUsers_Click);
            // 
            // numKeys
            // 
            this.numKeys.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.numKeys, Siticone.UI.AnimatorNS.DecorationType.None);
            this.numKeys.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numKeys.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numKeys.Location = new System.Drawing.Point(4, 112);
            this.numKeys.Margin = new System.Windows.Forms.Padding(2);
            this.numKeys.Name = "numKeys";
            this.numKeys.Size = new System.Drawing.Size(92, 19);
            this.numKeys.TabIndex = 50;
            this.numKeys.Text = "numKeysLabel";
            this.numKeys.Click += new System.EventHandler(this.numKeys_Click);
            // 
            // version
            // 
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.version, Siticone.UI.AnimatorNS.DecorationType.None);
            this.version.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.version.Location = new System.Drawing.Point(4, 135);
            this.version.Margin = new System.Windows.Forms.Padding(2);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(81, 19);
            this.version.TabIndex = 51;
            this.version.Text = "versionLabel";
            this.version.Click += new System.EventHandler(this.version_Click);
            // 
            // subscriptionDaysLabel
            // 
            this.subscriptionDaysLabel.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.subscriptionDaysLabel, Siticone.UI.AnimatorNS.DecorationType.None);
            this.subscriptionDaysLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscriptionDaysLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subscriptionDaysLabel.Location = new System.Drawing.Point(7, 179);
            this.subscriptionDaysLabel.Margin = new System.Windows.Forms.Padding(2);
            this.subscriptionDaysLabel.Name = "subscriptionDaysLabel";
            this.subscriptionDaysLabel.Size = new System.Drawing.Size(142, 19);
            this.subscriptionDaysLabel.TabIndex = 53;
            this.subscriptionDaysLabel.Text = "subscriptionDaysLabel";
            this.subscriptionDaysLabel.Click += new System.EventHandler(this.subscriptionDaysLabel_Click);
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel1.Location = new System.Drawing.Point(7, 161);
            this.siticoneLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(213, 19);
            this.siticoneLabel1.TabIndex = 53;
            this.siticoneLabel1.Text = "Current Session Valdiation Status: ";
            this.siticoneLabel1.Click += new System.EventHandler(this.siticoneLabel1_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneTransition1.SetDecoration(this.guna2ImageButton1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(24, 44);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton1.TabIndex = 55;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneTransition1.SetDecoration(this.guna2ImageButton2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.Location = new System.Drawing.Point(24, 162);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton2.TabIndex = 56;
            this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneTransition1.SetDecoration(this.guna2ImageButton3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton3.Image")));
            this.guna2ImageButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton3.ImageRotate = 0F;
            this.guna2ImageButton3.Location = new System.Drawing.Point(24, 279);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton3.TabIndex = 57;
            this.guna2ImageButton3.Click += new System.EventHandler(this.guna2ImageButton3_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2ControlBox3);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.key);
            this.siticoneTransition1.SetDecoration(this.guna2Panel1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Location = new System.Drawing.Point(129, 1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(572, 348);
            this.guna2Panel1.TabIndex = 58;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneTransition1.SetDecoration(this.guna2ControlBox3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(422, 3);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 58;
            this.guna2ControlBox3.Click += new System.EventHandler(this.guna2ControlBox3_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.siticoneTransition1.SetDecoration(this.guna2ControlBox2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(473, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 57;
            this.guna2ControlBox2.Click += new System.EventHandler(this.guna2ControlBox2_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneTransition1.SetDecoration(this.guna2ControlBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(524, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 56;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.siticoneLabel3);
            this.guna2Panel3.Controls.Add(this.ip);
            this.guna2Panel3.Controls.Add(this.subscription);
            this.guna2Panel3.Controls.Add(this.expiry);
            this.guna2Panel3.Controls.Add(this.createDate);
            this.guna2Panel3.Controls.Add(this.subscriptionDaysLabel);
            this.guna2Panel3.Controls.Add(this.lastLogin);
            this.guna2Panel3.Controls.Add(this.siticoneLabel1);
            this.guna2Panel3.Controls.Add(this.hwid);
            this.siticoneTransition1.SetDecoration(this.guna2Panel3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2Panel3.Location = new System.Drawing.Point(4, 56);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(307, 289);
            this.guna2Panel3.TabIndex = 55;
            this.guna2Panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel3_Paint);
            // 
            // siticoneLabel3
            // 
            this.siticoneLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel3.Location = new System.Drawing.Point(4, 3);
            this.siticoneLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel3.Name = "siticoneLabel3";
            this.siticoneLabel3.Size = new System.Drawing.Size(108, 19);
            this.siticoneLabel3.TabIndex = 60;
            this.siticoneLabel3.Text = "User Information";
            this.siticoneLabel3.Click += new System.EventHandler(this.siticoneLabel3_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.siticoneLabel2);
            this.guna2Panel2.Controls.Add(this.numUsers);
            this.guna2Panel2.Controls.Add(this.numOnlineUsers);
            this.guna2Panel2.Controls.Add(this.version);
            this.guna2Panel2.Controls.Add(this.numKeys);
            this.siticoneTransition1.SetDecoration(this.guna2Panel2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2Panel2.Location = new System.Drawing.Point(317, 56);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(252, 289);
            this.guna2Panel2.TabIndex = 54;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel2.Location = new System.Drawing.Point(4, 3);
            this.siticoneLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(128, 19);
            this.siticoneLabel2.TabIndex = 59;
            this.siticoneLabel2.Text = "General Information";
            this.siticoneLabel2.Click += new System.EventHandler(this.siticoneLabel2_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Panel2.BorderColor = System.Drawing.Color.Transparent;
            this.Panel2.Controls.Add(this.guna2Panel4);
            this.Panel2.Controls.Add(this.guna2Button1);
            this.Panel2.Controls.Add(this.listBox1);
            this.Panel2.Controls.Add(this.guna2ControlBox4);
            this.Panel2.Controls.Add(this.guna2ControlBox6);
            this.Panel2.Controls.Add(this.guna2ControlBox5);
            this.Panel2.CustomBorderColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.Panel2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.Panel2.Location = new System.Drawing.Point(127, 1);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(572, 348);
            this.Panel2.TabIndex = 59;
            this.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Panel3.BorderColor = System.Drawing.Color.Transparent;
            this.Panel3.Controls.Add(this.guna2CheckBox3);
            this.Panel3.Controls.Add(this.guna2CheckBox2);
            this.Panel3.Controls.Add(this.label2);
            this.Panel3.Controls.Add(this.guna2ControlBox7);
            this.Panel3.Controls.Add(this.guna2CheckBox4);
            this.Panel3.Controls.Add(this.guna2ControlBox8);
            this.Panel3.Controls.Add(this.guna2ControlBox9);
            this.Panel3.CustomBorderColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.Panel3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.Panel3.Location = new System.Drawing.Point(128, 1);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(572, 348);
            this.Panel3.TabIndex = 62;
            this.Panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // guna2CheckBox3
            // 
            this.guna2CheckBox3.AutoSize = true;
            this.guna2CheckBox3.CheckedState.BorderColor = System.Drawing.Color.Blue;
            this.guna2CheckBox3.CheckedState.BorderRadius = 0;
            this.guna2CheckBox3.CheckedState.BorderThickness = 0;
            this.guna2CheckBox3.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.siticoneTransition1.SetDecoration(this.guna2CheckBox3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2CheckBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.guna2CheckBox3.ForeColor = System.Drawing.Color.White;
            this.guna2CheckBox3.Location = new System.Drawing.Point(235, 175);
            this.guna2CheckBox3.Name = "guna2CheckBox3";
            this.guna2CheckBox3.Size = new System.Drawing.Size(77, 17);
            this.guna2CheckBox3.TabIndex = 61;
            this.guna2CheckBox3.Text = "Auto Login";
            this.guna2CheckBox3.UncheckedState.BorderColor = System.Drawing.Color.Blue;
            this.guna2CheckBox3.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox3.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox3.UncheckedState.FillColor = System.Drawing.Color.Blue;
            // 
            // guna2CheckBox4
            // 
            this.guna2CheckBox4.AutoSize = true;
            this.guna2CheckBox4.CheckedState.BorderColor = System.Drawing.Color.Blue;
            this.guna2CheckBox4.CheckedState.BorderRadius = 0;
            this.guna2CheckBox4.CheckedState.BorderThickness = 0;
            this.guna2CheckBox4.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.siticoneTransition1.SetDecoration(this.guna2CheckBox4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2CheckBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.guna2CheckBox4.ForeColor = System.Drawing.Color.White;
            this.guna2CheckBox4.Location = new System.Drawing.Point(235, 152);
            this.guna2CheckBox4.Name = "guna2CheckBox4";
            this.guna2CheckBox4.Size = new System.Drawing.Size(123, 17);
            this.guna2CheckBox4.TabIndex = 59;
            this.guna2CheckBox4.Text = "Application TopMost";
            this.guna2CheckBox4.UncheckedState.BorderColor = System.Drawing.Color.Blue;
            this.guna2CheckBox4.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox4.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox4.UncheckedState.FillColor = System.Drawing.Color.Blue;
            this.guna2CheckBox4.CheckedChanged += new System.EventHandler(this.guna2CheckBox4_CheckedChanged);
            // 
            // guna2CheckBox2
            // 
            this.guna2CheckBox2.AutoSize = true;
            this.guna2CheckBox2.CheckedState.BorderColor = System.Drawing.Color.Blue;
            this.guna2CheckBox2.CheckedState.BorderRadius = 0;
            this.guna2CheckBox2.CheckedState.BorderThickness = 0;
            this.guna2CheckBox2.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.siticoneTransition1.SetDecoration(this.guna2CheckBox2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2CheckBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.guna2CheckBox2.ForeColor = System.Drawing.Color.White;
            this.guna2CheckBox2.Location = new System.Drawing.Point(235, 129);
            this.guna2CheckBox2.Name = "guna2CheckBox2";
            this.guna2CheckBox2.Size = new System.Drawing.Size(84, 17);
            this.guna2CheckBox2.TabIndex = 61;
            this.guna2CheckBox2.Text = "Join Discord";
            this.guna2CheckBox2.UncheckedState.BorderColor = System.Drawing.Color.Blue;
            this.guna2CheckBox2.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox2.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox2.UncheckedState.FillColor = System.Drawing.Color.Blue;
            this.guna2CheckBox2.CheckedChanged += new System.EventHandler(this.guna2CheckBox2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(222, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Discord Settings";
            // 
            // guna2ControlBox7
            // 
            this.guna2ControlBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox7.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneTransition1.SetDecoration(this.guna2ControlBox7, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2ControlBox7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.guna2ControlBox7.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox7.Location = new System.Drawing.Point(422, 3);
            this.guna2ControlBox7.Name = "guna2ControlBox7";
            this.guna2ControlBox7.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox7.TabIndex = 58;
            this.guna2ControlBox7.Click += new System.EventHandler(this.guna2ControlBox7_Click);
            // 
            // guna2ControlBox8
            // 
            this.guna2ControlBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneTransition1.SetDecoration(this.guna2ControlBox8, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2ControlBox8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.guna2ControlBox8.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox8.Location = new System.Drawing.Point(524, 3);
            this.guna2ControlBox8.Name = "guna2ControlBox8";
            this.guna2ControlBox8.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox8.TabIndex = 56;
            this.guna2ControlBox8.Click += new System.EventHandler(this.guna2ControlBox8_Click);
            // 
            // guna2ControlBox9
            // 
            this.guna2ControlBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox9.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.siticoneTransition1.SetDecoration(this.guna2ControlBox9, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2ControlBox9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.guna2ControlBox9.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox9.Location = new System.Drawing.Point(473, 3);
            this.guna2ControlBox9.Name = "guna2ControlBox9";
            this.guna2ControlBox9.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox9.TabIndex = 57;
            this.guna2ControlBox9.Click += new System.EventHandler(this.guna2ControlBox9_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.guna2Panel4.BorderRadius = 5;
            this.guna2Panel4.BorderThickness = 2;
            this.guna2Panel4.Controls.Add(this.guna2ProgressBar3);
            this.guna2Panel4.Controls.Add(this.label10);
            this.guna2Panel4.Controls.Add(this.MethodBox);
            this.guna2Panel4.Controls.Add(this.guna2ProgressBar2);
            this.guna2Panel4.Controls.Add(this.label9);
            this.guna2Panel4.Controls.Add(this.TimeBox);
            this.guna2Panel4.Controls.Add(this.guna2ProgressBar1);
            this.guna2Panel4.Controls.Add(this.label8);
            this.guna2Panel4.Controls.Add(this.PortBox);
            this.guna2Panel4.Controls.Add(this.ProgressBar);
            this.guna2Panel4.Controls.Add(this.label5);
            this.guna2Panel4.Controls.Add(this.TargetBox);
            this.guna2Panel4.Controls.Add(this.label4);
            this.guna2Panel4.Controls.Add(this.guna2Button2);
            this.guna2Panel4.CustomBorderColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.guna2Panel4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2Panel4.Location = new System.Drawing.Point(9, 191);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(565, 155);
            this.guna2Panel4.TabIndex = 61;
            this.guna2Panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel4_Paint);
            // 
            // guna2ProgressBar3
            // 
            this.guna2ProgressBar3.BorderRadius = 1;
            this.siticoneTransition1.SetDecoration(this.guna2ProgressBar3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2ProgressBar3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2ProgressBar3.Location = new System.Drawing.Point(631, 68);
            this.guna2ProgressBar3.Minimum = 60;
            this.guna2ProgressBar3.Name = "guna2ProgressBar3";
            this.guna2ProgressBar3.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.guna2ProgressBar3.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(48)))), ((int)(((byte)(194)))));
            this.guna2ProgressBar3.Size = new System.Drawing.Size(164, 5);
            this.guna2ProgressBar3.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.guna2ProgressBar3.TabIndex = 43;
            this.guna2ProgressBar3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ProgressBar3.Value = 100;
            this.guna2ProgressBar3.ValueChanged += new System.EventHandler(this.guna2ProgressBar3_ValueChanged);
            // 
            // label10
            // 
            this.siticoneTransition1.SetDecoration(this.label10, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(616, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 19);
            this.label10.TabIndex = 42;
            this.label10.Text = "Method";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // MethodBox
            // 
            this.MethodBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MethodBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.siticoneTransition1.SetDecoration(this.MethodBox, Siticone.UI.AnimatorNS.DecorationType.None);
            this.MethodBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MethodBox.ForeColor = System.Drawing.Color.Gray;
            this.MethodBox.Location = new System.Drawing.Point(631, 83);
            this.MethodBox.Name = "MethodBox";
            this.MethodBox.ReadOnly = true;
            this.MethodBox.Size = new System.Drawing.Size(164, 128);
            this.MethodBox.TabIndex = 41;
            this.MethodBox.Text = "N/a";
            this.MethodBox.TextChanged += new System.EventHandler(this.MethodBox_TextChanged);
            // 
            // guna2ProgressBar2
            // 
            this.guna2ProgressBar2.BorderRadius = 1;
            this.siticoneTransition1.SetDecoration(this.guna2ProgressBar2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2ProgressBar2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2ProgressBar2.Location = new System.Drawing.Point(378, 51);
            this.guna2ProgressBar2.Minimum = 60;
            this.guna2ProgressBar2.Name = "guna2ProgressBar2";
            this.guna2ProgressBar2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.guna2ProgressBar2.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.guna2ProgressBar2.Size = new System.Drawing.Size(164, 5);
            this.guna2ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.guna2ProgressBar2.TabIndex = 40;
            this.guna2ProgressBar2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ProgressBar2.Value = 100;
            this.guna2ProgressBar2.ValueChanged += new System.EventHandler(this.guna2ProgressBar2_ValueChanged);
            // 
            // label9
            // 
            this.siticoneTransition1.SetDecoration(this.label9, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(375, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 19);
            this.label9.TabIndex = 39;
            this.label9.Text = "Errors";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // TimeBox
            // 
            this.TimeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TimeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.siticoneTransition1.SetDecoration(this.TimeBox, Siticone.UI.AnimatorNS.DecorationType.None);
            this.TimeBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TimeBox.ForeColor = System.Drawing.Color.Gray;
            this.TimeBox.Location = new System.Drawing.Point(378, 60);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.ReadOnly = true;
            this.TimeBox.Size = new System.Drawing.Size(164, 83);
            this.TimeBox.TabIndex = 38;
            this.TimeBox.Text = "N/a";
            this.TimeBox.TextChanged += new System.EventHandler(this.TimeBox_TextChanged);
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.BorderRadius = 1;
            this.siticoneTransition1.SetDecoration(this.guna2ProgressBar1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2ProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2ProgressBar1.Location = new System.Drawing.Point(208, 51);
            this.guna2ProgressBar1.Minimum = 60;
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.guna2ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.guna2ProgressBar1.Size = new System.Drawing.Size(164, 5);
            this.guna2ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.guna2ProgressBar1.TabIndex = 37;
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ProgressBar1.Value = 100;
            this.guna2ProgressBar1.ValueChanged += new System.EventHandler(this.guna2ProgressBar1_ValueChanged);
            // 
            // label8
            // 
            this.siticoneTransition1.SetDecoration(this.label8, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(205, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 19);
            this.label8.TabIndex = 36;
            this.label8.Text = "Cleaner";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // PortBox
            // 
            this.PortBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PortBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.siticoneTransition1.SetDecoration(this.PortBox, Siticone.UI.AnimatorNS.DecorationType.None);
            this.PortBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.PortBox.ForeColor = System.Drawing.Color.Gray;
            this.PortBox.Location = new System.Drawing.Point(208, 60);
            this.PortBox.Name = "PortBox";
            this.PortBox.ReadOnly = true;
            this.PortBox.Size = new System.Drawing.Size(164, 83);
            this.PortBox.TabIndex = 35;
            this.PortBox.Text = "N/a";
            this.PortBox.TextChanged += new System.EventHandler(this.PortBox_TextChanged);
            // 
            // ProgressBar
            // 
            this.ProgressBar.BorderRadius = 1;
            this.siticoneTransition1.SetDecoration(this.ProgressBar, Siticone.UI.AnimatorNS.DecorationType.None);
            this.ProgressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ProgressBar.Location = new System.Drawing.Point(41, 52);
            this.ProgressBar.Minimum = 60;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.ProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.ProgressBar.Size = new System.Drawing.Size(164, 5);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBar.TabIndex = 34;
            this.ProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ProgressBar.Value = 100;
            this.ProgressBar.ValueChanged += new System.EventHandler(this.ProgressBar_ValueChanged);
            // 
            // label5
            // 
            this.siticoneTransition1.SetDecoration(this.label5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(35, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Injection";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TargetBox
            // 
            this.TargetBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TargetBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.siticoneTransition1.SetDecoration(this.TargetBox, Siticone.UI.AnimatorNS.DecorationType.None);
            this.TargetBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TargetBox.ForeColor = System.Drawing.Color.Gray;
            this.TargetBox.Location = new System.Drawing.Point(38, 60);
            this.TargetBox.Name = "TargetBox";
            this.TargetBox.ReadOnly = true;
            this.TargetBox.Size = new System.Drawing.Size(164, 83);
            this.TargetBox.TabIndex = 32;
            this.TargetBox.Text = "N/a";
            this.TargetBox.TextChanged += new System.EventHandler(this.TargetBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(220, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Recent Usage Logs";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 5;
            this.siticoneTransition1.SetDecoration(this.guna2Button2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2Button2.Location = new System.Drawing.Point(870, 4);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedDepth = 0;
            this.guna2Button2.Size = new System.Drawing.Size(35, 35);
            this.guna2Button2.TabIndex = 1;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.guna2Button1.BorderRadius = 2;
            this.guna2Button1.BorderThickness = 2;
            this.siticoneTransition1.SetDecoration(this.guna2Button1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(9, 141);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.White;
            this.guna2Button1.Size = new System.Drawing.Size(558, 44);
            this.guna2Button1.TabIndex = 60;
            this.guna2Button1.Text = "Launch";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.siticoneTransition1.SetDecoration(this.listBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "CSGO",
            "WARZONE",
            "VALORANT",
            "FORTNITE",
            "GTA 5",
            "MINECRAFT"});
            this.listBox1.Location = new System.Drawing.Point(6, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(558, 96);
            this.listBox1.TabIndex = 59;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // guna2ControlBox4
            // 
            this.guna2ControlBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox4.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneTransition1.SetDecoration(this.guna2ControlBox4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2ControlBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.guna2ControlBox4.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox4.Location = new System.Drawing.Point(422, 3);
            this.guna2ControlBox4.Name = "guna2ControlBox4";
            this.guna2ControlBox4.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox4.TabIndex = 58;
            this.guna2ControlBox4.Click += new System.EventHandler(this.guna2ControlBox4_Click);
            // 
            // guna2ControlBox6
            // 
            this.guna2ControlBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneTransition1.SetDecoration(this.guna2ControlBox6, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2ControlBox6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.guna2ControlBox6.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox6.Location = new System.Drawing.Point(524, 3);
            this.guna2ControlBox6.Name = "guna2ControlBox6";
            this.guna2ControlBox6.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox6.TabIndex = 56;
            this.guna2ControlBox6.Click += new System.EventHandler(this.guna2ControlBox6_Click);
            // 
            // guna2ControlBox5
            // 
            this.guna2ControlBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox5.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.siticoneTransition1.SetDecoration(this.guna2ControlBox5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2ControlBox5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.guna2ControlBox5.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox5.Location = new System.Drawing.Point(473, 3);
            this.guna2ControlBox5.Name = "guna2ControlBox5";
            this.guna2ControlBox5.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox5.TabIndex = 57;
            this.guna2ControlBox5.Click += new System.EventHandler(this.guna2ControlBox5_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(704, 350);
            this.Controls.Add(this.guna2ImageButton3);
            this.Controls.Add(this.guna2ImageButton2);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.Panel3);
            this.siticoneTransition1.SetDecoration(this, Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loader";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Main_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x04000001 RID: 1
        private global::System.ComponentModel.IContainer components = null;

        // Token: 0x04000002 RID: 2
        private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

        // Token: 0x04000009 RID: 9
        private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

        // Token: 0x0400000A RID: 10
        private global::System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private Siticone.UI.WinForms.SiticoneLabel subscription;
        private Siticone.UI.WinForms.SiticoneLabel expiry;
        private Siticone.UI.WinForms.SiticoneLabel key;
        private System.Windows.Forms.Timer timer1;
        private Siticone.UI.WinForms.SiticoneLabel ip;
        private Siticone.UI.WinForms.SiticoneLabel hwid;
        private Siticone.UI.WinForms.SiticoneLabel createDate;
        private Siticone.UI.WinForms.SiticoneLabel lastLogin;
        private Siticone.UI.WinForms.SiticoneLabel numUsers;
        private Siticone.UI.WinForms.SiticoneLabel numOnlineUsers;
        private Siticone.UI.WinForms.SiticoneLabel numKeys;
        private Siticone.UI.WinForms.SiticoneLabel version;
        private Siticone.UI.WinForms.SiticoneLabel subscriptionDaysLabel;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel2;
        private Guna.UI2.WinForms.Guna2Panel Panel2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox4;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox5;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox6;
        private System.Windows.Forms.ListBox listBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox MethodBox;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox TimeBox;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox PortBox;
        private Guna.UI2.WinForms.Guna2ProgressBar ProgressBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox TargetBox;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Panel Panel3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox7;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox8;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox9;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox3;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox4;
    }
}
