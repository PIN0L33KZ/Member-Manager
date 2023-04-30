namespace Member_Manager
{
    partial class FRM_AddAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_AddAdmin));
            this.LBL_Heading = new System.Windows.Forms.Label();
            this.TBX_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.TBX_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.TBX_PasswordRepeated = new Guna.UI2.WinForms.Guna2TextBox();
            this.SEP_1 = new Guna.UI2.WinForms.Guna2Separator();
            this.ERR_Provider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BTN_AddAdmin = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.ERR_Provider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Heading
            // 
            this.LBL_Heading.AutoSize = true;
            this.LBL_Heading.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Heading.ForeColor = System.Drawing.Color.White;
            this.LBL_Heading.Location = new System.Drawing.Point(72, 33);
            this.LBL_Heading.Name = "LBL_Heading";
            this.LBL_Heading.Size = new System.Drawing.Size(182, 22);
            this.LBL_Heading.TabIndex = 0;
            this.LBL_Heading.Text = "Verwalter erstellen";
            // 
            // TBX_Username
            // 
            this.TBX_Username.Animated = true;
            this.TBX_Username.BackColor = System.Drawing.Color.Transparent;
            this.TBX_Username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.TBX_Username.BorderRadius = 5;
            this.TBX_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBX_Username.DefaultText = "";
            this.TBX_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBX_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBX_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBX_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBX_Username.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.TBX_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.TBX_Username.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Username.ForeColor = System.Drawing.Color.White;
            this.TBX_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.TBX_Username.Location = new System.Drawing.Point(65, 72);
            this.TBX_Username.MaxLength = 30;
            this.TBX_Username.Name = "TBX_Username";
            this.TBX_Username.PasswordChar = '\0';
            this.TBX_Username.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.TBX_Username.PlaceholderText = "Benutzername";
            this.TBX_Username.SelectedText = "";
            this.TBX_Username.Size = new System.Drawing.Size(200, 38);
            this.TBX_Username.TabIndex = 0;
            // 
            // TBX_Password
            // 
            this.TBX_Password.Animated = true;
            this.TBX_Password.BackColor = System.Drawing.Color.Transparent;
            this.TBX_Password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.TBX_Password.BorderRadius = 5;
            this.TBX_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBX_Password.DefaultText = "";
            this.TBX_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBX_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBX_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBX_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBX_Password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.TBX_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.TBX_Password.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Password.ForeColor = System.Drawing.Color.White;
            this.TBX_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.TBX_Password.Location = new System.Drawing.Point(65, 132);
            this.TBX_Password.MaxLength = 255;
            this.TBX_Password.Name = "TBX_Password";
            this.TBX_Password.PasswordChar = '●';
            this.TBX_Password.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.TBX_Password.PlaceholderText = "Passwort";
            this.TBX_Password.SelectedText = "";
            this.TBX_Password.Size = new System.Drawing.Size(200, 38);
            this.TBX_Password.TabIndex = 1;
            this.TBX_Password.UseSystemPasswordChar = true;
            // 
            // TBX_PasswordRepeated
            // 
            this.TBX_PasswordRepeated.Animated = true;
            this.TBX_PasswordRepeated.BackColor = System.Drawing.Color.Transparent;
            this.TBX_PasswordRepeated.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.TBX_PasswordRepeated.BorderRadius = 5;
            this.TBX_PasswordRepeated.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBX_PasswordRepeated.DefaultText = "";
            this.TBX_PasswordRepeated.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBX_PasswordRepeated.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBX_PasswordRepeated.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBX_PasswordRepeated.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBX_PasswordRepeated.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.TBX_PasswordRepeated.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.TBX_PasswordRepeated.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_PasswordRepeated.ForeColor = System.Drawing.Color.White;
            this.TBX_PasswordRepeated.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.TBX_PasswordRepeated.Location = new System.Drawing.Point(65, 176);
            this.TBX_PasswordRepeated.MaxLength = 255;
            this.TBX_PasswordRepeated.Name = "TBX_PasswordRepeated";
            this.TBX_PasswordRepeated.PasswordChar = '●';
            this.TBX_PasswordRepeated.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.TBX_PasswordRepeated.PlaceholderText = "Passwort wiederholen";
            this.TBX_PasswordRepeated.SelectedText = "";
            this.TBX_PasswordRepeated.Size = new System.Drawing.Size(200, 38);
            this.TBX_PasswordRepeated.TabIndex = 2;
            this.TBX_PasswordRepeated.UseSystemPasswordChar = true;
            // 
            // SEP_1
            // 
            this.SEP_1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.SEP_1.Location = new System.Drawing.Point(124, 116);
            this.SEP_1.Name = "SEP_1";
            this.SEP_1.Size = new System.Drawing.Size(83, 10);
            this.SEP_1.TabIndex = 2;
            // 
            // ERR_Provider1
            // 
            this.ERR_Provider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ERR_Provider1.ContainerControl = this;
            this.ERR_Provider1.Icon = ((System.Drawing.Icon)(resources.GetObject("ERR_Provider1.Icon")));
            // 
            // BTN_AddAdmin
            // 
            this.BTN_AddAdmin.Animated = true;
            this.BTN_AddAdmin.BorderRadius = 5;
            this.BTN_AddAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_AddAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_AddAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_AddAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_AddAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_AddAdmin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.BTN_AddAdmin.Font = new System.Drawing.Font("Arial", 9.75F);
            this.BTN_AddAdmin.ForeColor = System.Drawing.Color.White;
            this.BTN_AddAdmin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.BTN_AddAdmin.Image = global::Member_Manager.Properties.Resources.add;
            this.BTN_AddAdmin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_AddAdmin.Location = new System.Drawing.Point(65, 231);
            this.BTN_AddAdmin.Name = "BTN_AddAdmin";
            this.BTN_AddAdmin.Size = new System.Drawing.Size(200, 36);
            this.BTN_AddAdmin.TabIndex = 3;
            this.BTN_AddAdmin.Text = "Erstellen";
            this.BTN_AddAdmin.Click += new System.EventHandler(this.BTN_AddAdmin_Click);
            // 
            // FRM_AddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(326, 300);
            this.Controls.Add(this.BTN_AddAdmin);
            this.Controls.Add(this.SEP_1);
            this.Controls.Add(this.TBX_PasswordRepeated);
            this.Controls.Add(this.TBX_Password);
            this.Controls.Add(this.TBX_Username);
            this.Controls.Add(this.LBL_Heading);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FRM_AddAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verwalter erstellen :: Member Manager";
            ((System.ComponentModel.ISupportInitialize)(this.ERR_Provider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Heading;
        private Guna.UI2.WinForms.Guna2TextBox TBX_Username;
        private Guna.UI2.WinForms.Guna2TextBox TBX_Password;
        private Guna.UI2.WinForms.Guna2TextBox TBX_PasswordRepeated;
        private Guna.UI2.WinForms.Guna2Separator SEP_1;
        private Guna.UI2.WinForms.Guna2Button BTN_AddAdmin;
        private System.Windows.Forms.ErrorProvider ERR_Provider1;
    }
}

