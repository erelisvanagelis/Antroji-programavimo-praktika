namespace Praktika
{
    partial class GrupeControl
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
            this.grupeButton = new System.Windows.Forms.Button();
            this.salintButton = new System.Windows.Forms.Button();
            this.suNariaisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grupeButton
            // 
            this.grupeButton.Location = new System.Drawing.Point(3, 3);
            this.grupeButton.Name = "grupeButton";
            this.grupeButton.Size = new System.Drawing.Size(85, 70);
            this.grupeButton.TabIndex = 0;
            this.grupeButton.Text = "pavadinimas";
            this.grupeButton.UseVisualStyleBackColor = true;
            this.grupeButton.Click += new System.EventHandler(this.GrupeButton_Click);
            // 
            // salintButton
            // 
            this.salintButton.Location = new System.Drawing.Point(94, 3);
            this.salintButton.Name = "salintButton";
            this.salintButton.Size = new System.Drawing.Size(134, 32);
            this.salintButton.TabIndex = 1;
            this.salintButton.Text = "Grupę";
            this.salintButton.UseVisualStyleBackColor = true;
            this.salintButton.Click += new System.EventHandler(this.SalintButton_Click);
            // 
            // suNariaisButton
            // 
            this.suNariaisButton.Location = new System.Drawing.Point(94, 41);
            this.suNariaisButton.Name = "suNariaisButton";
            this.suNariaisButton.Size = new System.Drawing.Size(134, 32);
            this.suNariaisButton.TabIndex = 3;
            this.suNariaisButton.Text = "Grupę su nariais";
            this.suNariaisButton.UseVisualStyleBackColor = true;
            this.suNariaisButton.Click += new System.EventHandler(this.SuNariaisButton_Click);
            // 
            // GrupeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.suNariaisButton);
            this.Controls.Add(this.salintButton);
            this.Controls.Add(this.grupeButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "GrupeControl";
            this.Size = new System.Drawing.Size(233, 78);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button grupeButton;
        private System.Windows.Forms.Button salintButton;
        private System.Windows.Forms.Button suNariaisButton;
    }
}
