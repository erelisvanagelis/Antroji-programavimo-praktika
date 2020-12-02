namespace Praktika
{
    partial class Destytojo
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
            this.dalykoFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.grupesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.studentoFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // dalykoFlowLayoutPanel
            // 
            this.dalykoFlowLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dalykoFlowLayoutPanel.Location = new System.Drawing.Point(13, 13);
            this.dalykoFlowLayoutPanel.Name = "dalykoFlowLayoutPanel";
            this.dalykoFlowLayoutPanel.Size = new System.Drawing.Size(310, 425);
            this.dalykoFlowLayoutPanel.TabIndex = 0;
            // 
            // grupesFlowLayoutPanel
            // 
            this.grupesFlowLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupesFlowLayoutPanel.Location = new System.Drawing.Point(329, 13);
            this.grupesFlowLayoutPanel.Name = "grupesFlowLayoutPanel";
            this.grupesFlowLayoutPanel.Size = new System.Drawing.Size(189, 425);
            this.grupesFlowLayoutPanel.TabIndex = 1;
            // 
            // studentoFlowLayoutPanel
            // 
            this.studentoFlowLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentoFlowLayoutPanel.Location = new System.Drawing.Point(524, 13);
            this.studentoFlowLayoutPanel.Name = "studentoFlowLayoutPanel";
            this.studentoFlowLayoutPanel.Size = new System.Drawing.Size(250, 425);
            this.studentoFlowLayoutPanel.TabIndex = 2;
            // 
            // Destytojo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.studentoFlowLayoutPanel);
            this.Controls.Add(this.grupesFlowLayoutPanel);
            this.Controls.Add(this.dalykoFlowLayoutPanel);
            this.Name = "Destytojo";
            this.Text = "Destytojo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel dalykoFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel grupesFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel studentoFlowLayoutPanel;
    }
}