namespace Member_Manager
{
    partial class FRM_MemberPresenceList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MemberPresenceList));
            this.PNL_Spacer1 = new System.Windows.Forms.Panel();
            this.BTN_UpdateList = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_AddDateOfPresence = new Guna.UI2.WinForms.Guna2Button();
            this.LBL_MemberFullName = new System.Windows.Forms.Label();
            this.FLP_LayoutMain = new System.Windows.Forms.FlowLayoutPanel();
            this.PNL_Spacer2 = new System.Windows.Forms.Panel();
            this.DTP_YearOfPresence = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.PNL_Spacer1.SuspendLayout();
            this.PNL_Spacer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_Spacer1
            // 
            this.PNL_Spacer1.Controls.Add(this.BTN_UpdateList);
            this.PNL_Spacer1.Controls.Add(this.BTN_AddDateOfPresence);
            this.PNL_Spacer1.Controls.Add(this.LBL_MemberFullName);
            this.PNL_Spacer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_Spacer1.Location = new System.Drawing.Point(0, 0);
            this.PNL_Spacer1.Name = "PNL_Spacer1";
            this.PNL_Spacer1.Size = new System.Drawing.Size(346, 57);
            this.PNL_Spacer1.TabIndex = 0;
            // 
            // BTN_UpdateList
            // 
            this.BTN_UpdateList.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_UpdateList.Animated = true;
            this.BTN_UpdateList.BorderRadius = 5;
            this.BTN_UpdateList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_UpdateList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_UpdateList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_UpdateList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_UpdateList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_UpdateList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.BTN_UpdateList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_UpdateList.ForeColor = System.Drawing.Color.White;
            this.BTN_UpdateList.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.BTN_UpdateList.Image = global::Member_Manager.Properties.Resources.refresh;
            this.BTN_UpdateList.Location = new System.Drawing.Point(267, 4);
            this.BTN_UpdateList.Name = "BTN_UpdateList";
            this.BTN_UpdateList.Size = new System.Drawing.Size(35, 35);
            this.BTN_UpdateList.TabIndex = 6;
            this.BTN_UpdateList.Click += new System.EventHandler(this.BTN_UpdateList_Click);
            // 
            // BTN_AddDateOfPresence
            // 
            this.BTN_AddDateOfPresence.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_AddDateOfPresence.Animated = true;
            this.BTN_AddDateOfPresence.BorderRadius = 5;
            this.BTN_AddDateOfPresence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_AddDateOfPresence.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_AddDateOfPresence.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_AddDateOfPresence.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_AddDateOfPresence.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_AddDateOfPresence.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.BTN_AddDateOfPresence.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AddDateOfPresence.ForeColor = System.Drawing.Color.White;
            this.BTN_AddDateOfPresence.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.BTN_AddDateOfPresence.Image = global::Member_Manager.Properties.Resources.add;
            this.BTN_AddDateOfPresence.Location = new System.Drawing.Point(308, 3);
            this.BTN_AddDateOfPresence.Name = "BTN_AddDateOfPresence";
            this.BTN_AddDateOfPresence.Size = new System.Drawing.Size(35, 35);
            this.BTN_AddDateOfPresence.TabIndex = 6;
            this.BTN_AddDateOfPresence.Click += new System.EventHandler(this.BTN_AddDateOfPresence_Click);
            // 
            // LBL_MemberFullName
            // 
            this.LBL_MemberFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_MemberFullName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.LBL_MemberFullName.ForeColor = System.Drawing.Color.White;
            this.LBL_MemberFullName.Location = new System.Drawing.Point(3, 17);
            this.LBL_MemberFullName.Name = "LBL_MemberFullName";
            this.LBL_MemberFullName.Size = new System.Drawing.Size(343, 22);
            this.LBL_MemberFullName.TabIndex = 2;
            this.LBL_MemberFullName.Text = "Max, Mustermann";
            this.LBL_MemberFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FLP_LayoutMain
            // 
            this.FLP_LayoutMain.AutoScroll = true;
            this.FLP_LayoutMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.FLP_LayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP_LayoutMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLP_LayoutMain.ForeColor = System.Drawing.Color.White;
            this.FLP_LayoutMain.Location = new System.Drawing.Point(0, 57);
            this.FLP_LayoutMain.Name = "FLP_LayoutMain";
            this.FLP_LayoutMain.Size = new System.Drawing.Size(346, 401);
            this.FLP_LayoutMain.TabIndex = 1;
            // 
            // PNL_Spacer2
            // 
            this.PNL_Spacer2.Controls.Add(this.DTP_YearOfPresence);
            this.PNL_Spacer2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PNL_Spacer2.ForeColor = System.Drawing.Color.White;
            this.PNL_Spacer2.Location = new System.Drawing.Point(0, 458);
            this.PNL_Spacer2.Name = "PNL_Spacer2";
            this.PNL_Spacer2.Size = new System.Drawing.Size(346, 57);
            this.PNL_Spacer2.TabIndex = 1;
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
            this.DTP_YearOfPresence.Location = new System.Drawing.Point(12, 11);
            this.DTP_YearOfPresence.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTP_YearOfPresence.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTP_YearOfPresence.Name = "DTP_YearOfPresence";
            this.DTP_YearOfPresence.ShowUpDown = true;
            this.DTP_YearOfPresence.Size = new System.Drawing.Size(90, 35);
            this.DTP_YearOfPresence.TabIndex = 7;
            this.DTP_YearOfPresence.Value = new System.DateTime(2023, 3, 18, 16, 44, 45, 841);
            this.DTP_YearOfPresence.ValueChanged += new System.EventHandler(this.DTP_YearOfPresence_ValueChanged);
            // 
            // FRM_MemberPresenceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(346, 515);
            this.Controls.Add(this.FLP_LayoutMain);
            this.Controls.Add(this.PNL_Spacer2);
            this.Controls.Add(this.PNL_Spacer1);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(362, 554);
            this.Name = "FRM_MemberPresenceList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anwesenheiten :: Member Manager";
            this.Load += new System.EventHandler(this.FRM_MemberPresenceList_Load);
            this.PNL_Spacer1.ResumeLayout(false);
            this.PNL_Spacer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Spacer1;
        private System.Windows.Forms.FlowLayoutPanel FLP_LayoutMain;
        private System.Windows.Forms.Label LBL_MemberFullName;
        private Guna.UI2.WinForms.Guna2Button BTN_AddDateOfPresence;
        private System.Windows.Forms.Panel PNL_Spacer2;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTP_YearOfPresence;
        private Guna.UI2.WinForms.Guna2Button BTN_UpdateList;
    }
}