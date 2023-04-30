namespace Member_Manager
{
    partial class MemberPresenceDisplay
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
            this.SPN_Background = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.BTN_EditPresence = new Guna.UI2.WinForms.Guna2Button();
            this.LBL_PresenceDate = new System.Windows.Forms.Label();
            this.SPN_Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // SPN_Background
            // 
            this.SPN_Background.BackColor = System.Drawing.Color.Transparent;
            this.SPN_Background.Controls.Add(this.BTN_EditPresence);
            this.SPN_Background.Controls.Add(this.LBL_PresenceDate);
            this.SPN_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SPN_Background.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.SPN_Background.ForeColor = System.Drawing.Color.White;
            this.SPN_Background.Location = new System.Drawing.Point(0, 0);
            this.SPN_Background.Name = "SPN_Background";
            this.SPN_Background.Padding = new System.Windows.Forms.Padding(10);
            this.SPN_Background.Radius = 5;
            this.SPN_Background.ShadowColor = System.Drawing.Color.Black;
            this.SPN_Background.ShadowDepth = 25;
            this.SPN_Background.Size = new System.Drawing.Size(164, 42);
            this.SPN_Background.TabIndex = 1;
            // 
            // BTN_EditPresence
            // 
            this.BTN_EditPresence.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.BTN_EditPresence.Image = global::Member_Manager.Properties.Resources.edit_pencil;
            this.BTN_EditPresence.Location = new System.Drawing.Point(127, 9);
            this.BTN_EditPresence.Name = "BTN_EditPresence";
            this.BTN_EditPresence.Size = new System.Drawing.Size(25, 25);
            this.BTN_EditPresence.TabIndex = 6;
            this.BTN_EditPresence.Click += new System.EventHandler(this.BTN_EditPresence_Click);
            // 
            // LBL_PresenceDate
            // 
            this.LBL_PresenceDate.AutoSize = true;
            this.LBL_PresenceDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.LBL_PresenceDate.ForeColor = System.Drawing.Color.White;
            this.LBL_PresenceDate.Location = new System.Drawing.Point(13, 10);
            this.LBL_PresenceDate.Name = "LBL_PresenceDate";
            this.LBL_PresenceDate.Size = new System.Drawing.Size(108, 22);
            this.LBL_PresenceDate.TabIndex = 1;
            this.LBL_PresenceDate.Text = "00.00.0000";
            // 
            // MemberPresenceDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.SPN_Background);
            this.Name = "MemberPresenceDisplay";
            this.Size = new System.Drawing.Size(164, 42);
            this.SPN_Background.ResumeLayout(false);
            this.SPN_Background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel SPN_Background;
        private System.Windows.Forms.Label LBL_PresenceDate;
        private Guna.UI2.WinForms.Guna2Button BTN_EditPresence;
    }
}
