namespace Loi_Chao_Desktop
{
    partial class Form1
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
            this.Th_Ho_Ten = new System.Windows.Forms.TextBox();
            this.Th_Loi_Chao = new System.Windows.Forms.Label();
            this.dongy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Th_Ho_Ten
            // 
            this.Th_Ho_Ten.Location = new System.Drawing.Point(12, 25);
            this.Th_Ho_Ten.Name = "Th_Ho_Ten";
            this.Th_Ho_Ten.Size = new System.Drawing.Size(281, 20);
            this.Th_Ho_Ten.TabIndex = 0;
            // 
            // Th_Loi_Chao
            // 
            this.Th_Loi_Chao.AutoSize = true;
            this.Th_Loi_Chao.Location = new System.Drawing.Point(12, 65);
            this.Th_Loi_Chao.Name = "Th_Loi_Chao";
            this.Th_Loi_Chao.Size = new System.Drawing.Size(35, 13);
            this.Th_Loi_Chao.TabIndex = 1;
            this.Th_Loi_Chao.Text = "label1";
            // 
            // dongy
            // 
            this.dongy.Location = new System.Drawing.Point(12, 150);
            this.dongy.Name = "dongy";
            this.dongy.Size = new System.Drawing.Size(86, 23);
            this.dongy.TabIndex = 2;
            this.dongy.Text = "button1";
            this.dongy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 291);
            this.Controls.Add(this.dongy);
            this.Controls.Add(this.Th_Loi_Chao);
            this.Controls.Add(this.Th_Ho_Ten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Th_Ho_Ten;
        private System.Windows.Forms.Label Th_Loi_Chao;
        private System.Windows.Forms.Button dongy;
    }
}

