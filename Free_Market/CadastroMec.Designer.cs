namespace Free_Market
{
    partial class CadastroMec
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
            this.Nom = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.End = new System.Windows.Forms.TextBox();
            this.arcadia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(38, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro De Mercado";
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(25, 258);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(276, 20);
            this.Nom.TabIndex = 0;
            // 
            // Tel
            // 
            this.Tel.Location = new System.Drawing.Point(25, 313);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(276, 20);
            this.Tel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(27, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome Do Mercado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(27, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(28, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Endereço";
            // 
            // End
            // 
            this.End.Location = new System.Drawing.Point(25, 378);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(276, 20);
            this.End.TabIndex = 2;
            // 
            // arcadia
            // 
            this.arcadia.BackColor = System.Drawing.SystemColors.HotTrack;
            this.arcadia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arcadia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arcadia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.arcadia.Location = new System.Drawing.Point(18, 414);
            this.arcadia.Name = "arcadia";
            this.arcadia.Size = new System.Drawing.Size(283, 69);
            this.arcadia.TabIndex = 3;
            this.arcadia.Text = "Cadastro";
            this.arcadia.UseVisualStyleBackColor = false;
            this.arcadia.Click += new System.EventHandler(this.Arcadia_Click);
            // 
            // CadastroMec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arcadia);
            this.Controls.Add(this.End);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.Nom);
            this.Name = "CadastroMec";
            this.Size = new System.Drawing.Size(330, 661);
            this.Load += new System.EventHandler(this.CadastroMec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Tel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox End;
        private System.Windows.Forms.Button arcadia;
    }
}
