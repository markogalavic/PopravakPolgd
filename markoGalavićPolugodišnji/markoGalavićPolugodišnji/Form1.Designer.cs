namespace markoGalavićPolugodišnji
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
            this.Unesibutton = new System.Windows.Forms.Button();
            this.Obradibutton = new System.Windows.Forms.Button();
            this.Ispisibutton = new System.Windows.Forms.Button();
            this.ImetextBox1 = new System.Windows.Forms.TextBox();
            this.PrezimetextBox1 = new System.Windows.Forms.TextBox();
            this.OibtextBox1 = new System.Windows.Forms.TextBox();
            this.SpoltextBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Unesibutton
            // 
            this.Unesibutton.Location = new System.Drawing.Point(283, 76);
            this.Unesibutton.Name = "Unesibutton";
            this.Unesibutton.Size = new System.Drawing.Size(125, 58);
            this.Unesibutton.TabIndex = 0;
            this.Unesibutton.Text = "Unesi ";
            this.Unesibutton.UseVisualStyleBackColor = true;
            this.Unesibutton.Click += new System.EventHandler(this.Unesibutton_Click);
            // 
            // Obradibutton
            // 
            this.Obradibutton.Location = new System.Drawing.Point(452, 76);
            this.Obradibutton.Name = "Obradibutton";
            this.Obradibutton.Size = new System.Drawing.Size(124, 57);
            this.Obradibutton.TabIndex = 1;
            this.Obradibutton.Text = "Obradi";
            this.Obradibutton.UseVisualStyleBackColor = true;
            this.Obradibutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ispisibutton
            // 
            this.Ispisibutton.Location = new System.Drawing.Point(631, 76);
            this.Ispisibutton.Name = "Ispisibutton";
            this.Ispisibutton.Size = new System.Drawing.Size(128, 56);
            this.Ispisibutton.TabIndex = 2;
            this.Ispisibutton.Text = "Ispiši";
            this.Ispisibutton.UseVisualStyleBackColor = true;
            this.Ispisibutton.Click += new System.EventHandler(this.Ispisibutton_Click);
            // 
            // ImetextBox1
            // 
            this.ImetextBox1.Location = new System.Drawing.Point(44, 76);
            this.ImetextBox1.Name = "ImetextBox1";
            this.ImetextBox1.Size = new System.Drawing.Size(177, 20);
            this.ImetextBox1.TabIndex = 3;
            this.ImetextBox1.TextChanged += new System.EventHandler(this.ImetextBox1_TextChanged);
            // 
            // PrezimetextBox1
            // 
            this.PrezimetextBox1.Location = new System.Drawing.Point(44, 128);
            this.PrezimetextBox1.Name = "PrezimetextBox1";
            this.PrezimetextBox1.Size = new System.Drawing.Size(177, 20);
            this.PrezimetextBox1.TabIndex = 4;
            this.PrezimetextBox1.TextChanged += new System.EventHandler(this.PrezimetextBox1_TextChanged);
            // 
            // OibtextBox1
            // 
            this.OibtextBox1.Location = new System.Drawing.Point(44, 176);
            this.OibtextBox1.Name = "OibtextBox1";
            this.OibtextBox1.Size = new System.Drawing.Size(177, 20);
            this.OibtextBox1.TabIndex = 5;
            this.OibtextBox1.TextChanged += new System.EventHandler(this.OibtextBox1_TextChanged);
            // 
            // SpoltextBox1
            // 
            this.SpoltextBox1.Location = new System.Drawing.Point(44, 229);
            this.SpoltextBox1.Name = "SpoltextBox1";
            this.SpoltextBox1.Size = new System.Drawing.Size(177, 20);
            this.SpoltextBox1.TabIndex = 6;
            this.SpoltextBox1.TextChanged += new System.EventHandler(this.SpoltextBox1_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(283, 176);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(476, 248);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "OIB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Spol";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SpoltextBox1);
            this.Controls.Add(this.OibtextBox1);
            this.Controls.Add(this.PrezimetextBox1);
            this.Controls.Add(this.ImetextBox1);
            this.Controls.Add(this.Ispisibutton);
            this.Controls.Add(this.Obradibutton);
            this.Controls.Add(this.Unesibutton);
            this.Name = "Form1";
            this.Text = "AllProgram";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Unesibutton;
        private System.Windows.Forms.Button Obradibutton;
        private System.Windows.Forms.Button Ispisibutton;
        private System.Windows.Forms.TextBox ImetextBox1;
        private System.Windows.Forms.TextBox PrezimetextBox1;
        private System.Windows.Forms.TextBox OibtextBox1;
        private System.Windows.Forms.TextBox SpoltextBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

