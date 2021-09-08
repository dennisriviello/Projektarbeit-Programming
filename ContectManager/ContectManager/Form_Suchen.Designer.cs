
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
            this.cmd_Menue = new System.Windows.Forms.Button();
            this.CmdSuchen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmd_Menue
            // 
            this.cmd_Menue.Location = new System.Drawing.Point(546, 469);
            this.cmd_Menue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmd_Menue.Name = "cmd_Menue";
            this.cmd_Menue.Size = new System.Drawing.Size(178, 74);
            this.cmd_Menue.TabIndex = 3;
            this.cmd_Menue.Text = "zurück zum Menü";
            this.cmd_Menue.UseVisualStyleBackColor = true;
            this.cmd_Menue.Click += new System.EventHandler(this.cmd_Menue_Click);
            // 
            // CmdSuchen
            // 
            this.CmdSuchen.Location = new System.Drawing.Point(14, 462);
            this.CmdSuchen.Name = "CmdSuchen";
            this.CmdSuchen.Size = new System.Drawing.Size(171, 82);
            this.CmdSuchen.TabIndex = 6;
            this.CmdSuchen.Text = "Suchen";
            this.CmdSuchen.UseVisualStyleBackColor = true;
            this.CmdSuchen.Click += new System.EventHandler(this.CmdSuchen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Suche nach Mitarbeiter oder Kunde";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadTrainee);
            this.groupBox1.Controls.Add(this.RadEmployee);
            this.groupBox1.Controls.Add(this.RadCustomer);
            this.groupBox1.Location = new System.Drawing.Point(21, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 65);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // RadTrainee
            // 
            this.RadTrainee.AutoSize = true;
            this.RadTrainee.Location = new System.Drawing.Point(489, 26);
            this.RadTrainee.Name = "RadTrainee";
            this.RadTrainee.Size = new System.Drawing.Size(83, 24);
            this.RadTrainee.TabIndex = 2;
            this.RadTrainee.Text = "Lehrling";
            this.RadTrainee.UseVisualStyleBackColor = true;
            this.RadTrainee.CheckedChanged += new System.EventHandler(this.RadTrainee_CheckedChanged);
            // 
            // RadEmployee
            // 
            this.RadEmployee.AutoSize = true;
            this.RadEmployee.Checked = true;
            this.RadEmployee.Location = new System.Drawing.Point(22, 26);
            this.RadEmployee.Name = "RadEmployee";
            this.RadEmployee.Size = new System.Drawing.Size(102, 24);
            this.RadEmployee.TabIndex = 0;
            this.RadEmployee.TabStop = true;
            this.RadEmployee.Text = "Mitarbeiter";
            this.RadEmployee.UseVisualStyleBackColor = true;
            this.RadEmployee.CheckedChanged += new System.EventHandler(this.RadEmployee_CheckedChanged);
            // 
            // RadCustomer
            // 
            this.RadCustomer.AutoSize = true;
            this.RadCustomer.Location = new System.Drawing.Point(252, 26);
            this.RadCustomer.Name = "RadCustomer";
            this.RadCustomer.Size = new System.Drawing.Size(73, 24);
            this.RadCustomer.TabIndex = 1;
            this.RadCustomer.Text = "Kunde";
            this.RadCustomer.UseVisualStyleBackColor = true;
            this.RadCustomer.CheckedChanged += new System.EventHandler(this.RadCustomer_CheckedChanged);
            // 
            // LstOutput
            // 
            this.LstOutput.FormattingEnabled = true;
            this.LstOutput.ItemHeight = 20;
            this.LstOutput.Location = new System.Drawing.Point(12, 249);
            this.LstOutput.Name = "LstOutput";
            this.LstOutput.Size = new System.Drawing.Size(710, 164);
            this.LstOutput.TabIndex = 15;
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
            this.CmbEmployee.Location = new System.Drawing.Point(44, 149);
            this.CmbEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbEmployee.Name = "CmbEmployee";
            this.CmbEmployee.Size = new System.Drawing.Size(139, 28);
            this.CmbEmployee.TabIndex = 17;
            this.CmbEmployee.Text = "EmployeeID";
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
            this.CmbCustomer.Location = new System.Drawing.Point(273, 149);
            this.CmbCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbCustomer.Name = "CmbCustomer";
            this.CmbCustomer.Size = new System.Drawing.Size(139, 28);
            this.CmbCustomer.TabIndex = 19;
            this.CmbCustomer.Text = "Firstname";
            this.CmbCustomer.Visible = false;
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
            this.CmbTrainee.Location = new System.Drawing.Point(510, 149);
            this.CmbTrainee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbTrainee.Name = "CmbTrainee";
            this.CmbTrainee.Size = new System.Drawing.Size(139, 28);
            this.CmbTrainee.TabIndex = 20;
            this.CmbTrainee.Text = "EmployeeID";
            this.CmbTrainee.Visible = false;
            // 
            // TxtEmployee
            // 
            this.TxtEmployee.Location = new System.Drawing.Point(44, 189);
            this.TxtEmployee.Name = "TxtEmployee";
            this.TxtEmployee.Size = new System.Drawing.Size(139, 26);
            this.TxtEmployee.TabIndex = 21;
            // 
            // TxtCustomer
            // 
            this.TxtCustomer.Location = new System.Drawing.Point(273, 189);
            this.TxtCustomer.Name = "TxtCustomer";
            this.TxtCustomer.Size = new System.Drawing.Size(139, 26);
            this.TxtCustomer.TabIndex = 22;
            this.TxtCustomer.Visible = false;
            // 
            // TxtTrainee
            // 
            this.TxtTrainee.Location = new System.Drawing.Point(510, 189);
            this.TxtTrainee.Name = "TxtTrainee";
            this.TxtTrainee.Size = new System.Drawing.Size(139, 26);
            this.TxtTrainee.TabIndex = 23;
            this.TxtTrainee.Visible = false;
            // 
            // Form_Suche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 608);
            this.Controls.Add(this.TxtTrainee);
            this.Controls.Add(this.TxtCustomer);
            this.Controls.Add(this.TxtEmployee);
            this.Controls.Add(this.CmbTrainee);
            this.Controls.Add(this.CmbCustomer);
            this.Controls.Add(this.CmbEmployee);
            this.Controls.Add(this.LstOutput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdSuchen);
            this.Controls.Add(this.cmd_Menue);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Suche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informationen suchen/filtern";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_Menue;
        private System.Windows.Forms.Button CmdSuchen;
        private System.Windows.Forms.Label label1;
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
    }
}