namespace ProjetoImplantacaoMovimento
{
    partial class FormMovimentoCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMovimentoCadastro));
            this.simpleButtonSALVAR = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCANCELAR = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxIDMOVIMENTO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxNUMEROMOVIMENTO = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDESCRICAO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOBSERVACAO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDATACADASTRO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // simpleButtonSALVAR
            // 
            this.simpleButtonSALVAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonSALVAR.Location = new System.Drawing.Point(399, 296);
            this.simpleButtonSALVAR.Name = "simpleButtonSALVAR";
            this.simpleButtonSALVAR.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonSALVAR.TabIndex = 0;
            this.simpleButtonSALVAR.Text = "Salvar";
            this.simpleButtonSALVAR.Click += new System.EventHandler(this.simpleButtonSALVAR_Click);
            // 
            // simpleButtonCANCELAR
            // 
            this.simpleButtonCANCELAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonCANCELAR.Location = new System.Drawing.Point(318, 296);
            this.simpleButtonCANCELAR.Name = "simpleButtonCANCELAR";
            this.simpleButtonCANCELAR.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonCANCELAR.TabIndex = 1;
            this.simpleButtonCANCELAR.Text = "Cancelar";
            this.simpleButtonCANCELAR.Click += new System.EventHandler(this.simpleButtonCANCELAR_Click);
            // 
            // textBoxIDMOVIMENTO
            // 
            this.textBoxIDMOVIMENTO.Enabled = false;
            this.textBoxIDMOVIMENTO.Location = new System.Drawing.Point(12, 62);
            this.textBoxIDMOVIMENTO.Name = "textBoxIDMOVIMENTO";
            this.textBoxIDMOVIMENTO.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDMOVIMENTO.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id Movimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número Movimento";
            // 
            // maskedTextBoxNUMEROMOVIMENTO
            // 
            this.maskedTextBoxNUMEROMOVIMENTO.Location = new System.Drawing.Point(12, 101);
            this.maskedTextBoxNUMEROMOVIMENTO.Mask = "00,00,00";
            this.maskedTextBoxNUMEROMOVIMENTO.Name = "maskedTextBoxNUMEROMOVIMENTO";
            this.maskedTextBoxNUMEROMOVIMENTO.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxNUMEROMOVIMENTO.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descrição";
            // 
            // textBoxDESCRICAO
            // 
            this.textBoxDESCRICAO.Location = new System.Drawing.Point(12, 140);
            this.textBoxDESCRICAO.Name = "textBoxDESCRICAO";
            this.textBoxDESCRICAO.Size = new System.Drawing.Size(463, 20);
            this.textBoxDESCRICAO.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Observação";
            // 
            // textBoxOBSERVACAO
            // 
            this.textBoxOBSERVACAO.Location = new System.Drawing.Point(12, 179);
            this.textBoxOBSERVACAO.Multiline = true;
            this.textBoxOBSERVACAO.Name = "textBoxOBSERVACAO";
            this.textBoxOBSERVACAO.Size = new System.Drawing.Size(463, 80);
            this.textBoxOBSERVACAO.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data Cadastro";
            // 
            // textBoxDATACADASTRO
            // 
            this.textBoxDATACADASTRO.Enabled = false;
            this.textBoxDATACADASTRO.Location = new System.Drawing.Point(12, 23);
            this.textBoxDATACADASTRO.Name = "textBoxDATACADASTRO";
            this.textBoxDATACADASTRO.Size = new System.Drawing.Size(100, 20);
            this.textBoxDATACADASTRO.TabIndex = 11;
            // 
            // FormMovimentoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 331);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDATACADASTRO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOBSERVACAO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDESCRICAO);
            this.Controls.Add(this.maskedTextBoxNUMEROMOVIMENTO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIDMOVIMENTO);
            this.Controls.Add(this.simpleButtonCANCELAR);
            this.Controls.Add(this.simpleButtonSALVAR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMovimentoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Movimentos";
            this.Load += new System.EventHandler(this.FormMovimentoCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonSALVAR;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCANCELAR;
        private System.Windows.Forms.TextBox textBoxIDMOVIMENTO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNUMEROMOVIMENTO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDESCRICAO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOBSERVACAO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDATACADASTRO;
    }
}

