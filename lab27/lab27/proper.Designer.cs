namespace lab27
{
    partial class proper
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
            this.Name_txt = new System.Windows.Forms.Label();
            this.Date_txt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Path_txt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Format_txt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DateAccess_txt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва елементу:";
            // 
            // Name_txt
            // 
            this.Name_txt.AutoSize = true;
            this.Name_txt.Location = new System.Drawing.Point(137, 9);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(0, 16);
            this.Name_txt.TabIndex = 1;
            // 
            // Date_txt
            // 
            this.Date_txt.AutoSize = true;
            this.Date_txt.Location = new System.Drawing.Point(137, 32);
            this.Date_txt.Name = "Date_txt";
            this.Date_txt.Size = new System.Drawing.Size(0, 16);
            this.Date_txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата створення:";
            // 
            // Path_txt
            // 
            this.Path_txt.AutoSize = true;
            this.Path_txt.Location = new System.Drawing.Point(12, 115);
            this.Path_txt.Name = "Path_txt";
            this.Path_txt.Size = new System.Drawing.Size(0, 16);
            this.Path_txt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Повний шлях до файлу:";
            // 
            // Format_txt
            // 
            this.Format_txt.AutoSize = true;
            this.Format_txt.Location = new System.Drawing.Point(109, 73);
            this.Format_txt.Name = "Format_txt";
            this.Format_txt.Size = new System.Drawing.Size(0, 16);
            this.Format_txt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Розширення:";
            // 
            // DateAccess_txt
            // 
            this.DateAccess_txt.AutoSize = true;
            this.DateAccess_txt.Location = new System.Drawing.Point(204, 53);
            this.DateAccess_txt.Name = "DateAccess_txt";
            this.DateAccess_txt.Size = new System.Drawing.Size(0, 16);
            this.DateAccess_txt.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Дата останнього відкриття:";
            // 
            // proper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 178);
            this.Controls.Add(this.DateAccess_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Format_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Path_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Date_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "proper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Properties";
            this.Load += new System.EventHandler(this.proper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name_txt;
        private System.Windows.Forms.Label Date_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Path_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Format_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DateAccess_txt;
        private System.Windows.Forms.Label label7;
    }
}