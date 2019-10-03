namespace Free_Market
{
    partial class Compra
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
            this.datacompra = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Quant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.carrinho1 = new Free_Market.carrinho();
            ((System.ComponentModel.ISupportInitialize)(this.datacompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datacompra
            // 
            this.datacompra.AllowUserToAddRows = false;
            this.datacompra.AllowUserToDeleteRows = false;
            this.datacompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datacompra.Location = new System.Drawing.Point(4, 69);
            this.datacompra.Name = "datacompra";
            this.datacompra.ReadOnly = true;
            this.datacompra.RowTemplate.ReadOnly = true;
            this.datacompra.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.datacompra.Size = new System.Drawing.Size(324, 536);
            this.datacompra.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(14, 610);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Adicionar Ao Carrinho";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Quant
            // 
            this.Quant.Location = new System.Drawing.Point(204, 626);
            this.Quant.Name = "Quant";
            this.Quant.Size = new System.Drawing.Size(100, 20);
            this.Quant.TabIndex = 11;
            this.Quant.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 610);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quantidade";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Free_Market.Properties.Resources.cart;
            this.pictureBox1.Location = new System.Drawing.Point(285, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // carrinho1
            // 
            this.carrinho1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.carrinho1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.carrinho1.Location = new System.Drawing.Point(0, 0);
            this.carrinho1.Name = "carrinho1";
            this.carrinho1.Size = new System.Drawing.Size(330, 661);
            this.carrinho1.TabIndex = 14;
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quant);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datacompra);
            this.Controls.Add(this.carrinho1);
            this.Name = "Compra";
            this.Size = new System.Drawing.Size(330, 661);
            this.Load += new System.EventHandler(this.Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datacompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView datacompra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Quant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private carrinho carrinho1;
    }
}
