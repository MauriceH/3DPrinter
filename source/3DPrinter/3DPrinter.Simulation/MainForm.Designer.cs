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
            this.delterPrinterView = new DeltaPrinterView.DeltaPrinterView();
            this.SuspendLayout();
            // 
            // delterPrinterView
            // 
            this.delterPrinterView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delterPrinterView.Location = new System.Drawing.Point(24, 33);
            this.delterPrinterView.MaximumSize = new System.Drawing.Size(400, 400);
            this.delterPrinterView.MinimumSize = new System.Drawing.Size(400, 400);
            this.delterPrinterView.Name = "delterPrinterView";
            this.delterPrinterView.Size = new System.Drawing.Size(400, 400);
            this.delterPrinterView.TabIndex = 0;
            this.delterPrinterView.OnDirectMove += new DeltaPrinterView.DeltaPrinterView.DirectMovementEventHandler(this.delterPrinterView_OnDirectMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 530);
            this.Controls.Add(this.delterPrinterView);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DeltaPrinterView.DeltaPrinterView delterPrinterView;
    }
}

