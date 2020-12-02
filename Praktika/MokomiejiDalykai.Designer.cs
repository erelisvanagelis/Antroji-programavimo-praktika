namespace Praktika
{
    partial class MokomiejiDalykai
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
            this.PridėtiButton = new System.Windows.Forms.Button();
            this.destytojasComboBox = new System.Windows.Forms.ComboBox();
            this.Pavadinimas = new System.Windows.Forms.Label();
            this.pavadinimasTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dalykaiFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PridėtiButton
            // 
            this.PridėtiButton.Location = new System.Drawing.Point(17, 120);
            this.PridėtiButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PridėtiButton.Name = "PridėtiButton";
            this.PridėtiButton.Size = new System.Drawing.Size(300, 35);
            this.PridėtiButton.TabIndex = 0;
            this.PridėtiButton.Text = "Pridėti mokomajį dalyką";
            this.PridėtiButton.UseVisualStyleBackColor = true;
            this.PridėtiButton.Click += new System.EventHandler(this.PridėtiButton_Click);
            // 
            // destytojasComboBox
            // 
            this.destytojasComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.destytojasComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.destytojasComboBox.FormattingEnabled = true;
            this.destytojasComboBox.Location = new System.Drawing.Point(111, 82);
            this.destytojasComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.destytojasComboBox.Name = "destytojasComboBox";
            this.destytojasComboBox.Size = new System.Drawing.Size(206, 28);
            this.destytojasComboBox.TabIndex = 1;
            // 
            // Pavadinimas
            // 
            this.Pavadinimas.AutoSize = true;
            this.Pavadinimas.Location = new System.Drawing.Point(1, 49);
            this.Pavadinimas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pavadinimas.Name = "Pavadinimas";
            this.Pavadinimas.Size = new System.Drawing.Size(102, 20);
            this.Pavadinimas.TabIndex = 2;
            this.Pavadinimas.Text = "Pavadinimas:";
            // 
            // pavadinimasTextBox
            // 
            this.pavadinimasTextBox.Location = new System.Drawing.Point(111, 46);
            this.pavadinimasTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pavadinimasTextBox.Name = "pavadinimasTextBox";
            this.pavadinimasTextBox.Size = new System.Drawing.Size(206, 26);
            this.pavadinimasTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Destytojas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naujo mokomojo dalyko pridėjimas";
            // 
            // dalykaiFlowLayoutPanel
            // 
            this.dalykaiFlowLayoutPanel.AutoScroll = true;
            this.dalykaiFlowLayoutPanel.Location = new System.Drawing.Point(324, 46);
            this.dalykaiFlowLayoutPanel.Name = "dalykaiFlowLayoutPanel";
            this.dalykaiFlowLayoutPanel.Size = new System.Drawing.Size(763, 507);
            this.dalykaiFlowLayoutPanel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(420, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pavadinimas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(610, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Destytojo Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(724, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vardas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(862, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Pavarde";
            // 
            // MokomiejiDalykai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 565);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dalykaiFlowLayoutPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pavadinimasTextBox);
            this.Controls.Add(this.Pavadinimas);
            this.Controls.Add(this.destytojasComboBox);
            this.Controls.Add(this.PridėtiButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MokomiejiDalykai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MokomiejiDalykai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PridėtiButton;
        private System.Windows.Forms.ComboBox destytojasComboBox;
        private System.Windows.Forms.Label Pavadinimas;
        private System.Windows.Forms.TextBox pavadinimasTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel dalykaiFlowLayoutPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}