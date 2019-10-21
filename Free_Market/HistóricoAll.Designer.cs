namespace Free_Market
{
    partial class HistóricoAll
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // HistóricoAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.histgrid);
            this.Controls.Add(this.Compra);
            this.Controls.Add(this.Trans);
            this.Name = "HistóricoAll";
            this.Size = new System.Drawing.Size(330, 661);
            ((System.ComponentModel.ISupportInitialize)(this.histgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Trans;
        private System.Windows.Forms.Label Compra;
        private System.Windows.Forms.DataGridView histgrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
