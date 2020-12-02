namespace Praktika
{
    partial class AsmuoControl
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
            this.vardasLabel = new System.Windows.Forms.Label();
            this.pavardeLabel = new System.Windows.Forms.Label();
            this.grupeLabel = new System.Windows.Forms.Label();
            this.prisijungimoVLabel = new System.Windows.Forms.Label();
            this.slaptazodisLabel = new System.Windows.Forms.Label();
            this.salintiButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(1, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(57, 20);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ilgas id";
            // 
            // vardasLabel
            // 
            this.vardasLabel.AutoSize = true;
            this.vardasLabel.Location = new System.Drawing.Point(64, 0);
            this.vardasLabel.Name = "vardasLabel";
            this.vardasLabel.Size = new System.Drawing.Size(98, 20);
            this.vardasLabel.TabIndex = 1;
            this.vardasLabel.Text = "Ilgas Vardas";
            // 
            // pavardeLabel
            // 
            this.pavardeLabel.AutoSize = true;
            this.pavardeLabel.Location = new System.Drawing.Point(168, 0);
            this.pavardeLabel.Name = "pavardeLabel";
            this.pavardeLabel.Size = new System.Drawing.Size(97, 20);
            this.pavardeLabel.TabIndex = 2;
            this.pavardeLabel.Text = "Ilga Pavarde";
            // 
            // grupeLabel
            // 
            this.grupeLabel.AutoSize = true;
            this.grupeLabel.Location = new System.Drawing.Point(284, 0);
            this.grupeLabel.Name = "grupeLabel";
            this.grupeLabel.Size = new System.Drawing.Size(80, 20);
            this.grupeLabel.TabIndex = 3;
            this.grupeLabel.Text = "Ilga grupe";
            // 
            // prisijungimoVLabel
            // 
            this.prisijungimoVLabel.AutoSize = true;
            this.prisijungimoVLabel.Location = new System.Drawing.Point(370, 0);
            this.prisijungimoVLabel.Name = "prisijungimoVLabel";
            this.prisijungimoVLabel.Size = new System.Drawing.Size(103, 20);
            this.prisijungimoVLabel.TabIndex = 4;
            this.prisijungimoVLabel.Text = "prisijungimoV";
            // 
            // slaptazodisLabel
            // 
            this.slaptazodisLabel.AutoSize = true;
            this.slaptazodisLabel.Location = new System.Drawing.Point(479, 0);
            this.slaptazodisLabel.Name = "slaptazodisLabel";
            this.slaptazodisLabel.Size = new System.Drawing.Size(127, 20);
            this.slaptazodisLabel.TabIndex = 5;
            this.slaptazodisLabel.Text = "Ilgas slaptazodis";
            // 
            // salintiButton
            // 
            this.salintiButton.Location = new System.Drawing.Point(601, -6);
            this.salintiButton.Name = "salintiButton";
            this.salintiButton.Size = new System.Drawing.Size(76, 31);
            this.salintiButton.TabIndex = 6;
            this.salintiButton.Text = "Pašalinti";
            this.salintiButton.UseVisualStyleBackColor = true;
            this.salintiButton.Click += new System.EventHandler(this.SalintiButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pavardeLabel);
            this.panel1.Controls.Add(this.salintiButton);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.slaptazodisLabel);
            this.panel1.Controls.Add(this.vardasLabel);
            this.panel1.Controls.Add(this.prisijungimoVLabel);
            this.panel1.Controls.Add(this.grupeLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 22);
            this.panel1.TabIndex = 7;
            // 
            // AsmuoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.Name = "AsmuoControl";
            this.Size = new System.Drawing.Size(683, 28);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label vardasLabel;
        private System.Windows.Forms.Label pavardeLabel;
        private System.Windows.Forms.Label grupeLabel;
        private System.Windows.Forms.Label prisijungimoVLabel;
        private System.Windows.Forms.Label slaptazodisLabel;
        private System.Windows.Forms.Button salintiButton;
        private System.Windows.Forms.Panel panel1;
    }
}
