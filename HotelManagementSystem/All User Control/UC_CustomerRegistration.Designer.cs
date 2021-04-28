
using System;

namespace HotelManagementSystem.All_User_Control
{
    partial class UC_CustomerRegistration
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
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNationality = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtDob = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtIdProof = new Guna.UI2.WinForms.Guna2TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtCheckIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtBed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtRoom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtRoomNo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAlloteRoom = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(26, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(189, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Customer Registration";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Name";
            this.label15.Click += new System.EventHandler(this.label14_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 127);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Mobile No.";
            this.label16.Click += new System.EventHandler(this.label14_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 192);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Nationality";
            this.label17.Click += new System.EventHandler(this.label14_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(27, 256);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Gender";
            this.label18.Click += new System.EventHandler(this.label14_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(26, 320);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Date of Birth";
            this.label19.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(29, 75);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(200, 36);
            this.txtName.TabIndex = 1;
            // 
            // txtContact
            // 
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.DefaultText = "";
            this.txtContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContact.DisabledState.Parent = this.txtContact;
            this.txtContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContact.FocusedState.Parent = this.txtContact;
            this.txtContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContact.HoverState.Parent = this.txtContact;
            this.txtContact.Location = new System.Drawing.Point(29, 143);
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.PlaceholderText = "";
            this.txtContact.SelectedText = "";
            this.txtContact.ShadowDecoration.Parent = this.txtContact;
            this.txtContact.Size = new System.Drawing.Size(200, 36);
            this.txtContact.TabIndex = 1;
            // 
            // txtNationality
            // 
            this.txtNationality.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationality.DefaultText = "";
            this.txtNationality.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNationality.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNationality.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationality.DisabledState.Parent = this.txtNationality;
            this.txtNationality.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationality.FocusedState.Parent = this.txtNationality;
            this.txtNationality.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationality.HoverState.Parent = this.txtNationality;
            this.txtNationality.Location = new System.Drawing.Point(29, 208);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.PasswordChar = '\0';
            this.txtNationality.PlaceholderText = "";
            this.txtNationality.SelectedText = "";
            this.txtNationality.ShadowDecoration.Parent = this.txtNationality;
            this.txtNationality.Size = new System.Drawing.Size(200, 36);
            this.txtNationality.TabIndex = 1;
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.Transparent;
            this.txtGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGender.FocusedColor = System.Drawing.Color.Empty;
            this.txtGender.FocusedState.Parent = this.txtGender;
            this.txtGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtGender.FormattingEnabled = true;
            this.txtGender.HoverState.Parent = this.txtGender;
            this.txtGender.ItemHeight = 30;
            this.txtGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.txtGender.ItemsAppearance.Parent = this.txtGender;
            this.txtGender.Location = new System.Drawing.Point(29, 272);
            this.txtGender.Name = "txtGender";
            this.txtGender.ShadowDecoration.Parent = this.txtGender;
            this.txtGender.Size = new System.Drawing.Size(200, 36);
            this.txtGender.TabIndex = 2;
            // 
            // txtDob
            // 
            this.txtDob.CheckedState.Parent = this.txtDob;
            this.txtDob.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtDob.HoverState.Parent = this.txtDob;
            this.txtDob.Location = new System.Drawing.Point(29, 336);
            this.txtDob.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtDob.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtDob.Name = "txtDob";
            this.txtDob.ShadowDecoration.Parent = this.txtDob;
            this.txtDob.Size = new System.Drawing.Size(200, 36);
            this.txtDob.TabIndex = 3;
            this.txtDob.Value = new System.DateTime(2021, 4, 4, 21, 50, 36, 491);
            // 
            // txtIdProof
            // 
            this.txtIdProof.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdProof.DefaultText = "";
            this.txtIdProof.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdProof.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdProof.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdProof.DisabledState.Parent = this.txtIdProof;
            this.txtIdProof.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdProof.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdProof.FocusedState.Parent = this.txtIdProof;
            this.txtIdProof.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdProof.HoverState.Parent = this.txtIdProof;
            this.txtIdProof.Location = new System.Drawing.Point(299, 75);
            this.txtIdProof.Name = "txtIdProof";
            this.txtIdProof.PasswordChar = '\0';
            this.txtIdProof.PlaceholderText = "";
            this.txtIdProof.SelectedText = "";
            this.txtIdProof.ShadowDecoration.Parent = this.txtIdProof;
            this.txtIdProof.Size = new System.Drawing.Size(200, 36);
            this.txtIdProof.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(296, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "ID Proof";
            this.label20.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.Parent = this.txtAddress;
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.FocusedState.Parent = this.txtAddress;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.HoverState.Parent = this.txtAddress;
            this.txtAddress.Location = new System.Drawing.Point(299, 143);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.ShadowDecoration.Parent = this.txtAddress;
            this.txtAddress.Size = new System.Drawing.Size(200, 36);
            this.txtAddress.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(296, 127);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Address";
            this.label21.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtCheckIn
            // 
            this.txtCheckIn.CheckedState.Parent = this.txtCheckIn;
            this.txtCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtCheckIn.HoverState.Parent = this.txtCheckIn;
            this.txtCheckIn.Location = new System.Drawing.Point(299, 208);
            this.txtCheckIn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtCheckIn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtCheckIn.Name = "txtCheckIn";
            this.txtCheckIn.ShadowDecoration.Parent = this.txtCheckIn;
            this.txtCheckIn.Size = new System.Drawing.Size(200, 36);
            this.txtCheckIn.TabIndex = 3;
            this.txtCheckIn.Value = new System.DateTime(2021, 4, 4, 21, 50, 36, 491);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(296, 192);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Check In";
            this.label22.Click += new System.EventHandler(this.label14_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(563, 59);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(26, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Bed";
            this.label23.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtBed
            // 
            this.txtBed.BackColor = System.Drawing.Color.Transparent;
            this.txtBed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtBed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBed.FocusedColor = System.Drawing.Color.Empty;
            this.txtBed.FocusedState.Parent = this.txtBed;
            this.txtBed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtBed.FormattingEnabled = true;
            this.txtBed.HoverState.Parent = this.txtBed;
            this.txtBed.ItemHeight = 30;
            this.txtBed.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple"});
            this.txtBed.ItemsAppearance.Parent = this.txtBed;
            this.txtBed.Location = new System.Drawing.Point(566, 75);
            this.txtBed.Name = "txtBed";
            this.txtBed.ShadowDecoration.Parent = this.txtBed;
            this.txtBed.Size = new System.Drawing.Size(200, 36);
            this.txtBed.TabIndex = 2;
            this.txtBed.SelectedIndexChanged += new System.EventHandler(this.txtBed_SelectedIndexChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(563, 127);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(62, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Room Type";
            this.label24.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtRoom
            // 
            this.txtRoom.BackColor = System.Drawing.Color.Transparent;
            this.txtRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtRoom.FocusedColor = System.Drawing.Color.Empty;
            this.txtRoom.FocusedState.Parent = this.txtRoom;
            this.txtRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtRoom.FormattingEnabled = true;
            this.txtRoom.HoverState.Parent = this.txtRoom;
            this.txtRoom.ItemHeight = 30;
            this.txtRoom.Items.AddRange(new object[] {
            "Ac",
            "Non-ac"});
            this.txtRoom.ItemsAppearance.Parent = this.txtRoom;
            this.txtRoom.Location = new System.Drawing.Point(566, 143);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.ShadowDecoration.Parent = this.txtRoom;
            this.txtRoom.Size = new System.Drawing.Size(200, 36);
            this.txtRoom.TabIndex = 2;
            this.txtRoom.SelectedIndexChanged += new System.EventHandler(this.txtRoom_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(563, 192);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "Room No";
            this.label25.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.BackColor = System.Drawing.Color.Transparent;
            this.txtRoomNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtRoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtRoomNo.FocusedColor = System.Drawing.Color.Empty;
            this.txtRoomNo.FocusedState.Parent = this.txtRoomNo;
            this.txtRoomNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRoomNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtRoomNo.FormattingEnabled = true;
            this.txtRoomNo.HoverState.Parent = this.txtRoomNo;
            this.txtRoomNo.ItemHeight = 30;
            this.txtRoomNo.ItemsAppearance.Parent = this.txtRoomNo;
            this.txtRoomNo.Location = new System.Drawing.Point(566, 208);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.ShadowDecoration.Parent = this.txtRoomNo;
            this.txtRoomNo.Size = new System.Drawing.Size(200, 36);
            this.txtRoomNo.TabIndex = 2;
            this.txtRoomNo.SelectedIndexChanged += new System.EventHandler(this.txtRoomNo_SelectedIndexChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(563, 256);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(31, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "Price";
            this.label26.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.Parent = this.txtPrice;
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.FocusedState.Parent = this.txtPrice;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.HoverState.Parent = this.txtPrice;
            this.txtPrice.Location = new System.Drawing.Point(566, 272);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.ShadowDecoration.Parent = this.txtPrice;
            this.txtPrice.Size = new System.Drawing.Size(200, 36);
            this.txtPrice.TabIndex = 1;
            // 
            // btnAlloteRoom
            // 
            this.btnAlloteRoom.CheckedState.Parent = this.btnAlloteRoom;
            this.btnAlloteRoom.CustomImages.Parent = this.btnAlloteRoom;
            this.btnAlloteRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAlloteRoom.ForeColor = System.Drawing.Color.White;
            this.btnAlloteRoom.HoverState.Parent = this.btnAlloteRoom;
            this.btnAlloteRoom.Location = new System.Drawing.Point(586, 336);
            this.btnAlloteRoom.Name = "btnAlloteRoom";
            this.btnAlloteRoom.ShadowDecoration.Parent = this.btnAlloteRoom;
            this.btnAlloteRoom.Size = new System.Drawing.Size(180, 45);
            this.btnAlloteRoom.TabIndex = 4;
            this.btnAlloteRoom.Text = "Register";
            this.btnAlloteRoom.Click += new System.EventHandler(this.btnAlloteRoom_Click);
            // 
            // UC_CustomerRegistration
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAlloteRoom);
            this.Controls.Add(this.txtCheckIn);
            this.Controls.Add(this.txtDob);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.txtBed);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtIdProof);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Name = "UC_CustomerRegistration";
            this.Size = new System.Drawing.Size(1003, 452);
            this.Leave += new System.EventHandler(this.UC_CustomerRegistration_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtDob;
        private Guna.UI2.WinForms.Guna2ComboBox txtGender;
        private Guna.UI2.WinForms.Guna2TextBox txtNationality;
        private Guna.UI2.WinForms.Guna2TextBox txtContact;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtCheckIn;
        private Guna.UI2.WinForms.Guna2ComboBox txtBed;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtIdProof;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2ComboBox txtRoomNo;
        private Guna.UI2.WinForms.Guna2ComboBox txtRoom;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private Guna.UI2.WinForms.Guna2Button btnAlloteRoom;
    }
}
