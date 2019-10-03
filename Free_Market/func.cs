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
    public partial class func : UserControl
    {
        public func()
        {
            InitializeComponent();
        }
        public void reload ()
            {
            using (NpgsqlConnection conn = new NpgsqlConnection(Global.Database()))
            {
                NpgsqlDataReader data;
                string tituloS = "select login,user_id from users";
                using (NpgsqlCommand cmd = new NpgsqlCommand(tituloS, conn))
                {
                    conn.Open();
                    data = cmd.ExecuteReader();
                    DataTable tabela = new DataTable();
                    tabela.Columns.Add("user_id", typeof(int));
                    tabela.Columns.Add("login", typeof(string));
                    tabela.Load(data);
                    usera.DataSource = tabela;
                    usera.DisplayMember = "login";
                    usera.ValueMember = "user_id";
                    conn.Close();
                }
            }
            using (NpgsqlConnection conn = new NpgsqlConnection(Global.Database()))
            {
                NpgsqlDataReader data;
                string tituloS = "select * from cargos";
                using (NpgsqlCommand cmd = new NpgsqlCommand(tituloS, conn))
                {
                    conn.Open();
                    data = cmd.ExecuteReader();
                    DataTable tabela = new DataTable();
                    tabela.Columns.Add("Carg_id", typeof(int));
                    tabela.Columns.Add("Carg_nome", typeof(string));
                    tabela.Load(data);
                    carge.DataSource = tabela;
                    carge.DisplayMember = "Carg_nome";
                    carge.ValueMember = "Carg_id";
                    conn.Close();
                }
            }
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Global.Database()))
            {
                string tituloS = "update Users set carg_id = @id where user_id = @user";
                using (NpgsqlCommand cmd = new NpgsqlCommand(tituloS, conn))
                {
                    conn.Open();
                    cmd.Parameters.Add(new NpgsqlParameter("@user", this.usera.SelectedValue));
                    cmd.Parameters.Add(new NpgsqlParameter("@id", this.carge.SelectedValue));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        private void Func_Load(object sender, EventArgs e)
        {
        }
    }
}
