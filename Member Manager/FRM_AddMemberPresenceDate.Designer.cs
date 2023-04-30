namespace Member_Manager
{
    partial class FRM_AddMemberPresenceDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_AddMemberPresenceDate));
            this.BTN_SaveDateOfPresence = new Guna.UI2.WinForms.Guna2Button();
            this.DTP_DateOfPresence = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ERR_Provider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ERR_Provider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_SaveDateOfPresence
            // 
            this.BTN_SaveDateOfPresence.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_SaveDateOfPresence.Animated = true;
            this.BTN_SaveDateOfPresence.BorderRadius = 5;
            this.BTN_SaveDateOfPresence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SaveDateOfPresence.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_SaveDateOfPresence.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_SaveDateOfPresence.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_SaveDateOfPresence.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_SaveDateOfPresence.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.BTN_SaveDateOfPresence.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SaveDateOfPresence.ForeColor = System.Drawing.Color.White;
            this.BTN_SaveDateOfPresence.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.BTN_SaveDateOfPresence.Image = global::Member_Manager.Properties.Resources.okay;
            this.BTN_SaveDateOfPresence.Location = new System.Drawing.Point(180, 17);
            this.BTN_SaveDateOfPresence.Name = "BTN_SaveDateOfPresence";
            this.BTN_SaveDateOfPresence.Size = new System.Drawing.Size(35, 35);
            this.BTN_SaveDateOfPresence.TabIndex = 5;
            this.BTN_SaveDateOfPresence.Click += new System.EventHandler(this.BTN_SaveDateOfPresence_Click);
            // 
            // DTP_DateOfPresence
            // 
            this.DTP_DateOfPresence.Animated = true;
            this.DTP_DateOfPresence.BorderRadius = 5;
            this.DTP_DateOfPresence.Checked = true;
            this.DTP_DateOfPresence.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.DTP_DateOfPresence.Font = new System.Drawing.Font("Arial", 9.75F);
            this.DTP_DateOfPresence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_DateOfPresence.Location = new System.Drawing.Point(47, 17);
            this.DTP_DateOfPresence.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTP_DateOfPresence.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTP_DateOfPresence.Name = "DTP_DateOfPresence";
            this.DTP_DateOfPresence.Size = new System.Drawing.Size(127, 35);
            this.DTP_DateOfPresence.TabIndex = 6;
            this.DTP_DateOfPresence.Value = new System.DateTime(2023, 3, 18, 16, 44, 45, 841);
            // 
            // ERR_Provider1
            // 
            this.ERR_Provider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ERR_Provider1.ContainerControl = this;
            this.ERR_Provider1.Icon = ((System.Drawing.Icon)(resources.GetObject("ERR_Provider1.Icon")));
            // 
            // FRM_AddMemberPresenceDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(262, 69);
            this.Controls.Add(this.DTP_DateOfPresence);
            this.Controls.Add(this.BTN_SaveDateOfPresence);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_AddMemberPresenceDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anwesenheit hinzufügen";
            this.Load += new System.EventHandler(this.FRM_AddMemberPresenceDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ERR_Provider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BTN_SaveDateOfPresence;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTP_DateOfPresence;
        private System.Windows.Forms.ErrorProvider ERR_Provider1;
    }
}