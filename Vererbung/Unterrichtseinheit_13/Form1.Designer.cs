
namespace Unterrichtseinheit_13
{
    partial class Form1
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
            this.CmdStart = new System.Windows.Forms.Button();
            this.TxtOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdStart
            // 
            this.CmdStart.Location = new System.Drawing.Point(12, 41);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(164, 47);
            this.CmdStart.TabIndex = 0;
            this.CmdStart.Text = "Starte Demo";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // TxtOut
            // 
            this.TxtOut.Location = new System.Drawing.Point(12, 94);
            this.TxtOut.Multiline = true;
            this.TxtOut.Name = "TxtOut";
            this.TxtOut.Size = new System.Drawing.Size(776, 273);
            this.TxtOut.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Themenkreis Vererbung";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtOut);
            this.Controls.Add(this.CmdStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdStart;
        private System.Windows.Forms.TextBox TxtOut;
        private System.Windows.Forms.Label label1;
    }
}

