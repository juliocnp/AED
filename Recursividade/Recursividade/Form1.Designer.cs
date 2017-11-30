namespace Recursividade
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
            this.numBox = new System.Windows.Forms.TextBox();
            this.radioFatIte = new System.Windows.Forms.RadioButton();
            this.radioFiRe = new System.Windows.Forms.RadioButton();
            this.radioFatRe = new System.Windows.Forms.RadioButton();
            this.result = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(76, 12);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(70, 20);
            this.numBox.TabIndex = 1;
            // 
            // radioFatIte
            // 
            this.radioFatIte.AutoSize = true;
            this.radioFatIte.Location = new System.Drawing.Point(24, 47);
            this.radioFatIte.Name = "radioFatIte";
            this.radioFatIte.Size = new System.Drawing.Size(100, 17);
            this.radioFatIte.TabIndex = 2;
            this.radioFatIte.TabStop = true;
            this.radioFatIte.Text = "Fatorial Iterativo";
            this.radioFatIte.UseVisualStyleBackColor = true;
            // 
            // radioFiRe
            // 
            this.radioFiRe.AutoSize = true;
            this.radioFiRe.Location = new System.Drawing.Point(76, 70);
            this.radioFiRe.Name = "radioFiRe";
            this.radioFiRe.Size = new System.Drawing.Size(122, 17);
            this.radioFiRe.TabIndex = 3;
            this.radioFiRe.TabStop = true;
            this.radioFiRe.Text = "Fibonacci Recursivo";
            this.radioFiRe.UseVisualStyleBackColor = true;
            // 
            // radioFatRe
            // 
            this.radioFatRe.AutoSize = true;
            this.radioFatRe.Location = new System.Drawing.Point(140, 47);
            this.radioFatRe.Name = "radioFatRe";
            this.radioFatRe.Size = new System.Drawing.Size(110, 17);
            this.radioFatRe.TabIndex = 4;
            this.radioFatRe.TabStop = true;
            this.radioFatRe.Text = "Fatorial Recursivo";
            this.radioFatRe.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(100, 133);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(73, 13);
            this.result.TabIndex = 5;
            this.result.Text = "RESULTADO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tempo
            // 
            this.tempo.AutoSize = true;
            this.tempo.Location = new System.Drawing.Point(208, 14);
            this.tempo.Name = "tempo";
            this.tempo.Size = new System.Drawing.Size(40, 13);
            this.tempo.TabIndex = 7;
            this.tempo.Text = "Tempo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 155);
            this.Controls.Add(this.tempo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.radioFatRe);
            this.Controls.Add(this.radioFiRe);
            this.Controls.Add(this.radioFatIte);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numBox;
        private System.Windows.Forms.RadioButton radioFatIte;
        private System.Windows.Forms.RadioButton radioFiRe;
        private System.Windows.Forms.RadioButton radioFatRe;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label tempo;
    }
}

