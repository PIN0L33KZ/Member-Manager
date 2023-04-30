namespace Member_Manager
{
    partial class FRM_EditMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_EditMember));
            this.GPB_MemberProperties = new Guna.UI2.WinForms.Guna2GroupBox();
            this.CBX_MemberIsActive = new Guna.UI2.WinForms.Guna2CheckBox();
            this.LBL_EntryDate = new System.Windows.Forms.Label();
            this.LBL_DateOfBirthText = new System.Windows.Forms.Label();
            this.DTP_EntryDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DTP_DateOfBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.TBX_Surname = new Guna.UI2.WinForms.Guna2TextBox();
            this.TBX_Forename = new Guna.UI2.WinForms.Guna2TextBox();
            this.GPB_Adress = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TBX_Zipcode = new Guna.UI2.WinForms.Guna2TextBox();
            this.TBX_Housenumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.TBX_Town = new Guna.UI2.WinForms.Guna2TextBox();
            this.TBX_Street = new Guna.UI2.WinForms.Guna2TextBox();
            this.PNL_Spacer1 = new Guna.UI2.WinForms.Guna2Panel();
            this.PNL_Spacer2 = new Guna.UI2.WinForms.Guna2Panel();
            this.GPB_Departments = new Guna.UI2.WinForms.Guna2GroupBox();
            this.CBX_FireWeapons = new Guna.UI2.WinForms.Guna2CheckBox();
            this.CBX_AirPressureWeapons = new Guna.UI2.WinForms.Guna2CheckBox();
            this.CBX_Bow = new Guna.UI2.WinForms.Guna2CheckBox();
            this.BTN_SaveMember = new Guna.UI2.WinForms.Guna2Button();
            this.ERR_Provider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BTN_RemoveMember = new Guna.UI2.WinForms.Guna2Button();
            this.GPB_MemberProperties.SuspendLayout();
            this.GPB_Adress.SuspendLayout();
            this.GPB_Departments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ERR_Provider1)).BeginInit();
            this.SuspendLayout();
            // 
            // GPB_MemberProperties
            // 
            this.GPB_MemberProperties.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.GPB_MemberProperties.BorderRadius = 5;
            this.GPB_MemberProperties.Controls.Add(this.CBX_MemberIsActive);
            this.GPB_MemberProperties.Controls.Add(this.LBL_EntryDate);
            this.GPB_MemberProperties.Controls.Add(this.LBL_DateOfBirthText);
            this.GPB_MemberProperties.Controls.Add(this.DTP_EntryDate);
            this.GPB_MemberProperties.Controls.Add(this.DTP_DateOfBirth);
            this.GPB_MemberProperties.Controls.Add(this.TBX_Surname);
            this.GPB_MemberProperties.Controls.Add(this.TBX_Forename);
            this.GPB_MemberProperties.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.GPB_MemberProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.GPB_MemberProperties.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.GPB_MemberProperties.Font = new System.Drawing.Font("Arial", 9.75F);
            this.GPB_MemberProperties.ForeColor = System.Drawing.Color.White;
            this.GPB_MemberProperties.Location = new System.Drawing.Point(30, 30);
            this.GPB_MemberProperties.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.GPB_MemberProperties.Name = "GPB_MemberProperties";
            this.GPB_MemberProperties.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.GPB_MemberProperties.Size = new System.Drawing.Size(462, 212);
            this.GPB_MemberProperties.TabIndex = 0;
            this.GPB_MemberProperties.Text = "Mitglied";
            // 
            // CBX_MemberIsActive
            // 
            this.CBX_MemberIsActive.Animated = true;
            this.CBX_MemberIsActive.AutoSize = true;
            this.CBX_MemberIsActive.BackColor = System.Drawing.Color.Transparent;
            this.CBX_MemberIsActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.CBX_MemberIsActive.CheckedState.BorderRadius = 2;
            this.CBX_MemberIsActive.CheckedState.BorderThickness = 0;
            this.CBX_MemberIsActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.CBX_MemberIsActive.Location = new System.Drawing.Point(179, 186);
            this.CBX_MemberIsActive.Name = "CBX_MemberIsActive";
            this.CBX_MemberIsActive.Size = new System.Drawing.Size(104, 20);
            this.CBX_MemberIsActive.TabIndex = 2;
            this.CBX_MemberIsActive.Text = "Member Aktiv";
            this.CBX_MemberIsActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.CBX_MemberIsActive.UncheckedState.BorderRadius = 2;
            this.CBX_MemberIsActive.UncheckedState.BorderThickness = 0;
            this.CBX_MemberIsActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.CBX_MemberIsActive.UseVisualStyleBackColor = false;
            // 
            // LBL_EntryDate
            // 
            this.LBL_EntryDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LBL_EntryDate.AutoSize = true;
            this.LBL_EntryDate.BackColor = System.Drawing.Color.Transparent;
            this.LBL_EntryDate.Location = new System.Drawing.Point(120, 154);
            this.LBL_EntryDate.Name = "LBL_EntryDate";
            this.LBL_EntryDate.Size = new System.Drawing.Size(88, 16);
            this.LBL_EntryDate.TabIndex = 3;
            this.LBL_EntryDate.Text = "Eintrittsdatum";
            this.LBL_EntryDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_DateOfBirthText
            // 
            this.LBL_DateOfBirthText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LBL_DateOfBirthText.AutoSize = true;
            this.LBL_DateOfBirthText.BackColor = System.Drawing.Color.Transparent;
            this.LBL_DateOfBirthText.Location = new System.Drawing.Point(120, 112);
            this.LBL_DateOfBirthText.Name = "LBL_DateOfBirthText";
            this.LBL_DateOfBirthText.Size = new System.Drawing.Size(89, 16);
            this.LBL_DateOfBirthText.TabIndex = 3;
            this.LBL_DateOfBirthText.Text = "Geburtsdatum";
            this.LBL_DateOfBirthText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DTP_EntryDate
            // 
            this.DTP_EntryDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DTP_EntryDate.Animated = true;
            this.DTP_EntryDate.BorderRadius = 5;
            this.DTP_EntryDate.Checked = true;
            this.DTP_EntryDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.DTP_EntryDate.Font = new System.Drawing.Font("Arial", 9.75F);
            this.DTP_EntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_EntryDate.Location = new System.Drawing.Point(215, 144);
            this.DTP_EntryDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTP_EntryDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTP_EntryDate.Name = "DTP_EntryDate";
            this.DTP_EntryDate.Size = new System.Drawing.Size(127, 36);
            this.DTP_EntryDate.TabIndex = 3;
            this.DTP_EntryDate.Value = new System.DateTime(2023, 3, 14, 21, 49, 3, 899);
            // 
            // DTP_DateOfBirth
            // 
            this.DTP_DateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DTP_DateOfBirth.Animated = true;
            this.DTP_DateOfBirth.BorderRadius = 5;
            this.DTP_DateOfBirth.Checked = true;
            this.DTP_DateOfBirth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.DTP_DateOfBirth.Font = new System.Drawing.Font("Arial", 9.75F);
            this.DTP_DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_DateOfBirth.Location = new System.Drawing.Point(215, 102);
            this.DTP_DateOfBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTP_DateOfBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTP_DateOfBirth.Name = "DTP_DateOfBirth";
            this.DTP_DateOfBirth.Size = new System.Drawing.Size(127, 36);
            this.DTP_DateOfBirth.TabIndex = 2;
            this.DTP_DateOfBirth.Value = new System.DateTime(2023, 3, 14, 21, 49, 3, 899);
            // 
            // TBX_Surname
            // 
            this.TBX_Surname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TBX_Surname.Animated = true;
            this.TBX_Surname.BackColor = System.Drawing.Color.Transparent;
            this.TBX_Surname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.TBX_Surname.BorderRadius = 5;
            this.TBX_Surname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBX_Surname.DefaultText = "";
            this.TBX_Surname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBX_Surname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBX_Surname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBX_Surname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBX_Surname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.TBX_Surname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.TBX_Surname.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Surname.ForeColor = System.Drawing.Color.White;
            this.TBX_Surname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.TBX_Surname.Location = new System.Drawing.Point(234, 48);
            this.TBX_Surname.MaxLength = 30;
            this.TBX_Surname.Name = "TBX_Surname";
            this.TBX_Surname.PasswordChar = '\0';
            this.TBX_Surname.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.TBX_Surname.PlaceholderText = "Nachname";
            this.TBX_Surname.SelectedText = "";
            this.TBX_Surname.Size = new System.Drawing.Size(200, 38);
            this.TBX_Surname.TabIndex = 1;
            // 
            // TBX_Forename
            // 
            this.TBX_Forename.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TBX_Forename.Animated = true;
            this.TBX_Forename.BackColor = System.Drawing.Color.Transparent;
            this.TBX_Forename.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.TBX_Forename.BorderRadius = 5;
            this.TBX_Forename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBX_Forename.DefaultText = "";
            this.TBX_Forename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBX_Forename.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBX_Forename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBX_Forename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBX_Forename.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.TBX_Forename.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.TBX_Forename.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Forename.ForeColor = System.Drawing.Color.White;
            this.TBX_Forename.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.TBX_Forename.Location = new System.Drawing.Point(28, 48);
            this.TBX_Forename.MaxLength = 30;
            this.TBX_Forename.Name = "TBX_Forename";
            this.TBX_Forename.PasswordChar = '\0';
            this.TBX_Forename.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.TBX_Forename.PlaceholderText = "Vorname";
            this.TBX_Forename.SelectedText = "";
            this.TBX_Forename.Size = new System.Drawing.Size(200, 38);
            this.TBX_Forename.TabIndex = 0;
            // 
            // GPB_Adress
            // 
            this.GPB_Adress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.GPB_Adress.BorderRadius = 5;
            this.GPB_Adress.Controls.Add(this.TBX_Zipcode);
            this.GPB_Adress.Controls.Add(this.TBX_Housenumber);
            this.GPB_Adress.Controls.Add(this.TBX_Town);
            this.GPB_Adress.Controls.Add(this.TBX_Street);
            this.GPB_Adress.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.GPB_Adress.Dock = System.Windows.Forms.DockStyle.Top;
            this.GPB_Adress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.GPB_Adress.Font = new System.Drawing.Font("Arial", 9.75F);
            this.GPB_Adress.ForeColor = System.Drawing.Color.White;
            this.GPB_Adress.Location = new System.Drawing.Point(30, 264);
            this.GPB_Adress.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.GPB_Adress.Name = "GPB_Adress";
            this.GPB_Adress.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.GPB_Adress.Size = new System.Drawing.Size(462, 140);
            this.GPB_Adress.TabIndex = 1;
            this.GPB_Adress.Text = "Adresse";
            // 
            // TBX_Zipcode
            // 
            this.TBX_Zipcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TBX_Zipcode.Animated = true;
            this.TBX_Zipcode.BackColor = System.Drawing.Color.Transparent;
            this.TBX_Zipcode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.TBX_Zipcode.BorderRadius = 5;
            this.TBX_Zipcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBX_Zipcode.DefaultText = "";
            this.TBX_Zipcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBX_Zipcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBX_Zipcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBX_Zipcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBX_Zipcode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.TBX_Zipcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.TBX_Zipcode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Zipcode.ForeColor = System.Drawing.Color.White;
            this.TBX_Zipcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.TBX_Zipcode.Location = new System.Drawing.Point(28, 92);
            this.TBX_Zipcode.MaxLength = 5;
            this.TBX_Zipcode.Name = "TBX_Zipcode";
            this.TBX_Zipcode.PasswordChar = '\0';
            this.TBX_Zipcode.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.TBX_Zipcode.PlaceholderText = "PLZ";
            this.TBX_Zipcode.SelectedText = "";
            this.TBX_Zipcode.Size = new System.Drawing.Size(73, 38);
            this.TBX_Zipcode.TabIndex = 2;
            this.TBX_Zipcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBX_Housenumber
            // 
            this.TBX_Housenumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TBX_Housenumber.Animated = true;
            this.TBX_Housenumber.BackColor = System.Drawing.Color.Transparent;
            this.TBX_Housenumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.TBX_Housenumber.BorderRadius = 5;
            this.TBX_Housenumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBX_Housenumber.DefaultText = "";
            this.TBX_Housenumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBX_Housenumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBX_Housenumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBX_Housenumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBX_Housenumber.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.TBX_Housenumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.TBX_Housenumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Housenumber.ForeColor = System.Drawing.Color.White;
            this.TBX_Housenumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.TBX_Housenumber.Location = new System.Drawing.Point(361, 48);
            this.TBX_Housenumber.MaxLength = 5;
            this.TBX_Housenumber.Name = "TBX_Housenumber";
            this.TBX_Housenumber.PasswordChar = '\0';
            this.TBX_Housenumber.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.TBX_Housenumber.PlaceholderText = "Hausnr.";
            this.TBX_Housenumber.SelectedText = "";
            this.TBX_Housenumber.Size = new System.Drawing.Size(73, 38);
            this.TBX_Housenumber.TabIndex = 1;
            this.TBX_Housenumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBX_Town
            // 
            this.TBX_Town.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TBX_Town.Animated = true;
            this.TBX_Town.BackColor = System.Drawing.Color.Transparent;
            this.TBX_Town.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.TBX_Town.BorderRadius = 5;
            this.TBX_Town.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBX_Town.DefaultText = "";
            this.TBX_Town.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBX_Town.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBX_Town.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBX_Town.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBX_Town.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.TBX_Town.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.TBX_Town.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Town.ForeColor = System.Drawing.Color.White;
            this.TBX_Town.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.TBX_Town.Location = new System.Drawing.Point(107, 92);
            this.TBX_Town.MaxLength = 255;
            this.TBX_Town.Name = "TBX_Town";
            this.TBX_Town.PasswordChar = '\0';
            this.TBX_Town.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.TBX_Town.PlaceholderText = "Ort";
            this.TBX_Town.SelectedText = "";
            this.TBX_Town.Size = new System.Drawing.Size(327, 38);
            this.TBX_Town.TabIndex = 3;
            // 
            // TBX_Street
            // 
            this.TBX_Street.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TBX_Street.Animated = true;
            this.TBX_Street.BackColor = System.Drawing.Color.Transparent;
            this.TBX_Street.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.TBX_Street.BorderRadius = 5;
            this.TBX_Street.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBX_Street.DefaultText = "";
            this.TBX_Street.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBX_Street.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBX_Street.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBX_Street.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBX_Street.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.TBX_Street.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.TBX_Street.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Street.ForeColor = System.Drawing.Color.White;
            this.TBX_Street.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.TBX_Street.Location = new System.Drawing.Point(28, 48);
            this.TBX_Street.MaxLength = 255;
            this.TBX_Street.Name = "TBX_Street";
            this.TBX_Street.PasswordChar = '\0';
            this.TBX_Street.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.TBX_Street.PlaceholderText = "Straße";
            this.TBX_Street.SelectedText = "";
            this.TBX_Street.Size = new System.Drawing.Size(327, 38);
            this.TBX_Street.TabIndex = 0;
            // 
            // PNL_Spacer1
            // 
            this.PNL_Spacer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_Spacer1.Location = new System.Drawing.Point(30, 242);
            this.PNL_Spacer1.Name = "PNL_Spacer1";
            this.PNL_Spacer1.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.PNL_Spacer1.Size = new System.Drawing.Size(462, 22);
            this.PNL_Spacer1.TabIndex = 6;
            // 
            // PNL_Spacer2
            // 
            this.PNL_Spacer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_Spacer2.Location = new System.Drawing.Point(30, 404);
            this.PNL_Spacer2.Name = "PNL_Spacer2";
            this.PNL_Spacer2.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.PNL_Spacer2.Size = new System.Drawing.Size(462, 22);
            this.PNL_Spacer2.TabIndex = 7;
            // 
            // GPB_Departments
            // 
            this.GPB_Departments.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.GPB_Departments.BorderRadius = 5;
            this.GPB_Departments.Controls.Add(this.CBX_FireWeapons);
            this.GPB_Departments.Controls.Add(this.CBX_AirPressureWeapons);
            this.GPB_Departments.Controls.Add(this.CBX_Bow);
            this.GPB_Departments.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.GPB_Departments.Dock = System.Windows.Forms.DockStyle.Top;
            this.GPB_Departments.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.GPB_Departments.Font = new System.Drawing.Font("Arial", 9.75F);
            this.GPB_Departments.ForeColor = System.Drawing.Color.White;
            this.GPB_Departments.Location = new System.Drawing.Point(30, 426);
            this.GPB_Departments.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.GPB_Departments.Name = "GPB_Departments";
            this.GPB_Departments.Size = new System.Drawing.Size(462, 85);
            this.GPB_Departments.TabIndex = 8;
            this.GPB_Departments.Text = "Abteilungen";
            // 
            // CBX_FireWeapons
            // 
            this.CBX_FireWeapons.Animated = true;
            this.CBX_FireWeapons.AutoSize = true;
            this.CBX_FireWeapons.BackColor = System.Drawing.Color.Transparent;
            this.CBX_FireWeapons.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.CBX_FireWeapons.CheckedState.BorderRadius = 2;
            this.CBX_FireWeapons.CheckedState.BorderThickness = 0;
            this.CBX_FireWeapons.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.CBX_FireWeapons.Location = new System.Drawing.Point(316, 54);
            this.CBX_FireWeapons.Name = "CBX_FireWeapons";
            this.CBX_FireWeapons.Size = new System.Drawing.Size(95, 20);
            this.CBX_FireWeapons.TabIndex = 2;
            this.CBX_FireWeapons.Text = "Feuerwaffen";
            this.CBX_FireWeapons.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.CBX_FireWeapons.UncheckedState.BorderRadius = 2;
            this.CBX_FireWeapons.UncheckedState.BorderThickness = 0;
            this.CBX_FireWeapons.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.CBX_FireWeapons.UseVisualStyleBackColor = false;
            // 
            // CBX_AirPressureWeapons
            // 
            this.CBX_AirPressureWeapons.Animated = true;
            this.CBX_AirPressureWeapons.AutoSize = true;
            this.CBX_AirPressureWeapons.BackColor = System.Drawing.Color.Transparent;
            this.CBX_AirPressureWeapons.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.CBX_AirPressureWeapons.CheckedState.BorderRadius = 2;
            this.CBX_AirPressureWeapons.CheckedState.BorderThickness = 0;
            this.CBX_AirPressureWeapons.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.CBX_AirPressureWeapons.Location = new System.Drawing.Point(184, 54);
            this.CBX_AirPressureWeapons.Name = "CBX_AirPressureWeapons";
            this.CBX_AirPressureWeapons.Size = new System.Drawing.Size(115, 20);
            this.CBX_AirPressureWeapons.TabIndex = 1;
            this.CBX_AirPressureWeapons.Text = "Luftdruckwaffen";
            this.CBX_AirPressureWeapons.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.CBX_AirPressureWeapons.UncheckedState.BorderRadius = 2;
            this.CBX_AirPressureWeapons.UncheckedState.BorderThickness = 0;
            this.CBX_AirPressureWeapons.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.CBX_AirPressureWeapons.UseVisualStyleBackColor = false;
            // 
            // CBX_Bow
            // 
            this.CBX_Bow.Animated = true;
            this.CBX_Bow.AutoSize = true;
            this.CBX_Bow.BackColor = System.Drawing.Color.Transparent;
            this.CBX_Bow.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.CBX_Bow.CheckedState.BorderRadius = 2;
            this.CBX_Bow.CheckedState.BorderThickness = 0;
            this.CBX_Bow.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.CBX_Bow.Location = new System.Drawing.Point(51, 54);
            this.CBX_Bow.Name = "CBX_Bow";
            this.CBX_Bow.Size = new System.Drawing.Size(117, 20);
            this.CBX_Bow.TabIndex = 0;
            this.CBX_Bow.Text = "Bogenschießen";
            this.CBX_Bow.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.CBX_Bow.UncheckedState.BorderRadius = 2;
            this.CBX_Bow.UncheckedState.BorderThickness = 0;
            this.CBX_Bow.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.CBX_Bow.UseVisualStyleBackColor = false;
            // 
            // BTN_SaveMember
            // 
            this.BTN_SaveMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_SaveMember.Animated = true;
            this.BTN_SaveMember.BorderRadius = 5;
            this.BTN_SaveMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SaveMember.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_SaveMember.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_SaveMember.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_SaveMember.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_SaveMember.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.BTN_SaveMember.Font = new System.Drawing.Font("Arial", 9.75F);
            this.BTN_SaveMember.ForeColor = System.Drawing.Color.White;
            this.BTN_SaveMember.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.BTN_SaveMember.Image = global::Member_Manager.Properties.Resources.okay;
            this.BTN_SaveMember.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_SaveMember.Location = new System.Drawing.Point(292, 531);
            this.BTN_SaveMember.Name = "BTN_SaveMember";
            this.BTN_SaveMember.Size = new System.Drawing.Size(200, 36);
            this.BTN_SaveMember.TabIndex = 0;
            this.BTN_SaveMember.Text = "Speichern";
            this.BTN_SaveMember.Click += new System.EventHandler(this.BTN_SaveMember_Click);
            // 
            // ERR_Provider1
            // 
            this.ERR_Provider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ERR_Provider1.ContainerControl = this;
            this.ERR_Provider1.Icon = ((System.Drawing.Icon)(resources.GetObject("ERR_Provider1.Icon")));
            // 
            // BTN_RemoveMember
            // 
            this.BTN_RemoveMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_RemoveMember.Animated = true;
            this.BTN_RemoveMember.BorderRadius = 5;
            this.BTN_RemoveMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_RemoveMember.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_RemoveMember.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_RemoveMember.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_RemoveMember.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_RemoveMember.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.BTN_RemoveMember.Font = new System.Drawing.Font("Arial", 9.75F);
            this.BTN_RemoveMember.ForeColor = System.Drawing.Color.White;
            this.BTN_RemoveMember.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
            this.BTN_RemoveMember.Image = global::Member_Manager.Properties.Resources.trash;
            this.BTN_RemoveMember.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_RemoveMember.Location = new System.Drawing.Point(30, 531);
            this.BTN_RemoveMember.Name = "BTN_RemoveMember";
            this.BTN_RemoveMember.Size = new System.Drawing.Size(200, 36);
            this.BTN_RemoveMember.TabIndex = 0;
            this.BTN_RemoveMember.Text = "Löschen";
            this.BTN_RemoveMember.Click += new System.EventHandler(this.BTN_RemoveMember_Click);
            // 
            // FRM_EditMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(522, 600);
            this.Controls.Add(this.BTN_RemoveMember);
            this.Controls.Add(this.BTN_SaveMember);
            this.Controls.Add(this.GPB_Departments);
            this.Controls.Add(this.PNL_Spacer2);
            this.Controls.Add(this.GPB_Adress);
            this.Controls.Add(this.PNL_Spacer1);
            this.Controls.Add(this.GPB_MemberProperties);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_EditMember";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mitglied bearbeiten :: Member Manager";
            this.Load += new System.EventHandler(this.FRM_EditMember_Load);
            this.GPB_MemberProperties.ResumeLayout(false);
            this.GPB_MemberProperties.PerformLayout();
            this.GPB_Adress.ResumeLayout(false);
            this.GPB_Departments.ResumeLayout(false);
            this.GPB_Departments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ERR_Provider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GPB_MemberProperties;
        private Guna.UI2.WinForms.Guna2TextBox TBX_Forename;
        private Guna.UI2.WinForms.Guna2TextBox TBX_Surname;
        private System.Windows.Forms.Label LBL_DateOfBirthText;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTP_DateOfBirth;
        private Guna.UI2.WinForms.Guna2GroupBox GPB_Adress;
        private Guna.UI2.WinForms.Guna2TextBox TBX_Housenumber;
        private Guna.UI2.WinForms.Guna2TextBox TBX_Street;
        private Guna.UI2.WinForms.Guna2Panel PNL_Spacer1;
        private Guna.UI2.WinForms.Guna2TextBox TBX_Zipcode;
        private Guna.UI2.WinForms.Guna2TextBox TBX_Town;
        private Guna.UI2.WinForms.Guna2Panel PNL_Spacer2;
        private Guna.UI2.WinForms.Guna2GroupBox GPB_Departments;
        private Guna.UI2.WinForms.Guna2CheckBox CBX_Bow;
        private Guna.UI2.WinForms.Guna2CheckBox CBX_AirPressureWeapons;
        private Guna.UI2.WinForms.Guna2CheckBox CBX_FireWeapons;
        private Guna.UI2.WinForms.Guna2Button BTN_SaveMember;
        private System.Windows.Forms.Label LBL_EntryDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTP_EntryDate;
        private System.Windows.Forms.ErrorProvider ERR_Provider1;
        private Guna.UI2.WinForms.Guna2CheckBox CBX_MemberIsActive;
        private Guna.UI2.WinForms.Guna2Button BTN_RemoveMember;
    }
}