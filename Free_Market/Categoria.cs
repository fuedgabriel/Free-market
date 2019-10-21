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
    public partial class Categoria : UserControl
    {
        public Categoria()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            if (Global.cat(this.CategoriaNome.Text) == true) { MessageBox.Show("Ja Existe Essa Categoria"); goto a; }

            string codigo = "insert into categoria (cat_nome) values(@cat_nome)";
            using (NpgsqlConnection connection = new NpgsqlConnection(Global.Database()))
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(codigo, connection))
                {
                    connection.Open();
                    cmd.Parameters.Add(new NpgsqlParameter("@cat_nome", this.CategoriaNome.Text));
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Cadastrado Com Sucesso");
                    CategoriaNome.Text = "";
                }
            }
        a:;
        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
