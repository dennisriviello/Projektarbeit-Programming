namespace ContectManager
{
    partial class Form_MitarbeiterReg
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
            this.LblAktiv = new System.Windows.Forms.Label();
            this.ChkActive = new System.Windows.Forms.CheckBox();
            this.LblOrt = new System.Windows.Forms.Label();
            this.TxtResidence = new System.Windows.Forms.TextBox();
            this.LblPLZ = new System.Windows.Forms.Label();
            this.TxtZipcode = new System.Windows.Forms.TextBox();
            this.LblAddr = new System.Windows.Forms.Label();
            this.TxtAdress = new System.Windows.Forms.TextBox();
            this.TxtEMail = new System.Windows.Forms.TextBox();
            this.TxtFaxWork = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblFaxArbeit = new System.Windows.Forms.Label();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.LblGeschlecht = new System.Windows.Forms.Label();
            this.DtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.TxtSalutation = new System.Windows.Forms.TextBox();
            this.LblTitel = new System.Windows.Forms.Label();
            this.LblTelMobile = new System.Windows.Forms.Label();
            this.LblBday = new System.Windows.Forms.Label();
            this.lblKundenID = new System.Windows.Forms.Label();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.TxtTelMobile = new System.Windows.Forms.TextBox();
            this.TxtTelPrivate = new System.Windows.Forms.TextBox();
            this.TxtTelWork = new System.Windows.Forms.TextBox();
            this.LblTelPriv = new System.Windows.Forms.Label();
            this.LblTelAr = new System.Windows.Forms.Label();
            this.TxtLastname = new System.Windows.Forms.TextBox();
            this.TxtFirstname = new System.Windows.Forms.TextBox();
            this.lbl_Nachname = new System.Windows.Forms.Label();
            this.lbl_Vorname = new System.Windows.Forms.Label();
            this.LblAbteilung = new System.Windows.Forms.Label();
            this.LblAHV = new System.Windows.Forms.Label();
            this.TxtAhvNr = new System.Windows.Forms.TextBox();
            this.LblNation = new System.Windows.Forms.Label();
            this.TxtNationalaty = new System.Windows.Forms.TextBox();
            this.LblEintritt = new System.Windows.Forms.Label();
            this.LblProzAnstellung = new System.Windows.Forms.Label();
            this.LblAustritt = new System.Windows.Forms.Label();
            this.LblRolle = new System.Windows.Forms.Label();
            this.DtpQuitdate = new System.Windows.Forms.DateTimePicker();
            this.DtpEntrydate = new System.Windows.Forms.DateTimePicker();
            this.CmbEmploymentlevel = new System.Windows.Forms.ComboBox();
            this.CmbRole = new System.Windows.Forms.ComboBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.CmdAddEmployee = new System.Windows.Forms.Button();
            this.LblKaderstufe = new System.Windows.Forms.Label();
            this.CmbDepartment = new System.Windows.Forms.ComboBox();
            this.CmdDelEmployee = new System.Windows.Forms.Button();
            this.CmdMenue = new System.Windows.Forms.Button();
            this.NumManagementLevel = new System.Windows.Forms.NumericUpDown();
            this.LsbOutputMA = new System.Windows.Forms.ListBox();
            this.CmdEditEmployee = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblMaID = new System.Windows.Forms.Label();
            this.TxtMitarbeiterID = new System.Windows.Forms.TextBox();
            this.grpBoxMa = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumManagementLevel)).BeginInit();
            this.grpBoxMa.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblAktiv
            // 
            this.LblAktiv.AutoSize = true;
            this.LblAktiv.Location = new System.Drawing.Point(312, 28);
            this.LblAktiv.Name = "LblAktiv";
            this.LblAktiv.Size = new System.Drawing.Size(42, 17);
            this.LblAktiv.TabIndex = 88;
            this.LblAktiv.Text = "Aktiv:";
            // 
            // ChkActive
            // 
            this.ChkActive.AutoSize = true;
            this.ChkActive.Checked = true;
            this.ChkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkActive.Location = new System.Drawing.Point(389, 30);
            this.ChkActive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChkActive.Name = "ChkActive";
            this.ChkActive.Size = new System.Drawing.Size(15, 14);
            this.ChkActive.TabIndex = 12;
            this.ChkActive.UseVisualStyleBackColor = true;
            // 
            // LblOrt
            // 
            this.LblOrt.AutoSize = true;
            this.LblOrt.Location = new System.Drawing.Point(325, 104);
            this.LblOrt.Name = "LblOrt";
            this.LblOrt.Size = new System.Drawing.Size(32, 17);
            this.LblOrt.TabIndex = 86;
            this.LblOrt.Text = "Ort:";
            // 
            // TxtResidence
            // 
            this.TxtResidence.Location = new System.Drawing.Point(390, 104);
            this.TxtResidence.Name = "TxtResidence";
            this.TxtResidence.Size = new System.Drawing.Size(168, 23);
            this.TxtResidence.TabIndex = 15;
            this.TxtResidence.Text = "Musterhausen";
            this.TxtResidence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblPLZ
            // 
            this.LblPLZ.AutoSize = true;
            this.LblPLZ.Location = new System.Drawing.Point(272, 51);
            this.LblPLZ.Name = "LblPLZ";
            this.LblPLZ.Size = new System.Drawing.Size(84, 17);
            this.LblPLZ.TabIndex = 84;
            this.LblPLZ.Text = "Postleitzahl:";
            // 
            // TxtZipcode
            // 
            this.TxtZipcode.Location = new System.Drawing.Point(389, 51);
            this.TxtZipcode.Name = "TxtZipcode";
            this.TxtZipcode.Size = new System.Drawing.Size(169, 23);
            this.TxtZipcode.TabIndex = 13;
            this.TxtZipcode.Text = "8570";
            this.TxtZipcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblAddr
            // 
            this.LblAddr.AutoSize = true;
            this.LblAddr.Location = new System.Drawing.Point(292, 79);
            this.LblAddr.Name = "LblAddr";
            this.LblAddr.Size = new System.Drawing.Size(64, 17);
            this.LblAddr.TabIndex = 82;
            this.LblAddr.Text = "Adresse:";
            // 
            // TxtAdress
            // 
            this.TxtAdress.Location = new System.Drawing.Point(389, 76);
            this.TxtAdress.Name = "TxtAdress";
            this.TxtAdress.Size = new System.Drawing.Size(169, 23);
            this.TxtAdress.TabIndex = 14;
            this.TxtAdress.Text = "Musterstrasse 20a";
            this.TxtAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtEMail
            // 
            this.TxtEMail.Location = new System.Drawing.Point(389, 130);
            this.TxtEMail.Name = "TxtEMail";
            this.TxtEMail.Size = new System.Drawing.Size(169, 23);
            this.TxtEMail.TabIndex = 16;
            this.TxtEMail.Text = "max.muster@gail.com";
            this.TxtEMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtFaxWork
            // 
            this.TxtFaxWork.Location = new System.Drawing.Point(127, 296);
            this.TxtFaxWork.Name = "TxtFaxWork";
            this.TxtFaxWork.Size = new System.Drawing.Size(100, 23);
            this.TxtFaxWork.TabIndex = 10;
            this.TxtFaxWork.Text = "0716123456";
            this.TxtFaxWork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(306, 130);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(51, 17);
            this.LblEmail.TabIndex = 78;
            this.LblEmail.Text = "E-Mail:";
            // 
            // LblFaxArbeit
            // 
            this.LblFaxArbeit.AutoSize = true;
            this.LblFaxArbeit.Location = new System.Drawing.Point(31, 299);
            this.LblFaxArbeit.Name = "LblFaxArbeit";
            this.LblFaxArbeit.Size = new System.Drawing.Size(75, 17);
            this.LblFaxArbeit.TabIndex = 77;
            this.LblFaxArbeit.Text = "Fax Arbeit:";
            // 
            // CmbGender
            // 
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Items.AddRange(new object[] {
            "männlich",
            "weiblich",
            "andere"});
            this.CmbGender.Location = new System.Drawing.Point(127, 160);
            this.CmbGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(100, 24);
            this.CmbGender.TabIndex = 5;
            this.CmbGender.Text = "männlich";
            // 
            // LblGeschlecht
            // 
            this.LblGeschlecht.AutoSize = true;
            this.LblGeschlecht.Location = new System.Drawing.Point(23, 163);
            this.LblGeschlecht.Name = "LblGeschlecht";
            this.LblGeschlecht.Size = new System.Drawing.Size(83, 17);
            this.LblGeschlecht.TabIndex = 75;
            this.LblGeschlecht.Text = "Geschlecht:";
            // 
            // DtpBirthday
            // 
            this.DtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpBirthday.Location = new System.Drawing.Point(127, 187);
            this.DtpBirthday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtpBirthday.Name = "DtpBirthday";
            this.DtpBirthday.Size = new System.Drawing.Size(100, 23);
            this.DtpBirthday.TabIndex = 6;
            this.DtpBirthday.Value = new System.DateTime(1990, 8, 26, 13, 54, 0, 0);
            // 
            // TxtSalutation
            // 
            this.TxtSalutation.Location = new System.Drawing.Point(127, 78);
            this.TxtSalutation.Name = "TxtSalutation";
            this.TxtSalutation.Size = new System.Drawing.Size(100, 23);
            this.TxtSalutation.TabIndex = 2;
            this.TxtSalutation.Text = "Herr";
            this.TxtSalutation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblTitel
            // 
            this.LblTitel.AutoSize = true;
            this.LblTitel.Location = new System.Drawing.Point(67, 56);
            this.LblTitel.Name = "LblTitel";
            this.LblTitel.Size = new System.Drawing.Size(39, 17);
            this.LblTitel.TabIndex = 72;
            this.LblTitel.Text = "Titel:";
            // 
            // LblTelMobile
            // 
            this.LblTelMobile.AutoSize = true;
            this.LblTelMobile.Location = new System.Drawing.Point(9, 270);
            this.LblTelMobile.Name = "LblTelMobile";
            this.LblTelMobile.Size = new System.Drawing.Size(97, 17);
            this.LblTelMobile.TabIndex = 71;
            this.LblTelMobile.Text = "Telefon Mobil:";
            // 
            // LblBday
            // 
            this.LblBday.AutoSize = true;
            this.LblBday.Location = new System.Drawing.Point(23, 192);
            this.LblBday.Name = "LblBday";
            this.LblBday.Size = new System.Drawing.Size(83, 17);
            this.LblBday.TabIndex = 70;
            this.LblBday.Text = "Geburtstag:";
            // 
            // lblKundenID
            // 
            this.lblKundenID.AutoSize = true;
            this.lblKundenID.Location = new System.Drawing.Point(51, 81);
            this.lblKundenID.Name = "lblKundenID";
            this.lblKundenID.Size = new System.Drawing.Size(58, 17);
            this.lblKundenID.TabIndex = 69;
            this.lblKundenID.Text = "Anrede:";
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(127, 53);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(100, 23);
            this.TxtTitle.TabIndex = 1;
            this.TxtTitle.Text = "Dr.";
            this.TxtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtTelMobile
            // 
            this.TxtTelMobile.Location = new System.Drawing.Point(127, 267);
            this.TxtTelMobile.Name = "TxtTelMobile";
            this.TxtTelMobile.Size = new System.Drawing.Size(100, 23);
            this.TxtTelMobile.TabIndex = 9;
            this.TxtTelMobile.Text = "076456789";
            this.TxtTelMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtTelPrivate
            // 
            this.TxtTelPrivate.Location = new System.Drawing.Point(127, 213);
            this.TxtTelPrivate.Name = "TxtTelPrivate";
            this.TxtTelPrivate.Size = new System.Drawing.Size(100, 23);
            this.TxtTelPrivate.TabIndex = 7;
            this.TxtTelPrivate.Text = "076456789";
            this.TxtTelPrivate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtTelWork
            // 
            this.TxtTelWork.Location = new System.Drawing.Point(127, 239);
            this.TxtTelWork.Name = "TxtTelWork";
            this.TxtTelWork.Size = new System.Drawing.Size(100, 23);
            this.TxtTelWork.TabIndex = 8;
            this.TxtTelWork.Text = "071456789";
            this.TxtTelWork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblTelPriv
            // 
            this.LblTelPriv.AutoSize = true;
            this.LblTelPriv.Location = new System.Drawing.Point(6, 216);
            this.LblTelPriv.Name = "LblTelPriv";
            this.LblTelPriv.Size = new System.Drawing.Size(100, 17);
            this.LblTelPriv.TabIndex = 64;
            this.LblTelPriv.Text = "Telefon Privat:";
            // 
            // LblTelAr
            // 
            this.LblTelAr.AutoSize = true;
            this.LblTelAr.Location = new System.Drawing.Point(8, 242);
            this.LblTelAr.Name = "LblTelAr";
            this.LblTelAr.Size = new System.Drawing.Size(101, 17);
            this.LblTelAr.TabIndex = 63;
            this.LblTelAr.Text = "Telefon Arbeit:";
            // 
            // TxtLastname
            // 
            this.TxtLastname.Location = new System.Drawing.Point(127, 133);
            this.TxtLastname.Name = "TxtLastname";
            this.TxtLastname.Size = new System.Drawing.Size(100, 23);
            this.TxtLastname.TabIndex = 4;
            this.TxtLastname.Text = "Muster";
            this.TxtLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtFirstname
            // 
            this.TxtFirstname.Location = new System.Drawing.Point(127, 104);
            this.TxtFirstname.Name = "TxtFirstname";
            this.TxtFirstname.Size = new System.Drawing.Size(100, 23);
            this.TxtFirstname.TabIndex = 3;
            this.TxtFirstname.Text = "Max";
            this.TxtFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Nachname
            // 
            this.lbl_Nachname.AutoSize = true;
            this.lbl_Nachname.Location = new System.Drawing.Point(26, 136);
            this.lbl_Nachname.Name = "lbl_Nachname";
            this.lbl_Nachname.Size = new System.Drawing.Size(80, 17);
            this.lbl_Nachname.TabIndex = 60;
            this.lbl_Nachname.Text = "Nachname:";
            // 
            // lbl_Vorname
            // 
            this.lbl_Vorname.AutoSize = true;
            this.lbl_Vorname.Location = new System.Drawing.Point(37, 107);
            this.lbl_Vorname.Name = "lbl_Vorname";
            this.lbl_Vorname.Size = new System.Drawing.Size(69, 17);
            this.lbl_Vorname.TabIndex = 59;
            this.lbl_Vorname.Text = "Vorname:";
            // 
            // LblAbteilung
            // 
            this.LblAbteilung.AutoSize = true;
            this.LblAbteilung.Location = new System.Drawing.Point(285, 190);
            this.LblAbteilung.Name = "LblAbteilung";
            this.LblAbteilung.Size = new System.Drawing.Size(71, 17);
            this.LblAbteilung.TabIndex = 95;
            this.LblAbteilung.Text = "Abteilung:";
            // 
            // LblAHV
            // 
            this.LblAHV.AutoSize = true;
            this.LblAHV.Location = new System.Drawing.Point(37, 328);
            this.LblAHV.Name = "LblAHV";
            this.LblAHV.Size = new System.Drawing.Size(64, 17);
            this.LblAHV.TabIndex = 97;
            this.LblAHV.Text = "AHV-Nr :";
            // 
            // TxtAhvNr
            // 
            this.TxtAhvNr.Location = new System.Drawing.Point(127, 325);
            this.TxtAhvNr.Name = "TxtAhvNr";
            this.TxtAhvNr.Size = new System.Drawing.Size(100, 23);
            this.TxtAhvNr.TabIndex = 11;
            this.TxtAhvNr.Text = "123.123.123";
            this.TxtAhvNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblNation
            // 
            this.LblNation.AutoSize = true;
            this.LblNation.Location = new System.Drawing.Point(274, 161);
            this.LblNation.Name = "LblNation";
            this.LblNation.Size = new System.Drawing.Size(83, 17);
            this.LblNation.TabIndex = 99;
            this.LblNation.Text = "Nationalität:";
            // 
            // TxtNationalaty
            // 
            this.TxtNationalaty.Location = new System.Drawing.Point(389, 161);
            this.TxtNationalaty.Name = "TxtNationalaty";
            this.TxtNationalaty.Size = new System.Drawing.Size(169, 23);
            this.TxtNationalaty.TabIndex = 17;
            this.TxtNationalaty.Text = "Schweizer";
            this.TxtNationalaty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblEintritt
            // 
            this.LblEintritt.AutoSize = true;
            this.LblEintritt.Location = new System.Drawing.Point(264, 271);
            this.LblEintritt.Name = "LblEintritt";
            this.LblEintritt.Size = new System.Drawing.Size(98, 17);
            this.LblEintritt.TabIndex = 101;
            this.LblEintritt.Text = "Eintrittsdatum:";
            // 
            // LblProzAnstellung
            // 
            this.LblProzAnstellung.AutoSize = true;
            this.LblProzAnstellung.Location = new System.Drawing.Point(252, 220);
            this.LblProzAnstellung.Name = "LblProzAnstellung";
            this.LblProzAnstellung.Size = new System.Drawing.Size(104, 17);
            this.LblProzAnstellung.TabIndex = 102;
            this.LblProzAnstellung.Text = "Beschäftig.(%):";
            // 
            // LblAustritt
            // 
            this.LblAustritt.AutoSize = true;
            this.LblAustritt.Location = new System.Drawing.Point(260, 300);
            this.LblAustritt.Name = "LblAustritt";
            this.LblAustritt.Size = new System.Drawing.Size(102, 17);
            this.LblAustritt.TabIndex = 103;
            this.LblAustritt.Text = "Austrittsdatum:";
            // 
            // LblRolle
            // 
            this.LblRolle.AutoSize = true;
            this.LblRolle.Location = new System.Drawing.Point(306, 246);
            this.LblRolle.Name = "LblRolle";
            this.LblRolle.Size = new System.Drawing.Size(44, 17);
            this.LblRolle.TabIndex = 104;
            this.LblRolle.Text = "Rolle:";
            // 
            // DtpQuitdate
            // 
            this.DtpQuitdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpQuitdate.Location = new System.Drawing.Point(390, 300);
            this.DtpQuitdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtpQuitdate.Name = "DtpQuitdate";
            this.DtpQuitdate.Size = new System.Drawing.Size(168, 23);
            this.DtpQuitdate.TabIndex = 22;
            // 
            // DtpEntrydate
            // 
            this.DtpEntrydate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpEntrydate.Location = new System.Drawing.Point(390, 271);
            this.DtpEntrydate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtpEntrydate.Name = "DtpEntrydate";
            this.DtpEntrydate.Size = new System.Drawing.Size(168, 23);
            this.DtpEntrydate.TabIndex = 21;
            this.DtpEntrydate.Value = new System.DateTime(2021, 1, 26, 13, 54, 0, 0);
            // 
            // CmbEmploymentlevel
            // 
            this.CmbEmploymentlevel.AllowDrop = true;
            this.CmbEmploymentlevel.FormattingEnabled = true;
            this.CmbEmploymentlevel.Items.AddRange(new object[] {
            "10",
            "20",
            "25",
            "30",
            "40",
            "50",
            "60",
            "70",
            "75",
            "80",
            "90",
            "100"});
            this.CmbEmploymentlevel.Location = new System.Drawing.Point(389, 217);
            this.CmbEmploymentlevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbEmploymentlevel.Name = "CmbEmploymentlevel";
            this.CmbEmploymentlevel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbEmploymentlevel.Size = new System.Drawing.Size(169, 24);
            this.CmbEmploymentlevel.TabIndex = 19;
            this.CmbEmploymentlevel.Text = "80";
            // 
            // CmbRole
            // 
            this.CmbRole.AllowDrop = true;
            this.CmbRole.FormattingEnabled = true;
            this.CmbRole.Items.AddRange(new object[] {
            "Mech Maschinenführer",
            "Mech Schlosser",
            "Mech Blechbearbeitung",
            "Product Manager",
            "Delivery Manager",
            "IT Programmierer",
            "IT Netzwerktechniker",
            "IT Service Desk",
            "HR Finanzen",
            "HR Mitarbeiter"});
            this.CmbRole.Location = new System.Drawing.Point(389, 243);
            this.CmbRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbRole.Name = "CmbRole";
            this.CmbRole.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbRole.Size = new System.Drawing.Size(169, 24);
            this.CmbRole.TabIndex = 20;
            this.CmbRole.Text = "IT Service Desk";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(5, 393);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(143, 17);
            this.lblOutput.TabIndex = 111;
            this.lblOutput.Text = "Mitarbeiter Vorschau:";
            // 
            // CmdAddEmployee
            // 
            this.CmdAddEmployee.Location = new System.Drawing.Point(8, 600);
            this.CmdAddEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdAddEmployee.Name = "CmdAddEmployee";
            this.CmdAddEmployee.Size = new System.Drawing.Size(116, 40);
            this.CmdAddEmployee.TabIndex = 24;
            this.CmdAddEmployee.Text = "Mitarbeiter Hinzufügen";
            this.CmdAddEmployee.UseVisualStyleBackColor = true;
            this.CmdAddEmployee.Click += new System.EventHandler(this.CmdAddEmployee_Click);
            // 
            // LblKaderstufe
            // 
            this.LblKaderstufe.AutoSize = true;
            this.LblKaderstufe.Location = new System.Drawing.Point(276, 329);
            this.LblKaderstufe.Name = "LblKaderstufe";
            this.LblKaderstufe.Size = new System.Drawing.Size(81, 17);
            this.LblKaderstufe.TabIndex = 114;
            this.LblKaderstufe.Text = "Kaderstufe:";
            // 
            // CmbDepartment
            // 
            this.CmbDepartment.FormattingEnabled = true;
            this.CmbDepartment.ItemHeight = 16;
            this.CmbDepartment.Items.AddRange(new object[] {
            "Mechanik",
            "Einkauf",
            "Verkauf",
            "Informatik",
            "Produktion"});
            this.CmbDepartment.Location = new System.Drawing.Point(389, 189);
            this.CmbDepartment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbDepartment.Name = "CmbDepartment";
            this.CmbDepartment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbDepartment.Size = new System.Drawing.Size(169, 24);
            this.CmbDepartment.TabIndex = 8;
            this.CmbDepartment.Text = "Informatik";
            // 
            // CmdDelEmployee
            // 
            this.CmdDelEmployee.Location = new System.Drawing.Point(278, 601);
            this.CmdDelEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdDelEmployee.Name = "CmdDelEmployee";
            this.CmdDelEmployee.Size = new System.Drawing.Size(91, 40);
            this.CmdDelEmployee.TabIndex = 26;
            this.CmdDelEmployee.Text = "Mitarbeiter Löschen";
            this.CmdDelEmployee.UseVisualStyleBackColor = true;
            this.CmdDelEmployee.Click += new System.EventHandler(this.CmdDelEmployee_Click);
            // 
            // CmdMenue
            // 
            this.CmdMenue.Location = new System.Drawing.Point(484, 601);
            this.CmdMenue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdMenue.Name = "CmdMenue";
            this.CmdMenue.Size = new System.Drawing.Size(114, 40);
            this.CmdMenue.TabIndex = 27;
            this.CmdMenue.Text = "Zurück zum Menu";
            this.CmdMenue.UseVisualStyleBackColor = true;
            this.CmdMenue.Click += new System.EventHandler(this.CmdMenue_Click);
            // 
            // NumManagementLevel
            // 
            this.NumManagementLevel.Location = new System.Drawing.Point(389, 327);
            this.NumManagementLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumManagementLevel.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumManagementLevel.Name = "NumManagementLevel";
            this.NumManagementLevel.Size = new System.Drawing.Size(169, 23);
            this.NumManagementLevel.TabIndex = 23;
            this.NumManagementLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LsbOutputMA
            // 
            this.LsbOutputMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsbOutputMA.FormattingEnabled = true;
            this.LsbOutputMA.ItemHeight = 16;
            this.LsbOutputMA.Location = new System.Drawing.Point(8, 409);
            this.LsbOutputMA.Name = "LsbOutputMA";
            this.LsbOutputMA.Size = new System.Drawing.Size(590, 148);
            this.LsbOutputMA.TabIndex = 28;
            // 
            // CmdEditEmployee
            // 
            this.CmdEditEmployee.Location = new System.Drawing.Point(142, 600);
            this.CmdEditEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdEditEmployee.Name = "CmdEditEmployee";
            this.CmdEditEmployee.Size = new System.Drawing.Size(108, 41);
            this.CmdEditEmployee.TabIndex = 25;
            this.CmdEditEmployee.Text = "Mitarbeiter bearbeiten";
            this.CmdEditEmployee.UseVisualStyleBackColor = true;
            this.CmdEditEmployee.Click += new System.EventHandler(this.CmdEditEmployee_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // LblMaID
            // 
            this.LblMaID.AutoSize = true;
            this.LblMaID.Location = new System.Drawing.Point(14, 31);
            this.LblMaID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMaID.Name = "LblMaID";
            this.LblMaID.Size = new System.Drawing.Size(92, 17);
            this.LblMaID.TabIndex = 123;
            this.LblMaID.Text = "MitarbeiterID:";
            // 
            // TxtMitarbeiterID
            // 
            this.TxtMitarbeiterID.Location = new System.Drawing.Point(127, 28);
            this.TxtMitarbeiterID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtMitarbeiterID.Name = "TxtMitarbeiterID";
            this.TxtMitarbeiterID.ReadOnly = true;
            this.TxtMitarbeiterID.Size = new System.Drawing.Size(100, 23);
            this.TxtMitarbeiterID.TabIndex = 124;
            // 
            // grpBoxMa
            // 
            this.grpBoxMa.Controls.Add(this.LblMaID);
            this.grpBoxMa.Controls.Add(this.TxtMitarbeiterID);
            this.grpBoxMa.Controls.Add(this.lbl_Vorname);
            this.grpBoxMa.Controls.Add(this.lbl_Nachname);
            this.grpBoxMa.Controls.Add(this.TxtFirstname);
            this.grpBoxMa.Controls.Add(this.NumManagementLevel);
            this.grpBoxMa.Controls.Add(this.TxtLastname);
            this.grpBoxMa.Controls.Add(this.LblTelPriv);
            this.grpBoxMa.Controls.Add(this.TxtTelPrivate);
            this.grpBoxMa.Controls.Add(this.CmbDepartment);
            this.grpBoxMa.Controls.Add(this.TxtTitle);
            this.grpBoxMa.Controls.Add(this.LblKaderstufe);
            this.grpBoxMa.Controls.Add(this.lblKundenID);
            this.grpBoxMa.Controls.Add(this.LblBday);
            this.grpBoxMa.Controls.Add(this.LblTitel);
            this.grpBoxMa.Controls.Add(this.TxtNationalaty);
            this.grpBoxMa.Controls.Add(this.LblNation);
            this.grpBoxMa.Controls.Add(this.CmbRole);
            this.grpBoxMa.Controls.Add(this.TxtAhvNr);
            this.grpBoxMa.Controls.Add(this.TxtSalutation);
            this.grpBoxMa.Controls.Add(this.LblAHV);
            this.grpBoxMa.Controls.Add(this.CmbEmploymentlevel);
            this.grpBoxMa.Controls.Add(this.LblAbteilung);
            this.grpBoxMa.Controls.Add(this.DtpBirthday);
            this.grpBoxMa.Controls.Add(this.DtpEntrydate);
            this.grpBoxMa.Controls.Add(this.LblGeschlecht);
            this.grpBoxMa.Controls.Add(this.DtpQuitdate);
            this.grpBoxMa.Controls.Add(this.CmbGender);
            this.grpBoxMa.Controls.Add(this.LblRolle);
            this.grpBoxMa.Controls.Add(this.LblAktiv);
            this.grpBoxMa.Controls.Add(this.LblAustritt);
            this.grpBoxMa.Controls.Add(this.ChkActive);
            this.grpBoxMa.Controls.Add(this.LblProzAnstellung);
            this.grpBoxMa.Controls.Add(this.TxtTelWork);
            this.grpBoxMa.Controls.Add(this.LblEintritt);
            this.grpBoxMa.Controls.Add(this.LblTelAr);
            this.grpBoxMa.Controls.Add(this.LblTelMobile);
            this.grpBoxMa.Controls.Add(this.TxtTelMobile);
            this.grpBoxMa.Controls.Add(this.TxtFaxWork);
            this.grpBoxMa.Controls.Add(this.LblFaxArbeit);
            this.grpBoxMa.Controls.Add(this.TxtEMail);
            this.grpBoxMa.Controls.Add(this.LblOrt);
            this.grpBoxMa.Controls.Add(this.LblEmail);
            this.grpBoxMa.Controls.Add(this.TxtResidence);
            this.grpBoxMa.Controls.Add(this.TxtAdress);
            this.grpBoxMa.Controls.Add(this.LblPLZ);
            this.grpBoxMa.Controls.Add(this.LblAddr);
            this.grpBoxMa.Controls.Add(this.TxtZipcode);
            this.grpBoxMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxMa.Location = new System.Drawing.Point(23, 12);
            this.grpBoxMa.Name = "grpBoxMa";
            this.grpBoxMa.Size = new System.Drawing.Size(575, 354);
            this.grpBoxMa.TabIndex = 125;
            this.grpBoxMa.TabStop = false;
            this.grpBoxMa.Text = "Datenverwaltung";
            // 
            // Form_MitarbeiterReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 671);
            this.Controls.Add(this.grpBoxMa);
            this.Controls.Add(this.CmdEditEmployee);
            this.Controls.Add(this.LsbOutputMA);
            this.Controls.Add(this.CmdMenue);
            this.Controls.Add(this.CmdDelEmployee);
            this.Controls.Add(this.CmdAddEmployee);
            this.Controls.Add(this.lblOutput);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_MitarbeiterReg";
            this.Text = "Form_MitarbeiterReg";
            ((System.ComponentModel.ISupportInitialize)(this.NumManagementLevel)).EndInit();
            this.grpBoxMa.ResumeLayout(false);
            this.grpBoxMa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblAktiv;
        private System.Windows.Forms.CheckBox ChkActive;
        private System.Windows.Forms.Label LblOrt;
        private System.Windows.Forms.TextBox TxtResidence;
        private System.Windows.Forms.Label LblPLZ;
        private System.Windows.Forms.TextBox TxtZipcode;
        private System.Windows.Forms.Label LblAddr;
        private System.Windows.Forms.TextBox TxtAdress;
        private System.Windows.Forms.TextBox TxtEMail;
        private System.Windows.Forms.TextBox TxtFaxWork;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblFaxArbeit;
        private System.Windows.Forms.ComboBox CmbGender;
        private System.Windows.Forms.Label LblGeschlecht;
        private System.Windows.Forms.DateTimePicker DtpBirthday;
        private System.Windows.Forms.TextBox TxtSalutation;
        private System.Windows.Forms.Label LblTitel;
        private System.Windows.Forms.Label LblTelMobile;
        private System.Windows.Forms.Label LblBday;
        private System.Windows.Forms.Label lblKundenID;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.TextBox TxtTelMobile;
        private System.Windows.Forms.TextBox TxtTelPrivate;
        private System.Windows.Forms.TextBox TxtTelWork;
        private System.Windows.Forms.Label LblTelPriv;
        private System.Windows.Forms.Label LblTelAr;
        private System.Windows.Forms.TextBox TxtLastname;
        private System.Windows.Forms.TextBox TxtFirstname;
        private System.Windows.Forms.Label lbl_Nachname;
        private System.Windows.Forms.Label lbl_Vorname;
        private System.Windows.Forms.Label LblAbteilung;
        private System.Windows.Forms.Label LblAHV;
        private System.Windows.Forms.TextBox TxtAhvNr;
        private System.Windows.Forms.Label LblNation;
        private System.Windows.Forms.TextBox TxtNationalaty;
        private System.Windows.Forms.Label LblEintritt;
        private System.Windows.Forms.Label LblProzAnstellung;
        private System.Windows.Forms.Label LblAustritt;
        private System.Windows.Forms.Label LblRolle;
        private System.Windows.Forms.DateTimePicker DtpQuitdate;
        private System.Windows.Forms.DateTimePicker DtpEntrydate;
        private System.Windows.Forms.ComboBox CmbEmploymentlevel;
        private System.Windows.Forms.ComboBox CmbRole;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button CmdAddEmployee;
        private System.Windows.Forms.Label LblKaderstufe;
        private System.Windows.Forms.ComboBox CmbDepartment;
        private System.Windows.Forms.Button CmdDelEmployee;
        private System.Windows.Forms.Button CmdMenue;
        private System.Windows.Forms.NumericUpDown NumManagementLevel;
        private System.Windows.Forms.ListBox LsbOutputMA;
        private System.Windows.Forms.Button CmdEditEmployee;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblMaID;
        private System.Windows.Forms.TextBox TxtMitarbeiterID;
        private System.Windows.Forms.GroupBox grpBoxMa;
    }
}