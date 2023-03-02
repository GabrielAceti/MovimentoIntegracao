namespace ProjetoImplantacaoMovimento
{
    partial class FormItensVisao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormItensVisao));
            this.gridControlITENS = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNOVO = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEDITAR = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEXCLUIR = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlITENS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlITENS
            // 
            this.gridControlITENS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlITENS.Location = new System.Drawing.Point(1, 49);
            this.gridControlITENS.MainView = this.gridView1;
            this.gridControlITENS.Name = "gridControlITENS";
            this.gridControlITENS.Size = new System.Drawing.Size(632, 347);
            this.gridControlITENS.TabIndex = 0;
            this.gridControlITENS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlITENS;
            this.gridView1.Name = "gridView1";
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
            this.toolStrip1.Size = new System.Drawing.Size(632, 46);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNOVO
            // 
            this.toolStripButtonNOVO.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNOVO.Image")));
            this.toolStripButtonNOVO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonNOVO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNOVO.Name = "toolStripButtonNOVO";
            this.toolStripButtonNOVO.Size = new System.Drawing.Size(72, 43);
            this.toolStripButtonNOVO.Text = "Novo";
            this.toolStripButtonNOVO.Click += new System.EventHandler(this.toolStripButtonNOVO_Click);
            // 
            // toolStripButtonEDITAR
            // 
            this.toolStripButtonEDITAR.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEDITAR.Image")));
            this.toolStripButtonEDITAR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonEDITAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEDITAR.Name = "toolStripButtonEDITAR";
            this.toolStripButtonEDITAR.Size = new System.Drawing.Size(73, 43);
            this.toolStripButtonEDITAR.Text = "Editar";
            this.toolStripButtonEDITAR.Click += new System.EventHandler(this.toolStripButtonEDITAR_Click);
            // 
            // toolStripButtonEXCLUIR
            // 
            this.toolStripButtonEXCLUIR.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEXCLUIR.Image")));
            this.toolStripButtonEXCLUIR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonEXCLUIR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEXCLUIR.Name = "toolStripButtonEXCLUIR";
            this.toolStripButtonEXCLUIR.Size = new System.Drawing.Size(78, 43);
            this.toolStripButtonEXCLUIR.Text = "Excluir";
            this.toolStripButtonEXCLUIR.Click += new System.EventHandler(this.toolStripButtonEXCLUIR_Click);
            // 
            // FormItensVisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 397);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gridControlITENS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormItensVisao";
            this.Text = "Visão de Movimentos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormItensVisao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlITENS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlITENS;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNOVO;
        private System.Windows.Forms.ToolStripButton toolStripButtonEDITAR;
        private System.Windows.Forms.ToolStripButton toolStripButtonEXCLUIR;
    }
}