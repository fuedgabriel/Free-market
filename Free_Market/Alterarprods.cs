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
    public partial class Alterarprods : UserControl
    {
        public Alterarprods()
        {
            InitializeComponent();
        }

        public void reload()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Global.Database()))
            {
                NpgsqlDataReader data;
                string tituloS = "SELECT id_prod,prod_nome from produtos";
                using (NpgsqlCommand cmd = new NpgsqlCommand(tituloS, conn))
                {
                    conn.Open();
                    data = cmd.ExecuteReader();
                    DataTable tabela = new DataTable();
                    tabela.Columns.Add("id_prod", typeof(int));
                    tabela.Columns.Add("prod_nome", typeof(string));
                    tabela.Load(data);
                    prodbox.DataSource = tabela;
                    prodbox.DisplayMember = "prod_nome";
                    prodbox.ValueMember = "id_prod";
                    conn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                using (NpgsqlConnection conn = new NpgsqlConnection(Global.Database()))
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand("delete from produtos where id_prod = @id_prod", conn))
                    {
                        conn.Open();
                        cmd.Parameters.Add(new NpgsqlParameter("@id_prod", prodbox.SelectedValue));
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Não é possivel Excluir este item");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string precoNV = precnew.Text;
            if (precoNV.Contains(",") || precoNV.Contains(" "))
            {
                precoNV = precoNV.Replace(",", ".");
                precoNV = precoNV.Replace(" ", "");
            }
            try
            {
                Convert.ToDouble(precoNV);
            }
            catch(Exception)
            {
                MessageBox.Show("Valor Inválido");
                goto a;
            }
            using (NpgsqlConnection conn = new NpgsqlConnection(Global.Database()))
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand("update produtos set preco = @preco where id_prod = @id_prod ", conn))
                {
                    conn.Open();
                    cmd.Parameters.Add(new NpgsqlParameter("@id_prod", prodbox.SelectedValue));
                    cmd.Parameters.Add(new NpgsqlParameter("@preco", precoNV));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        a:;
        }
    }
}
