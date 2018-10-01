namespace TerbilangApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputnominal = new System.Windows.Forms.TextBox();
            this.terbilang = new System.Windows.Forms.ListBox();
            this.btnCek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nominal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Terbilang";
            // 
            // inputnominal
            // 
            this.inputnominal.Location = new System.Drawing.Point(91, 25);
            this.inputnominal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputnominal.Name = "inputnominal";
            this.inputnominal.Size = new System.Drawing.Size(115, 20);
            this.inputnominal.TabIndex = 2;
            // 
            // terbilang
            // 
            this.terbilang.FormattingEnabled = true;
            this.terbilang.Location = new System.Drawing.Point(91, 70);
            this.terbilang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.terbilang.Name = "terbilang";
            this.terbilang.Size = new System.Drawing.Size(499, 69);
            this.terbilang.TabIndex = 3;
            this.terbilang.SelectedIndexChanged += new System.EventHandler(this.hasilterbilang_SelectedIndexChanged);
            // 
            // btnCek
            // 
            this.btnCek.Location = new System.Drawing.Point(224, 23);
            this.btnCek.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(82, 21);
            this.btnCek.TabIndex = 4;
            this.btnCek.Text = "Cek Terbilang";
            this.btnCek.UseVisualStyleBackColor = true;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 183);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.terbilang);
            this.Controls.Add(this.inputnominal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputnominal;
        private System.Windows.Forms.ListBox terbilang;
        private System.Windows.Forms.Button btnCek;
    }
}

