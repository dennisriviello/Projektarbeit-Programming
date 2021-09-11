
namespace ContectManager
{
    partial class Form_Suche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Suche));
            this.cmd_Menue = new System.Windows.Forms.Button();
            this.CmdSuchen = new System.Windows.Forms.Button();
            this.TxtTopic = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadTrainee = new System.Windows.Forms.RadioButton();
            this.RadEmployee = new System.Windows.Forms.RadioButton();
            this.RadCustomer = new System.Windows.Forms.RadioButton();
            this.LstOutput = new System.Windows.Forms.ListBox();
            this.CmbEmployee = new System.Windows.Forms.ComboBox();
            this.CmbCustomer = new System.Windows.Forms.ComboBox();
            this.CmbTrainee = new System.Windows.Forms.ComboBox();
            this.TxtEmployee = new System.Windows.Forms.TextBox();
            this.TxtCustomer = new System.Windows.Forms.TextBox();
            this.TxtTrainee = new System.Windows.Forms.TextBox();
            this.LblEmployee = new System.Windows.Forms.Label();
            this.LblCustomer = new System.Windows.Forms.Label();
            this.LblTrainee = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_Menue
            // 
            this.cmd_Menue.Location = new System.Drawing.Point(502, 688);
            this.cmd_Menue.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_Menue.Name = "cmd_Menue";
            this.cmd_Menue.Size = new System.Drawing.Size(157, 59);
            this.cmd_Menue.TabIndex = 52;
            this.cmd_Menue.Text = "zurück zum Menü";
            this.cmd_Menue.UseVisualStyleBackColor = true;
            this.cmd_Menue.Click += new System.EventHandler(this.cmd_Menue_Click);
            // 
            // CmdSuchen
            // 
            this.CmdSuchen.Location = new System.Drawing.Point(15, 681);
            this.CmdSuchen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdSuchen.Name = "CmdSuchen";
            this.CmdSuchen.Size = new System.Drawing.Size(152, 66);
            this.CmdSuchen.TabIndex = 51;
            this.CmdSuchen.Text = "Suchen";
            this.CmdSuchen.UseVisualStyleBackColor = true;
            this.CmdSuchen.Click += new System.EventHandler(this.CmdSuchen_Click);
            // 
            // TxtTopic
            // 
            this.TxtTopic.AutoSize = true;
            this.TxtTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTopic.Location = new System.Drawing.Point(17, 9);
            this.TxtTopic.Name = "TxtTopic";
            this.TxtTopic.Size = new System.Drawing.Size(584, 39);
            this.TxtTopic.TabIndex = 9;
            this.TxtTopic.Text = "Suche nach Mitarbeiter oder Kunde";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadTrainee);
            this.groupBox1.Controls.Add(this.RadEmployee);
            this.groupBox1.Controls.Add(this.RadCustomer);
            this.groupBox1.Location = new System.Drawing.Point(15, 227);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(644, 52);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // RadTrainee
            // 
            this.RadTrainee.AutoSize = true;
            this.RadTrainee.Location = new System.Drawing.Point(500, 18);
            this.RadTrainee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadTrainee.Name = "RadTrainee";
            this.RadTrainee.Size = new System.Drawing.Size(80, 21);
            this.RadTrainee.TabIndex = 2;
            this.RadTrainee.Text = "Lehrling";
            this.RadTrainee.UseVisualStyleBackColor = true;
            this.RadTrainee.CheckedChanged += new System.EventHandler(this.RadTrainee_CheckedChanged);
            // 
            // RadEmployee
            // 
            this.RadEmployee.AutoSize = true;
            this.RadEmployee.Checked = true;
            this.RadEmployee.Location = new System.Drawing.Point(29, 18);
            this.RadEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadEmployee.Name = "RadEmployee";
            this.RadEmployee.Size = new System.Drawing.Size(96, 21);
            this.RadEmployee.TabIndex = 0;
            this.RadEmployee.TabStop = true;
            this.RadEmployee.Text = "Mitarbeiter";
            this.RadEmployee.UseVisualStyleBackColor = true;
            this.RadEmployee.CheckedChanged += new System.EventHandler(this.RadEmployee_CheckedChanged);
            // 
            // RadCustomer
            // 
            this.RadCustomer.AutoSize = true;
            this.RadCustomer.Location = new System.Drawing.Point(280, 18);
            this.RadCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadCustomer.Name = "RadCustomer";
            this.RadCustomer.Size = new System.Drawing.Size(70, 21);
            this.RadCustomer.TabIndex = 1;
            this.RadCustomer.Text = "Kunde";
            this.RadCustomer.UseVisualStyleBackColor = true;
            this.RadCustomer.CheckedChanged += new System.EventHandler(this.RadCustomer_CheckedChanged);
            // 
            // LstOutput
            // 
            this.LstOutput.FormattingEnabled = true;
            this.LstOutput.ItemHeight = 16;
            this.LstOutput.Location = new System.Drawing.Point(15, 386);
            this.LstOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LstOutput.Name = "LstOutput";
            this.LstOutput.Size = new System.Drawing.Size(644, 276);
            this.LstOutput.TabIndex = 40;
            // 
            // CmbEmployee
            // 
            this.CmbEmployee.FormattingEnabled = true;
            this.CmbEmployee.Items.AddRange(new object[] {
            "EmployeeID",
            "Firstname",
            "Lastname",
            "Salutation",
            "Gender",
            "Title",
            "Telwork",
            "Faxwork",
            "Adress",
            "Zipcode",
            "Residence",
            "Telprivate",
            "Telmobile",
            "Email",
            "Active",
            "Department",
            "Ahvnumber",
            "Nationality",
            "Employmentlevel",
            "Role",
            "Managementlevel"});
            this.CmbEmployee.Location = new System.Drawing.Point(35, 284);
            this.CmbEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.CmbEmployee.Name = "CmbEmployee";
            this.CmbEmployee.Size = new System.Drawing.Size(141, 24);
            this.CmbEmployee.TabIndex = 10;
            this.CmbEmployee.Text = "EmployeeID";
            this.CmbEmployee.SelectedIndexChanged += new System.EventHandler(this.CmbEmployee_SelectedIndexChanged);
            // 
            // CmbCustomer
            // 
            this.CmbCustomer.FormattingEnabled = true;
            this.CmbCustomer.Items.AddRange(new object[] {
            "Firstname",
            "Lastname",
            "Salutation",
            "Gender",
            "Title",
            "Telwork",
            "Faxwork",
            "Adress",
            "Zipcode",
            "Residence",
            "Telprivate",
            "Telmobile",
            "Email",
            "Active",
            "Companyname",
            "Companyadress",
            "Customertype"});
            this.CmbCustomer.Location = new System.Drawing.Point(263, 284);
            this.CmbCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.CmbCustomer.Name = "CmbCustomer";
            this.CmbCustomer.Size = new System.Drawing.Size(141, 24);
            this.CmbCustomer.TabIndex = 20;
            this.CmbCustomer.Text = "Firstname";
            this.CmbCustomer.Visible = false;
            this.CmbCustomer.SelectedIndexChanged += new System.EventHandler(this.CmbCustomer_SelectedIndexChanged);
            // 
            // CmbTrainee
            // 
            this.CmbTrainee.FormattingEnabled = true;
            this.CmbTrainee.Items.AddRange(new object[] {
            "EmployeeID",
            "Firstname",
            "Lastname",
            "Salutation",
            "Gender",
            "Title",
            "Telwork",
            "Faxwork",
            "Adress",
            "Zipcode",
            "Residence",
            "Telprivate",
            "Telmobile",
            "Email",
            "Active",
            "Department",
            "Ahvnumber",
            "Nationality",
            "Employmentlevel",
            "Role",
            "Managementlevel",
            "Apprenticeshipyears",
            "Currentyear"});
            this.CmbTrainee.Location = new System.Drawing.Point(493, 285);
            this.CmbTrainee.Margin = new System.Windows.Forms.Padding(4);
            this.CmbTrainee.Name = "CmbTrainee";
            this.CmbTrainee.Size = new System.Drawing.Size(141, 24);
            this.CmbTrainee.TabIndex = 30;
            this.CmbTrainee.Text = "EmployeeID";
            this.CmbTrainee.Visible = false;
            this.CmbTrainee.SelectedIndexChanged += new System.EventHandler(this.CmbTrainee_SelectedIndexChanged);
            // 
            // TxtEmployee
            // 
            this.TxtEmployee.Location = new System.Drawing.Point(35, 316);
            this.TxtEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtEmployee.Name = "TxtEmployee";
            this.TxtEmployee.Size = new System.Drawing.Size(141, 22);
            this.TxtEmployee.TabIndex = 11;
            this.TxtEmployee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keydown);
            // 
            // TxtCustomer
            // 
            this.TxtCustomer.Location = new System.Drawing.Point(263, 316);
            this.TxtCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCustomer.Name = "TxtCustomer";
            this.TxtCustomer.Size = new System.Drawing.Size(141, 22);
            this.TxtCustomer.TabIndex = 21;
            this.TxtCustomer.Visible = false;
            this.TxtCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keydown);
            // 
            // TxtTrainee
            // 
            this.TxtTrainee.Location = new System.Drawing.Point(493, 315);
            this.TxtTrainee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTrainee.Name = "TxtTrainee";
            this.TxtTrainee.Size = new System.Drawing.Size(141, 22);
            this.TxtTrainee.TabIndex = 31;
            this.TxtTrainee.Visible = false;
            this.TxtTrainee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keydown);
            // 
            // LblEmployee
            // 
            this.LblEmployee.AutoSize = true;
            this.LblEmployee.ForeColor = System.Drawing.Color.Red;
            this.LblEmployee.Location = new System.Drawing.Point(21, 356);
            this.LblEmployee.Name = "LblEmployee";
            this.LblEmployee.Size = new System.Drawing.Size(207, 17);
            this.LblEmployee.TabIndex = 24;
            this.LblEmployee.Text = "Nur Zahlen zur Eingabe erlaubt";
            this.LblEmployee.Visible = false;
            // 
            // LblCustomer
            // 
            this.LblCustomer.AutoSize = true;
            this.LblCustomer.ForeColor = System.Drawing.Color.Red;
            this.LblCustomer.Location = new System.Drawing.Point(256, 356);
            this.LblCustomer.Name = "LblCustomer";
            this.LblCustomer.Size = new System.Drawing.Size(158, 17);
            this.LblCustomer.TabIndex = 25;
            this.LblCustomer.Text = "Nur Buchstaben erlaubt";
            this.LblCustomer.Visible = false;
            // 
            // LblTrainee
            // 
            this.LblTrainee.AutoSize = true;
            this.LblTrainee.ForeColor = System.Drawing.Color.Red;
            this.LblTrainee.Location = new System.Drawing.Point(467, 356);
            this.LblTrainee.Name = "LblTrainee";
            this.LblTrainee.Size = new System.Drawing.Size(207, 17);
            this.LblTrainee.TabIndex = 27;
            this.LblTrainee.Text = "Nur Zahlen zur Eingabe erlaubt";
            this.LblTrainee.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(249, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 147);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Suche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 758);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblTrainee);
            this.Controls.Add(this.LblCustomer);
            this.Controls.Add(this.LblEmployee);
            this.Controls.Add(this.TxtTrainee);
            this.Controls.Add(this.TxtCustomer);
            this.Controls.Add(this.TxtEmployee);
            this.Controls.Add(this.CmbTrainee);
            this.Controls.Add(this.CmbCustomer);
            this.Controls.Add(this.CmbEmployee);
            this.Controls.Add(this.LstOutput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtTopic);
            this.Controls.Add(this.CmdSuchen);
            this.Controls.Add(this.cmd_Menue);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Suche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informationen suchen / filtern";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_Menue;
        private System.Windows.Forms.Button CmdSuchen;
        private System.Windows.Forms.Label TxtTopic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadCustomer;
        private System.Windows.Forms.RadioButton RadEmployee;
        private System.Windows.Forms.ListBox LstOutput;
        private System.Windows.Forms.RadioButton RadTrainee;
        private System.Windows.Forms.ComboBox CmbEmployee;
        private System.Windows.Forms.ComboBox CmbCustomer;
        private System.Windows.Forms.ComboBox CmbTrainee;
        private System.Windows.Forms.TextBox TxtEmployee;
        private System.Windows.Forms.TextBox TxtCustomer;
        private System.Windows.Forms.TextBox TxtTrainee;
        private System.Windows.Forms.Label LblEmployee;
        private System.Windows.Forms.Label LblCustomer;
        private System.Windows.Forms.Label LblTrainee;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}