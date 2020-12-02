namespace Praktika
{
    partial class Studento
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
            this.dalykaiFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pazymiaiFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tipaslabel = new System.Windows.Forms.Label();
            this.dataLabel = new System.Windows.Forms.Label();
            this.pazimysLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dalykaiFlowLayoutPanel
            // 
            this.dalykaiFlowLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dalykaiFlowLayoutPanel.Location = new System.Drawing.Point(13, 13);
            this.dalykaiFlowLayoutPanel.Name = "dalykaiFlowLayoutPanel";
            this.dalykaiFlowLayoutPanel.Size = new System.Drawing.Size(357, 425);
            this.dalykaiFlowLayoutPanel.TabIndex = 0;
            // 
            // pazymiaiFlowLayoutPanel
            // 
            this.pazymiaiFlowLayoutPanel.AutoScroll = true;
            this.pazymiaiFlowLayoutPanel.Location = new System.Drawing.Point(376, 42);
            this.pazymiaiFlowLayoutPanel.Name = "pazymiaiFlowLayoutPanel";
            this.pazymiaiFlowLayoutPanel.Size = new System.Drawing.Size(430, 396);
            this.pazymiaiFlowLayoutPanel.TabIndex = 1;
            // 
            // tipaslabel
            // 
            this.tipaslabel.AutoSize = true;
            this.tipaslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tipaslabel.Location = new System.Drawing.Point(420, 13);
            this.tipaslabel.Name = "tipaslabel";
            this.tipaslabel.Size = new System.Drawing.Size(64, 26);
            this.tipaslabel.TabIndex = 7;
            this.tipaslabel.Text = "Tipas";
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dataLabel.Location = new System.Drawing.Point(669, 13);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(58, 26);
            this.dataLabel.TabIndex = 6;
            this.dataLabel.Text = "Data";
            // 
            // pazimysLabel
            // 
            this.pazimysLabel.AutoSize = true;
            this.pazimysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.pazimysLabel.Location = new System.Drawing.Point(556, 13);
            this.pazimysLabel.Name = "pazimysLabel";
            this.pazimysLabel.Size = new System.Drawing.Size(67, 26);
            this.pazimysLabel.TabIndex = 5;
            this.pazimysLabel.Text = "Balas";
            // 
            // Studento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.tipaslabel);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.pazimysLabel);
            this.Controls.Add(this.pazymiaiFlowLayoutPanel);
            this.Controls.Add(this.dalykaiFlowLayoutPanel);
            this.Name = "Studento";
            this.Text = "Studento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel dalykaiFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel pazymiaiFlowLayoutPanel;
        private System.Windows.Forms.Label tipaslabel;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Label pazimysLabel;
    }
}