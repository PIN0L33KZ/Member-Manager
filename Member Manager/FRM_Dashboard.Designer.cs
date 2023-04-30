namespace Member_Manager
{
    partial class FRM_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Dashboard));
            this.SPN_Birthdays = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.BTN_UpdateDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.LBL_BirthdayMembers = new System.Windows.Forms.Label();
            this.LBL_BirthdaysHeading = new System.Windows.Forms.Label();
            this.PBX_BirthdaysIcon = new System.Windows.Forms.PictureBox();
            this.SPN_AdminUser = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.LBL_AdminUserWelcomeText = new System.Windows.Forms.Label();
            this.PBX_AdminUserIcon = new System.Windows.Forms.PictureBox();
            this.LBL_AdminUserHeading = new System.Windows.Forms.Label();
            this.PNL_Spacer2 = new Guna.UI2.WinForms.Guna2Panel();
            this.SPN_MemberOverview = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.BTN_MemberOverview = new Guna.UI2.WinForms.Guna2Button();
            this.PBX_MemberOverview = new System.Windows.Forms.PictureBox();
            this.LBL_MemberOverviewTitle = new System.Windows.Forms.Label();
            this.PNL_Spacer1 = new Guna.UI2.WinForms.Guna2Panel();
            this.SPN_Birthdays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_BirthdaysIcon)).BeginInit();
            this.SPN_AdminUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_AdminUserIcon)).BeginInit();
            this.SPN_MemberOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_MemberOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // SPN_Birthdays
            // 
            this.SPN_Birthdays.BackColor = System.Drawing.Color.Transparent;
            this.SPN_Birthdays.Controls.Add(this.BTN_UpdateDashboard);
            this.SPN_Birthdays.Controls.Add(this.LBL_BirthdayMembers);
            this.SPN_Birthdays.Controls.Add(this.LBL_BirthdaysHeading);
            this.SPN_Birthdays.Controls.Add(this.PBX_BirthdaysIcon);
            this.SPN_Birthdays.Dock = System.Windows.Forms.DockStyle.Top;
            this.SPN_Birthdays.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.SPN_Birthdays.Location = new System.Drawing.Point(0, 95);
            this.SPN_Birthdays.Margin = new System.Windows.Forms.Padding(10);
            this.SPN_Birthdays.Name = "SPN_Birthdays";
            this.SPN_Birthdays.Padding = new System.Windows.Forms.Padding(10, 10, 95, 10);
            this.SPN_Birthdays.Radius = 5;
            this.SPN_Birthdays.ShadowColor = System.Drawing.Color.Black;
            this.SPN_Birthdays.ShadowDepth = 50;
            this.SPN_Birthdays.ShadowShift = 4;
            this.SPN_Birthdays.Size = new System.Drawing.Size(974, 85);
            this.SPN_Birthdays.TabIndex = 0;
            // 
            // BTN_UpdateDashboard
            // 
            this.BTN_UpdateDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_UpdateDashboard.Animated = true;
            this.BTN_UpdateDashboard.BorderRadius = 5;
            this.BTN_UpdateDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_UpdateDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_UpdateDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_UpdateDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_UpdateDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_UpdateDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.BTN_UpdateDashboard.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_UpdateDashboard.ForeColor = System.Drawing.Color.White;
            this.BTN_UpdateDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.BTN_UpdateDashboard.Image = global::Member_Manager.Properties.Resources.refresh;
            this.BTN_UpdateDashboard.Location = new System.Drawing.Point(927, 10);
            this.BTN_UpdateDashboard.Name = "BTN_UpdateDashboard";
            this.BTN_UpdateDashboard.Size = new System.Drawing.Size(35, 35);
            this.BTN_UpdateDashboard.TabIndex = 7;
            this.BTN_UpdateDashboard.Click += new System.EventHandler(this.BTN_UpdateDashboard_Click);
            // 
            // LBL_BirthdayMembers
            // 
            this.LBL_BirthdayMembers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LBL_BirthdayMembers.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LBL_BirthdayMembers.ForeColor = System.Drawing.Color.White;
            this.LBL_BirthdayMembers.Location = new System.Drawing.Point(95, 42);
            this.LBL_BirthdayMembers.Name = "LBL_BirthdayMembers";
            this.LBL_BirthdayMembers.Size = new System.Drawing.Size(784, 33);
            this.LBL_BirthdayMembers.TabIndex = 0;
            this.LBL_BirthdayMembers.Text = "Heute stehen keine Geburtstage an.";
            this.LBL_BirthdayMembers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBL_BirthdaysHeading
            // 
            this.LBL_BirthdaysHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBL_BirthdaysHeading.AutoSize = true;
            this.LBL_BirthdaysHeading.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.LBL_BirthdaysHeading.ForeColor = System.Drawing.Color.White;
            this.LBL_BirthdaysHeading.Location = new System.Drawing.Point(425, 10);
            this.LBL_BirthdaysHeading.Name = "LBL_BirthdaysHeading";
            this.LBL_BirthdaysHeading.Size = new System.Drawing.Size(125, 22);
            this.LBL_BirthdaysHeading.TabIndex = 0;
            this.LBL_BirthdaysHeading.Text = "Geburtstage";
            this.LBL_BirthdaysHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PBX_BirthdaysIcon
            // 
            this.PBX_BirthdaysIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.PBX_BirthdaysIcon.Image = global::Member_Manager.Properties.Resources.cake;
            this.PBX_BirthdaysIcon.Location = new System.Drawing.Point(10, 10);
            this.PBX_BirthdaysIcon.Name = "PBX_BirthdaysIcon";
            this.PBX_BirthdaysIcon.Size = new System.Drawing.Size(85, 65);
            this.PBX_BirthdaysIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBX_BirthdaysIcon.TabIndex = 1;
            this.PBX_BirthdaysIcon.TabStop = false;
            // 
            // SPN_AdminUser
            // 
            this.SPN_AdminUser.BackColor = System.Drawing.Color.Transparent;
            this.SPN_AdminUser.Controls.Add(this.LBL_AdminUserWelcomeText);
            this.SPN_AdminUser.Controls.Add(this.PBX_AdminUserIcon);
            this.SPN_AdminUser.Controls.Add(this.LBL_AdminUserHeading);
            this.SPN_AdminUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.SPN_AdminUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.SPN_AdminUser.Location = new System.Drawing.Point(0, 0);
            this.SPN_AdminUser.Margin = new System.Windows.Forms.Padding(10);
            this.SPN_AdminUser.Name = "SPN_AdminUser";
            this.SPN_AdminUser.Padding = new System.Windows.Forms.Padding(10, 10, 95, 10);
            this.SPN_AdminUser.Radius = 5;
            this.SPN_AdminUser.ShadowColor = System.Drawing.Color.Black;
            this.SPN_AdminUser.ShadowDepth = 50;
            this.SPN_AdminUser.ShadowShift = 4;
            this.SPN_AdminUser.Size = new System.Drawing.Size(974, 85);
            this.SPN_AdminUser.TabIndex = 2;
            // 
            // LBL_AdminUserWelcomeText
            // 
            this.LBL_AdminUserWelcomeText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LBL_AdminUserWelcomeText.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LBL_AdminUserWelcomeText.ForeColor = System.Drawing.Color.White;
            this.LBL_AdminUserWelcomeText.Location = new System.Drawing.Point(95, 42);
            this.LBL_AdminUserWelcomeText.Name = "LBL_AdminUserWelcomeText";
            this.LBL_AdminUserWelcomeText.Size = new System.Drawing.Size(784, 33);
            this.LBL_AdminUserWelcomeText.TabIndex = 0;
            this.LBL_AdminUserWelcomeText.Text = "Sie sind angemeldet als: admin.\r\nWir wünschen ihnen einen erfolgreichen tag.";
            this.LBL_AdminUserWelcomeText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PBX_AdminUserIcon
            // 
            this.PBX_AdminUserIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.PBX_AdminUserIcon.Image = global::Member_Manager.Properties.Resources.id_card;
            this.PBX_AdminUserIcon.Location = new System.Drawing.Point(10, 10);
            this.PBX_AdminUserIcon.Name = "PBX_AdminUserIcon";
            this.PBX_AdminUserIcon.Size = new System.Drawing.Size(85, 65);
            this.PBX_AdminUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBX_AdminUserIcon.TabIndex = 1;
            this.PBX_AdminUserIcon.TabStop = false;
            // 
            // LBL_AdminUserHeading
            // 
            this.LBL_AdminUserHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBL_AdminUserHeading.AutoSize = true;
            this.LBL_AdminUserHeading.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.LBL_AdminUserHeading.ForeColor = System.Drawing.Color.White;
            this.LBL_AdminUserHeading.Location = new System.Drawing.Point(327, 10);
            this.LBL_AdminUserHeading.Name = "LBL_AdminUserHeading";
            this.LBL_AdminUserHeading.Size = new System.Drawing.Size(321, 22);
            this.LBL_AdminUserHeading.TabIndex = 0;
            this.LBL_AdminUserHeading.Text = "Willkommen im \"Glühenden Colt\"!";
            this.LBL_AdminUserHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PNL_Spacer2
            // 
            this.PNL_Spacer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_Spacer2.Location = new System.Drawing.Point(0, 180);
            this.PNL_Spacer2.Name = "PNL_Spacer2";
            this.PNL_Spacer2.Padding = new System.Windows.Forms.Padding(200, 0, 200, 0);
            this.PNL_Spacer2.Size = new System.Drawing.Size(974, 22);
            this.PNL_Spacer2.TabIndex = 5;
            // 
            // SPN_MemberOverview
            // 
            this.SPN_MemberOverview.BackColor = System.Drawing.Color.Transparent;
            this.SPN_MemberOverview.Controls.Add(this.BTN_MemberOverview);
            this.SPN_MemberOverview.Controls.Add(this.PBX_MemberOverview);
            this.SPN_MemberOverview.Controls.Add(this.LBL_MemberOverviewTitle);
            this.SPN_MemberOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.SPN_MemberOverview.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.SPN_MemberOverview.Location = new System.Drawing.Point(0, 202);
            this.SPN_MemberOverview.Margin = new System.Windows.Forms.Padding(10);
            this.SPN_MemberOverview.Name = "SPN_MemberOverview";
            this.SPN_MemberOverview.Padding = new System.Windows.Forms.Padding(10);
            this.SPN_MemberOverview.Radius = 5;
            this.SPN_MemberOverview.ShadowColor = System.Drawing.Color.Black;
            this.SPN_MemberOverview.ShadowDepth = 50;
            this.SPN_MemberOverview.ShadowShift = 4;
            this.SPN_MemberOverview.Size = new System.Drawing.Size(974, 90);
            this.SPN_MemberOverview.TabIndex = 6;
            // 
            // BTN_MemberOverview
            // 
            this.BTN_MemberOverview.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_MemberOverview.Animated = true;
            this.BTN_MemberOverview.BorderRadius = 5;
            this.BTN_MemberOverview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_MemberOverview.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_MemberOverview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_MemberOverview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_MemberOverview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_MemberOverview.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.BTN_MemberOverview.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_MemberOverview.ForeColor = System.Drawing.Color.White;
            this.BTN_MemberOverview.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.BTN_MemberOverview.Image = global::Member_Manager.Properties.Resources.group;
            this.BTN_MemberOverview.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_MemberOverview.Location = new System.Drawing.Point(387, 41);
            this.BTN_MemberOverview.Name = "BTN_MemberOverview";
            this.BTN_MemberOverview.Size = new System.Drawing.Size(200, 36);
            this.BTN_MemberOverview.TabIndex = 4;
            this.BTN_MemberOverview.Text = "Verwalten";
            this.BTN_MemberOverview.Click += new System.EventHandler(this.BTN_MemberOverview_Click);
            // 
            // PBX_MemberOverview
            // 
            this.PBX_MemberOverview.Dock = System.Windows.Forms.DockStyle.Left;
            this.PBX_MemberOverview.Image = global::Member_Manager.Properties.Resources.edit;
            this.PBX_MemberOverview.Location = new System.Drawing.Point(10, 10);
            this.PBX_MemberOverview.Name = "PBX_MemberOverview";
            this.PBX_MemberOverview.Size = new System.Drawing.Size(85, 70);
            this.PBX_MemberOverview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBX_MemberOverview.TabIndex = 1;
            this.PBX_MemberOverview.TabStop = false;
            // 
            // LBL_MemberOverviewTitle
            // 
            this.LBL_MemberOverviewTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBL_MemberOverviewTitle.AutoSize = true;
            this.LBL_MemberOverviewTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.LBL_MemberOverviewTitle.ForeColor = System.Drawing.Color.White;
            this.LBL_MemberOverviewTitle.Location = new System.Drawing.Point(389, 10);
            this.LBL_MemberOverviewTitle.Name = "LBL_MemberOverviewTitle";
            this.LBL_MemberOverviewTitle.Size = new System.Drawing.Size(197, 22);
            this.LBL_MemberOverviewTitle.TabIndex = 0;
            this.LBL_MemberOverviewTitle.Text = "Mitgliedsverwaltung";
            this.LBL_MemberOverviewTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PNL_Spacer1
            // 
            this.PNL_Spacer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_Spacer1.Location = new System.Drawing.Point(0, 85);
            this.PNL_Spacer1.Name = "PNL_Spacer1";
            this.PNL_Spacer1.Padding = new System.Windows.Forms.Padding(200, 0, 200, 0);
            this.PNL_Spacer1.Size = new System.Drawing.Size(974, 10);
            this.PNL_Spacer1.TabIndex = 7;
            // 
            // FRM_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(974, 567);
            this.Controls.Add(this.SPN_MemberOverview);
            this.Controls.Add(this.PNL_Spacer2);
            this.Controls.Add(this.SPN_Birthdays);
            this.Controls.Add(this.PNL_Spacer1);
            this.Controls.Add(this.SPN_AdminUser);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(990, 606);
            this.Name = "FRM_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Dashboard :: Member Manager";
            this.SPN_Birthdays.ResumeLayout(false);
            this.SPN_Birthdays.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_BirthdaysIcon)).EndInit();
            this.SPN_AdminUser.ResumeLayout(false);
            this.SPN_AdminUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_AdminUserIcon)).EndInit();
            this.SPN_MemberOverview.ResumeLayout(false);
            this.SPN_MemberOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_MemberOverview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel SPN_Birthdays;
        private System.Windows.Forms.Label LBL_BirthdaysHeading;
        private System.Windows.Forms.PictureBox PBX_BirthdaysIcon;
        private System.Windows.Forms.Label LBL_BirthdayMembers;
        private Guna.UI2.WinForms.Guna2ShadowPanel SPN_AdminUser;
        private System.Windows.Forms.PictureBox PBX_AdminUserIcon;
        private System.Windows.Forms.Label LBL_AdminUserWelcomeText;
        private System.Windows.Forms.Label LBL_AdminUserHeading;
        private Guna.UI2.WinForms.Guna2Panel PNL_Spacer2;
        private Guna.UI2.WinForms.Guna2ShadowPanel SPN_MemberOverview;
        private Guna.UI2.WinForms.Guna2Button BTN_MemberOverview;
        private System.Windows.Forms.PictureBox PBX_MemberOverview;
        private System.Windows.Forms.Label LBL_MemberOverviewTitle;
        private Guna.UI2.WinForms.Guna2Panel PNL_Spacer1;
        private Guna.UI2.WinForms.Guna2Button BTN_UpdateDashboard;
    }
}