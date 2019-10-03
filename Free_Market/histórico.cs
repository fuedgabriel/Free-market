using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Free_Market
{
    public partial class histórico : UserControl
    {
        public int userid { get; set; }

        public histórico()
        {
            InitializeComponent();
        }

        public void Reload()
        {

            using (NpgsqlConnection conn = new NpgsqlConnection(Global.Database()))
            {
                DataTable tabela = new DataTable();
                NpgsqlDataReader data;
                int i = 0;
                string tituloS = "SELECT * FROM transaçoes where user_id = @userid";
                using (NpgsqlCommand cmd = new NpgsqlCommand(tituloS, conn))
                {
                    tabela.Columns.Add("ID", typeof(int));
                    tabela.Columns.Add("Info", typeof(string));
                    Trans.DisplayMember = "Info";
                    Trans.ValueMember = "ID";
                    cmd.Parameters.Add(new NpgsqlParameter("@userid", userid));
                    conn.Open();
                    data = cmd.ExecuteReader();
                    while (data.Read())
                    {
                        i++;
                        DateTime Data = data.GetDateTime(data.GetOrdinal("data"));
                        string dataa = String.Format("{0}/{1}/{2}", Data.Day, Data.Month, Data.Year);
                        int tran_id = data.GetInt32(data.GetOrdinal("tran_id"));
                        string status = data.GetString(data.GetOrdinal("status"));
                        string aa = string.Format("Codigo:{0} - Data:{1} - Status:{2}", i, dataa, status);
                        tabela.Rows.Add(tran_id, aa);
                    }
                    Trans.DataSource = tabela;

                    conn.Close();
                }
            }
            if (Trans.SelectedValue == null) MessageBox.Show("Você não realizou Nenhuma Compra ainda");
        }

        private void Trans_TabIndexChanged(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();
            using (NpgsqlConnection conn = new NpgsqlConnection(Global.Database()))
            {
                datatable.Columns.Add("item", typeof(int));
                datatable.Columns.Add("Produto", typeof(string));
                datatable.Columns.Add("Preco", typeof(string));
                datatable.Columns.Add("Quantidade", typeof(int));
                NpgsqlDataReader data;
                int i = 0;
                string tituloS = "select * from itens where tran_id = @tran_id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(tituloS, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("@tran_id", this.Trans.SelectedValue));
                    conn.Open();
                    data = cmd.ExecuteReader();
                    while (data.Read())
                    {
                        i++;
                        int quant = data.GetInt32(data.GetOrdinal("quantidade"));
                        int id_prod = data.GetInt32(data.GetOrdinal("id_prod"));
                        datatable.Rows.Add(i,getprodinfo(id_prod, "alo"), getprodinfo(id_prod, "prc"), quant);
                    }
                    conn.Close();
                }
                histgrid.DataSource = datatable;
            }


        }


        public string getprodinfo(int idprod, string aba)
        {
            if (aba == "prc")
            {
                Double abac = 1;
                using (NpgsqlConnection conn = new NpgsqlConnection(Global.Database()))
                {
                    NpgsqlDataReader data;
                    string tituloS = "select * from produtos where id_prod = @id_prod";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(tituloS, conn))
                    {
                        cmd.Parameters.Add(new NpgsqlParameter("@id_prod", idprod));
                        conn.Open();
                        data = cmd.ExecuteReader();
                        if (data.Read())
                        {
                            abac = data.GetDouble(data.GetOrdinal("preco"));
                        }
                        conn.Close();
                        return abac.ToString("n");
                    }
                }
            }
            else
            {
                string abac = "";
                using (NpgsqlConnection conn = new NpgsqlConnection(Global.Database()))
                {
                    NpgsqlDataReader data;
                    string tituloS = "select * from produtos where id_prod = @id_prod";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(tituloS, conn))
                    {
                        cmd.Parameters.Add(new NpgsqlParameter("@id_prod", idprod));
                        conn.Open();
                        data = cmd.ExecuteReader();
                        if (data.Read())
                        {
                            abac = data.GetString(data.GetOrdinal("prod_nome"));
                        }
                        conn.Close();
                        return abac;
                    }
                }
            }

        }
    }
}
