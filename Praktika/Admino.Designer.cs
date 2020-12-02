namespace Praktika
{
    partial class Admino
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
            this.naudotojaiButton = new System.Windows.Forms.Button();
            this.dalykuButton = new System.Windows.Forms.Button();
            this.destytojasDalykasButton = new System.Windows.Forms.Button();
            this.dalykoGrupesButton = new System.Windows.Forms.Button();
            this.studentoGrupesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // naudotojaiButton
            // 
            this.naudotojaiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naudotojaiButton.Location = new System.Drawing.Point(13, 13);
            this.naudotojaiButton.Name = "naudotojaiButton";
            this.naudotojaiButton.Size = new System.Drawing.Size(233, 34);
            this.naudotojaiButton.TabIndex = 0;
            this.naudotojaiButton.Text = "Grupių - naudotojų valdymas";
            this.naudotojaiButton.UseVisualStyleBackColor = true;
            this.naudotojaiButton.Click += new System.EventHandler(this.NaudotojaiButton_Click);
            // 
            // dalykuButton
            // 
            this.dalykuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dalykuButton.Location = new System.Drawing.Point(12, 53);
            this.dalykuButton.Name = "dalykuButton";
            this.dalykuButton.Size = new System.Drawing.Size(233, 34);
            this.dalykuButton.TabIndex = 2;
            this.dalykuButton.Text = "Mokomųjų dalykų valdymas";
            this.dalykuButton.UseVisualStyleBackColor = true;
            this.dalykuButton.Click += new System.EventHandler(this.DalykuButton_Click);
            // 
            // destytojasDalykasButton
            // 
            this.destytojasDalykasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destytojasDalykasButton.Location = new System.Drawing.Point(12, 93);
            this.destytojasDalykasButton.Name = "destytojasDalykasButton";
            this.destytojasDalykasButton.Size = new System.Drawing.Size(233, 34);
            this.destytojasDalykasButton.TabIndex = 3;
            this.destytojasDalykasButton.Text = "Dėstytojo - dalyko susiejimas";
            this.destytojasDalykasButton.UseVisualStyleBackColor = true;
            this.destytojasDalykasButton.Click += new System.EventHandler(this.DestytojasDalykasButton_Click);
            // 
            // dalykoGrupesButton
            // 
            this.dalykoGrupesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dalykoGrupesButton.Location = new System.Drawing.Point(12, 133);
            this.dalykoGrupesButton.Name = "dalykoGrupesButton";
            this.dalykoGrupesButton.Size = new System.Drawing.Size(233, 34);
            this.dalykoGrupesButton.TabIndex = 4;
            this.dalykoGrupesButton.Text = "Dalyko - grupės susiejimas";
            this.dalykoGrupesButton.UseVisualStyleBackColor = true;
            this.dalykoGrupesButton.Click += new System.EventHandler(this.DalykoGrupesButton_Click);
            // 
            // studentoGrupesButton
            // 
            this.studentoGrupesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentoGrupesButton.Location = new System.Drawing.Point(12, 173);
            this.studentoGrupesButton.Name = "studentoGrupesButton";
            this.studentoGrupesButton.Size = new System.Drawing.Size(233, 34);
            this.studentoGrupesButton.TabIndex = 5;
            this.studentoGrupesButton.Text = "Studento - grupės susiejimas";
            this.studentoGrupesButton.UseVisualStyleBackColor = true;
            this.studentoGrupesButton.Click += new System.EventHandler(this.StudentoGrupesButton_Click);
            // 
            // Admino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 213);
            this.Controls.Add(this.studentoGrupesButton);
            this.Controls.Add(this.dalykoGrupesButton);
            this.Controls.Add(this.destytojasDalykasButton);
            this.Controls.Add(this.dalykuButton);
            this.Controls.Add(this.naudotojaiButton);
            this.Name = "Admino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admino";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button naudotojaiButton;
        private System.Windows.Forms.Button dalykuButton;
        private System.Windows.Forms.Button destytojasDalykasButton;
        private System.Windows.Forms.Button dalykoGrupesButton;
        private System.Windows.Forms.Button studentoGrupesButton;
    }
}