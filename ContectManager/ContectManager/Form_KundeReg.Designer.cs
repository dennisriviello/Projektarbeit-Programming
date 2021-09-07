
using System;

namespace ContectManager
{
    partial class Form_KundeReg
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
            this.CmdDelCustomer = new System.Windows.Forms.Button();
            this.CmdEditCustomer = new System.Windows.Forms.Button();
            this.lbl_Vorname = new System.Windows.Forms.Label();
            this.lbl_Nachname = new System.Windows.Forms.Label();
            this.TxtFirstname = new System.Windows.Forms.TextBox();
            this.TxtLastname = new System.Windows.Forms.TextBox();
            this.CmdAddCustomer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTelWork = new System.Windows.Forms.TextBox();
            this.TxtTelPrivate = new System.Windows.Forms.TextBox();
            this.TxtTelMobile = new System.Windows.Forms.TextBox();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.lblKundenID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmdMenue = new System.Windows.Forms.Button();
            this.TxtSalutation = new System.Windows.Forms.TextBox();
            this.DtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtAdress = new System.Windows.Forms.TextBox();
            this.TxtEMail = new System.Windows.Forms.TextBox();
            this.TxtFaxWork = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtZipcode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtResidence = new System.Windows.Forms.TextBox();
            this.ChkActive = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtCompanyAdress = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtCompanyName = new System.Windows.Forms.TextBox();
            this.CmbCustomerType = new System.Windows.Forms.ComboBox();
            this.LsbOutputKU = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmdDelCustomer
            // 
            this.CmdDelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdDelCustomer.Location = new System.Drawing.Point(400, 828);
            this.CmdDelCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmdDelCustomer.Name = "CmdDelCustomer";
            this.CmdDelCustomer.Size = new System.Drawing.Size(175, 65);
            this.CmdDelCustomer.TabIndex = 43;
            this.CmdDelCustomer.Text = "Kunde\r\nlöschen";
            this.CmdDelCustomer.UseVisualStyleBackColor = true;
            this.CmdDelCustomer.Click += new System.EventHandler(this.CmdDelCustomer_Click);
            // 
            // CmdEditCustomer
            // 
            this.CmdEditCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdEditCustomer.Location = new System.Drawing.Point(217, 828);
            this.CmdEditCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmdEditCustomer.Name = "CmdEditCustomer";
            this.CmdEditCustomer.Size = new System.Drawing.Size(175, 65);
            this.CmdEditCustomer.TabIndex = 42;
            this.CmdEditCustomer.Text = "Kunde\r\nbearbeiten";
            this.CmdEditCustomer.UseVisualStyleBackColor = true;
            this.CmdEditCustomer.Click += new System.EventHandler(this.CmdEditCustomer_Click);
            // 
            // lbl_Vorname
            // 
            this.lbl_Vorname.AutoSize = true;
            this.lbl_Vorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vorname.Location = new System.Drawing.Point(57, 128);
            this.lbl_Vorname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Vorname.Name = "lbl_Vorname";
            this.lbl_Vorname.Size = new System.Drawing.Size(98, 25);
            this.lbl_Vorname.TabIndex = 0;
            this.lbl_Vorname.Text = "Vorname:";
            // 
            // lbl_Nachname
            // 
            this.lbl_Nachname.AutoSize = true;
            this.lbl_Nachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nachname.Location = new System.Drawing.Point(42, 168);
            this.lbl_Nachname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nachname.Name = "lbl_Nachname";
            this.lbl_Nachname.Size = new System.Drawing.Size(113, 25);
            this.lbl_Nachname.TabIndex = 1;
            this.lbl_Nachname.Text = "Nachname:";
            // 
            // TxtFirstname
            // 
            this.TxtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFirstname.Location = new System.Drawing.Point(190, 123);
            this.TxtFirstname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFirstname.Name = "TxtFirstname";
            this.TxtFirstname.Size = new System.Drawing.Size(148, 30);
            this.TxtFirstname.TabIndex = 3;
            this.TxtFirstname.Text = "Hans";
            // 
            // TxtLastname
            // 
            this.TxtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLastname.Location = new System.Drawing.Point(190, 163);
            this.TxtLastname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtLastname.Name = "TxtLastname";
            this.TxtLastname.Size = new System.Drawing.Size(148, 30);
            this.TxtLastname.TabIndex = 4;
            this.TxtLastname.Text = "Nötig";
            // 
            // CmdAddCustomer
            // 
            this.CmdAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAddCustomer.Location = new System.Drawing.Point(34, 828);
            this.CmdAddCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmdAddCustomer.Name = "CmdAddCustomer";
            this.CmdAddCustomer.Size = new System.Drawing.Size(175, 65);
            this.CmdAddCustomer.TabIndex = 41;
            this.CmdAddCustomer.Text = "Kunde\r\nhinzufuegen";
            this.CmdAddCustomer.UseVisualStyleBackColor = true;
            this.CmdAddCustomer.Click += new System.EventHandler(this.CmdAddCustomer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 328);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Telefon Arbeit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 288);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Telefon Privat:";
            // 
            // TxtTelWork
            // 
            this.TxtTelWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelWork.Location = new System.Drawing.Point(190, 326);
            this.TxtTelWork.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTelWork.Name = "TxtTelWork";
            this.TxtTelWork.Size = new System.Drawing.Size(148, 30);
            this.TxtTelWork.TabIndex = 7;
            // 
            // TxtTelPrivate
            // 
            this.TxtTelPrivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelPrivate.Location = new System.Drawing.Point(190, 286);
            this.TxtTelPrivate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTelPrivate.Name = "TxtTelPrivate";
            this.TxtTelPrivate.Size = new System.Drawing.Size(148, 30);
            this.TxtTelPrivate.TabIndex = 8;
            // 
            // TxtTelMobile
            // 
            this.TxtTelMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelMobile.Location = new System.Drawing.Point(190, 366);
            this.TxtTelMobile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTelMobile.Name = "TxtTelMobile";
            this.TxtTelMobile.Size = new System.Drawing.Size(148, 30);
            this.TxtTelMobile.TabIndex = 9;
            // 
            // TxtTitle
            // 
            this.TxtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitle.Location = new System.Drawing.Point(190, 43);
            this.TxtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(148, 30);
            this.TxtTitle.TabIndex = 1;
            this.TxtTitle.Text = "Professor";
            // 
            // lblKundenID
            // 
            this.lblKundenID.AutoSize = true;
            this.lblKundenID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKundenID.Location = new System.Drawing.Point(73, 88);
            this.lblKundenID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKundenID.Name = "lblKundenID";
            this.lblKundenID.Size = new System.Drawing.Size(82, 25);
            this.lblKundenID.TabIndex = 28;
            this.lblKundenID.Text = "Anrede:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Geburtstag:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 368);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Telefon Mobil:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Titel:";
            // 
            // CmdMenue
            // 
            this.CmdMenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdMenue.Location = new System.Drawing.Point(719, 828);
            this.CmdMenue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmdMenue.Name = "CmdMenue";
            this.CmdMenue.Size = new System.Drawing.Size(175, 65);
            this.CmdMenue.TabIndex = 44;
            this.CmdMenue.Text = "Zurück zum Menue";
            this.CmdMenue.UseVisualStyleBackColor = true;
            this.CmdMenue.Click += new System.EventHandler(this.CmdMenue_Click);
            // 
            // TxtSalutation
            // 
            this.TxtSalutation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSalutation.Location = new System.Drawing.Point(190, 83);
            this.TxtSalutation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSalutation.Name = "TxtSalutation";
            this.TxtSalutation.Size = new System.Drawing.Size(148, 30);
            this.TxtSalutation.TabIndex = 2;
            this.TxtSalutation.Text = "Herr";
            // 
            // DtpBirthday
            // 
            this.DtpBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpBirthday.Location = new System.Drawing.Point(190, 246);
            this.DtpBirthday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpBirthday.Name = "DtpBirthday";
            this.DtpBirthday.Size = new System.Drawing.Size(148, 30);
            this.DtpBirthday.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Geschlecht:";
            // 
            // CmbGender
            // 
            this.CmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Items.AddRange(new object[] {
            "männlich",
            "weiblich",
            "andere"});
            this.CmbGender.Location = new System.Drawing.Point(190, 203);
            this.CmbGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(148, 33);
            this.CmbGender.TabIndex = 5;
            this.CmbGender.Text = "andere";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(438, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 45;
            this.label7.Text = "Adresse:";
            // 
            // TxtAdress
            // 
            this.TxtAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdress.Location = new System.Drawing.Point(584, 121);
            this.TxtAdress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAdress.Name = "TxtAdress";
            this.TxtAdress.Size = new System.Drawing.Size(252, 30);
            this.TxtAdress.TabIndex = 22;
            // 
            // TxtEMail
            // 
            this.TxtEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEMail.Location = new System.Drawing.Point(584, 205);
            this.TxtEMail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtEMail.Name = "TxtEMail";
            this.TxtEMail.Size = new System.Drawing.Size(252, 30);
            this.TxtEMail.TabIndex = 24;
            // 
            // TxtFaxWork
            // 
            this.TxtFaxWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFaxWork.Location = new System.Drawing.Point(190, 406);
            this.TxtFaxWork.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFaxWork.Name = "TxtFaxWork";
            this.TxtFaxWork.Size = new System.Drawing.Size(148, 30);
            this.TxtFaxWork.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(455, 211);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 25);
            this.label8.TabIndex = 41;
            this.label8.Text = "E-Mail:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(48, 408);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 25);
            this.label11.TabIndex = 40;
            this.label11.Text = "Fax Arbeit:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(412, 85);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 25);
            this.label12.TabIndex = 47;
            this.label12.Text = "Postleitzahl:";
            // 
            // TxtZipcode
            // 
            this.TxtZipcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtZipcode.Location = new System.Drawing.Point(584, 79);
            this.TxtZipcode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtZipcode.Name = "TxtZipcode";
            this.TxtZipcode.Size = new System.Drawing.Size(252, 30);
            this.TxtZipcode.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(484, 169);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 25);
            this.label13.TabIndex = 49;
            this.label13.Text = "Ort:";
            // 
            // TxtResidence
            // 
            this.TxtResidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResidence.Location = new System.Drawing.Point(584, 163);
            this.TxtResidence.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtResidence.Name = "TxtResidence";
            this.TxtResidence.Size = new System.Drawing.Size(252, 30);
            this.TxtResidence.TabIndex = 23;
            // 
            // ChkActive
            // 
            this.ChkActive.AutoSize = true;
            this.ChkActive.Checked = true;
            this.ChkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkActive.Location = new System.Drawing.Point(584, 46);
            this.ChkActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChkActive.Name = "ChkActive";
            this.ChkActive.Size = new System.Drawing.Size(22, 21);
            this.ChkActive.TabIndex = 20;
            this.ChkActive.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(468, 43);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 25);
            this.label14.TabIndex = 51;
            this.label14.Text = "Aktiv:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(416, 337);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 25);
            this.label15.TabIndex = 57;
            this.label15.Text = "Kundentyp:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(381, 295);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(148, 25);
            this.label16.TabIndex = 55;
            this.label16.Text = "Firmenadresse:";
            // 
            // TxtCompanyAdress
            // 
            this.TxtCompanyAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCompanyAdress.Location = new System.Drawing.Point(584, 289);
            this.TxtCompanyAdress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCompanyAdress.Name = "TxtCompanyAdress";
            this.TxtCompanyAdress.Size = new System.Drawing.Size(252, 30);
            this.TxtCompanyAdress.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(402, 253);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 25);
            this.label17.TabIndex = 53;
            this.label17.Text = "Firmenname:";
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCompanyName.Location = new System.Drawing.Point(584, 247);
            this.TxtCompanyName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.Size = new System.Drawing.Size(252, 30);
            this.TxtCompanyName.TabIndex = 25;
            // 
            // CmbCustomerType
            // 
            this.CmbCustomerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCustomerType.FormattingEnabled = true;
            this.CmbCustomerType.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.CmbCustomerType.Location = new System.Drawing.Point(584, 331);
            this.CmbCustomerType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbCustomerType.Name = "CmbCustomerType";
            this.CmbCustomerType.Size = new System.Drawing.Size(252, 33);
            this.CmbCustomerType.TabIndex = 27;
            // 
            // LsbOutputKU
            // 
            this.LsbOutputKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsbOutputKU.FormattingEnabled = true;
            this.LsbOutputKU.ItemHeight = 25;
            this.LsbOutputKU.Location = new System.Drawing.Point(34, 541);
            this.LsbOutputKU.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LsbOutputKU.Name = "LsbOutputKU";
            this.LsbOutputKU.Size = new System.Drawing.Size(860, 229);
            this.LsbOutputKU.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtLastname);
            this.groupBox1.Controls.Add(this.lbl_Vorname);
            this.groupBox1.Controls.Add(this.CmbCustomerType);
            this.groupBox1.Controls.Add(this.lbl_Nachname);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.TxtFirstname);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtCompanyAdress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.TxtTelWork);
            this.groupBox1.Controls.Add(this.TxtCompanyName);
            this.groupBox1.Controls.Add(this.TxtTelPrivate);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.TxtTelMobile);
            this.groupBox1.Controls.Add(this.ChkActive);
            this.groupBox1.Controls.Add(this.TxtTitle);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblKundenID);
            this.groupBox1.Controls.Add(this.TxtResidence);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtZipcode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtSalutation);
            this.groupBox1.Controls.Add(this.TxtAdress);
            this.groupBox1.Controls.Add(this.DtpBirthday);
            this.groupBox1.Controls.Add(this.TxtEMail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtFaxWork);
            this.groupBox1.Controls.Add(this.CmbGender);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 453);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datenverwaltung";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(29, 511);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(176, 25);
            this.lblOutput.TabIndex = 112;
            this.lblOutput.Text = "Kunden Vorschau:";
            // 
            // Form_KundeReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 949);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LsbOutputKU);
            this.Controls.Add(this.CmdMenue);
            this.Controls.Add(this.CmdEditCustomer);
            this.Controls.Add(this.CmdDelCustomer);
            this.Controls.Add(this.CmdAddCustomer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_KundeReg";
            this.Text = "Kunden registrieren";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      
        #endregion
        private System.Windows.Forms.Button CmdDelCustomer;
        private System.Windows.Forms.Button CmdEditCustomer;
        private System.Windows.Forms.Label lbl_Vorname;
        private System.Windows.Forms.Label lbl_Nachname;
        private System.Windows.Forms.TextBox TxtFirstname;
        private System.Windows.Forms.TextBox TxtLastname;
        private System.Windows.Forms.Button CmdAddCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTelWork;
        private System.Windows.Forms.TextBox TxtTelPrivate;
        private System.Windows.Forms.TextBox TxtTelMobile;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Label lblKundenID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CmdMenue;
        private System.Windows.Forms.TextBox TxtSalutation;
        private System.Windows.Forms.DateTimePicker DtpBirthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtAdress;
        private System.Windows.Forms.TextBox TxtEMail;
        private System.Windows.Forms.TextBox TxtFaxWork;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtZipcode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtResidence;
        private System.Windows.Forms.CheckBox ChkActive;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtCompanyAdress;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxtCompanyName;
        private System.Windows.Forms.ComboBox CmbCustomerType;
        private System.Windows.Forms.ListBox LsbOutputKU;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOutput;
    }
}