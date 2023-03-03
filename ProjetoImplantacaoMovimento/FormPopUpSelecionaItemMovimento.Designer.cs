namespace ProjetoImplantacaoMovimento
{
    partial class FormPopUpSelecionaItemMovimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPopUpSelecionaItemMovimento));
            this.textBoxIDITEM = new System.Windows.Forms.TextBox();
            this.textBoxDESCRICAOITEM = new System.Windows.Forms.TextBox();
            this.simpleButtonSelecionaItem = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButtonSelecionaPrevisto = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxDESCRICAOPREVISTO = new System.Windows.Forms.TextBox();
            this.textBoxIDPREVISTO = new System.Windows.Forms.TextBox();
            this.simpleButtonCANCELAR = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSALVAR = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxOBSERVACAO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxIDITEM
            // 
            this.textBoxIDITEM.Location = new System.Drawing.Point(12, 24);
            this.textBoxIDITEM.Name = "textBoxIDITEM";
            this.textBoxIDITEM.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDITEM.TabIndex = 0;
            // 
            // textBoxDESCRICAOITEM
            // 
            this.textBoxDESCRICAOITEM.Location = new System.Drawing.Point(147, 24);
            this.textBoxDESCRICAOITEM.Name = "textBoxDESCRICAOITEM";
            this.textBoxDESCRICAOITEM.Size = new System.Drawing.Size(281, 20);
            this.textBoxDESCRICAOITEM.TabIndex = 1;
            // 
            // simpleButtonSelecionaItem
            // 
            this.simpleButtonSelecionaItem.Location = new System.Drawing.Point(118, 24);
            this.simpleButtonSelecionaItem.Name = "simpleButtonSelecionaItem";
            this.simpleButtonSelecionaItem.Size = new System.Drawing.Size(23, 20);
            this.simpleButtonSelecionaItem.TabIndex = 2;
            this.simpleButtonSelecionaItem.Text = "...";
            this.simpleButtonSelecionaItem.Click += new System.EventHandler(this.simpleButtonSelecionaItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Previsto";
            // 
            // simpleButtonSelecionaPrevisto
            // 
            this.simpleButtonSelecionaPrevisto.Location = new System.Drawing.Point(118, 65);
            this.simpleButtonSelecionaPrevisto.Name = "simpleButtonSelecionaPrevisto";
            this.simpleButtonSelecionaPrevisto.Size = new System.Drawing.Size(23, 20);
            this.simpleButtonSelecionaPrevisto.TabIndex = 6;
            this.simpleButtonSelecionaPrevisto.Text = "...";
            this.simpleButtonSelecionaPrevisto.Click += new System.EventHandler(this.simpleButtonSelecionaPrevisto_Click);
            // 
            // textBoxDESCRICAOPREVISTO
            // 
            this.textBoxDESCRICAOPREVISTO.Location = new System.Drawing.Point(147, 65);
            this.textBoxDESCRICAOPREVISTO.Name = "textBoxDESCRICAOPREVISTO";
            this.textBoxDESCRICAOPREVISTO.Size = new System.Drawing.Size(281, 20);
            this.textBoxDESCRICAOPREVISTO.TabIndex = 5;
            // 
            // textBoxIDPREVISTO
            // 
            this.textBoxIDPREVISTO.Location = new System.Drawing.Point(12, 65);
            this.textBoxIDPREVISTO.Name = "textBoxIDPREVISTO";
            this.textBoxIDPREVISTO.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDPREVISTO.TabIndex = 4;
            // 
            // simpleButtonCANCELAR
            // 
            this.simpleButtonCANCELAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonCANCELAR.Location = new System.Drawing.Point(292, 204);
            this.simpleButtonCANCELAR.Name = "simpleButtonCANCELAR";
            this.simpleButtonCANCELAR.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonCANCELAR.TabIndex = 9;
            this.simpleButtonCANCELAR.Text = "Cancelar";
            this.simpleButtonCANCELAR.Click += new System.EventHandler(this.simpleButtonCANCELAR_Click);
            // 
            // simpleButtonSALVAR
            // 
            this.simpleButtonSALVAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonSALVAR.Location = new System.Drawing.Point(373, 204);
            this.simpleButtonSALVAR.Name = "simpleButtonSALVAR";
            this.simpleButtonSALVAR.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonSALVAR.TabIndex = 8;
            this.simpleButtonSALVAR.Text = "Salvar";
            this.simpleButtonSALVAR.Click += new System.EventHandler(this.simpleButtonSALVAR_Click);
            // 
            // textBoxOBSERVACAO
            // 
            this.textBoxOBSERVACAO.Location = new System.Drawing.Point(12, 105);
            this.textBoxOBSERVACAO.Multiline = true;
            this.textBoxOBSERVACAO.Name = "textBoxOBSERVACAO";
            this.textBoxOBSERVACAO.Size = new System.Drawing.Size(416, 80);
            this.textBoxOBSERVACAO.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Observação";
            // 
            // FormPopUpSelecionaItemMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 239);
            this.Controls.Add(this.textBoxOBSERVACAO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.simpleButtonCANCELAR);
            this.Controls.Add(this.simpleButtonSALVAR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.simpleButtonSelecionaPrevisto);
            this.Controls.Add(this.textBoxDESCRICAOPREVISTO);
            this.Controls.Add(this.textBoxIDPREVISTO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simpleButtonSelecionaItem);
            this.Controls.Add(this.textBoxDESCRICAOITEM);
            this.Controls.Add(this.textBoxIDITEM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPopUpSelecionaItemMovimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Item Movimento";
            this.Load += new System.EventHandler(this.FormPopUpSelecionaItemMovimento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIDITEM;
        private System.Windows.Forms.TextBox textBoxDESCRICAOITEM;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSelecionaItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSelecionaPrevisto;
        private System.Windows.Forms.TextBox textBoxDESCRICAOPREVISTO;
        private System.Windows.Forms.TextBox textBoxIDPREVISTO;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCANCELAR;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSALVAR;
        private System.Windows.Forms.TextBox textBoxOBSERVACAO;
        private System.Windows.Forms.Label label4;
    }
}