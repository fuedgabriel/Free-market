namespace Free_Market
{
    partial class func
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
            this.usera = new System.Windows.Forms.ComboBox();
            this.carge = new System.Windows.Forms.ComboBox();
            this.Alterar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cargaao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usera
            // 
            this.usera.FormattingEnabled = true;
            this.usera.Location = new System.Drawing.Point(62, 249);
            this.usera.Name = "usera";
            this.usera.Size = new System.Drawing.Size(192, 21);
            this.usera.TabIndex = 0;
            // 
            // carge
            // 
            this.carge.FormattingEnabled = true;
            this.carge.Location = new System.Drawing.Point(62, 301);
            this.carge.Name = "carge";
            this.carge.Size = new System.Drawing.Size(192, 21);
            this.carge.TabIndex = 1;
            // 
            // Alterar
            // 
            this.Alterar.BackColor = System.Drawing.Color.DodgerBlue;
            this.Alterar.FlatAppearance.BorderSize = 0;
            this.Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alterar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Alterar.Location = new System.Drawing.Point(59, 360);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(207, 48);
            this.Alterar.TabIndex = 2;
            this.Alterar.Text = "Alterar";
            this.Alterar.UseVisualStyleBackColor = false;
            this.Alterar.Click += new System.EventHandler(this.Alterar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(85, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alterar Permissão";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // Cargaao
            // 
            this.Cargaao.AutoSize = true;
            this.Cargaao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cargaao.Location = new System.Drawing.Point(62, 282);
            this.Cargaao.Name = "Cargaao";
            this.Cargaao.Size = new System.Drawing.Size(45, 16);
            this.Cargaao.TabIndex = 5;
            this.Cargaao.Text = "Cargo";
            // 
            // func
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Cargaao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Alterar);
            this.Controls.Add(this.carge);
            this.Controls.Add(this.usera);
            this.Name = "func";
            this.Size = new System.Drawing.Size(330, 661);
            this.Load += new System.EventHandler(this.Func_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox usera;
        private System.Windows.Forms.ComboBox carge;
        private System.Windows.Forms.Button Alterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Cargaao;
    }
}
