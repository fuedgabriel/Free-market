namespace Free_Market
{
    partial class config
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
            this.cadastrar = new System.Windows.Forms.Button();
            this.ip = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cadastrar
            // 
            this.cadastrar.Location = new System.Drawing.Point(12, 194);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(110, 56);
            this.cadastrar.TabIndex = 4;
            this.cadastrar.Text = "Mudar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(12, 28);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(261, 20);
            this.ip.TabIndex = 0;
            this.ip.Text = "127.0.0.1";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(12, 65);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(261, 20);
            this.port.TabIndex = 1;
            this.port.Text = "5432";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(12, 104);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(261, 20);
            this.pass.TabIndex = 2;
            this.pass.Text = "pgadmin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Database";
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(12, 143);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(261, 20);
            this.Data.TabIndex = 3;
            this.Data.Text = "Fecip";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "Instalar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.port);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.cadastrar);
            this.Name = "config";
            this.Text = "config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Data;
        private System.Windows.Forms.Button button1;
    }
}