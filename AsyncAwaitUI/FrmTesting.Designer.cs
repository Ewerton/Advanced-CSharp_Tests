namespace AsyncAwaitUI
{
    partial class FrmTesting
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
            this.components = new System.ComponentModel.Container();
            this.btnCalculate1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUrl2 = new System.Windows.Forms.TextBox();
            this.txtListWords = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcultae2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate1
            // 
            this.btnCalculate1.Location = new System.Drawing.Point(334, 70);
            this.btnCalculate1.Name = "btnCalculate1";
            this.btnCalculate1.Size = new System.Drawing.Size(162, 23);
            this.btnCalculate1.TabIndex = 0;
            this.btnCalculate1.Text = "Calculate";
            this.btnCalculate1.UseVisualStyleBackColor = true;
            this.btnCalculate1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insert a word:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Insert a url:";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(89, 6);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(100, 20);
            this.txtWord.TabIndex = 3;
            this.txtWord.Text = "net";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(89, 36);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(407, 20);
            this.txtURL.TabIndex = 4;
            this.txtURL.Text = "https://dotnetfoundation.org";
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(3, 260);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(701, 162);
            this.txtResult.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(3, 428);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(701, 17);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(3, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 6);
            this.panel1.TabIndex = 7;
            // 
            // txtUrl2
            // 
            this.txtUrl2.Location = new System.Drawing.Point(89, 165);
            this.txtUrl2.Name = "txtUrl2";
            this.txtUrl2.Size = new System.Drawing.Size(407, 20);
            this.txtUrl2.TabIndex = 11;
            this.txtUrl2.Text = "https://dotnetfoundation.org";
            // 
            // txtListWords
            // 
            this.txtListWords.Location = new System.Drawing.Point(208, 135);
            this.txtListWords.Name = "txtListWords";
            this.txtListWords.Size = new System.Drawing.Size(288, 20);
            this.txtListWords.TabIndex = 10;
            this.txtListWords.Text = "net, source, projects";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Insert a url:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Insert a list of comma separated words:";
            // 
            // btnCalcultae2
            // 
            this.btnCalcultae2.Location = new System.Drawing.Point(334, 195);
            this.btnCalcultae2.Name = "btnCalcultae2";
            this.btnCalcultae2.Size = new System.Drawing.Size(162, 23);
            this.btnCalcultae2.TabIndex = 12;
            this.btnCalcultae2.Text = "Calculate";
            this.btnCalcultae2.UseVisualStyleBackColor = true;
            this.btnCalcultae2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Calculate how many times the word occurs in the website";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(298, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Calculate how many times ALL the word occurs in the website";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(7, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 6);
            this.panel2.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(309, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Check how the progress bar still working without blocking the UI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 541);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalcultae2);
            this.Controls.Add(this.txtUrl2);
            this.Controls.Add(this.txtListWords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUrl2;
        private System.Windows.Forms.TextBox txtListWords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcultae2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
    }
}

