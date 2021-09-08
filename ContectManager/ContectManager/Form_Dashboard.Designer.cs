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
            this.CmdOpenLogFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbllKundenAktivLabel = new System.Windows.Forms.Label();
            this.LbllKundenTotalLabel = new System.Windows.Forms.Label();
            this.LblKundenAktiv = new System.Windows.Forms.Label();
            this.LblKundenTotal = new System.Windows.Forms.Label();
            this.LblMitarbeiterInaktiv = new System.Windows.Forms.Label();
            this.LblMitarbeiterTotal = new System.Windows.Forms.Label();
            this.LblMitarbeiterAktiv = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblLehrlingInaktiv = new System.Windows.Forms.Label();
            this.LblLehrlingTotal = new System.Windows.Forms.Label();
            this.LblLehrlingAktiv = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LbllKundenInaktivLabel = new System.Windows.Forms.Label();
            this.LblKundenInaktiv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdMenue
            // 
            this.CmdMenue.Location = new System.Drawing.Point(468, 439);
            this.CmdMenue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmdMenue.Name = "CmdMenue";
            this.CmdMenue.Size = new System.Drawing.Size(153, 35);
            this.CmdMenue.TabIndex = 0;
            this.CmdMenue.Text = "Zurück zum Menü";
            this.CmdMenue.UseVisualStyleBackColor = true;
            this.CmdMenue.Click += new System.EventHandler(this.CmdMenue_Click);
            // 
            // LblContactManager
            // 
            this.LblContactManager.AutoSize = true;
            this.LblContactManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContactManager.Location = new System.Drawing.Point(181, 65);
            this.LblContactManager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblContactManager.Name = "LblContactManager";
            this.LblContactManager.Size = new System.Drawing.Size(282, 24);
            this.LblContactManager.TabIndex = 6;
            this.LblContactManager.Text = "Dashboard - ContactManager";
            // 
            // LblTitelCountCustomer
            // 
            this.LblTitelCountCustomer.AutoSize = true;
            this.LblTitelCountCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitelCountCustomer.Location = new System.Drawing.Point(45, 149);
            this.LblTitelCountCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitelCountCustomer.Name = "LblTitelCountCustomer";
            this.LblTitelCountCustomer.Size = new System.Drawing.Size(119, 18);
            this.LblTitelCountCustomer.TabIndex = 7;
            this.LblTitelCountCustomer.Text = "Anzahl Kunden";
            // 
            // LblTitelCountEmployee
            // 
            this.LblTitelCountEmployee.AutoSize = true;
            this.LblTitelCountEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.LblTitelCountEmployee.Location = new System.Drawing.Point(251, 149);
            this.LblTitelCountEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitelCountEmployee.Name = "LblTitelCountEmployee";
            this.LblTitelCountEmployee.Size = new System.Drawing.Size(143, 18);
            this.LblTitelCountEmployee.TabIndex = 8;
            this.LblTitelCountEmployee.Text = "Anzahl Mitarbeiter";
            // 
            // CmdOpenLogFile
            // 
            this.CmdOpenLogFile.Location = new System.Drawing.Point(13, 439);
            this.CmdOpenLogFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmdOpenLogFile.Name = "CmdOpenLogFile";
            this.CmdOpenLogFile.Size = new System.Drawing.Size(128, 35);
            this.CmdOpenLogFile.TabIndex = 11;
            this.CmdOpenLogFile.Text = "Open Log File";
            this.CmdOpenLogFile.UseVisualStyleBackColor = true;
            this.CmdOpenLogFile.Click += new System.EventHandler(this.CmdOpenLogFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(490, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Anzahl Lehrlinge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 13;
            // 
            // LbllKundenAktivLabel
            // 
            this.LbllKundenAktivLabel.AutoSize = true;
            this.LbllKundenAktivLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbllKundenAktivLabel.Location = new System.Drawing.Point(45, 203);
            this.LbllKundenAktivLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbllKundenAktivLabel.Name = "LbllKundenAktivLabel";
            this.LbllKundenAktivLabel.Size = new System.Drawing.Size(40, 13);
            this.LbllKundenAktivLabel.TabIndex = 14;
            this.LbllKundenAktivLabel.Text = "Aktiv:";
            // 
            // LbllKundenTotalLabel
            // 
            this.LbllKundenTotalLabel.AutoSize = true;
            this.LbllKundenTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbllKundenTotalLabel.Location = new System.Drawing.Point(45, 256);
            this.LbllKundenTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbllKundenTotalLabel.Name = "LbllKundenTotalLabel";
            this.LbllKundenTotalLabel.Size = new System.Drawing.Size(40, 13);
            this.LbllKundenTotalLabel.TabIndex = 15;
            this.LbllKundenTotalLabel.Text = "Total:";
            // 
            // LblKundenAktiv
            // 
            this.LblKundenAktiv.AutoSize = true;
            this.LblKundenAktiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKundenAktiv.Location = new System.Drawing.Point(108, 203);
            this.LblKundenAktiv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblKundenAktiv.Name = "LblKundenAktiv";
            this.LblKundenAktiv.Size = new System.Drawing.Size(19, 13);
            this.LblKundenAktiv.TabIndex = 18;
            this.LblKundenAktiv.Text = "...";
            // 
            // LblKundenTotal
            // 
            this.LblKundenTotal.AutoSize = true;
            this.LblKundenTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKundenTotal.Location = new System.Drawing.Point(108, 256);
            this.LblKundenTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblKundenTotal.Name = "LblKundenTotal";
            this.LblKundenTotal.Size = new System.Drawing.Size(19, 13);
            this.LblKundenTotal.TabIndex = 19;
            this.LblKundenTotal.Text = "...";
            // 
            // LblMitarbeiterInaktiv
            // 
            this.LblMitarbeiterInaktiv.AutoSize = true;
            this.LblMitarbeiterInaktiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMitarbeiterInaktiv.Location = new System.Drawing.Point(314, 230);
            this.LblMitarbeiterInaktiv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMitarbeiterInaktiv.Name = "LblMitarbeiterInaktiv";
            this.LblMitarbeiterInaktiv.Size = new System.Drawing.Size(19, 13);
            this.LblMitarbeiterInaktiv.TabIndex = 27;
            this.LblMitarbeiterInaktiv.Text = "...";
            // 
            // LblMitarbeiterTotal
            // 
            this.LblMitarbeiterTotal.AutoSize = true;
            this.LblMitarbeiterTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMitarbeiterTotal.Location = new System.Drawing.Point(314, 256);
            this.LblMitarbeiterTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMitarbeiterTotal.Name = "LblMitarbeiterTotal";
            this.LblMitarbeiterTotal.Size = new System.Drawing.Size(19, 13);
            this.LblMitarbeiterTotal.TabIndex = 26;
            this.LblMitarbeiterTotal.Text = "...";
            // 
            // LblMitarbeiterAktiv
            // 
            this.LblMitarbeiterAktiv.AutoSize = true;
            this.LblMitarbeiterAktiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMitarbeiterAktiv.Location = new System.Drawing.Point(314, 203);
            this.LblMitarbeiterAktiv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMitarbeiterAktiv.Name = "LblMitarbeiterAktiv";
            this.LblMitarbeiterAktiv.Size = new System.Drawing.Size(19, 13);
            this.LblMitarbeiterAktiv.TabIndex = 25;
            this.LblMitarbeiterAktiv.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(251, 230);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Inaktiv:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(251, 256);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(251, 203);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Aktiv:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(251, 181);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 21;
            // 
            // LblLehrlingInaktiv
            // 
            this.LblLehrlingInaktiv.AutoSize = true;
            this.LblLehrlingInaktiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLehrlingInaktiv.Location = new System.Drawing.Point(553, 230);
            this.LblLehrlingInaktiv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLehrlingInaktiv.Name = "LblLehrlingInaktiv";
            this.LblLehrlingInaktiv.Size = new System.Drawing.Size(19, 13);
            this.LblLehrlingInaktiv.TabIndex = 33;
            this.LblLehrlingInaktiv.Text = "...";
            // 
            // LblLehrlingTotal
            // 
            this.LblLehrlingTotal.AutoSize = true;
            this.LblLehrlingTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLehrlingTotal.Location = new System.Drawing.Point(553, 256);
            this.LblLehrlingTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLehrlingTotal.Name = "LblLehrlingTotal";
            this.LblLehrlingTotal.Size = new System.Drawing.Size(19, 13);
            this.LblLehrlingTotal.TabIndex = 32;
            this.LblLehrlingTotal.Text = "...";
            // 
            // LblLehrlingAktiv
            // 
            this.LblLehrlingAktiv.AutoSize = true;
            this.LblLehrlingAktiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLehrlingAktiv.Location = new System.Drawing.Point(553, 203);
            this.LblLehrlingAktiv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLehrlingAktiv.Name = "LblLehrlingAktiv";
            this.LblLehrlingAktiv.Size = new System.Drawing.Size(19, 13);
            this.LblLehrlingAktiv.TabIndex = 31;
            this.LblLehrlingAktiv.Text = "...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(490, 230);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Inaktiv:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(490, 256);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Total:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(490, 203);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Aktiv:";
            // 
            // LbllKundenInaktivLabel
            // 
            this.LbllKundenInaktivLabel.AutoSize = true;
            this.LbllKundenInaktivLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbllKundenInaktivLabel.Location = new System.Drawing.Point(45, 230);
            this.LbllKundenInaktivLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbllKundenInaktivLabel.Name = "LbllKundenInaktivLabel";
            this.LbllKundenInaktivLabel.Size = new System.Drawing.Size(50, 13);
            this.LbllKundenInaktivLabel.TabIndex = 17;
            this.LbllKundenInaktivLabel.Text = "Inaktiv:";
            // 
            // LblKundenInaktiv
            // 
            this.LblKundenInaktiv.AutoSize = true;
            this.LblKundenInaktiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKundenInaktiv.Location = new System.Drawing.Point(108, 230);
            this.LblKundenInaktiv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblKundenInaktiv.Name = "LblKundenInaktiv";
            this.LblKundenInaktiv.Size = new System.Drawing.Size(19, 13);
            this.LblKundenInaktiv.TabIndex = 20;
            this.LblKundenInaktiv.Text = "...";
            // 
            // Form_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 488);
            this.Controls.Add(this.LblLehrlingInaktiv);
            this.Controls.Add(this.LblLehrlingTotal);
            this.Controls.Add(this.LblLehrlingAktiv);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LblMitarbeiterInaktiv);
            this.Controls.Add(this.LblMitarbeiterTotal);
            this.Controls.Add(this.LblMitarbeiterAktiv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblKundenInaktiv);
            this.Controls.Add(this.LblKundenTotal);
            this.Controls.Add(this.LblKundenAktiv);
            this.Controls.Add(this.LbllKundenInaktivLabel);
            this.Controls.Add(this.LbllKundenTotalLabel);
            this.Controls.Add(this.LbllKundenAktivLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdOpenLogFile);
            this.Controls.Add(this.LblTitelCountEmployee);
            this.Controls.Add(this.LblTitelCountCustomer);
            this.Controls.Add(this.LblContactManager);
            this.Controls.Add(this.CmdMenue);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdMenue;
        private System.Windows.Forms.Label LblContactManager;
        private System.Windows.Forms.Label LblTitelCountCustomer;
        private System.Windows.Forms.Label LblTitelCountEmployee;
        private System.Windows.Forms.Button CmdOpenLogFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbllKundenAktivLabel;
        private System.Windows.Forms.Label LbllKundenTotalLabel;
        private System.Windows.Forms.Label LblKundenAktiv;
        private System.Windows.Forms.Label LblKundenTotal;
        private System.Windows.Forms.Label LblMitarbeiterInaktiv;
        private System.Windows.Forms.Label LblMitarbeiterTotal;
        private System.Windows.Forms.Label LblMitarbeiterAktiv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblLehrlingInaktiv;
        private System.Windows.Forms.Label LblLehrlingTotal;
        private System.Windows.Forms.Label LblLehrlingAktiv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LbllKundenInaktivLabel;
        private System.Windows.Forms.Label LblKundenInaktiv;
    }
}