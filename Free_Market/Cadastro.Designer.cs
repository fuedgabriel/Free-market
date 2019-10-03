namespace Free_Market
{
    partial class user
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
            this.Cadastrar = new System.Windows.Forms.Button();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.pass2 = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.labelcpf = new System.Windows.Forms.Label();
            this.Cpf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(15, 172);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(260, 58);
            this.Cadastrar.TabIndex = 8;
            this.Cadastrar.Text = "cadastro";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(15, 29);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(120, 20);
            this.Usuario.TabIndex = 1;
            // 
            // pass2
            // 
            this.pass2.Location = new System.Drawing.Point(151, 68);
            this.pass2.Name = "pass2";
            this.pass2.PasswordChar = '*';
            this.pass2.Size = new System.Drawing.Size(120, 20);
            this.pass2.TabIndex = 4;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(15, 68);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(120, 20);
            this.pass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "senha";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(15, 107);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(256, 20);
            this.email.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "email";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(151, 29);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(120, 20);
            this.username.TabIndex = 2;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(148, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 8;
            this.name.Text = "Nome";
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Location = new System.Drawing.Point(15, 130);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(49, 13);
            this.Telefone.TabIndex = 10;
            this.Telefone.Text = "Telefone";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(15, 146);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(120, 20);
            this.tel.TabIndex = 6;
            // 
            // labelcpf
            // 
            this.labelcpf.AutoSize = true;
            this.labelcpf.Location = new System.Drawing.Point(160, 130);
            this.labelcpf.Name = "labelcpf";
            this.labelcpf.Size = new System.Drawing.Size(23, 13);
            this.labelcpf.TabIndex = 12;
            this.labelcpf.Text = "Cpf";
            // 
            // Cpf
            // 
            this.Cpf.Location = new System.Drawing.Point(155, 146);
            this.Cpf.Name = "Cpf";
            this.Cpf.Size = new System.Drawing.Size(120, 20);
            this.Cpf.TabIndex = 7;
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 241);
            this.Controls.Add(this.labelcpf);
            this.Controls.Add(this.Cpf);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.pass2);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Cadastrar);
            this.MaximumSize = new System.Drawing.Size(300, 280);
            this.MinimumSize = new System.Drawing.Size(300, 280);
            this.Name = "user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.TextBox pass2;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label labelcpf;
        private System.Windows.Forms.TextBox Cpf;
    }
}