namespace Free_Market
{
    partial class carrinho
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
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.Fin = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.tot = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(4, 68);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(323, 503);
            this.datagrid.TabIndex = 0;
            // 
            // Fin
            // 
            this.Fin.BackColor = System.Drawing.Color.DodgerBlue;
            this.Fin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Fin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Fin.Location = new System.Drawing.Point(137, 593);
            this.Fin.Name = "Fin";
            this.Fin.Size = new System.Drawing.Size(87, 47);
            this.Fin.TabIndex = 1;
            this.Fin.Text = "Finalizar Pedido";
            this.Fin.UseVisualStyleBackColor = false;
            this.Fin.Click += new System.EventHandler(this.Fin_Click);
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.DodgerBlue;
            this.Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Remove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Remove.Location = new System.Drawing.Point(230, 593);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(97, 47);
            this.Remove.TabIndex = 2;
            this.Remove.Text = "Remover Do Carrinho";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // tot
            // 
            this.tot.AutoSize = true;
            this.tot.Location = new System.Drawing.Point(13, 610);
            this.tot.Name = "tot";
            this.tot.Size = new System.Drawing.Size(31, 13);
            this.tot.TabIndex = 3;
            this.tot.Text = "Total";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Free_Market.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(4, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // carrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tot);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Fin);
            this.Controls.Add(this.datagrid);
            this.Name = "carrinho";
            this.Size = new System.Drawing.Size(330, 661);
            this.Load += new System.EventHandler(this.Carrinho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Fin;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Label tot;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView datagrid;
    }
}
