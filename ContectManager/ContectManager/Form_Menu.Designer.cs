
namespace ContectManager
{
    partial class Form_Menue
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmd_KundenMenue = new System.Windows.Forms.Button();
            this.cmd_MitarbeiterMenue = new System.Windows.Forms.Button();
            this.cmd_InformationenMenue = new System.Windows.Forms.Button();
            this.CmdLogout = new System.Windows.Forms.Button();
            this.LblNamen = new System.Windows.Forms.Label();
            this.LblContactManager = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_KundenMenue
            // 
            this.cmd_KundenMenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_KundenMenue.Location = new System.Drawing.Point(84, 115);
            this.cmd_KundenMenue.Name = "cmd_KundenMenue";
            this.cmd_KundenMenue.Size = new System.Drawing.Size(186, 39);
            this.cmd_KundenMenue.TabIndex = 0;
            this.cmd_KundenMenue.Text = "Kunden verwalten";
            this.cmd_KundenMenue.UseVisualStyleBackColor = true;
            this.cmd_KundenMenue.Click += new System.EventHandler(this.cmd_KundenMenue_Click);
            // 
            // cmd_MitarbeiterMenue
            // 
            this.cmd_MitarbeiterMenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_MitarbeiterMenue.Location = new System.Drawing.Point(84, 180);
            this.cmd_MitarbeiterMenue.Name = "cmd_MitarbeiterMenue";
            this.cmd_MitarbeiterMenue.Size = new System.Drawing.Size(186, 39);
            this.cmd_MitarbeiterMenue.TabIndex = 1;
            this.cmd_MitarbeiterMenue.Text = "Mitarbeiter verwalten";
            this.cmd_MitarbeiterMenue.UseVisualStyleBackColor = true;
            this.cmd_MitarbeiterMenue.Click += new System.EventHandler(this.cmd_MitarbeiterMenue_Click);
            // 
            // cmd_InformationenMenue
            // 
            this.cmd_InformationenMenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_InformationenMenue.Location = new System.Drawing.Point(84, 244);
            this.cmd_InformationenMenue.Name = "cmd_InformationenMenue";
            this.cmd_InformationenMenue.Size = new System.Drawing.Size(186, 39);
            this.cmd_InformationenMenue.TabIndex = 2;
            this.cmd_InformationenMenue.Text = "Suchen / Filtern";
            this.cmd_InformationenMenue.UseVisualStyleBackColor = true;
            this.cmd_InformationenMenue.Click += new System.EventHandler(this.cmd_InformationenMenue_Click);
            // 
            // CmdLogout
            // 
            this.CmdLogout.Location = new System.Drawing.Point(282, 12);
            this.CmdLogout.Name = "CmdLogout";
            this.CmdLogout.Size = new System.Drawing.Size(61, 23);
            this.CmdLogout.TabIndex = 3;
            this.CmdLogout.Text = "Logout";
            this.CmdLogout.UseVisualStyleBackColor = true;
            this.CmdLogout.Click += new System.EventHandler(this.CmdLogout_Click);
            // 
            // LblNamen
            // 
            this.LblNamen.AutoSize = true;
            this.LblNamen.Location = new System.Drawing.Point(37, 303);
            this.LblNamen.Name = "LblNamen";
            this.LblNamen.Size = new System.Drawing.Size(285, 13);
            this.LblNamen.TabIndex = 4;
            this.LblNamen.Text = "Fabian Tavani, Joel Schlegel, Daniel Zoller, Dennis Riviello";
            // 
            // LblContactManager
            // 
            this.LblContactManager.AutoSize = true;
            this.LblContactManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContactManager.Location = new System.Drawing.Point(98, 44);
            this.LblContactManager.Name = "LblContactManager";
            this.LblContactManager.Size = new System.Drawing.Size(162, 24);
            this.LblContactManager.TabIndex = 5;
            this.LblContactManager.Text = "ContactManager";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ContectManager.Properties.Resources.LogoContactManager_75px;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 85);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Menue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 329);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblContactManager);
            this.Controls.Add(this.LblNamen);
            this.Controls.Add(this.CmdLogout);
            this.Controls.Add(this.cmd_InformationenMenue);
            this.Controls.Add(this.cmd_MitarbeiterMenue);
            this.Controls.Add(this.cmd_KundenMenue);
            this.Name = "Form_Menue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactManager";
            this.Load += new System.EventHandler(this.Form_Menue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_KundenMenue;
        private System.Windows.Forms.Button cmd_MitarbeiterMenue;
        private System.Windows.Forms.Button cmd_InformationenMenue;
        private System.Windows.Forms.Button CmdLogout;
        private System.Windows.Forms.Label LblNamen;
        private System.Windows.Forms.Label LblContactManager;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

