namespace Trabalho_Prático
{
    partial class FormEscolha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEscolha));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonFatRe = new System.Windows.Forms.RadioButton();
            this.radioButtonFatIte = new System.Windows.Forms.RadioButton();
            this.radioButtonFiboRe = new System.Windows.Forms.RadioButton();
            this.radioButtonFiboIte = new System.Windows.Forms.RadioButton();
            this.radioButtonPesSeq = new System.Windows.Forms.RadioButton();
            this.radioButtonPesBin = new System.Windows.Forms.RadioButton();
            this.radioButtonHanoi = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor:";
            // 
            // radioButtonFatRe
            // 
            this.radioButtonFatRe.AutoSize = true;
            this.radioButtonFatRe.Location = new System.Drawing.Point(12, 86);
            this.radioButtonFatRe.Name = "radioButtonFatRe";
            this.radioButtonFatRe.Size = new System.Drawing.Size(110, 17);
            this.radioButtonFatRe.TabIndex = 2;
            this.radioButtonFatRe.TabStop = true;
            this.radioButtonFatRe.Text = "Fatorial Recursivo";
            this.radioButtonFatRe.UseVisualStyleBackColor = true;
            this.radioButtonFatRe.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonFatIte
            // 
            this.radioButtonFatIte.AutoSize = true;
            this.radioButtonFatIte.Location = new System.Drawing.Point(161, 86);
            this.radioButtonFatIte.Name = "radioButtonFatIte";
            this.radioButtonFatIte.Size = new System.Drawing.Size(100, 17);
            this.radioButtonFatIte.TabIndex = 3;
            this.radioButtonFatIte.TabStop = true;
            this.radioButtonFatIte.Text = "Fatorial Iterativo";
            this.radioButtonFatIte.UseVisualStyleBackColor = true;
            this.radioButtonFatIte.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonFiboRe
            // 
            this.radioButtonFiboRe.AutoSize = true;
            this.radioButtonFiboRe.Location = new System.Drawing.Point(12, 122);
            this.radioButtonFiboRe.Name = "radioButtonFiboRe";
            this.radioButtonFiboRe.Size = new System.Drawing.Size(122, 17);
            this.radioButtonFiboRe.TabIndex = 4;
            this.radioButtonFiboRe.TabStop = true;
            this.radioButtonFiboRe.Text = "Fibonacci Recursivo";
            this.radioButtonFiboRe.UseVisualStyleBackColor = true;
            this.radioButtonFiboRe.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButtonFiboIte
            // 
            this.radioButtonFiboIte.AutoSize = true;
            this.radioButtonFiboIte.Location = new System.Drawing.Point(161, 122);
            this.radioButtonFiboIte.Name = "radioButtonFiboIte";
            this.radioButtonFiboIte.Size = new System.Drawing.Size(112, 17);
            this.radioButtonFiboIte.TabIndex = 5;
            this.radioButtonFiboIte.TabStop = true;
            this.radioButtonFiboIte.Text = "Fibonacci Iterativo";
            this.radioButtonFiboIte.UseVisualStyleBackColor = true;
            this.radioButtonFiboIte.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButtonPesSeq
            // 
            this.radioButtonPesSeq.AutoSize = true;
            this.radioButtonPesSeq.Location = new System.Drawing.Point(12, 158);
            this.radioButtonPesSeq.Name = "radioButtonPesSeq";
            this.radioButtonPesSeq.Size = new System.Drawing.Size(124, 17);
            this.radioButtonPesSeq.TabIndex = 6;
            this.radioButtonPesSeq.TabStop = true;
            this.radioButtonPesSeq.Text = "Pesquisa Sequencial";
            this.radioButtonPesSeq.UseVisualStyleBackColor = true;
            this.radioButtonPesSeq.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButtonPesBin
            // 
            this.radioButtonPesBin.AutoSize = true;
            this.radioButtonPesBin.Location = new System.Drawing.Point(161, 158);
            this.radioButtonPesBin.Name = "radioButtonPesBin";
            this.radioButtonPesBin.Size = new System.Drawing.Size(103, 17);
            this.radioButtonPesBin.TabIndex = 7;
            this.radioButtonPesBin.TabStop = true;
            this.radioButtonPesBin.Text = "Pesquisa Binária";
            this.radioButtonPesBin.UseVisualStyleBackColor = true;
            this.radioButtonPesBin.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButtonHanoi
            // 
            this.radioButtonHanoi.AutoSize = true;
            this.radioButtonHanoi.Location = new System.Drawing.Point(86, 196);
            this.radioButtonHanoi.Name = "radioButtonHanoi";
            this.radioButtonHanoi.Size = new System.Drawing.Size(101, 17);
            this.radioButtonHanoi.TabIndex = 8;
            this.radioButtonHanoi.TabStop = true;
            this.radioButtonHanoi.Text = "Torres de Hanói";
            this.radioButtonHanoi.UseVisualStyleBackColor = true;
            this.radioButtonHanoi.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Executar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tamanho:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "10 mil",
            "20 mil",
            "100 mil",
            "1 milhão",
            "10 milhões",
            "20 milhões",
            "50 milhões"});
            this.comboBox1.Location = new System.Drawing.Point(107, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // FormEscolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 260);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonHanoi);
            this.Controls.Add(this.radioButtonPesBin);
            this.Controls.Add(this.radioButtonPesSeq);
            this.Controls.Add(this.radioButtonFiboIte);
            this.Controls.Add(this.radioButtonFiboRe);
            this.Controls.Add(this.radioButtonFatIte);
            this.Controls.Add(this.radioButtonFatRe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEscolha";
            this.Text = "Métodos Legais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonFatRe;
        private System.Windows.Forms.RadioButton radioButtonFatIte;
        private System.Windows.Forms.RadioButton radioButtonFiboRe;
        private System.Windows.Forms.RadioButton radioButtonFiboIte;
        private System.Windows.Forms.RadioButton radioButtonPesSeq;
        private System.Windows.Forms.RadioButton radioButtonPesBin;
        private System.Windows.Forms.RadioButton radioButtonHanoi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

