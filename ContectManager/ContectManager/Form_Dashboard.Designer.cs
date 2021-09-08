namespace ContectManager
{
    partial class Form_Dashboard
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
            this.CmdMenue = new System.Windows.Forms.Button();
            this.LblContactManager = new System.Windows.Forms.Label();
            this.LblTitelCountCustomer = new System.Windows.Forms.Label();
            this.LblTitelCountEmployee = new System.Windows.Forms.Label();
            this.LblCountCustomer = new System.Windows.Forms.Label();
            this.LblCountEmployee = new System.Windows.Forms.Label();
            this.CmdOpenLogFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdMenue
            // 
            this.CmdMenue.Location = new System.Drawing.Point(682, 388);
            this.CmdMenue.Name = "CmdMenue";
            this.CmdMenue.Size = new System.Drawing.Size(106, 50);
            this.CmdMenue.TabIndex = 0;
            this.CmdMenue.Text = "Zurück zum Menü";
            this.CmdMenue.UseVisualStyleBackColor = true;
            this.CmdMenue.Click += new System.EventHandler(this.CmdMenue_Click);
            // 
            // LblContactManager
            // 
            this.LblContactManager.AutoSize = true;
            this.LblContactManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContactManager.Location = new System.Drawing.Point(311, 21);
            this.LblContactManager.Name = "LblContactManager";
            this.LblContactManager.Size = new System.Drawing.Size(162, 24);
            this.LblContactManager.TabIndex = 6;
            this.LblContactManager.Text = "ContactManager";
            // 
            // LblTitelCountCustomer
            // 
            this.LblTitelCountCustomer.AutoSize = true;
            this.LblTitelCountCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitelCountCustomer.Location = new System.Drawing.Point(45, 89);
            this.LblTitelCountCustomer.Name = "LblTitelCountCustomer";
            this.LblTitelCountCustomer.Size = new System.Drawing.Size(119, 18);
            this.LblTitelCountCustomer.TabIndex = 7;
            this.LblTitelCountCustomer.Text = "Anzahl Kunden";
            // 
            // LblTitelCountEmployee
            // 
            this.LblTitelCountEmployee.AutoSize = true;
            this.LblTitelCountEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.LblTitelCountEmployee.Location = new System.Drawing.Point(250, 89);
            this.LblTitelCountEmployee.Name = "LblTitelCountEmployee";
            this.LblTitelCountEmployee.Size = new System.Drawing.Size(143, 18);
            this.LblTitelCountEmployee.TabIndex = 8;
            this.LblTitelCountEmployee.Text = "Anzahl Mitarbeiter";
            // 
            // LblCountCustomer
            // 
            this.LblCountCustomer.AutoSize = true;
            this.LblCountCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCountCustomer.Location = new System.Drawing.Point(80, 120);
            this.LblCountCustomer.Name = "LblCountCustomer";
            this.LblCountCustomer.Size = new System.Drawing.Size(44, 31);
            this.LblCountCustomer.TabIndex = 9;
            this.LblCountCustomer.Text = "15";
            // 
            // LblCountEmployee
            // 
            this.LblCountEmployee.AutoSize = true;
            this.LblCountEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.LblCountEmployee.Location = new System.Drawing.Point(298, 120);
            this.LblCountEmployee.Name = "LblCountEmployee";
            this.LblCountEmployee.Size = new System.Drawing.Size(44, 31);
            this.LblCountEmployee.TabIndex = 10;
            this.LblCountEmployee.Text = "15";
            // 
            // CmdOpenLogFile
            // 
            this.CmdOpenLogFile.Location = new System.Drawing.Point(58, 379);
            this.CmdOpenLogFile.Name = "CmdOpenLogFile";
            this.CmdOpenLogFile.Size = new System.Drawing.Size(106, 50);
            this.CmdOpenLogFile.TabIndex = 11;
            this.CmdOpenLogFile.Text = "Open Log File";
            this.CmdOpenLogFile.UseVisualStyleBackColor = true;
            this.CmdOpenLogFile.Click += new System.EventHandler(this.CmdOpenLogFile_Click);
            // 
            // Form_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdOpenLogFile);
            this.Controls.Add(this.LblCountEmployee);
            this.Controls.Add(this.LblCountCustomer);
            this.Controls.Add(this.LblTitelCountEmployee);
            this.Controls.Add(this.LblTitelCountCustomer);
            this.Controls.Add(this.LblContactManager);
            this.Controls.Add(this.CmdMenue);
            this.Name = "Form_Dashboard";
            this.Text = "Form_Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdMenue;
        private System.Windows.Forms.Label LblContactManager;
        private System.Windows.Forms.Label LblTitelCountCustomer;
        private System.Windows.Forms.Label LblTitelCountEmployee;
        private System.Windows.Forms.Label LblCountCustomer;
        private System.Windows.Forms.Label LblCountEmployee;
        private System.Windows.Forms.Button CmdOpenLogFile;
    }
}