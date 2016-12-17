namespace DeltaPrinter.Simulation
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
            DeltaPrinter.Simulation.DeltaPrinterView.AppearanceSettings appearanceSettings1 = new DeltaPrinter.Simulation.DeltaPrinterView.AppearanceSettings();
            DeltaPrinter.Simulation.DeltaPrinterView.AppeareancePen appeareancePen1 = new DeltaPrinter.Simulation.DeltaPrinterView.AppeareancePen();
            DeltaPrinter.Simulation.DeltaPrinterView.AppeareancePen appeareancePen2 = new DeltaPrinter.Simulation.DeltaPrinterView.AppeareancePen();
            DeltaPrinter.Simulation.DeltaPrinterView.AppeareancePen appeareancePen3 = new DeltaPrinter.Simulation.DeltaPrinterView.AppeareancePen();
            this.delterPrinterView = new DeltaPrinter.Simulation.DeltaPrinterView.DeltaPrinterView();
            this.SuspendLayout();
            // 
            // delterPrinterView
            // 
            appearanceSettings1.CoilCoolerColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            appearanceSettings1.CoilHeaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            appeareancePen1.Color = System.Drawing.Color.DarkSlateGray;
            appeareancePen1.Width = 3;
            appearanceSettings1.ConnectorBigPen = appeareancePen1;
            appearanceSettings1.GroundPlateColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            appearanceSettings1.HeadAxisConnector = System.Drawing.Color.LightGray;
            appearanceSettings1.HeatPlateColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            appearanceSettings1.PrintHeadPlateColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            appearanceSettings1.Smoothing = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            appeareancePen2.Color = System.Drawing.Color.Black;
            appeareancePen2.Width = 4;
            appearanceSettings1.StrokeBig = appeareancePen2;
            appeareancePen3.Color = System.Drawing.Color.Black;
            appeareancePen3.Width = 1;
            appearanceSettings1.StrokeSmall = appeareancePen3;
            this.delterPrinterView.Appearance = appearanceSettings1;
            this.delterPrinterView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delterPrinterView.Enabled = false;
            this.delterPrinterView.Location = new System.Drawing.Point(58, 39);
            this.delterPrinterView.MaximumSize = new System.Drawing.Size(400, 400);
            this.delterPrinterView.MinimumSize = new System.Drawing.Size(400, 400);
            this.delterPrinterView.Name = "delterPrinterView";
            this.delterPrinterView.Size = new System.Drawing.Size(400, 400);
            this.delterPrinterView.TabIndex = 0;
            this.delterPrinterView.OnDirectMove += new DeltaPrinter.Simulation.DeltaPrinterView.DeltaPrinterView.DirectMovementEventHandler(this.delterPrinterView_OnDirectMove);
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

