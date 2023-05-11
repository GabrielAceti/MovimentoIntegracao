namespace ProjetoImplantacaoMovimento
{
    partial class FormClienteVisao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClienteVisao));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNOVO = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEDITAR = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEXCLUIR = new System.Windows.Forms.ToolStripButton();
            this.gridControlMOVIMENTOS = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMOVIMENTOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNOVO,
            this.toolStripButtonEDITAR,
            this.toolStripButtonEXCLUIR});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(651, 52);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNOVO
            // 
            this.toolStripButtonNOVO.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNOVO.Image")));
            this.toolStripButtonNOVO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonNOVO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNOVO.Name = "toolStripButtonNOVO";
            this.toolStripButtonNOVO.Size = new System.Drawing.Size(72, 49);
            this.toolStripButtonNOVO.Text = "Novo";
            this.toolStripButtonNOVO.Click += new System.EventHandler(this.toolStripButtonNOVO_Click);
            // 
            // toolStripButtonEDITAR
            // 
            this.toolStripButtonEDITAR.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEDITAR.Image")));
            this.toolStripButtonEDITAR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonEDITAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEDITAR.Name = "toolStripButtonEDITAR";
            this.toolStripButtonEDITAR.Size = new System.Drawing.Size(73, 49);
            this.toolStripButtonEDITAR.Text = "Editar";
            this.toolStripButtonEDITAR.Click += new System.EventHandler(this.toolStripButtonEDITAR_Click);
            // 
            // toolStripButtonEXCLUIR
            // 
            this.toolStripButtonEXCLUIR.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEXCLUIR.Image")));
            this.toolStripButtonEXCLUIR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonEXCLUIR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEXCLUIR.Name = "toolStripButtonEXCLUIR";
            this.toolStripButtonEXCLUIR.Size = new System.Drawing.Size(78, 49);
            this.toolStripButtonEXCLUIR.Text = "Excluir";
            // 
            // gridControlMOVIMENTOS
            // 
            this.gridControlMOVIMENTOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlMOVIMENTOS.Location = new System.Drawing.Point(0, 55);
            this.gridControlMOVIMENTOS.MainView = this.gridView1;
            this.gridControlMOVIMENTOS.Name = "gridControlMOVIMENTOS";
            this.gridControlMOVIMENTOS.Size = new System.Drawing.Size(651, 392);
            this.gridControlMOVIMENTOS.TabIndex = 0;
            this.gridControlMOVIMENTOS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlMOVIMENTOS;
            this.gridView1.Name = "gridView1";
            // 
            // FormClienteVisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.gridControlMOVIMENTOS);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormClienteVisao";
            this.Text = "ClienteVisao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormClienteVisao_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMOVIMENTOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNOVO;
        private System.Windows.Forms.ToolStripButton toolStripButtonEDITAR;
        private System.Windows.Forms.ToolStripButton toolStripButtonEXCLUIR;
        private DevExpress.XtraGrid.GridControl gridControlMOVIMENTOS;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}