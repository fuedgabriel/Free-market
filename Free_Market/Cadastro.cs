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
    public partial class user : Form
    {


        public static string Loginresp { get; set; }
        public static string Emailresp { get; set; }


        public user()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try {
                

                    if (username.Text != "" && pass.Text != "" && pass2.Text != "" && Usuario.Text != "" && email.Text != "" && pass.Text == pass2.Text && Telefone.Text != "" && Cpf.Text != "")
                {
                   

                    if (email.Text.Contains("@") && email.Text.Contains("."))
                    {
                        string cpf = Cpf.Text;
                        if(Cpf.Text.Contains("-")|| Cpf.Text.Contains(".") || Cpf.Text.Contains(" "))
                        {
                            cpf = cpf.Replace(".", "");
                            cpf = cpf.Replace("-", "");
                            cpf = cpf.Replace(" ", "");       
                        }
                        string tela = tel.Text;
                        if (tela.Contains("-") || tela.Contains("+") || tela.Contains("(") || tela.Contains(")") || Cpf.Text.Contains(" "))
                        {
                            tela = tela.Replace("-", "");
                            tela = tela.Replace(" ", "");
                            tela = tela.Replace("+", "");
                            tela = tela.Replace("(", "");
                            tela = tela.Replace(")", "");
                        }
                        try
                        {
                            Convert.ToInt64(cpf);
                        }
                        catch(Exception)
                        {
                            MessageBox.Show("Cpf Contem Letras\nEx: 307.547.090-27");
                            goto a;
                        }
                        try
                        {
                            Convert.ToInt64(tela);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Telefone Invalido\nEx:+55(21)9246-2897");
                            goto a;
                        }


                        if (cpf.Length < 11 || cpf.Length > 11 )
                        {
                            MessageBox.Show("Cpf Invalido\n 307.547.090-27");
                            goto a;
                        }
                        if (tela.Length < 8 || tela.Length > 13)
                        {
                            MessageBox.Show("Telefone Invalido\nEx:+55(21)99246-2897");
                            goto a;
                        }

                            if (Global.Verifemail(email.Text) == false && Global.Veriflogin(Usuario.Text) == false)
                        {
                            string codigo = "insert into Users (Login,senha,nome,Email,Carg_id,cpf,telefone) values (@login,@pass,@username,@email,0,@cpf,@tel)";
                            using (NpgsqlConnection connection = new NpgsqlConnection(Global.Database()))
                            {
                                using (NpgsqlCommand cmd = new NpgsqlCommand(codigo, connection))
                                {
                                    connection.Open();
                                    cmd.Parameters.Add(new NpgsqlParameter("@login", this.Usuario.Text));
                                    cmd.Parameters.Add(new NpgsqlParameter("@pass", this.pass.Text));
                                    cmd.Parameters.Add(new NpgsqlParameter("@username", this.username.Text));
                                    cmd.Parameters.Add(new NpgsqlParameter("@email", this.email.Text));
                                    cmd.Parameters.Add(new NpgsqlParameter("@cpf", cpf));
                                    cmd.Parameters.Add(new NpgsqlParameter("@tel", tela));
                                    cmd.ExecuteNonQuery();
                                    connection.Close();
                                    MessageBox.Show("Cadastrado com sucesso", "Sucesso");
                                }
                            }
                            username.Text = "";
                            pass.Text = "";
                            pass2.Text = "";
                            Usuario.Text = "";
                            email.Text = "";
                            Cpf.Text = "";
                            tel.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Email Ou Usuario ja existem no banco de dados", "Aviso");
                        }
                    }
                    else
                    {
                        MessageBox.Show("O E-mail está incorreto");
                    }
                }


                else
                {
                    MessageBox.Show("Existem Campos Vazios / ou Senhas não coincidem", "Erro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Banco de dados desativado ou mal configurado \nException:"+ex, "Erro");
            }
        a:;
        }
    }
}
