namespace Member_Manager
{
    partial class FRM_MemberOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MemberOverview));
            this.FLP_MainLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.PNL_Spacer1 = new System.Windows.Forms.Panel();
            this.CBX_FilterDisplayNotActive = new Guna.UI2.WinForms.Guna2CheckBox();
            this.RBT_FilterDisplaySurname = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RBT_FilterDisplayForename = new Guna.UI2.WinForms.Guna2RadioButton();
            this.BTN_FilterDisplays = new Guna.UI2.WinForms.Guna2Button();
            this.TBX_FilterDisplayInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.ERR_Provider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PNL_Spacer = new System.Windows.Forms.Panel();
            this.LBL_CalculateLicenceYear = new System.Windows.Forms.Label();
            this.DTP_YearOfPresence = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.BTN_AddMember = new Guna.UI2.WinForms.Guna2Button();
            this.PNL_Spacer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ERR_Provider1)).BeginInit();
            this.PNL_Spacer.SuspendLayout();
            this.SuspendLayout();
            // 
            // FLP_MainLayout
            // 
            this.FLP_MainLayout.AutoScroll = true;
            this.FLP_MainLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.FLP_MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP_MainLayout.Location = new System.Drawing.Point(0, 56);
            this.FLP_MainLayout.Name = "FLP_MainLayout";
            this.FLP_MainLayout.Size = new System.Drawing.Size(1114, 520);
            this.FLP_MainLayout.TabIndex = 0;
            // 
            // PNL_Spacer1
            // 
            this.PNL_Spacer1.Controls.Add(this.CBX_FilterDisplayNotActive);
            this.PNL_Spacer1.Controls.Add(this.RBT_FilterDisplaySurname);
            this.PNL_Spacer1.Controls.Add(this.RBT_FilterDisplayForename);
            this.PNL_Spacer1.Controls.Add(this.BTN_FilterDisplays);
            this.PNL_Spacer1.Controls.Add(this.TBX_FilterDisplayInput);
            this.PNL_Spacer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_Spacer1.Location = new System.Drawing.Point(0, 0);
            this.PNL_Spacer1.Name = "PNL_Spacer1";
            this.PNL_Spacer1.Size = new System.Drawing.Size(1114, 56);
            this.PNL_Spacer1.TabIndex = 0;
            // 
            // CBX_FilterDisplayNotActive
            // 
            this.CBX_FilterDisplayNotActive.Animated = true;
            this.CBX_FilterDisplayNotActive.AutoSize = true;
            this.CBX_FilterDisplayNotActive.BackColor = System.Drawing.Color.Transparent;
            this.CBX_FilterDisplayNotActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.CBX_FilterDisplayNotActive.CheckedState.BorderRadius = 2;
            this.CBX_FilterDisplayNotActive.CheckedState.BorderThickness = 0;
            this.CBX_FilterDisplayNotActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.CBX_FilterDisplayNotActive.Location = new System.Drawing.Point(435, 18);
            this.CBX_FilterDisplayNotActive.Name = "CBX_FilterDisplayNotActive";
            this.CBX_FilterDisplayNotActive.Size = new System.Drawing.Size(188, 20);
            this.CBX_FilterDisplayNotActive.TabIndex = 6;
            this.CBX_FilterDisplayNotActive.Text = "Nicht aktive Mitglieder listen";
            this.CBX_FilterDisplayNotActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.CBX_FilterDisplayNotActive.UncheckedState.BorderRadius = 2;
            this.CBX_FilterDisplayNotActive.UncheckedState.BorderThickness = 2;
            this.CBX_FilterDisplayNotActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.CBX_FilterDisplayNotActive.UseVisualStyleBackColor = false;
            // 
            // RBT_FilterDisplaySurname
            // 
            this.RBT_FilterDisplaySurname.Animated = true;
            this.RBT_FilterDisplaySurname.AutoSize = true;
            this.RBT_FilterDisplaySurname.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.RBT_FilterDisplaySurname.CheckedState.BorderThickness = 0;
            this.RBT_FilterDisplaySurname.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.RBT_FilterDisplaySurname.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.RBT_FilterDisplaySurname.CheckedState.InnerOffset = -4;
            this.RBT_FilterDisplaySurname.Location = new System.Drawing.Point(321, 18);
            this.RBT_FilterDisplaySurname.Name = "RBT_FilterDisplaySurname";
            this.RBT_FilterDisplaySurname.Size = new System.Drawing.Size(108, 20);
            this.RBT_FilterDisplaySurname.TabIndex = 5;
            this.RBT_FilterDisplaySurname.Text = "In Nachnamen";
            this.RBT_FilterDisplaySurname.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.RBT_FilterDisplaySurname.UncheckedState.BorderThickness = 2;
            this.RBT_FilterDisplaySurname.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RBT_FilterDisplaySurname.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // RBT_FilterDisplayForename
            // 
            this.RBT_FilterDisplayForename.Animated = true;
            this.RBT_FilterDisplayForename.AutoSize = true;
            this.RBT_FilterDisplayForename.Checked = true;
            this.RBT_FilterDisplayForename.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.RBT_FilterDisplayForename.CheckedState.BorderThickness = 0;
            this.RBT_FilterDisplayForename.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.RBT_FilterDisplayForename.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.RBT_FilterDisplayForename.CheckedState.InnerOffset = -4;
            this.RBT_FilterDisplayForename.Location = new System.Drawing.Point(218, 18);
            this.RBT_FilterDisplayForename.Name = "RBT_FilterDisplayForename";
            this.RBT_FilterDisplayForename.Size = new System.Drawing.Size(97, 20);
            this.RBT_FilterDisplayForename.TabIndex = 5;
            this.RBT_FilterDisplayForename.TabStop = true;
            this.RBT_FilterDisplayForename.Text = "In Vornamen";
            this.RBT_FilterDisplayForename.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.RBT_FilterDisplayForename.UncheckedState.BorderThickness = 2;
            this.RBT_FilterDisplayForename.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RBT_FilterDisplayForename.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // BTN_FilterDisplays
            // 
            this.BTN_FilterDisplays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_FilterDisplays.Animated = true;
            this.BTN_FilterDisplays.BorderRadius = 5;
            this.BTN_FilterDisplays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_FilterDisplays.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_FilterDisplays.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_FilterDisplays.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_FilterDisplays.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_FilterDisplays.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.BTN_FilterDisplays.Font = new System.Drawing.Font("Arial", 9.75F);
            this.BTN_FilterDisplays.ForeColor = System.Drawing.Color.White;
            this.BTN_FilterDisplays.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.BTN_FilterDisplays.Image = global::Member_Manager.Properties.Resources.search;
            this.BTN_FilterDisplays.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_FilterDisplays.Location = new System.Drawing.Point(876, 10);
            this.BTN_FilterDisplays.Name = "BTN_FilterDisplays";
            this.BTN_FilterDisplays.Size = new System.Drawing.Size(226, 36);
            this.BTN_FilterDisplays.TabIndex = 4;
            this.BTN_FilterDisplays.Text = "Suchen/Aktualisieren";
            this.BTN_FilterDisplays.Click += new System.EventHandler(this.BTN_FilterDisplays_Click);
            // 
            // TBX_FilterDisplayInput
            // 
            this.TBX_FilterDisplayInput.Animated = true;
            this.TBX_FilterDisplayInput.BackColor = System.Drawing.Color.Transparent;
            this.TBX_FilterDisplayInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.TBX_FilterDisplayInput.BorderRadius = 5;
            this.TBX_FilterDisplayInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBX_FilterDisplayInput.DefaultText = "";
            this.TBX_FilterDisplayInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBX_FilterDisplayInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBX_FilterDisplayInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBX_FilterDisplayInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBX_FilterDisplayInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.TBX_FilterDisplayInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.TBX_FilterDisplayInput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_FilterDisplayInput.ForeColor = System.Drawing.Color.White;
            this.TBX_FilterDisplayInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.TBX_FilterDisplayInput.Location = new System.Drawing.Point(12, 9);
            this.TBX_FilterDisplayInput.MaxLength = 30;
            this.TBX_FilterDisplayInput.Name = "TBX_FilterDisplayInput";
            this.TBX_FilterDisplayInput.PasswordChar = '\0';
            this.TBX_FilterDisplayInput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.TBX_FilterDisplayInput.PlaceholderText = "Filter";
            this.TBX_FilterDisplayInput.SelectedText = "";
            this.TBX_FilterDisplayInput.Size = new System.Drawing.Size(200, 38);
            this.TBX_FilterDisplayInput.TabIndex = 1;
            // 
            // ERR_Provider1
            // 
            this.ERR_Provider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ERR_Provider1.ContainerControl = this;
            this.ERR_Provider1.Icon = ((System.Drawing.Icon)(resources.GetObject("ERR_Provider1.Icon")));
            // 
            // PNL_Spacer
            // 
            this.PNL_Spacer.Controls.Add(this.BTN_AddMember);
            this.PNL_Spacer.Controls.Add(this.LBL_CalculateLicenceYear);
            this.PNL_Spacer.Controls.Add(this.DTP_YearOfPresence);
            this.PNL_Spacer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PNL_Spacer.Location = new System.Drawing.Point(0, 576);
            this.PNL_Spacer.Name = "PNL_Spacer";
            this.PNL_Spacer.Size = new System.Drawing.Size(1114, 56);
            this.PNL_Spacer.TabIndex = 1;
            // 
            // LBL_CalculateLicenceYear
            // 
            this.LBL_CalculateLicenceYear.AutoSize = true;
            this.LBL_CalculateLicenceYear.Location = new System.Drawing.Point(12, 20);
            this.LBL_CalculateLicenceYear.Name = "LBL_CalculateLicenceYear";
            this.LBL_CalculateLicenceYear.Size = new System.Drawing.Size(288, 16);
            this.LBL_CalculateLicenceYear.TabIndex = 9;
            this.LBL_CalculateLicenceYear.Text = "Waffenschein Lizenzberechtigung errechen aus: ";
            // 
            // DTP_YearOfPresence
            // 
            this.DTP_YearOfPresence.Animated = true;
            this.DTP_YearOfPresence.BorderRadius = 5;
            this.DTP_YearOfPresence.Checked = true;
            this.DTP_YearOfPresence.CustomFormat = "yyyy";
            this.DTP_YearOfPresence.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.DTP_YearOfPresence.Font = new System.Drawing.Font("Arial", 9.75F);
            this.DTP_YearOfPresence.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_YearOfPresence.Location = new System.Drawing.Point(306, 11);
            this.DTP_YearOfPresence.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTP_YearOfPresence.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTP_YearOfPresence.Name = "DTP_YearOfPresence";
            this.DTP_YearOfPresence.ShowUpDown = true;
            this.DTP_YearOfPresence.Size = new System.Drawing.Size(90, 35);
            this.DTP_YearOfPresence.TabIndex = 8;
            this.DTP_YearOfPresence.Value = new System.DateTime(2023, 3, 18, 16, 44, 45, 841);
            this.DTP_YearOfPresence.ValueChanged += new System.EventHandler(this.DTP_YearOfPresence_ValueChanged);
            // 
            // BTN_AddMember
            // 
            this.BTN_AddMember.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_AddMember.Animated = true;
            this.BTN_AddMember.BorderRadius = 5;
            this.BTN_AddMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_AddMember.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_AddMember.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_AddMember.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_AddMember.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_AddMember.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.BTN_AddMember.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AddMember.ForeColor = System.Drawing.Color.White;
            this.BTN_AddMember.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.BTN_AddMember.Image = global::Member_Manager.Properties.Resources.add;
            this.BTN_AddMember.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_AddMember.Location = new System.Drawing.Point(902, 11);
            this.BTN_AddMember.Name = "BTN_AddMember";
            this.BTN_AddMember.Size = new System.Drawing.Size(200, 36);
            this.BTN_AddMember.TabIndex = 10;
            this.BTN_AddMember.Text = "Mitglied anlegen";
            this.BTN_AddMember.Click += new System.EventHandler(this.BTN_AddMember_Click);
            // 
            // FRM_MemberOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1114, 632);
            this.Controls.Add(this.FLP_MainLayout);
            this.Controls.Add(this.PNL_Spacer);
            this.Controls.Add(this.PNL_Spacer1);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1130, 671);
            this.Name = "FRM_MemberOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mitgliederübersicht :: Member Manager";
            this.Load += new System.EventHandler(this.FRM_MemberOverview_Load);
            this.PNL_Spacer1.ResumeLayout(false);
            this.PNL_Spacer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ERR_Provider1)).EndInit();
            this.PNL_Spacer.ResumeLayout(false);
            this.PNL_Spacer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLP_MainLayout;
        private System.Windows.Forms.Panel PNL_Spacer1;
        private Guna.UI2.WinForms.Guna2TextBox TBX_FilterDisplayInput;
        private Guna.UI2.WinForms.Guna2Button BTN_FilterDisplays;
        private Guna.UI2.WinForms.Guna2RadioButton RBT_FilterDisplaySurname;
        private Guna.UI2.WinForms.Guna2RadioButton RBT_FilterDisplayForename;
        private System.Windows.Forms.ErrorProvider ERR_Provider1;
        private Guna.UI2.WinForms.Guna2CheckBox CBX_FilterDisplayNotActive;
        private System.Windows.Forms.Panel PNL_Spacer;
        private System.Windows.Forms.Label LBL_CalculateLicenceYear;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTP_YearOfPresence;
        private Guna.UI2.WinForms.Guna2Button BTN_AddMember;
    }
}