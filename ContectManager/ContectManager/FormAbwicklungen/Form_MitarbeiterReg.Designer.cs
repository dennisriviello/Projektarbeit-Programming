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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MitarbeiterReg));
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
            this.LblApprenticeYears = new System.Windows.Forms.Label();
            this.LblCurrentYear = new System.Windows.Forms.Label();
            this.TxtCurrentYear = new System.Windows.Forms.TextBox();
            this.TxtApprenticeYears = new System.Windows.Forms.TextBox();
            this.ChkTrainee = new System.Windows.Forms.CheckBox();
            this.RadMitarbeiter = new System.Windows.Forms.RadioButton();
            this.RadLehrling = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblTopic = new System.Windows.Forms.Label();
            this.CmdMitarbeiterImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumManagementLevel)).BeginInit();
            this.grpBoxMa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAktiv
            // 
            this.LblAktiv.AutoSize = true;
            this.LblAktiv.Location = new System.Drawing.Point(481, 42);
            this.LblAktiv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAktiv.Name = "LblAktiv";
            this.LblAktiv.Size = new System.Drawing.Size(61, 25);
            this.LblAktiv.TabIndex = 88;
            this.LblAktiv.Text = "Aktiv:";
            // 
            // ChkActive
            // 
            this.ChkActive.AutoSize = true;
            this.ChkActive.Checked = true;
            this.ChkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkActive.Location = new System.Drawing.Point(600, 46);
            this.ChkActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChkActive.Name = "ChkActive";
            this.ChkActive.Size = new System.Drawing.Size(22, 21);
            this.ChkActive.TabIndex = 12;
            this.ChkActive.UseVisualStyleBackColor = true;
            // 
            // LblOrt
            // 
            this.LblOrt.AutoSize = true;
            this.LblOrt.Location = new System.Drawing.Point(497, 160);
            this.LblOrt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblOrt.Name = "LblOrt";
            this.LblOrt.Size = new System.Drawing.Size(45, 25);
            this.LblOrt.TabIndex = 86;
            this.LblOrt.Text = "Ort:";
            // 
            // TxtResidence
            // 
            this.TxtResidence.Location = new System.Drawing.Point(602, 160);
            this.TxtResidence.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtResidence.Name = "TxtResidence";
            this.TxtResidence.Size = new System.Drawing.Size(250, 30);
            this.TxtResidence.TabIndex = 15;
            // 
            // LblPLZ
            // 
            this.LblPLZ.AutoSize = true;
            this.LblPLZ.Location = new System.Drawing.Point(425, 80);
            this.LblPLZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPLZ.Name = "LblPLZ";
            this.LblPLZ.Size = new System.Drawing.Size(117, 25);
            this.LblPLZ.TabIndex = 84;
            this.LblPLZ.Text = "Postleitzahl:";
            // 
            // TxtZipcode
            // 
            this.TxtZipcode.Location = new System.Drawing.Point(600, 78);
            this.TxtZipcode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtZipcode.Name = "TxtZipcode";
            this.TxtZipcode.Size = new System.Drawing.Size(252, 30);
            this.TxtZipcode.TabIndex = 13;
            // 
            // LblAddr
            // 
            this.LblAddr.AutoSize = true;
            this.LblAddr.Location = new System.Drawing.Point(451, 122);
            this.LblAddr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAddr.Name = "LblAddr";
            this.LblAddr.Size = new System.Drawing.Size(91, 25);
            this.LblAddr.TabIndex = 82;
            this.LblAddr.Text = "Adresse:";
            // 
            // TxtAdress
            // 
            this.TxtAdress.Location = new System.Drawing.Point(600, 118);
            this.TxtAdress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAdress.Name = "TxtAdress";
            this.TxtAdress.Size = new System.Drawing.Size(252, 30);
            this.TxtAdress.TabIndex = 14;
            // 
            // TxtEMail
            // 
            this.TxtEMail.Location = new System.Drawing.Point(600, 200);
            this.TxtEMail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtEMail.Name = "TxtEMail";
            this.TxtEMail.Size = new System.Drawing.Size(252, 30);
            this.TxtEMail.TabIndex = 16;
            // 
            // TxtFaxWork
            // 
            this.TxtFaxWork.Location = new System.Drawing.Point(190, 455);
            this.TxtFaxWork.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFaxWork.Name = "TxtFaxWork";
            this.TxtFaxWork.Size = new System.Drawing.Size(148, 30);
            this.TxtFaxWork.TabIndex = 10;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(468, 200);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(74, 25);
            this.LblEmail.TabIndex = 78;
            this.LblEmail.Text = "E-Mail:";
            // 
            // LblFaxArbeit
            // 
            this.LblFaxArbeit.AutoSize = true;
            this.LblFaxArbeit.Location = new System.Drawing.Point(42, 460);
            this.LblFaxArbeit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFaxArbeit.Name = "LblFaxArbeit";
            this.LblFaxArbeit.Size = new System.Drawing.Size(107, 25);
            this.LblFaxArbeit.TabIndex = 77;
            this.LblFaxArbeit.Text = "Fax Arbeit:";
            // 
            // CmbGender
            // 
            this.CmbGender.DisplayMember = "0";
            this.CmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Items.AddRange(new object[] {
            "männlich",
            "weiblich",
            "andere"});
            this.CmbGender.Location = new System.Drawing.Point(190, 246);
            this.CmbGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(148, 33);
            this.CmbGender.TabIndex = 5;
            // 
            // LblGeschlecht
            // 
            this.LblGeschlecht.AutoSize = true;
            this.LblGeschlecht.Location = new System.Drawing.Point(33, 251);
            this.LblGeschlecht.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGeschlecht.Name = "LblGeschlecht";
            this.LblGeschlecht.Size = new System.Drawing.Size(116, 25);
            this.LblGeschlecht.TabIndex = 75;
            this.LblGeschlecht.Text = "Geschlecht:";
            // 
            // DtpBirthday
            // 
            this.DtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpBirthday.Location = new System.Drawing.Point(190, 288);
            this.DtpBirthday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpBirthday.Name = "DtpBirthday";
            this.DtpBirthday.Size = new System.Drawing.Size(148, 30);
            this.DtpBirthday.TabIndex = 6;
            this.DtpBirthday.Value = new System.DateTime(1996, 1, 1, 0, 0, 0, 0);
            // 
            // TxtSalutation
            // 
            this.TxtSalutation.Location = new System.Drawing.Point(190, 120);
            this.TxtSalutation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSalutation.Name = "TxtSalutation";
            this.TxtSalutation.Size = new System.Drawing.Size(148, 30);
            this.TxtSalutation.TabIndex = 2;
            // 
            // LblTitel
            // 
            this.LblTitel.AutoSize = true;
            this.LblTitel.Location = new System.Drawing.Point(94, 86);
            this.LblTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitel.Name = "LblTitel";
            this.LblTitel.Size = new System.Drawing.Size(55, 25);
            this.LblTitel.TabIndex = 72;
            this.LblTitel.Text = "Titel:";
            // 
            // LblTelMobile
            // 
            this.LblTelMobile.AutoSize = true;
            this.LblTelMobile.Location = new System.Drawing.Point(13, 415);
            this.LblTelMobile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTelMobile.Name = "LblTelMobile";
            this.LblTelMobile.Size = new System.Drawing.Size(136, 25);
            this.LblTelMobile.TabIndex = 71;
            this.LblTelMobile.Text = "Telefon Mobil:";
            // 
            // LblBday
            // 
            this.LblBday.AutoSize = true;
            this.LblBday.Location = new System.Drawing.Point(35, 295);
            this.LblBday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBday.Name = "LblBday";
            this.LblBday.Size = new System.Drawing.Size(114, 25);
            this.LblBday.TabIndex = 70;
            this.LblBday.Text = "Geburtstag:";
            // 
            // lblKundenID
            // 
            this.lblKundenID.AutoSize = true;
            this.lblKundenID.Location = new System.Drawing.Point(67, 125);
            this.lblKundenID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKundenID.Name = "lblKundenID";
            this.lblKundenID.Size = new System.Drawing.Size(82, 25);
            this.lblKundenID.TabIndex = 69;
            this.lblKundenID.Text = "Anrede:";
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(190, 82);
            this.TxtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(148, 30);
            this.TxtTitle.TabIndex = 1;
            // 
            // TxtTelMobile
            // 
            this.TxtTelMobile.Location = new System.Drawing.Point(190, 411);
            this.TxtTelMobile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTelMobile.Name = "TxtTelMobile";
            this.TxtTelMobile.Size = new System.Drawing.Size(148, 30);
            this.TxtTelMobile.TabIndex = 9;
            // 
            // TxtTelPrivate
            // 
            this.TxtTelPrivate.Location = new System.Drawing.Point(190, 328);
            this.TxtTelPrivate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTelPrivate.Name = "TxtTelPrivate";
            this.TxtTelPrivate.Size = new System.Drawing.Size(148, 30);
            this.TxtTelPrivate.TabIndex = 7;
            // 
            // TxtTelWork
            // 
            this.TxtTelWork.Location = new System.Drawing.Point(190, 368);
            this.TxtTelWork.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTelWork.Name = "TxtTelWork";
            this.TxtTelWork.Size = new System.Drawing.Size(148, 30);
            this.TxtTelWork.TabIndex = 8;
            // 
            // LblTelPriv
            // 
            this.LblTelPriv.AutoSize = true;
            this.LblTelPriv.Location = new System.Drawing.Point(11, 332);
            this.LblTelPriv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTelPriv.Name = "LblTelPriv";
            this.LblTelPriv.Size = new System.Drawing.Size(138, 25);
            this.LblTelPriv.TabIndex = 64;
            this.LblTelPriv.Text = "Telefon Privat:";
            // 
            // LblTelAr
            // 
            this.LblTelAr.AutoSize = true;
            this.LblTelAr.Location = new System.Drawing.Point(9, 372);
            this.LblTelAr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTelAr.Name = "LblTelAr";
            this.LblTelAr.Size = new System.Drawing.Size(140, 25);
            this.LblTelAr.TabIndex = 63;
            this.LblTelAr.Text = "Telefon Arbeit:";
            // 
            // TxtLastname
            // 
            this.TxtLastname.Location = new System.Drawing.Point(190, 205);
            this.TxtLastname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtLastname.Name = "TxtLastname";
            this.TxtLastname.Size = new System.Drawing.Size(148, 30);
            this.TxtLastname.TabIndex = 4;
            // 
            // TxtFirstname
            // 
            this.TxtFirstname.Location = new System.Drawing.Point(190, 160);
            this.TxtFirstname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFirstname.Name = "TxtFirstname";
            this.TxtFirstname.Size = new System.Drawing.Size(148, 30);
            this.TxtFirstname.TabIndex = 3;
            // 
            // lbl_Nachname
            // 
            this.lbl_Nachname.AutoSize = true;
            this.lbl_Nachname.Location = new System.Drawing.Point(36, 209);
            this.lbl_Nachname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nachname.Name = "lbl_Nachname";
            this.lbl_Nachname.Size = new System.Drawing.Size(113, 25);
            this.lbl_Nachname.TabIndex = 60;
            this.lbl_Nachname.Text = "Nachname:";
            // 
            // lbl_Vorname
            // 
            this.lbl_Vorname.AutoSize = true;
            this.lbl_Vorname.Location = new System.Drawing.Point(51, 165);
            this.lbl_Vorname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Vorname.Name = "lbl_Vorname";
            this.lbl_Vorname.Size = new System.Drawing.Size(98, 25);
            this.lbl_Vorname.TabIndex = 59;
            this.lbl_Vorname.Text = "Vorname:";
            // 
            // LblAbteilung
            // 
            this.LblAbteilung.AutoSize = true;
            this.LblAbteilung.Location = new System.Drawing.Point(442, 292);
            this.LblAbteilung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAbteilung.Name = "LblAbteilung";
            this.LblAbteilung.Size = new System.Drawing.Size(100, 25);
            this.LblAbteilung.TabIndex = 95;
            this.LblAbteilung.Text = "Abteilung:";
            // 
            // LblAHV
            // 
            this.LblAHV.AutoSize = true;
            this.LblAHV.Location = new System.Drawing.Point(57, 505);
            this.LblAHV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAHV.Name = "LblAHV";
            this.LblAHV.Size = new System.Drawing.Size(92, 25);
            this.LblAHV.TabIndex = 97;
            this.LblAHV.Text = "AHV-Nr :";
            // 
            // TxtAhvNr
            // 
            this.TxtAhvNr.Location = new System.Drawing.Point(190, 500);
            this.TxtAhvNr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAhvNr.Name = "TxtAhvNr";
            this.TxtAhvNr.Size = new System.Drawing.Size(148, 30);
            this.TxtAhvNr.TabIndex = 11;
            // 
            // LblNation
            // 
            this.LblNation.AutoSize = true;
            this.LblNation.Location = new System.Drawing.Point(428, 248);
            this.LblNation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNation.Name = "LblNation";
            this.LblNation.Size = new System.Drawing.Size(114, 25);
            this.LblNation.TabIndex = 99;
            this.LblNation.Text = "Nationalität:";
            // 
            // TxtNationalaty
            // 
            this.TxtNationalaty.Location = new System.Drawing.Point(600, 248);
            this.TxtNationalaty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNationalaty.Name = "TxtNationalaty";
            this.TxtNationalaty.Size = new System.Drawing.Size(252, 30);
            this.TxtNationalaty.TabIndex = 17;
            // 
            // LblEintritt
            // 
            this.LblEintritt.AutoSize = true;
            this.LblEintritt.Location = new System.Drawing.Point(407, 418);
            this.LblEintritt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEintritt.Name = "LblEintritt";
            this.LblEintritt.Size = new System.Drawing.Size(135, 25);
            this.LblEintritt.TabIndex = 101;
            this.LblEintritt.Text = "Eintrittsdatum:";
            // 
            // LblProzAnstellung
            // 
            this.LblProzAnstellung.AutoSize = true;
            this.LblProzAnstellung.Location = new System.Drawing.Point(396, 338);
            this.LblProzAnstellung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProzAnstellung.Name = "LblProzAnstellung";
            this.LblProzAnstellung.Size = new System.Drawing.Size(146, 25);
            this.LblProzAnstellung.TabIndex = 102;
            this.LblProzAnstellung.Text = "Beschäftig.(%):";
            // 
            // LblAustritt
            // 
            this.LblAustritt.AutoSize = true;
            this.LblAustritt.Location = new System.Drawing.Point(400, 462);
            this.LblAustritt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAustritt.Name = "LblAustritt";
            this.LblAustritt.Size = new System.Drawing.Size(142, 25);
            this.LblAustritt.TabIndex = 103;
            this.LblAustritt.Text = "Austrittsdatum:";
            // 
            // LblRolle
            // 
            this.LblRolle.AutoSize = true;
            this.LblRolle.Location = new System.Drawing.Point(481, 378);
            this.LblRolle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRolle.Name = "LblRolle";
            this.LblRolle.Size = new System.Drawing.Size(61, 25);
            this.LblRolle.TabIndex = 104;
            this.LblRolle.Text = "Rolle:";
            // 
            // DtpQuitdate
            // 
            this.DtpQuitdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpQuitdate.Location = new System.Drawing.Point(602, 462);
            this.DtpQuitdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpQuitdate.Name = "DtpQuitdate";
            this.DtpQuitdate.Size = new System.Drawing.Size(250, 30);
            this.DtpQuitdate.TabIndex = 22;
            // 
            // DtpEntrydate
            // 
            this.DtpEntrydate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpEntrydate.Location = new System.Drawing.Point(602, 418);
            this.DtpEntrydate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpEntrydate.Name = "DtpEntrydate";
            this.DtpEntrydate.Size = new System.Drawing.Size(250, 30);
            this.DtpEntrydate.TabIndex = 21;
            this.DtpEntrydate.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // CmbEmploymentlevel
            // 
            this.CmbEmploymentlevel.AllowDrop = true;
            this.CmbEmploymentlevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEmploymentlevel.FormattingEnabled = true;
            this.CmbEmploymentlevel.Items.AddRange(new object[] {
            "100",
            "90",
            "80",
            "70",
            "60",
            "50",
            "40",
            "30",
            "20",
            "10"});
            this.CmbEmploymentlevel.Location = new System.Drawing.Point(600, 334);
            this.CmbEmploymentlevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbEmploymentlevel.Name = "CmbEmploymentlevel";
            this.CmbEmploymentlevel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbEmploymentlevel.Size = new System.Drawing.Size(252, 33);
            this.CmbEmploymentlevel.TabIndex = 19;
            // 
            // CmbRole
            // 
            this.CmbRole.AllowDrop = true;
            this.CmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.CmbRole.Location = new System.Drawing.Point(600, 374);
            this.CmbRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbRole.Name = "CmbRole";
            this.CmbRole.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbRole.Size = new System.Drawing.Size(252, 33);
            this.CmbRole.TabIndex = 20;
            // 
            // CmdAddEmployee
            // 
            this.CmdAddEmployee.Location = new System.Drawing.Point(33, 994);
            this.CmdAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdAddEmployee.Name = "CmdAddEmployee";
            this.CmdAddEmployee.Size = new System.Drawing.Size(152, 62);
            this.CmdAddEmployee.TabIndex = 40;
            this.CmdAddEmployee.Text = "Mitarbeiter Hinzufügen";
            this.CmdAddEmployee.UseVisualStyleBackColor = true;
            this.CmdAddEmployee.Click += new System.EventHandler(this.CmdAddEmployee_Click);
            // 
            // LblKaderstufe
            // 
            this.LblKaderstufe.AutoSize = true;
            this.LblKaderstufe.Location = new System.Drawing.Point(429, 506);
            this.LblKaderstufe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblKaderstufe.Name = "LblKaderstufe";
            this.LblKaderstufe.Size = new System.Drawing.Size(113, 25);
            this.LblKaderstufe.TabIndex = 114;
            this.LblKaderstufe.Text = "Kaderstufe:";
            // 
            // CmbDepartment
            // 
            this.CmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDepartment.FormattingEnabled = true;
            this.CmbDepartment.ItemHeight = 25;
            this.CmbDepartment.Items.AddRange(new object[] {
            "Mechanik",
            "Einkauf",
            "Verkauf",
            "Informatik",
            "Produktion"});
            this.CmbDepartment.Location = new System.Drawing.Point(600, 291);
            this.CmbDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbDepartment.Name = "CmbDepartment";
            this.CmbDepartment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbDepartment.Size = new System.Drawing.Size(252, 33);
            this.CmbDepartment.TabIndex = 18;
            // 
            // CmdDelEmployee
            // 
            this.CmdDelEmployee.Location = new System.Drawing.Point(404, 994);
            this.CmdDelEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdDelEmployee.Name = "CmdDelEmployee";
            this.CmdDelEmployee.Size = new System.Drawing.Size(152, 62);
            this.CmdDelEmployee.TabIndex = 42;
            this.CmdDelEmployee.Text = "Mitarbeiter Löschen";
            this.CmdDelEmployee.UseVisualStyleBackColor = true;
            this.CmdDelEmployee.Click += new System.EventHandler(this.CmdDelEmployee_Click);
            // 
            // CmdMenue
            // 
            this.CmdMenue.Location = new System.Drawing.Point(1128, 994);
            this.CmdMenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdMenue.Name = "CmdMenue";
            this.CmdMenue.Size = new System.Drawing.Size(152, 62);
            this.CmdMenue.TabIndex = 43;
            this.CmdMenue.Text = "Zurück zum Menu";
            this.CmdMenue.UseVisualStyleBackColor = true;
            this.CmdMenue.Click += new System.EventHandler(this.CmdMenue_Click);
            // 
            // NumManagementLevel
            // 
            this.NumManagementLevel.Location = new System.Drawing.Point(600, 502);
            this.NumManagementLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumManagementLevel.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumManagementLevel.Name = "NumManagementLevel";
            this.NumManagementLevel.Size = new System.Drawing.Size(255, 30);
            this.NumManagementLevel.TabIndex = 23;
            this.NumManagementLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LsbOutputMA
            // 
            this.LsbOutputMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsbOutputMA.FormattingEnabled = true;
            this.LsbOutputMA.ItemHeight = 25;
            this.LsbOutputMA.Location = new System.Drawing.Point(33, 765);
            this.LsbOutputMA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LsbOutputMA.Name = "LsbOutputMA";
            this.LsbOutputMA.Size = new System.Drawing.Size(1246, 179);
            this.LsbOutputMA.TabIndex = 32;
            // 
            // CmdEditEmployee
            // 
            this.CmdEditEmployee.Location = new System.Drawing.Point(212, 994);
            this.CmdEditEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdEditEmployee.Name = "CmdEditEmployee";
            this.CmdEditEmployee.Size = new System.Drawing.Size(162, 62);
            this.CmdEditEmployee.TabIndex = 41;
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
            this.LblMaID.Location = new System.Drawing.Point(21, 48);
            this.LblMaID.Name = "LblMaID";
            this.LblMaID.Size = new System.Drawing.Size(128, 25);
            this.LblMaID.TabIndex = 123;
            this.LblMaID.Text = "MitarbeiterID:";
            // 
            // TxtMitarbeiterID
            // 
            this.TxtMitarbeiterID.Location = new System.Drawing.Point(190, 42);
            this.TxtMitarbeiterID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtMitarbeiterID.Name = "TxtMitarbeiterID";
            this.TxtMitarbeiterID.ReadOnly = true;
            this.TxtMitarbeiterID.Size = new System.Drawing.Size(148, 30);
            this.TxtMitarbeiterID.TabIndex = 0;
            // 
            // grpBoxMa
            // 
            this.grpBoxMa.Controls.Add(this.LblApprenticeYears);
            this.grpBoxMa.Controls.Add(this.LblCurrentYear);
            this.grpBoxMa.Controls.Add(this.TxtCurrentYear);
            this.grpBoxMa.Controls.Add(this.TxtApprenticeYears);
            this.grpBoxMa.Controls.Add(this.ChkTrainee);
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
            this.grpBoxMa.Location = new System.Drawing.Point(378, 135);
            this.grpBoxMa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxMa.Name = "grpBoxMa";
            this.grpBoxMa.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxMa.Size = new System.Drawing.Size(902, 602);
            this.grpBoxMa.TabIndex = 125;
            this.grpBoxMa.TabStop = false;
            this.grpBoxMa.Text = "Datenverwaltung";
            // 
            // LblApprenticeYears
            // 
            this.LblApprenticeYears.AutoSize = true;
            this.LblApprenticeYears.Location = new System.Drawing.Point(49, 551);
            this.LblApprenticeYears.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblApprenticeYears.Name = "LblApprenticeYears";
            this.LblApprenticeYears.Size = new System.Drawing.Size(100, 25);
            this.LblApprenticeYears.TabIndex = 129;
            this.LblApprenticeYears.Text = "Lehrjahre:";
            this.LblApprenticeYears.Visible = false;
            // 
            // LblCurrentYear
            // 
            this.LblCurrentYear.AutoSize = true;
            this.LblCurrentYear.Location = new System.Drawing.Point(400, 552);
            this.LblCurrentYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCurrentYear.Name = "LblCurrentYear";
            this.LblCurrentYear.Size = new System.Drawing.Size(142, 25);
            this.LblCurrentYear.TabIndex = 128;
            this.LblCurrentYear.Text = "Aktuelles Jahr:";
            this.LblCurrentYear.Visible = false;
            // 
            // TxtCurrentYear
            // 
            this.TxtCurrentYear.Location = new System.Drawing.Point(602, 548);
            this.TxtCurrentYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCurrentYear.Name = "TxtCurrentYear";
            this.TxtCurrentYear.Size = new System.Drawing.Size(130, 30);
            this.TxtCurrentYear.TabIndex = 26;
            this.TxtCurrentYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCurrentYear.Visible = false;
            // 
            // TxtApprenticeYears
            // 
            this.TxtApprenticeYears.Location = new System.Drawing.Point(190, 548);
            this.TxtApprenticeYears.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtApprenticeYears.Name = "TxtApprenticeYears";
            this.TxtApprenticeYears.Size = new System.Drawing.Size(148, 30);
            this.TxtApprenticeYears.TabIndex = 25;
            this.TxtApprenticeYears.Visible = false;
            // 
            // ChkTrainee
            // 
            this.ChkTrainee.AutoSize = true;
            this.ChkTrainee.Location = new System.Drawing.Point(753, 551);
            this.ChkTrainee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkTrainee.Name = "ChkTrainee";
            this.ChkTrainee.Size = new System.Drawing.Size(116, 29);
            this.ChkTrainee.TabIndex = 24;
            this.ChkTrainee.Text = "Lerneder";
            this.ChkTrainee.UseVisualStyleBackColor = true;
            this.ChkTrainee.CheckedChanged += new System.EventHandler(this.ChkTrainee_CheckedChanged);
            // 
            // RadMitarbeiter
            // 
            this.RadMitarbeiter.AutoSize = true;
            this.RadMitarbeiter.Location = new System.Drawing.Point(6, 32);
            this.RadMitarbeiter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadMitarbeiter.Name = "RadMitarbeiter";
            this.RadMitarbeiter.Size = new System.Drawing.Size(109, 24);
            this.RadMitarbeiter.TabIndex = 30;
            this.RadMitarbeiter.TabStop = true;
            this.RadMitarbeiter.Text = "Mitarbeiter";
            this.RadMitarbeiter.UseVisualStyleBackColor = true;
            this.RadMitarbeiter.CheckedChanged += new System.EventHandler(this.RadMitarbeiter_CheckedChanged);
            // 
            // RadLehrling
            // 
            this.RadLehrling.AutoSize = true;
            this.RadLehrling.Location = new System.Drawing.Point(6, 58);
            this.RadLehrling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadLehrling.Name = "RadLehrling";
            this.RadLehrling.Size = new System.Drawing.Size(90, 24);
            this.RadLehrling.TabIndex = 31;
            this.RadLehrling.TabStop = true;
            this.RadLehrling.Text = "Lehrling";
            this.RadLehrling.UseVisualStyleBackColor = true;
            this.RadLehrling.CheckedChanged += new System.EventHandler(this.RadLehrling_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadMitarbeiter);
            this.groupBox1.Controls.Add(this.RadLehrling);
            this.groupBox1.Location = new System.Drawing.Point(33, 638);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(242, 100);
            this.groupBox1.TabIndex = 128;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vorschau wählen:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 149);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 374);
            this.pictureBox1.TabIndex = 129;
            this.pictureBox1.TabStop = false;
            // 
            // LblTopic
            // 
            this.LblTopic.AutoSize = true;
            this.LblTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTopic.Location = new System.Drawing.Point(26, 25);
            this.LblTopic.Name = "LblTopic";
            this.LblTopic.Size = new System.Drawing.Size(781, 79);
            this.LblTopic.TabIndex = 130;
            this.LblTopic.Text = "Mitarbeiter Registration";
            // 
            // CmdMitarbeiterImport
            // 
            this.CmdMitarbeiterImport.Location = new System.Drawing.Point(945, 95);
            this.CmdMitarbeiterImport.Name = "CmdMitarbeiterImport";
            this.CmdMitarbeiterImport.Size = new System.Drawing.Size(334, 32);
            this.CmdMitarbeiterImport.TabIndex = 131;
            this.CmdMitarbeiterImport.Text = "Mitarbeiter importieren aus CSV-Datei";
            this.CmdMitarbeiterImport.UseVisualStyleBackColor = true;
            this.CmdMitarbeiterImport.Click += new System.EventHandler(this.CmdMitarbeiterImport_Click);
            // 
            // Form_MitarbeiterReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 1049);
            this.Controls.Add(this.CmdMitarbeiterImport);
            this.Controls.Add(this.LblTopic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxMa);
            this.Controls.Add(this.CmdEditEmployee);
            this.Controls.Add(this.LsbOutputMA);
            this.Controls.Add(this.CmdMenue);
            this.Controls.Add(this.CmdDelEmployee);
            this.Controls.Add(this.CmdAddEmployee);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_MitarbeiterReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mitarbeiterverwaltung";
            ((System.ComponentModel.ISupportInitialize)(this.NumManagementLevel)).EndInit();
            this.grpBoxMa.ResumeLayout(false);
            this.grpBoxMa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label LblApprenticeYears;
        private System.Windows.Forms.Label LblCurrentYear;
        private System.Windows.Forms.TextBox TxtCurrentYear;
        private System.Windows.Forms.TextBox TxtApprenticeYears;
        private System.Windows.Forms.CheckBox ChkTrainee;
        private System.Windows.Forms.RadioButton RadMitarbeiter;
        private System.Windows.Forms.RadioButton RadLehrling;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblTopic;
        private System.Windows.Forms.Button CmdMitarbeiterImport;
    }
}