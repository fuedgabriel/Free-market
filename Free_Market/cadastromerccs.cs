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
    public partial class cadastromerccs : UserControl
    {
        public cadastromerccs()
        {
            InitializeComponent();
        }

        public void Reload()
        {

            using (NpgsqlConnection conn = new NpgsqlConnection(Global.Database()))
            {
                NpgsqlDataReader data;
                string tituloS = "SELECT nome,mer_id FROM mercado";
                using (NpgsqlCommand cmd = new NpgsqlCommand(tituloS, conn))
                {
                    conn.Open();
                    data = cmd.ExecuteReader();
                    DataTable tabela = new DataTable();
                    tabela.Columns.Add("mer_id", typeof(int));
                    tabela.Columns.Add("nome", typeof(string));
                    tabela.Load(data);
                    catm.DataSource = tabela;
                    catm.DisplayMember = "nome";
                    catm.ValueMember = "mer_id";
                    conn.Close();               }
            }
            using (NpgsqlConnection conn = new NpgsqlConnection(Global.Database()))
            {
                NpgsqlDataReader data;
                string tituloS = "SELECT * from categoria";
                using (NpgsqlCommand cmd = new NpgsqlCommand(tituloS, conn))
                {
                    conn.Open();
                    data = cmd.ExecuteReader();
                    DataTable tabela = new DataTable();
                    tabela.Columns.Add("cat_id", typeof(int));
                    tabela.Columns.Add("cat_nome", typeof(string));
                    tabela.Load(data);
                    catp.DataSource = tabela;
                    catp.DisplayMember = "cat_nome";
                    catp.ValueMember = "cat_id";
                    conn.Close();
                }
            }
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            
            if(catm.SelectedValue == null || catp.SelectedValue == null)
            {
                MessageBox.Show("Não Foram Inseridos Dados De Categoria ou Mercado");
            }
            else
            {
                if (namepr.Text == null || namepr.Text == "")
                {
                    MessageBox.Show("O valor não pode ser vazio ou nulo");
                    goto a;
                }

                if(Global.Verificarprodname(namepr.Text,Convert.ToInt32(catm.SelectedValue)) == true)
                {
                    MessageBox.Show("Esse Produto ja existe");
                    goto a;
                }

                using (NpgsqlConnection conn = new NpgsqlConnection(Global.Database()))
                {
                    string preco = prec1.Text;
                    if(preco.Contains(",") || preco.Contains(" "))
                    {
                        preco.Replace(",", ".");
                        preco.Replace(" ", "");
                    }
       

                    try
                    {
                        Convert.ToDouble(preco);
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("O Preço So pode Ser Preenchido Com Numeros");
                        goto a;
                    }

                    if (Convert.ToDouble(preco) <= 0)
                    {
                        MessageBox.Show("O Valor Inserido é invalido");
                        goto a;
                    }

                    string tituloS = "insert into produtos (preco,prod_nome,mer_id,cat_id) values (@preco,@nome,@mercid,@catid)";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(tituloS, conn))
                    {
                        conn.Open();
                        cmd.Parameters.Add(new NpgsqlParameter("@nome", namepr.Text));
                        cmd.Parameters.Add(new NpgsqlParameter("@preco", preco));
                        cmd.Parameters.Add(new NpgsqlParameter("@mercid", catm.SelectedValue));
                        cmd.Parameters.Add(new NpgsqlParameter("@catid", catp.SelectedValue));
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                prec1.Text = "";
                namepr.Text = "";
                MessageBox.Show("Cadastro Concluido", "Sucesso");
            a:;
            }
        }

        private void Cadastromerccs_Load(object sender, EventArgs e)
        {
        }
    }
}
