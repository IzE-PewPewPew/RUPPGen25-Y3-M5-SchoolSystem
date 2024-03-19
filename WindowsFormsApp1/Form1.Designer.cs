namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.airForm1 = new Shade.Forms.AirForm();
            this.dungeonLabel1 = new Shade.Controls.DungeonLabel();
            this.lbUser = new Shade.Controls.DungeonLabel();
            this.airSeparator1 = new Shade.Controls.AirSeparator();
            this.txtPass = new Shade.Controls.DungeonTextBox();
            this.txtUser = new Shade.Controls.DungeonTextBox();
            this.btnLogin = new Shade.Controls.Button();
            this.airForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // airForm1
            // 
            this.airForm1.BackColor = System.Drawing.Color.Snow;
            this.airForm1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.airForm1.Controls.Add(this.dungeonLabel1);
            this.airForm1.Controls.Add(this.lbUser);
            this.airForm1.Controls.Add(this.airSeparator1);
            this.airForm1.Controls.Add(this.txtPass);
            this.airForm1.Controls.Add(this.txtUser);
            this.airForm1.Controls.Add(this.btnLogin);
            this.airForm1.Customization = "AAAA/1paWv9ycnL/";
            this.airForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.airForm1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.airForm1.Image = null;
            this.airForm1.Location = new System.Drawing.Point(0, 0);
            this.airForm1.MinimumSize = new System.Drawing.Size(112, 35);
            this.airForm1.Movable = false;
            this.airForm1.Name = "airForm1";
            this.airForm1.NoRounding = false;
            this.airForm1.Sizable = false;
            this.airForm1.Size = new System.Drawing.Size(300, 250);
            this.airForm1.SmartBounds = true;
            this.airForm1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.airForm1.TabIndex = 0;
            this.airForm1.Text = "Login";
            this.airForm1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.airForm1.Transparent = false;
            this.airForm1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.airForm1_MouseDown);
            this.airForm1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.airForm1_MouseMove);
            this.airForm1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.airForm1_MouseUp);
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dungeonLabel1.ForeColor = System.Drawing.Color.Black;
            this.dungeonLabel1.Location = new System.Drawing.Point(54, 101);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(70, 19);
            this.dungeonLabel1.TabIndex = 9;
            this.dungeonLabel1.Text = "Password:";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbUser.ForeColor = System.Drawing.Color.Black;
            this.lbUser.Location = new System.Drawing.Point(54, 48);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(74, 19);
            this.lbUser.TabIndex = 8;
            this.lbUser.Text = "Username:";
            // 
            // airSeparator1
            // 
            this.airSeparator1.BackColor = System.Drawing.Color.Black;
            this.airSeparator1.Colors = new Shade.Util.BloomAir[0];
            this.airSeparator1.Customization = "";
            this.airSeparator1.Font = new System.Drawing.Font("Verdana", 8F);
            this.airSeparator1.Image = null;
            this.airSeparator1.Location = new System.Drawing.Point(28, 166);
            this.airSeparator1.Name = "airSeparator1";
            this.airSeparator1.NoRounding = false;
            this.airSeparator1.Size = new System.Drawing.Size(246, 1);
            this.airSeparator1.TabIndex = 7;
            this.airSeparator1.Text = "airSeparator1";
            this.airSeparator1.Transparent = false;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtPass.EdgeColor = System.Drawing.Color.White;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.txtPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtPass.Location = new System.Drawing.Point(55, 123);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.ReadOnly = false;
            this.txtPass.Size = new System.Drawing.Size(194, 28);
            this.txtPass.TabIndex = 6;
            this.txtPass.Text = "Input password...";
            this.txtPass.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPass.UseSystemPasswordChar = false;
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Transparent;
            this.txtUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtUser.EdgeColor = System.Drawing.Color.White;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.txtUser.ForeColor = System.Drawing.Color.DimGray;
            this.txtUser.Location = new System.Drawing.Point(55, 70);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Multiline = false;
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = false;
            this.txtUser.Size = new System.Drawing.Size(194, 28);
            this.txtUser.TabIndex = 5;
            this.txtUser.Text = "Input username...";
            this.txtUser.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUser.UseSystemPasswordChar = false;
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnLogin.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogin.Image = null;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnLogin.Location = new System.Drawing.Point(146, 189);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnLogin.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnLogin.Size = new System.Drawing.Size(120, 40);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Sign in";
            this.btnLogin.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.airForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(112, 35);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formTheme1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.airForm1.ResumeLayout(false);
            this.airForm1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Shade.Forms.AirForm airForm1;
        private Shade.Controls.Button btnLogin;
        private Shade.Controls.AirSeparator airSeparator1;
        private Shade.Controls.DungeonTextBox txtPass;
        private Shade.Controls.DungeonTextBox txtUser;
        private Shade.Controls.DungeonLabel dungeonLabel1;
        private Shade.Controls.DungeonLabel lbUser;
    }
}

