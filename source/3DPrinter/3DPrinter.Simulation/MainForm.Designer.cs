namespace _3DPrinter.Simulation
{
    partial class MainForm
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
            this.printArea1 = new _3DPrinter.Simulation.PrintArea();
            this.SuspendLayout();
            // 
            // printArea1
            // 
            this.printArea1.BackColor = System.Drawing.Color.Gray;
            this.printArea1.Location = new System.Drawing.Point(74, 42);
            this.printArea1.MaximumSize = new System.Drawing.Size(400, 400);
            this.printArea1.MinimumSize = new System.Drawing.Size(400, 400);
            this.printArea1.Name = "printArea1";
            this.printArea1.Size = new System.Drawing.Size(400, 400);
            this.printArea1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 530);
            this.Controls.Add(this.printArea1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private PrintArea printArea1;
    }
}

