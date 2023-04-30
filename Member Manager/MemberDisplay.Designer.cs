namespace Member_Manager
{
    partial class MemberDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SPN_Background = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.PBX_MemberIcon = new System.Windows.Forms.PictureBox();
            this.PBX_FireWeapon = new System.Windows.Forms.PictureBox();
            this.PBX_AirPressureWeapon = new System.Windows.Forms.PictureBox();
            this.PBX_Archer = new System.Windows.Forms.PictureBox();
            this.BTN_EditPresence = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_EditMember = new Guna.UI2.WinForms.Guna2Button();
            this.LBL_LicenceAuthorized = new System.Windows.Forms.Label();
            this.LBL_MemberIsActive = new System.Windows.Forms.Label();
            this.LBL_MemberCosts = new System.Windows.Forms.Label();
            this.LBL_MemberEntryDate = new System.Windows.Forms.Label();
            this.LBL_MemberBirthday = new System.Windows.Forms.Label();
            this.LBL_MemberAdress = new System.Windows.Forms.Label();
            this.LBL_MemberFullName = new System.Windows.Forms.Label();
            this.TTP_1 = new System.Windows.Forms.ToolTip(this.components);
            this.SPN_Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_MemberIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_FireWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_AirPressureWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Archer)).BeginInit();
            this.SuspendLayout();
            // 
            // SPN_Background
            // 
            this.SPN_Background.BackColor = System.Drawing.Color.Transparent;
            this.SPN_Background.Controls.Add(this.PBX_MemberIcon);
            this.SPN_Background.Controls.Add(this.PBX_FireWeapon);
            this.SPN_Background.Controls.Add(this.PBX_AirPressureWeapon);
            this.SPN_Background.Controls.Add(this.PBX_Archer);
            this.SPN_Background.Controls.Add(this.BTN_EditPresence);
            this.SPN_Background.Controls.Add(this.BTN_EditMember);
            this.SPN_Background.Controls.Add(this.LBL_LicenceAuthorized);
            this.SPN_Background.Controls.Add(this.LBL_MemberIsActive);
            this.SPN_Background.Controls.Add(this.LBL_MemberCosts);
            this.SPN_Background.Controls.Add(this.LBL_MemberEntryDate);
            this.SPN_Background.Controls.Add(this.LBL_MemberBirthday);
            this.SPN_Background.Controls.Add(this.LBL_MemberAdress);
            this.SPN_Background.Controls.Add(this.LBL_MemberFullName);
            this.SPN_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SPN_Background.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.SPN_Background.ForeColor = System.Drawing.Color.White;
            this.SPN_Background.Location = new System.Drawing.Point(0, 0);
            this.SPN_Background.Name = "SPN_Background";
            this.SPN_Background.Padding = new System.Windows.Forms.Padding(10);
            this.SPN_Background.Radius = 5;
            this.SPN_Background.ShadowColor = System.Drawing.Color.Black;
            this.SPN_Background.Size = new System.Drawing.Size(470, 163);
            this.SPN_Background.TabIndex = 0;
            // 
            // PBX_MemberIcon
            // 
            this.PBX_MemberIcon.Image = global::Member_Manager.Properties.Resources.user;
            this.PBX_MemberIcon.Location = new System.Drawing.Point(13, 39);
            this.PBX_MemberIcon.Name = "PBX_MemberIcon";
            this.PBX_MemberIcon.Size = new System.Drawing.Size(85, 85);
            this.PBX_MemberIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PBX_MemberIcon.TabIndex = 0;
            this.PBX_MemberIcon.TabStop = false;
            // 
            // PBX_FireWeapon
            // 
            this.PBX_FireWeapon.Dock = System.Windows.Forms.DockStyle.Left;
            this.PBX_FireWeapon.Image = global::Member_Manager.Properties.Resources.fire_weapon;
            this.PBX_FireWeapon.Location = new System.Drawing.Point(74, 10);
            this.PBX_FireWeapon.Name = "PBX_FireWeapon";
            this.PBX_FireWeapon.Size = new System.Drawing.Size(32, 143);
            this.PBX_FireWeapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PBX_FireWeapon.TabIndex = 6;
            this.PBX_FireWeapon.TabStop = false;
            this.TTP_1.SetToolTip(this.PBX_FireWeapon, "Feuerwaffenschütze");
            this.PBX_FireWeapon.Visible = false;
            // 
            // PBX_AirPressureWeapon
            // 
            this.PBX_AirPressureWeapon.Dock = System.Windows.Forms.DockStyle.Left;
            this.PBX_AirPressureWeapon.Image = global::Member_Manager.Properties.Resources.air_pressure_weapon;
            this.PBX_AirPressureWeapon.Location = new System.Drawing.Point(42, 10);
            this.PBX_AirPressureWeapon.Name = "PBX_AirPressureWeapon";
            this.PBX_AirPressureWeapon.Size = new System.Drawing.Size(32, 143);
            this.PBX_AirPressureWeapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PBX_AirPressureWeapon.TabIndex = 6;
            this.PBX_AirPressureWeapon.TabStop = false;
            this.TTP_1.SetToolTip(this.PBX_AirPressureWeapon, "Luftdruckwaffenschütze");
            this.PBX_AirPressureWeapon.Visible = false;
            // 
            // PBX_Archer
            // 
            this.PBX_Archer.Dock = System.Windows.Forms.DockStyle.Left;
            this.PBX_Archer.Image = global::Member_Manager.Properties.Resources.archer;
            this.PBX_Archer.Location = new System.Drawing.Point(10, 10);
            this.PBX_Archer.Name = "PBX_Archer";
            this.PBX_Archer.Size = new System.Drawing.Size(32, 143);
            this.PBX_Archer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PBX_Archer.TabIndex = 6;
            this.PBX_Archer.TabStop = false;
            this.TTP_1.SetToolTip(this.PBX_Archer, "Bogenschütze");
            this.PBX_Archer.Visible = false;
            // 
            // BTN_EditPresence
            // 
            this.BTN_EditPresence.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_EditPresence.Animated = true;
            this.BTN_EditPresence.BorderRadius = 5;
            this.BTN_EditPresence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_EditPresence.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_EditPresence.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_EditPresence.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_EditPresence.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_EditPresence.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.BTN_EditPresence.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EditPresence.ForeColor = System.Drawing.Color.White;
            this.BTN_EditPresence.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.BTN_EditPresence.Image = global::Member_Manager.Properties.Resources.book;
            this.BTN_EditPresence.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_EditPresence.Location = new System.Drawing.Point(289, 90);
            this.BTN_EditPresence.Name = "BTN_EditPresence";
            this.BTN_EditPresence.Size = new System.Drawing.Size(168, 27);
            this.BTN_EditPresence.TabIndex = 5;
            this.BTN_EditPresence.Text = "Anwesenheit";
            this.BTN_EditPresence.Click += new System.EventHandler(this.BTN_EditPresence_Click);
            // 
            // BTN_EditMember
            // 
            this.BTN_EditMember.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_EditMember.Animated = true;
            this.BTN_EditMember.BorderRadius = 5;
            this.BTN_EditMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_EditMember.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_EditMember.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_EditMember.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_EditMember.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_EditMember.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.BTN_EditMember.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EditMember.ForeColor = System.Drawing.Color.White;
            this.BTN_EditMember.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.BTN_EditMember.Image = global::Member_Manager.Properties.Resources.edit_pencil;
            this.BTN_EditMember.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_EditMember.Location = new System.Drawing.Point(289, 123);
            this.BTN_EditMember.Name = "BTN_EditMember";
            this.BTN_EditMember.Size = new System.Drawing.Size(168, 27);
            this.BTN_EditMember.TabIndex = 5;
            this.BTN_EditMember.Text = "Bearbeiten";
            this.BTN_EditMember.Click += new System.EventHandler(this.BTN_EditMember_Click);
            // 
            // LBL_LicenceAuthorized
            // 
            this.LBL_LicenceAuthorized.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LBL_LicenceAuthorized.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.LBL_LicenceAuthorized.Location = new System.Drawing.Point(286, 52);
            this.LBL_LicenceAuthorized.Name = "LBL_LicenceAuthorized";
            this.LBL_LicenceAuthorized.Size = new System.Drawing.Size(171, 20);
            this.LBL_LicenceAuthorized.TabIndex = 1;
            this.LBL_LicenceAuthorized.Text = "Nicht Erwerbsberechtigt";
            this.LBL_LicenceAuthorized.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_MemberIsActive
            // 
            this.LBL_MemberIsActive.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LBL_MemberIsActive.ForeColor = System.Drawing.Color.White;
            this.LBL_MemberIsActive.Location = new System.Drawing.Point(286, 10);
            this.LBL_MemberIsActive.Name = "LBL_MemberIsActive";
            this.LBL_MemberIsActive.Size = new System.Drawing.Size(171, 20);
            this.LBL_MemberIsActive.TabIndex = 1;
            this.LBL_MemberIsActive.Text = "Aktiv";
            this.LBL_MemberIsActive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_MemberCosts
            // 
            this.LBL_MemberCosts.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LBL_MemberCosts.ForeColor = System.Drawing.Color.White;
            this.LBL_MemberCosts.Location = new System.Drawing.Point(286, 32);
            this.LBL_MemberCosts.Name = "LBL_MemberCosts";
            this.LBL_MemberCosts.Size = new System.Drawing.Size(171, 20);
            this.LBL_MemberCosts.TabIndex = 1;
            this.LBL_MemberCosts.Text = "Mitgliedsbeitrag: 100€";
            this.LBL_MemberCosts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_MemberEntryDate
            // 
            this.LBL_MemberEntryDate.AutoSize = true;
            this.LBL_MemberEntryDate.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LBL_MemberEntryDate.ForeColor = System.Drawing.Color.White;
            this.LBL_MemberEntryDate.Location = new System.Drawing.Point(105, 124);
            this.LBL_MemberEntryDate.Name = "LBL_MemberEntryDate";
            this.LBL_MemberEntryDate.Size = new System.Drawing.Size(117, 16);
            this.LBL_MemberEntryDate.TabIndex = 1;
            this.LBL_MemberEntryDate.Text = "Eintritt: 28.09.2003";
            // 
            // LBL_MemberBirthday
            // 
            this.LBL_MemberBirthday.AutoSize = true;
            this.LBL_MemberBirthday.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LBL_MemberBirthday.ForeColor = System.Drawing.Color.White;
            this.LBL_MemberBirthday.Location = new System.Drawing.Point(105, 108);
            this.LBL_MemberBirthday.Name = "LBL_MemberBirthday";
            this.LBL_MemberBirthday.Size = new System.Drawing.Size(128, 16);
            this.LBL_MemberBirthday.TabIndex = 1;
            this.LBL_MemberBirthday.Text = "Geboren: 28.09.2003";
            // 
            // LBL_MemberAdress
            // 
            this.LBL_MemberAdress.AutoSize = true;
            this.LBL_MemberAdress.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LBL_MemberAdress.ForeColor = System.Drawing.Color.White;
            this.LBL_MemberAdress.Location = new System.Drawing.Point(105, 66);
            this.LBL_MemberAdress.Name = "LBL_MemberAdress";
            this.LBL_MemberAdress.Size = new System.Drawing.Size(109, 32);
            this.LBL_MemberAdress.TabIndex = 1;
            this.LBL_MemberAdress.Text = "Pfalzfelder Str. 17\r\n56329 St. Goar";
            // 
            // LBL_MemberFullName
            // 
            this.LBL_MemberFullName.AutoSize = true;
            this.LBL_MemberFullName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.LBL_MemberFullName.ForeColor = System.Drawing.Color.White;
            this.LBL_MemberFullName.Location = new System.Drawing.Point(104, 39);
            this.LBL_MemberFullName.Name = "LBL_MemberFullName";
            this.LBL_MemberFullName.Size = new System.Drawing.Size(176, 22);
            this.LBL_MemberFullName.TabIndex = 1;
            this.LBL_MemberFullName.Text = "Max, Mustermann";
            // 
            // MemberDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.SPN_Background);
            this.Name = "MemberDisplay";
            this.Size = new System.Drawing.Size(470, 163);
            this.SPN_Background.ResumeLayout(false);
            this.SPN_Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_MemberIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_FireWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_AirPressureWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Archer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel SPN_Background;
        private System.Windows.Forms.PictureBox PBX_MemberIcon;
        private System.Windows.Forms.Label LBL_MemberFullName;
        private System.Windows.Forms.Label LBL_MemberAdress;
        private System.Windows.Forms.Label LBL_MemberBirthday;
        private System.Windows.Forms.Label LBL_MemberCosts;
        private System.Windows.Forms.Label LBL_LicenceAuthorized;
        private Guna.UI2.WinForms.Guna2Button BTN_EditMember;
        private System.Windows.Forms.PictureBox PBX_Archer;
        private System.Windows.Forms.PictureBox PBX_AirPressureWeapon;
        private System.Windows.Forms.PictureBox PBX_FireWeapon;
        private System.Windows.Forms.ToolTip TTP_1;
        private System.Windows.Forms.Label LBL_MemberIsActive;
        private System.Windows.Forms.Label LBL_MemberEntryDate;
        private Guna.UI2.WinForms.Guna2Button BTN_EditPresence;
    }
}
