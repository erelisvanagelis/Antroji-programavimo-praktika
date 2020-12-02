namespace Praktika
{
    partial class DalykasControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.idLabel = new System.Windows.Forms.Label();
            this.pavadinimasLabel = new System.Windows.Forms.Label();
            this.destytojoIdLabel = new System.Windows.Forms.Label();
            this.vardasLabel = new System.Windows.Forms.Label();
            this.pavardeLabel = new System.Windows.Forms.Label();
            this.pasalantiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(4, 4);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(53, 20);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ilgasid";
            // 
            // pavadinimasLabel
            // 
            this.pavadinimasLabel.AutoSize = true;
            this.pavadinimasLabel.Location = new System.Drawing.Point(48, 4);
            this.pavadinimasLabel.Name = "pavadinimasLabel";
            this.pavadinimasLabel.Size = new System.Drawing.Size(210, 20);
            this.pavadinimasLabel.TabIndex = 1;
            this.pavadinimasLabel.Text = "LabaiLabaiIlgasPavadinimas";
            // 
            // destytojoIdLabel
            // 
            this.destytojoIdLabel.AutoSize = true;
            this.destytojoIdLabel.Location = new System.Drawing.Point(323, 4);
            this.destytojoIdLabel.Name = "destytojoIdLabel";
            this.destytojoIdLabel.Size = new System.Drawing.Size(90, 20);
            this.destytojoIdLabel.TabIndex = 2;
            this.destytojoIdLabel.Text = "DestytojoId";
            // 
            // vardasLabel
            // 
            this.vardasLabel.AutoSize = true;
            this.vardasLabel.Location = new System.Drawing.Point(397, 4);
            this.vardasLabel.Name = "vardasLabel";
            this.vardasLabel.Size = new System.Drawing.Size(131, 20);
            this.vardasLabel.TabIndex = 3;
            this.vardasLabel.Text = "Destytojo Vardas";
            // 
            // pavardeLabel
            // 
            this.pavardeLabel.AutoSize = true;
            this.pavardeLabel.Location = new System.Drawing.Point(534, 4);
            this.pavardeLabel.Name = "pavardeLabel";
            this.pavardeLabel.Size = new System.Drawing.Size(138, 20);
            this.pavardeLabel.TabIndex = 4;
            this.pavardeLabel.Text = "Destytojo Pavarde";
            // 
            // pasalantiButton
            // 
            this.pasalantiButton.Location = new System.Drawing.Point(655, 2);
            this.pasalantiButton.Name = "pasalantiButton";
            this.pasalantiButton.Size = new System.Drawing.Size(83, 24);
            this.pasalantiButton.TabIndex = 5;
            this.pasalantiButton.Text = "Pašalinti";
            this.pasalantiButton.UseVisualStyleBackColor = true;
            this.pasalantiButton.Click += new System.EventHandler(this.PasalantiButton_Click);
            // 
            // DalykasControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pasalantiButton);
            this.Controls.Add(this.pavardeLabel);
            this.Controls.Add(this.vardasLabel);
            this.Controls.Add(this.destytojoIdLabel);
            this.Controls.Add(this.pavadinimasLabel);
            this.Controls.Add(this.idLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DalykasControl";
            this.Size = new System.Drawing.Size(738, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label pavadinimasLabel;
        private System.Windows.Forms.Label destytojoIdLabel;
        private System.Windows.Forms.Label vardasLabel;
        private System.Windows.Forms.Label pavardeLabel;
        private System.Windows.Forms.Button pasalantiButton;
    }
}
