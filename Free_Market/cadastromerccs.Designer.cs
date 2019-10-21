namespace Free_Market
{
    partial class cadastromerccs
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
            this.label1 = new System.Windows.Forms.Label();
            this.namepr = new System.Windows.Forms.TextBox();
            this.catp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Mercado = new System.Windows.Forms.Label();
            this.catm = new System.Windows.Forms.ComboBox();
            this.Confirmar = new System.Windows.Forms.Button();
            this.prec1 = new System.Windows.Forms.TextBox();
            this.prec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(22, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro De Mercadoria";
            // 
            // namepr
            // 
            this.namepr.Location = new System.Drawing.Point(21, 186);
            this.namepr.Name = "namepr";
            this.namepr.Size = new System.Drawing.Size(279, 20);
            this.namepr.TabIndex = 0;
            // 
            // catp
            // 
            this.catp.FormattingEnabled = true;
            this.catp.Location = new System.Drawing.Point(21, 244);
            this.catp.Name = "catp";
            this.catp.Size = new System.Drawing.Size(279, 21);
            this.catp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome Da Mercadoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categoria Do produto";
            // 
            // Mercado
            // 
            this.Mercado.AutoSize = true;
            this.Mercado.Location = new System.Drawing.Point(21, 278);
            this.Mercado.Name = "Mercado";
            this.Mercado.Size = new System.Drawing.Size(49, 13);
            this.Mercado.TabIndex = 7;
            this.Mercado.Text = "Mercado";
            // 
            // catm
            // 
            this.catm.FormattingEnabled = true;
            this.catm.Location = new System.Drawing.Point(21, 303);
            this.catm.Name = "catm";
            this.catm.Size = new System.Drawing.Size(279, 21);
            this.catm.TabIndex = 2;
            // 
            // Confirmar
            // 
            this.Confirmar.BackColor = System.Drawing.Color.DodgerBlue;
            this.Confirmar.FlatAppearance.BorderSize = 0;
            this.Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Confirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Confirmar.Location = new System.Drawing.Point(21, 406);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(279, 43);
            this.Confirmar.TabIndex = 4;
            this.Confirmar.Text = "Cadastrar";
            this.Confirmar.UseVisualStyleBackColor = false;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // prec1
            // 
            this.prec1.Location = new System.Drawing.Point(21, 350);
            this.prec1.Name = "prec1";
            this.prec1.Size = new System.Drawing.Size(279, 20);
            this.prec1.TabIndex = 3;
            // 
            // prec
            // 
            this.prec.AutoSize = true;
            this.prec.Location = new System.Drawing.Point(24, 334);
            this.prec.Name = "prec";
            this.prec.Size = new System.Drawing.Size(35, 13);
            this.prec.TabIndex = 12;
            this.prec.Text = "Preço";
            // 
            // cadastromerccs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.prec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prec1);
            this.Controls.Add(this.Confirmar);
            this.Controls.Add(this.Mercado);
            this.Controls.Add(this.catm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.catp);
            this.Controls.Add(this.namepr);
            this.Name = "cadastromerccs";
            this.Size = new System.Drawing.Size(330, 661);
            this.Load += new System.EventHandler(this.Cadastromerccs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namepr;
        private System.Windows.Forms.ComboBox catp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Mercado;
        private System.Windows.Forms.ComboBox catm;
        private System.Windows.Forms.Button Confirmar;
        private System.Windows.Forms.TextBox prec1;
        private System.Windows.Forms.Label prec;
    }
}
