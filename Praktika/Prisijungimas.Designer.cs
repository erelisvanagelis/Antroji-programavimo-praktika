namespace Praktika
{
    partial class Prisijungimas
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
            this.label1 = new System.Windows.Forms.Label();
            this.prisijungimoBox = new System.Windows.Forms.TextBox();
            this.prisijungti = new System.Windows.Forms.Button();
            this.slaptBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prisijungimo vardas:";
            // 
            // prisijungimoBox
            // 
            this.prisijungimoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prisijungimoBox.Location = new System.Drawing.Point(186, 4);
            this.prisijungimoBox.Name = "prisijungimoBox";
            this.prisijungimoBox.Size = new System.Drawing.Size(100, 26);
            this.prisijungimoBox.TabIndex = 1;
            // 
            // prisijungti
            // 
            this.prisijungti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prisijungti.Location = new System.Drawing.Point(40, 68);
            this.prisijungti.Name = "prisijungti";
            this.prisijungti.Size = new System.Drawing.Size(246, 31);
            this.prisijungti.TabIndex = 2;
            this.prisijungti.Text = "Prisijungti";
            this.prisijungti.UseVisualStyleBackColor = true;
            this.prisijungti.Click += new System.EventHandler(this.Prisijungti_Click);
            // 
            // slaptBox
            // 
            this.slaptBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slaptBox.Location = new System.Drawing.Point(186, 36);
            this.slaptBox.Name = "slaptBox";
            this.slaptBox.Size = new System.Drawing.Size(100, 26);
            this.slaptBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Slaptazodis:";
            // 
            // Prisijungimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 108);
            this.Controls.Add(this.slaptBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prisijungti);
            this.Controls.Add(this.prisijungimoBox);
            this.Controls.Add(this.label1);
            this.Name = "Prisijungimas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Akademine sistema - prisijungimas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prisijungimoBox;
        private System.Windows.Forms.Button prisijungti;
        private System.Windows.Forms.TextBox slaptBox;
        private System.Windows.Forms.Label label2;
    }
}

