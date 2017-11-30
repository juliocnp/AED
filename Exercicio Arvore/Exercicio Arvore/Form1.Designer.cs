namespace Exercicio_Arvore
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
            this.textBoxCpfId = new System.Windows.Forms.TextBox();
            this.textBoxContasCpf = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonCpf = new System.Windows.Forms.RadioButton();
            this.radioButtonConta = new System.Windows.Forms.RadioButton();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCpfId
            // 
            this.textBoxCpfId.Location = new System.Drawing.Point(129, 65);
            this.textBoxCpfId.Name = "textBoxCpfId";
            this.textBoxCpfId.Size = new System.Drawing.Size(100, 20);
            this.textBoxCpfId.TabIndex = 1;
            // 
            // textBoxContasCpf
            // 
            this.textBoxContasCpf.Location = new System.Drawing.Point(93, 110);
            this.textBoxContasCpf.Multiline = true;
            this.textBoxContasCpf.Name = "textBoxContasCpf";
            this.textBoxContasCpf.Size = new System.Drawing.Size(136, 101);
            this.textBoxContasCpf.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Abrir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cpf/Identificador:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contas/Cpf:";
            // 
            // radioButtonCpf
            // 
            this.radioButtonCpf.AutoSize = true;
            this.radioButtonCpf.Location = new System.Drawing.Point(26, 12);
            this.radioButtonCpf.Name = "radioButtonCpf";
            this.radioButtonCpf.Size = new System.Drawing.Size(41, 17);
            this.radioButtonCpf.TabIndex = 7;
            this.radioButtonCpf.TabStop = true;
            this.radioButtonCpf.Text = "Cpf";
            this.radioButtonCpf.UseVisualStyleBackColor = true;
            // 
            // radioButtonConta
            // 
            this.radioButtonConta.AutoSize = true;
            this.radioButtonConta.Location = new System.Drawing.Point(26, 35);
            this.radioButtonConta.Name = "radioButtonConta";
            this.radioButtonConta.Size = new System.Drawing.Size(53, 17);
            this.radioButtonConta.TabIndex = 8;
            this.radioButtonConta.TabStop = true;
            this.radioButtonConta.Text = "Conta";
            this.radioButtonConta.UseVisualStyleBackColor = true;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(77, 227);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisar.TabIndex = 9;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 262);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.radioButtonConta);
            this.Controls.Add(this.radioButtonCpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxContasCpf);
            this.Controls.Add(this.textBoxCpfId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxCpfId;
        private System.Windows.Forms.TextBox textBoxContasCpf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonCpf;
        private System.Windows.Forms.RadioButton radioButtonConta;
        private System.Windows.Forms.Button buttonPesquisar;
    }
}

