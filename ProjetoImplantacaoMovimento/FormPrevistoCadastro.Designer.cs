namespace ProjetoImplantacaoMovimento
{
    partial class FormPrevistoCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrevistoCadastro));
            this.simpleButtonSALVAR = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCANCELAR = new DevExpress.XtraEditors.SimpleButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIDPREVISTO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDESCRICAO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDATACADASTRO = new System.Windows.Forms.TextBox();
            this.tabPageCADASTRO = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageCADASTRO.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButtonSALVAR
            // 
            this.simpleButtonSALVAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonSALVAR.Location = new System.Drawing.Point(460, 436);
            this.simpleButtonSALVAR.Name = "simpleButtonSALVAR";
            this.simpleButtonSALVAR.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonSALVAR.TabIndex = 0;
            this.simpleButtonSALVAR.Text = "Salvar";
            this.simpleButtonSALVAR.Click += new System.EventHandler(this.simpleButtonSALVAR_Click);
            // 
            // simpleButtonCANCELAR
            // 
            this.simpleButtonCANCELAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonCANCELAR.Location = new System.Drawing.Point(379, 436);
            this.simpleButtonCANCELAR.Name = "simpleButtonCANCELAR";
            this.simpleButtonCANCELAR.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonCANCELAR.TabIndex = 1;
            this.simpleButtonCANCELAR.Text = "Cancelar";
            this.simpleButtonCANCELAR.Click += new System.EventHandler(this.simpleButtonCANCELAR_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCADASTRO);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(523, 418);
            this.tabControl1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id Previsto";
            // 
            // textBoxIDPREVISTO
            // 
            this.textBoxIDPREVISTO.Enabled = false;
            this.textBoxIDPREVISTO.Location = new System.Drawing.Point(6, 59);
            this.textBoxIDPREVISTO.Name = "textBoxIDPREVISTO";
            this.textBoxIDPREVISTO.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDPREVISTO.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descrição";
            // 
            // textBoxDESCRICAO
            // 
            this.textBoxDESCRICAO.Location = new System.Drawing.Point(6, 99);
            this.textBoxDESCRICAO.Name = "textBoxDESCRICAO";
            this.textBoxDESCRICAO.Size = new System.Drawing.Size(463, 20);
            this.textBoxDESCRICAO.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Data Cadastro";
            // 
            // textBoxDATACADASTRO
            // 
            this.textBoxDATACADASTRO.Enabled = false;
            this.textBoxDATACADASTRO.Location = new System.Drawing.Point(6, 20);
            this.textBoxDATACADASTRO.Name = "textBoxDATACADASTRO";
            this.textBoxDATACADASTRO.Size = new System.Drawing.Size(100, 20);
            this.textBoxDATACADASTRO.TabIndex = 9;
            // 
            // tabPageCADASTRO
            // 
            this.tabPageCADASTRO.Controls.Add(this.textBoxDATACADASTRO);
            this.tabPageCADASTRO.Controls.Add(this.label2);
            this.tabPageCADASTRO.Controls.Add(this.textBoxDESCRICAO);
            this.tabPageCADASTRO.Controls.Add(this.label3);
            this.tabPageCADASTRO.Controls.Add(this.textBoxIDPREVISTO);
            this.tabPageCADASTRO.Controls.Add(this.label1);
            this.tabPageCADASTRO.Location = new System.Drawing.Point(4, 22);
            this.tabPageCADASTRO.Name = "tabPageCADASTRO";
            this.tabPageCADASTRO.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCADASTRO.Size = new System.Drawing.Size(515, 392);
            this.tabPageCADASTRO.TabIndex = 0;
            this.tabPageCADASTRO.Text = "Cadastro";
            this.tabPageCADASTRO.UseVisualStyleBackColor = true;
            // 
            // FormPrevistoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 471);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.simpleButtonCANCELAR);
            this.Controls.Add(this.simpleButtonSALVAR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrevistoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Previsto";
            this.Load += new System.EventHandler(this.FormPrevistoCadastro_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCADASTRO.ResumeLayout(false);
            this.tabPageCADASTRO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonSALVAR;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCANCELAR;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCADASTRO;
        private System.Windows.Forms.TextBox textBoxDATACADASTRO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDESCRICAO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIDPREVISTO;
        private System.Windows.Forms.Label label1;
    }
}

