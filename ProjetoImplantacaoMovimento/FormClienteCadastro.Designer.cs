namespace ProjetoImplantacaoMovimento
{
    partial class FormClienteCadastro
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
            this.Informações = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.simpleButtonCANCELAR = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSALVAR = new DevExpress.XtraEditors.SimpleButton();
            this.maskedTextBoxTELEFONE = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCEP = new System.Windows.Forms.MaskedTextBox();
            this.textBoxCIDADE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBAIRRO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNUMERO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRUA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNOME = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Informações.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Informações
            // 
            this.Informações.Controls.Add(this.tabPage1);
            this.Informações.Location = new System.Drawing.Point(1, 0);
            this.Informações.Name = "Informações";
            this.Informações.SelectedIndex = 0;
            this.Informações.Size = new System.Drawing.Size(502, 423);
            this.Informações.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.TextBoxID);
            this.tabPage1.Controls.Add(this.simpleButtonCANCELAR);
            this.tabPage1.Controls.Add(this.simpleButtonSALVAR);
            this.tabPage1.Controls.Add(this.maskedTextBoxTELEFONE);
            this.tabPage1.Controls.Add(this.maskedTextBoxCPF);
            this.tabPage1.Controls.Add(this.maskedTextBoxCEP);
            this.tabPage1.Controls.Add(this.textBoxCIDADE);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBoxBAIRRO);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBoxNUMERO);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxRUA);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxNOME);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(494, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informações";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "ID";
            // 
            // TextBoxID
            // 
            this.TextBoxID.Enabled = false;
            this.TextBoxID.Location = new System.Drawing.Point(14, 34);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(86, 20);
            this.TextBoxID.TabIndex = 21;
            // 
            // simpleButtonCANCELAR
            // 
            this.simpleButtonCANCELAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonCANCELAR.Location = new System.Drawing.Point(332, 368);
            this.simpleButtonCANCELAR.Name = "simpleButtonCANCELAR";
            this.simpleButtonCANCELAR.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonCANCELAR.TabIndex = 20;
            this.simpleButtonCANCELAR.Text = "Cancelar";
            this.simpleButtonCANCELAR.Click += new System.EventHandler(this.simpleButtonCANCELAR_Click);
            // 
            // simpleButtonSALVAR
            // 
            this.simpleButtonSALVAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonSALVAR.Location = new System.Drawing.Point(413, 368);
            this.simpleButtonSALVAR.Name = "simpleButtonSALVAR";
            this.simpleButtonSALVAR.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonSALVAR.TabIndex = 19;
            this.simpleButtonSALVAR.Text = "Salvar";
            this.simpleButtonSALVAR.Click += new System.EventHandler(this.simpleButtonSALVAR_Click);
            // 
            // maskedTextBoxTELEFONE
            // 
            this.maskedTextBoxTELEFONE.Location = new System.Drawing.Point(14, 123);
            this.maskedTextBoxTELEFONE.Mask = "(99) 0 0000-0000";
            this.maskedTextBoxTELEFONE.Name = "maskedTextBoxTELEFONE";
            this.maskedTextBoxTELEFONE.Size = new System.Drawing.Size(86, 20);
            this.maskedTextBoxTELEFONE.TabIndex = 16;
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(14, 173);
            this.maskedTextBoxCPF.Mask = "___.___.___-__";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(86, 20);
            this.maskedTextBoxCPF.TabIndex = 17;
            // 
            // maskedTextBoxCEP
            // 
            this.maskedTextBoxCEP.Location = new System.Drawing.Point(14, 272);
            this.maskedTextBoxCEP.Mask = "____-__";
            this.maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            this.maskedTextBoxCEP.Size = new System.Drawing.Size(86, 20);
            this.maskedTextBoxCEP.TabIndex = 18;
            // 
            // textBoxCIDADE
            // 
            this.textBoxCIDADE.Location = new System.Drawing.Point(106, 272);
            this.textBoxCIDADE.Name = "textBoxCIDADE";
            this.textBoxCIDADE.Size = new System.Drawing.Size(373, 20);
            this.textBoxCIDADE.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "CEP";
            // 
            // textBoxBAIRRO
            // 
            this.textBoxBAIRRO.Location = new System.Drawing.Point(203, 224);
            this.textBoxBAIRRO.Name = "textBoxBAIRRO";
            this.textBoxBAIRRO.Size = new System.Drawing.Size(157, 20);
            this.textBoxBAIRRO.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bairro";
            // 
            // textBoxNUMERO
            // 
            this.textBoxNUMERO.Location = new System.Drawing.Point(366, 224);
            this.textBoxNUMERO.Name = "textBoxNUMERO";
            this.textBoxNUMERO.Size = new System.Drawing.Size(113, 20);
            this.textBoxNUMERO.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Número";
            // 
            // textBoxRUA
            // 
            this.textBoxRUA.Location = new System.Drawing.Point(14, 224);
            this.textBoxRUA.Name = "textBoxRUA";
            this.textBoxRUA.Size = new System.Drawing.Size(183, 20);
            this.textBoxRUA.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rua";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Telefone";
            // 
            // textBoxNOME
            // 
            this.textBoxNOME.Location = new System.Drawing.Point(14, 73);
            this.textBoxNOME.Name = "textBoxNOME";
            this.textBoxNOME.Size = new System.Drawing.Size(465, 20);
            this.textBoxNOME.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nome";
            // 
            // FormClienteCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 424);
            this.Controls.Add(this.Informações);
            this.Name = "FormClienteCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cliente";
            this.Informações.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Informações;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCEP;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPF;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTELEFONE;
        private System.Windows.Forms.TextBox textBoxCIDADE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBAIRRO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNUMERO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRUA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNOME;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSALVAR;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCANCELAR;
        private System.Windows.Forms.TextBox textBoxIDCliente;
        private System.Windows.Forms.TextBox MaskedtextBoxIDCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBoxID;
    }
}