using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace Free_Market
{
    public partial class Dashboard : Form
    {
        public struct dados
        {
            public int user_id;
            public string senha;
            public string email;
            public string Cpf;
            public string telefone;
            public string nome;
            public string login;
            public int carg_id;
        }

        dados[] perfil;

        public void loaddados()
        {
            NpgsqlDataReader SqlGetDash;
            using (NpgsqlConnection connection = new NpgsqlConnection(Global.Database()))
            {
                perfil = new dados[1];
                using (NpgsqlCommand cmd = new NpgsqlCommand("select * from users where user_id = @user", connection))
                {
                   
                    connection.Open();
                    cmd.Parameters.Add(new NpgsqlParameter("@user", Global.usercode));
                    SqlGetDash = cmd.ExecuteReader();
                    if (SqlGetDash.Read())
                    {
                        perfil[0].login = SqlGetDash.GetString(SqlGetDash.GetOrdinal("login"));
                        perfil[0].nome = SqlGetDash.GetString(SqlGetDash.GetOrdinal("nome"));
                        perfil[0].senha = SqlGetDash.GetString(SqlGetDash.GetOrdinal("senha"));
                        perfil[0].telefone = SqlGetDash.GetString(SqlGetDash.GetOrdinal("telefone"));
                        perfil[0].carg_id = SqlGetDash.GetInt32(SqlGetDash.GetOrdinal("carg_id"));
                        perfil[0].email = SqlGetDash.GetString(SqlGetDash.GetOrdinal("email"));
                        perfil[0].Cpf = SqlGetDash.GetString(SqlGetDash.GetOrdinal("cpf"));
                        perfil[0].user_id = SqlGetDash.GetInt32(SqlGetDash.GetOrdinal("user_id"));
                    }
                    connection.Close();
                }
            }
        }

        public Dashboard()
        {
            InitializeComponent();
        }

        public void Closeall()
        {
            compra1.Hide();
            cadastroMec1.Hide();
            categoria1.Hide();
            cadastromerccs1.Hide();
            func1.Hide();
            histórico1.Hide();
            alterarprods1.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loaddados();
            Closeall();
            User.Text = perfil[0].nome;
            if (perfil[0].carg_id == 0)
            {
                Cargo.Text = "Comprador";
                button2.Hide();
                button3.Hide();
                button4.Hide();
                button5.Hide();
                button7.Hide();
            }
            else if (perfil[0].carg_id == 1)
            {
                Cargo.Text = "Administrador";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Closeall();
            compra1.Reload();
            compra1.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Closeall();
            cadastroMec1.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Closeall();
            categoria1.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Closeall();
            cadastromerccs1.Reload();
            cadastromerccs1.Show();
        }

        private void Alteruser_Click(object sender, EventArgs e)
        {
            Closeall();
            func1.reload();
            func1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Closeall();
            histórico1.userid = perfil[0].user_id;
            histórico1.Reload();
            histórico1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Closeall();
            alterarprods1.reload();
            alterarprods1.Show();
        }
    }
}
