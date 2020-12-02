namespace Praktika
{
    partial class DestytojoPazimysControl
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
            this.patvirtintiButton = new System.Windows.Forms.Button();
            this.tipasComboBox = new System.Windows.Forms.ComboBox();
            this.balasComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Trinti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patvirtintiButton
            // 
            this.patvirtintiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patvirtintiButton.Location = new System.Drawing.Point(424, 6);
            this.patvirtintiButton.Name = "patvirtintiButton";
            this.patvirtintiButton.Size = new System.Drawing.Size(92, 28);
            this.patvirtintiButton.TabIndex = 10;
            this.patvirtintiButton.Text = "Patvirtinti";
            this.patvirtintiButton.UseVisualStyleBackColor = true;
            this.patvirtintiButton.Click += new System.EventHandler(this.PatvirtintiButton_Click);
            // 
            // tipasComboBox
            // 
            this.tipasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipasComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipasComboBox.FormattingEnabled = true;
            this.tipasComboBox.Items.AddRange(new object[] {
            "Kontrolinis darbas",
            "Savarankiškas darbas",
            "Praktinis darbas",
            "Kursinis darbas",
            "Egzaminas",
            "Praktika"});
            this.tipasComboBox.Location = new System.Drawing.Point(18, 6);
            this.tipasComboBox.Name = "tipasComboBox";
            this.tipasComboBox.Size = new System.Drawing.Size(171, 28);
            this.tipasComboBox.TabIndex = 18;
            // 
            // balasComboBox
            // 
            this.balasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.balasComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balasComboBox.FormattingEnabled = true;
            this.balasComboBox.Items.AddRange(new object[] {
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
            this.balasComboBox.Location = new System.Drawing.Point(218, 6);
            this.balasComboBox.Name = "balasComboBox";
            this.balasComboBox.Size = new System.Drawing.Size(61, 28);
            this.balasComboBox.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(298, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 26);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // Trinti
            // 
            this.Trinti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trinti.Location = new System.Drawing.Point(534, 6);
            this.Trinti.Name = "Trinti";
            this.Trinti.Size = new System.Drawing.Size(31, 26);
            this.Trinti.TabIndex = 21;
            this.Trinti.Text = "X";
            this.Trinti.UseVisualStyleBackColor = true;
            this.Trinti.Click += new System.EventHandler(this.Trinti_Click);
            // 
            // DestytojoPazimysControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.Trinti);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.balasComboBox);
            this.Controls.Add(this.tipasComboBox);
            this.Controls.Add(this.patvirtintiButton);
            this.Name = "DestytojoPazimysControl";
            this.Size = new System.Drawing.Size(568, 38);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button patvirtintiButton;
        private System.Windows.Forms.ComboBox tipasComboBox;
        private System.Windows.Forms.ComboBox balasComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Trinti;
    }
}
