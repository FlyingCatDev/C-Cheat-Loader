namespace KeyAuth
{
    // Token: 0x02000002 RID: 2
    public partial class Login : global::System.Windows.Forms.Form
    {
        // Token: 0x06000011 RID: 17 RVA: 0x0000215C File Offset: 0x0000035C
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x06000012 RID: 18 RVA: 0x00002194 File Offset: 0x00000394
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Siticone.UI.AnimatorNS.Animation animation4 = new Siticone.UI.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneTransition1 = new Siticone.UI.WinForms.SiticoneTransition();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowRegBTN = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Key = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ProgressBar2 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.Remebermecheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Panel1.SuspendLayout();
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
            // 
            // ShowRegBTN
            // 
            this.ShowRegBTN.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.ShowRegBTN, Siticone.UI.AnimatorNS.DecorationType.None);
            this.ShowRegBTN.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowRegBTN.ForeColor = System.Drawing.Color.Cyan;
            this.ShowRegBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowRegBTN.Location = new System.Drawing.Point(73, 404);
            this.ShowRegBTN.Name = "ShowRegBTN";
            this.ShowRegBTN.Size = new System.Drawing.Size(73, 14);
            this.ShowRegBTN.TabIndex = 39;
            this.ShowRegBTN.Text = "Register here";
            this.ShowRegBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowRegBTN.Click += new System.EventHandler(this.ShowRegBTN_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label7, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(9, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "New user?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Username
            // 
            this.Username.Animated = true;
            this.Username.BorderColor = System.Drawing.Color.Blue;
            this.Username.BorderThickness = 0;
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.Username, Siticone.UI.AnimatorNS.DecorationType.None);
            this.Username.DefaultText = "";
            this.Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.Username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Username.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Username.IconLeft = ((System.Drawing.Image)(resources.GetObject("Username.IconLeft")));
            this.Username.Location = new System.Drawing.Point(76, 96);
            this.Username.Name = "Username";
            this.Username.PasswordChar = '\0';
            this.Username.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Username.PlaceholderText = "Username";
            this.Username.SelectedText = "";
            this.Username.Size = new System.Drawing.Size(547, 36);
            this.Username.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Username.TabIndex = 40;
            // 
            // Password
            // 
            this.Password.Animated = true;
            this.Password.BorderColor = System.Drawing.Color.Blue;
            this.Password.BorderThickness = 0;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.Password, Siticone.UI.AnimatorNS.DecorationType.None);
            this.Password.DefaultText = "";
            this.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Password.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Password.IconLeft = ((System.Drawing.Image)(resources.GetObject("Password.IconLeft")));
            this.Password.Location = new System.Drawing.Point(76, 150);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Password.PlaceholderText = "Password";
            this.Password.SelectedText = "";
            this.Password.Size = new System.Drawing.Size(547, 36);
            this.Password.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Password.TabIndex = 41;
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
            this.guna2Button1.Location = new System.Drawing.Point(191, 276);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.White;
            this.guna2Button1.Size = new System.Drawing.Size(299, 37);
            this.guna2Button1.TabIndex = 42;
            this.guna2Button1.Text = "Login";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.Remebermecheck);
            this.guna2Panel1.Controls.Add(this.guna2ProgressBar2);
            this.guna2Panel1.Controls.Add(this.guna2TextBox1);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Controls.Add(this.Password);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.ShowRegBTN);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.Key);
            this.guna2Panel1.Controls.Add(this.Username);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.siticoneTransition1.SetDecoration(this.guna2Panel1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Location = new System.Drawing.Point(1, -2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(703, 430);
            this.guna2Panel1.TabIndex = 44;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneTransition1.SetDecoration(this.guna2ControlBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(653, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 45;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneTransition1.SetDecoration(this.guna2ControlBox2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(602, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 46;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Blue;
            this.guna2TextBox1.BorderThickness = 0;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.guna2TextBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconLeft")));
            this.guna2TextBox1.Location = new System.Drawing.Point(76, 96);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.guna2TextBox1.PlaceholderText = "Username";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(547, 36);
            this.guna2TextBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2TextBox1.TabIndex = 49;
            // 
            // Key
            // 
            this.Key.Animated = true;
            this.Key.BorderColor = System.Drawing.Color.Blue;
            this.Key.BorderThickness = 0;
            this.Key.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.Key, Siticone.UI.AnimatorNS.DecorationType.None);
            this.Key.DefaultText = "";
            this.Key.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Key.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Key.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Key.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Key.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.Key.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.Key.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Key.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Key.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Key.IconLeft = ((System.Drawing.Image)(resources.GetObject("Key.IconLeft")));
            this.Key.IconLeftSize = new System.Drawing.Size(23, 23);
            this.Key.Location = new System.Drawing.Point(76, 204);
            this.Key.Name = "Key";
            this.Key.PasswordChar = '*';
            this.Key.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Key.PlaceholderText = "Key";
            this.Key.SelectedText = "";
            this.Key.Size = new System.Drawing.Size(547, 36);
            this.Key.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Key.TabIndex = 43;
            // 
            // guna2ProgressBar2
            // 
            this.guna2ProgressBar2.BorderRadius = 1;
            this.siticoneTransition1.SetDecoration(this.guna2ProgressBar2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2ProgressBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ProgressBar2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2ProgressBar2.Location = new System.Drawing.Point(0, 0);
            this.guna2ProgressBar2.Minimum = 60;
            this.guna2ProgressBar2.Name = "guna2ProgressBar2";
            this.guna2ProgressBar2.ProgressColor = System.Drawing.Color.Blue;
            this.guna2ProgressBar2.ProgressColor2 = System.Drawing.Color.Blue;
            this.guna2ProgressBar2.Size = new System.Drawing.Size(703, 3);
            this.guna2ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.guna2ProgressBar2.TabIndex = 50;
            this.guna2ProgressBar2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ProgressBar2.Value = 100;
            // 
            // Remebermecheck
            // 
            this.Remebermecheck.Animated = true;
            this.Remebermecheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.Remebermecheck.CheckedState.BorderRadius = 2;
            this.Remebermecheck.CheckedState.BorderThickness = 0;
            this.Remebermecheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.siticoneTransition1.SetDecoration(this.Remebermecheck, Siticone.UI.AnimatorNS.DecorationType.None);
            this.Remebermecheck.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Remebermecheck.ForeColor = System.Drawing.Color.Gainsboro;
            this.Remebermecheck.Location = new System.Drawing.Point(76, 249);
            this.Remebermecheck.Name = "Remebermecheck";
            this.Remebermecheck.Size = new System.Drawing.Size(385, 19);
            this.Remebermecheck.TabIndex = 51;
            this.Remebermecheck.Text = "Remember Me?";
            this.Remebermecheck.UncheckedState.BorderColor = System.Drawing.Color.Blue;
            this.Remebermecheck.UncheckedState.BorderRadius = 2;
            this.Remebermecheck.UncheckedState.BorderThickness = 0;
            this.Remebermecheck.UncheckedState.FillColor = System.Drawing.Color.Blue;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(703, 430);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.siticoneTransition1.SetDecoration(this, Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loader";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Login_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2TextBox Password;
        private Guna.UI2.WinForms.Guna2TextBox Username;
        private System.Windows.Forms.Label ShowRegBTN;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox Key;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar2;
        private Guna.UI2.WinForms.Guna2CheckBox Remebermecheck;
    }
}
