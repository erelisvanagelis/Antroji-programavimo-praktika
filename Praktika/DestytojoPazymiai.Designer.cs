namespace Praktika
{
    partial class DestytojoPazymiai
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
            this.DestytojoPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.balaiComboBox = new System.Windows.Forms.ComboBox();
            this.TipaiComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pazymiaiFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DestytojoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DestytojoPanel
            // 
            this.DestytojoPanel.Controls.Add(this.label4);
            this.DestytojoPanel.Controls.Add(this.button1);
            this.DestytojoPanel.Controls.Add(this.balaiComboBox);
            this.DestytojoPanel.Controls.Add(this.TipaiComboBox);
            this.DestytojoPanel.Controls.Add(this.label3);
            this.DestytojoPanel.Controls.Add(this.label2);
            this.DestytojoPanel.Controls.Add(this.dateTimePicker1);
            this.DestytojoPanel.Controls.Add(this.label1);
            this.DestytojoPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestytojoPanel.Location = new System.Drawing.Point(12, 12);
            this.DestytojoPanel.Name = "DestytojoPanel";
            this.DestytojoPanel.Size = new System.Drawing.Size(357, 426);
            this.DestytojoPanel.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(51, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Naujo pažymio įvedimas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Pridėti naują pažymį";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // balaiComboBox
            // 
            this.balaiComboBox.DisplayMember = "10";
            this.balaiComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.balaiComboBox.FormattingEnabled = true;
            this.balaiComboBox.Items.AddRange(new object[] {
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.balaiComboBox.Location = new System.Drawing.Point(101, 71);
            this.balaiComboBox.Name = "balaiComboBox";
            this.balaiComboBox.Size = new System.Drawing.Size(121, 28);
            this.balaiComboBox.TabIndex = 9;
            // 
            // TipaiComboBox
            // 
            this.TipaiComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipaiComboBox.FormattingEnabled = true;
            this.TipaiComboBox.Items.AddRange(new object[] {
            "Kontrolinis darbas",
            "Savarankiškas darbas",
            "Praktinis darbas",
            "Kursinis darbas",
            "Egzaminas",
            "Praktika"});
            this.TipaiComboBox.Location = new System.Drawing.Point(101, 39);
            this.TipaiComboBox.Name = "TipaiComboBox";
            this.TipaiComboBox.Size = new System.Drawing.Size(200, 28);
            this.TipaiComboBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Balas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipas:";
            // 
            // pazymiaiFlowLayoutPanel
            // 
            this.pazymiaiFlowLayoutPanel.Location = new System.Drawing.Point(375, 51);
            this.pazymiaiFlowLayoutPanel.Name = "pazymiaiFlowLayoutPanel";
            this.pazymiaiFlowLayoutPanel.Size = new System.Drawing.Size(584, 386);
            this.pazymiaiFlowLayoutPanel.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(707, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(585, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Balas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(440, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipas";
            // 
            // DestytojoPazymiai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pazymiaiFlowLayoutPanel);
            this.Controls.Add(this.DestytojoPanel);
            this.Name = "DestytojoPazymiai";
            this.Text = "DestytojoPazymiai";
            this.DestytojoPanel.ResumeLayout(false);
            this.DestytojoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DestytojoPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox balaiComboBox;
        private System.Windows.Forms.ComboBox TipaiComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pazymiaiFlowLayoutPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}