using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using System.Threading;

namespace Free_Market
{
    public partial class Login : Form
    {

               public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void Cadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            user cads = new user();
            cads.ShowDialog();
            this.Show();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            
            if (user.Text == "teste" && pass.Text =="teste")
            {
                try
                {
                    config cadsss = new config();
                    cadsss.Show();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(string.Format("Uma Excessão Foi Encontrada \nMande Esses dados pro Desenvolvedor:\n{0}", ex.ToString()), "Erro");
                }

            }
            else if (user.Text != "" && pass.Text != "")
            {
                try
                {
                    NpgsqlDataReader loginuser;
                    string codigo = "select * from users where (Login = @login and senha = @pass)";
                    using (NpgsqlConnection connection = new NpgsqlConnection(Global.Database()))
                    {
                        using (NpgsqlCommand cmd = new NpgsqlCommand(codigo, connection))
                        {
                            cmd.Parameters.Add(new NpgsqlParameter("@login", this.user.Text));
                            cmd.Parameters.Add(new NpgsqlParameter("@pass", this.pass.Text));
                            connection.Open();
                            loginuser = cmd.ExecuteReader();
                        }
                        if (loginuser.Read())
                        {
                            this.Hide();
                            Dashboard dash = new Dashboard();
                            Global.usercode = loginuser.GetInt32(loginuser.GetOrdinal("user_id"));
                            dash.loaddados();
                            dash.ShowDialog(); 
                        }
                        else
                        {
                            MessageBox.Show("Login Ou Senha Não Encontrados no banco de dados", "Erro");
                        }
                        connection.Close();
                    }
                    user.Text = "";
                    pass.Text = "";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(string.Format("Uma Excessão Foi Encontrada \nMande Esses dados pro Desenvolvedor:\n{0}",ex.ToString()),"Erro");
                }
            }
            else
            {
                MessageBox.Show("Senha Ou Usuario com campos vazios", "Erro");
            }
            this.Show();

        }
   }
}
