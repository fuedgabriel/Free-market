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
    public partial class carrinho : UserControl
    {

        public DataTable data = new DataTable();

        public carrinho()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Carrinho_Load(object sender, EventArgs e)
        {
            data.Columns.Add("Produto", typeof(string));
            data.Columns.Add("Preco", typeof(Double));
            data.Columns.Add("Quantidade", typeof(int));
            data.Columns.Add("id", typeof(int));
            datagrid.DataSource = data;
            datagrid.Columns["id"].Visible = false;
        }

        public void Reload()
        {

            double fin = 0;
            int y = datagrid.Rows.Count;
            for (int x = 0; x < y; x++)
            {
                fin = fin + Convert.ToDouble(datagrid.Rows[x].Cells["Preco"].Value) * Convert.ToDouble(datagrid.Rows[x].Cells["Quantidade"].Value);
            }
            tot.Text = string.Format("Total:{0}", fin.ToString("n"));
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            int y = datagrid.Rows.Count;
            if (y > 1)
            {
                if (datagrid.SelectedRows.Count == 1)
                {
                    int x = datagrid.CurrentRow.Index;
                    datagrid.Rows.RemoveAt(x);
                    Reload();
                }
                else if (datagrid.SelectedRows.Count >= 2)
                {
                    MessageBox.Show("Você Selecionou mais De Um produto, Por Favor Selecione 1 por vez");
                }
                else
                {
                    MessageBox.Show("Deve Ter Um Produto Selecionado", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Selecionado inválido");
            }
        }

        private void Fin_Click(object sender, EventArgs e)
        {
            int y = datagrid.Rows.Count;
            if (y > 1)
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(Global.Database()))
                {
                    string tituloS = "insert into transaçoes (Data,status,user_id) values (@Data,@status,@user_id)";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(tituloS, conn))
                    {
                        conn.Open();
                        cmd.Parameters.Add(new NpgsqlParameter("@Data", DateTime.Now));
                        cmd.Parameters.Add(new NpgsqlParameter("@status", "Entregue"));
                        cmd.Parameters.Add(new NpgsqlParameter("@user_id", Global.usercode));
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                int datavalue = Getult();
                for (int x = 0; x < y; x++)
                {
                    if (datagrid.Rows[x].Cells["Quantidade"].Value != null)
                    {
                        using (NpgsqlConnection conn = new NpgsqlConnection(Global.Database()))
                        {
                            string tituloS = "insert into itens (quantidade,id_prod,tran_id) values (@Quantidade,@id_prod,@tran_id)";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(tituloS, conn))
                            {
                                conn.Open();
                                cmd.Parameters.Add(new NpgsqlParameter("@Quantidade", datagrid.Rows[x].Cells["Quantidade"].Value));
                                cmd.Parameters.Add(new NpgsqlParameter("@id_prod", datagrid.Rows[x].Cells["id"].Value));
                                cmd.Parameters.Add(new NpgsqlParameter("@tran_id", datavalue));
                                cmd.ExecuteReader();
                                conn.Close();
                            }

                        }
                    }
                }
                MessageBox.Show("Concluido");
            }
            else MessageBox.Show("Nenhum Produto foi inserido.", "Erro");
            data.Rows.Clear();
        }

        public int Getult()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Global.Database()))
            {
                long ret = 0;
                NpgsqlDataReader lerQuant;
                string tituloS = "SELECT COUNT(transaçoes) AS quantidade FROM transaçoes; ";
                using (NpgsqlCommand cmd = new NpgsqlCommand(tituloS, conn))
                {
                    conn.Open();
                    lerQuant = cmd.ExecuteReader();
                    if(lerQuant.Read())
                    {
                    ret = lerQuant.GetInt64(lerQuant.GetOrdinal("quantidade"));
                    }
                    conn.Close();
                    return Convert.ToInt32(ret);
                }

            }
        }
    }
}
