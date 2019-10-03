using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace Free_Market
{
    public partial class CadastroMec : UserControl
    {
        public CadastroMec()
        {
            InitializeComponent();
        }

        private void Arcadia_Click(object sender, EventArgs e)
        {
            if (Nom.Text != "" && Tel.Text != "" && End.Text != "")
            {
                if (Global.Merc(this.Nom.Text) == true)
                {
                    MessageBox.Show("O Nome Do Mercado Ja Existe");
                    goto a;
                }

                string tela = Tel.Text;
                if (tela.Contains("-") || tela.Contains("+") || tela.Contains("(") || tela.Contains(")")|| tela.Contains(" "))
                {
                    tela = tela.Replace("-", "");
                    tela = tela.Replace(" ", "");
                    tela = tela.Replace("+", "");
                    tela = tela.Replace("(", "");
                    tela = tela.Replace(")", "");
                }
                try
                {
                    Convert.ToInt32(tela);
                }
                catch(Exception)
                {
                    MessageBox.Show("Digite o número corretamente\nEx: (55) 21 97192-6771");
                    goto a;
                }


                if (tela.Length > 7 && tela.Length <= 13)
                {
                    string codigo = "insert into mercado (nome,telefone,endereco) values(@nome,@telefone,@endereco)";
                    using (NpgsqlConnection connection = new NpgsqlConnection(Global.Database()))
                    {
                        using (NpgsqlCommand cmd = new NpgsqlCommand(codigo, connection))
                        {
                            connection.Open();
                            cmd.Parameters.Add(new NpgsqlParameter("@nome", this.Nom.Text));
                            cmd.Parameters.Add(new NpgsqlParameter("@telefone", tela));
                            cmd.Parameters.Add(new NpgsqlParameter("@endereco", this.End.Text));
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Cadastro Concluido");
                            Nom.Text = "";
                            Tel.Text = "";
                            End.Text = "";
                        }
                    }

                }
                else {  MessageBox.Show("Digite o número corretamente\nEx: (55) 21 97192-6771"); }
            a:;
            }
        }

        private void CadastroMec_Load(object sender, EventArgs e)
        {
        }
    }
}
