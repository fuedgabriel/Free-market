namespace Free_Market
{
    partial class histórico
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Trans = new System.Windows.Forms.ComboBox();
            this.Compra = new System.Windows.Forms.Label();
            this.histgrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.histgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Trans
            // 
            this.Trans.FormattingEnabled = true;
            this.Trans.Location = new System.Drawing.Point(23, 90);
            this.Trans.Name = "Trans";
            this.Trans.Size = new System.Drawing.Size(284, 21);
            this.Trans.TabIndex = 0;
            this.Trans.SelectedIndexChanged += new System.EventHandler(this.Trans_TabIndexChanged);
            this.Trans.TabIndexChanged += new System.EventHandler(this.Trans_TabIndexChanged);
            // 
            // Compra
            // 
            this.Compra.AutoSize = true;
            this.Compra.Location = new System.Drawing.Point(23, 71);
            this.Compra.Name = "Compra";
            this.Compra.Size = new System.Drawing.Size(43, 13);
            this.Compra.TabIndex = 1;
            this.Compra.Text = "Compra";
            // 
            // histgrid
            // 
            this.histgrid.AllowUserToAddRows = false;
            this.histgrid.AllowUserToDeleteRows = false;
            this.histgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.histgrid.Location = new System.Drawing.Point(26, 128);
            this.histgrid.Name = "histgrid";
            this.histgrid.ReadOnly = true;
            this.histgrid.Size = new System.Drawing.Size(281, 500);
            this.histgrid.TabIndex = 3;
            // 
            // histórico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.histgrid);
            this.Controls.Add(this.Compra);
            this.Controls.Add(this.Trans);
            this.Name = "histórico";
            this.Size = new System.Drawing.Size(330, 661);
            ((System.ComponentModel.ISupportInitialize)(this.histgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Trans;
        private System.Windows.Forms.Label Compra;
        private System.Windows.Forms.DataGridView histgrid;
    }
}
