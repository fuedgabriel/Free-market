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

    public partial class Compra : UserControl
    {
        public struct Data
        {
           public int id_prod;
           public int mer_id;
           public int cat_id;
           public string prod_nome;
           public double preco;
        }

        public Data[] interferencia;

        public Compra()
        {
            InitializeComponent();
        }
        private void Compra_Load(object sender, EventArgs e)
        {
            carrinho1.Hide();
        }

        public void Reload ()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Global.Database()))
            {
                NpgsqlDataReader data;
                using (NpgsqlCommand cmd = new NpgsqlCommand("select * from produtos ", conn))
                {
                    conn.Open();
                    data = cmd.ExecuteReader();
                    DataTable tabela = new DataTable();
                    tabela.Columns.Add("Mercado",typeof(string));
                    tabela.Columns.Add("Produto", typeof(string));
                    tabela.Columns.Add("Preco", typeof(string));
                    tabela.Columns.Add("id", typeof(int));
                    int quantdata = data.FieldCount;
                    interferencia = new Data[quantdata];
                    for (int x=0;data.Read();x++)
                    {
                        interferencia[x].id_prod = data.GetInt32(data.GetOrdinal("id_prod"));
                        interferencia[x].mer_id = data.GetInt32(data.GetOrdinal("mer_id"));
                        interferencia[x].prod_nome = data.GetString(data.GetOrdinal("prod_nome"));
                        interferencia[x].cat_id = data.GetInt32(data.GetOrdinal("cat_id"));
                        interferencia[x].preco = data.GetDouble(data.GetOrdinal("preco"));
                        tabela.Rows.Add(Mercadoname(interferencia[x].mer_id), interferencia[x].prod_nome, interferencia[x].preco.ToString("n"),interferencia[x].id_prod);
                    }
                    conn.Close();
                    datacompra.DataSource = tabela;
                    datacompra.Columns["id"].Visible = false;
                }

            }
        }

        public string Mercadoname(int id)
        {

            using (NpgsqlConnection conn = new NpgsqlConnection(Global.Database()))
            {
                string close = "";
                NpgsqlDataReader data;
                using (NpgsqlCommand dmc = new NpgsqlCommand("select nome from mercado where mer_id = @id", conn))
            {
                    conn.Open();
                dmc.Parameters.Add(new NpgsqlParameter("@id", id));
                data = dmc.ExecuteReader();
                    if(data.Read())
                    { 
                    close = data.GetString(data.GetOrdinal("nome"));
                    }
                    conn.Close();
                return close ;
            }

            }
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            carrinho1.Show();
            carrinho1.BringToFront();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(Quant.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Quantidade invalida");
                goto a;
            }

                if (Convert.ToInt32(Quant.Text) >= 1)
            {
                if(datacompra.SelectedRows.Count == 1)
                {
                    int x = Convert.ToInt32(datacompra.CurrentRow.Cells[3].Value);
                    x = x - 1;
                    int y = carrinho1.data.Rows.Count;
                    for (int d = 0, z = 0; z <= y; z++ , d++ )
                    {
                        if(Convert.ToInt32(carrinho1.datagrid.Rows[z].Cells["id"].Value ) == interferencia[x].id_prod)
                        {
                            int bsa = Convert.ToInt32(carrinho1.datagrid.Rows[z].Cells["Quantidade"].Value);
                            carrinho1.datagrid.Rows[z].Cells["Quantidade"].Value = bsa + Convert.ToInt32(Quant.Text);
                            carrinho1.Reload();
                            goto a;
                        }
                    }
                    carrinho1.data.Rows.Add(interferencia[x].prod_nome,Convert.ToDouble(interferencia[x].preco), Quant.Text, interferencia[x].id_prod);
                    carrinho1.Reload();
                }
                else if(datacompra.SelectedRows.Count >=2)
                {
                    MessageBox.Show("Você Selecionou mais De Um produto, Por Favor Selecione 1 por vez");
                }
                else
                {
                    MessageBox.Show("Deve Ter Um Produto Selecionado","Erro");
                }
            }
            else
            {
                MessageBox.Show("A Quantidade Deve Ser maio Que 0", "Erro");
            }
        a:;
        }
    }
}
