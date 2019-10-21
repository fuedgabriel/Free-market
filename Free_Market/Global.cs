using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace Free_Market
{
    class Global
    {

        public static string Linha { get; set; }

        public static int usercode { get; set; }
        public static string Database()
        {
            if (Linha != null)
            {
                return (Linha);
            }
            else
            {
                return ("Server=127.0.0.1;Port=5432;User Id=postgres;Password=pgadmin;Database=Fecip;");
            }
        }

        public static bool VerificarMercadoria(string email_inp)
        {
            NpgsqlDataReader data;
            bool a;
            string codigo = "select email from produtos where ";
            using (NpgsqlConnection conn = new NpgsqlConnection(Global.Database()))
            {

                using (NpgsqlCommand cmd = new NpgsqlCommand(codigo, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("@email", email_inp));
                    conn.Open();
                    data = cmd.ExecuteReader();
                }
                if (data.Read())
                {
                    a = true;
                }
                else
                {
                    a = false;
                }

            }
            return a;
        }

        public static bool Verificarprodname(string NomeProd,int IdProd)
        {
            NpgsqlDataReader data;
            bool a;
            string codigo = "select * from produtos where(prod_nome = @nome  and mer_id = @mer_id)";
            using (NpgsqlConnection conn = new NpgsqlConnection(Global.Database()))
            {

                using (NpgsqlCommand cmd = new NpgsqlCommand(codigo, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("@nome", NomeProd));
                    cmd.Parameters.Add(new NpgsqlParameter("@mer_id", IdProd));
                    conn.Open();
                    data = cmd.ExecuteReader();
                }
                if (data.Read())
                {
                    a = true;
                }
                else
                {
                    a = false;
                }

            }
            return a;
        }
        public static bool cat(string Nome)
        {
            NpgsqlDataReader data;
            bool a;
            string codigo = "select * from categoria where cat_nome = @nome";
            using (NpgsqlConnection conn = new NpgsqlConnection(Global.Database()))
            {

                using (NpgsqlCommand cmd = new NpgsqlCommand(codigo, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("@nome", Nome));
                    conn.Open();
                    data = cmd.ExecuteReader();
                }
                if (data.Read())
                {
                    a = true;
                }
                else
                {
                    a = false;
                }

            }
            return a;
        }

        public static bool Merc(string NomeMerc)
        {
            NpgsqlDataReader data;
            bool a;
            string codigo = "select * from mercado where nome = @nome";
            using (NpgsqlConnection conn = new NpgsqlConnection(Global.Database()))
            {

                using (NpgsqlCommand cmd = new NpgsqlCommand(codigo, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("@nome", NomeMerc));
                    conn.Open();
                    data = cmd.ExecuteReader();
                }
                if (data.Read())
                {
                    a = true;
                }
                else
                {
                    a = false;
                }

            }
            return a;
        }

        public static bool Verifemail(string email_inp)
        {
                NpgsqlDataReader data;
                bool a;
                string codigo = "select email from Users where (email = @email)";
                using (NpgsqlConnection conn = new NpgsqlConnection(Global.Database()))
                {
                    
                    using (NpgsqlCommand cmd = new NpgsqlCommand(codigo, conn))
                    {
                        cmd.Parameters.Add(new NpgsqlParameter("@email", email_inp));
                        conn.Open();
                        data = cmd.ExecuteReader();
                    }
                    if (data.Read())
                    {
                        a = true;
                    }
                    else
                    {
                        a = false;
                    }
                    
                }
            return a;
        }

        public static bool Veriflogin(string login_inp)
        {
            bool a;
            NpgsqlDataReader data;
            string codigo = "select login from Users where (login = @login)";
            using (NpgsqlConnection conn = new NpgsqlConnection(Global.Database()))
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(codigo, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("@login",login_inp));
                    conn.Open();
                    data = cmd.ExecuteReader();
                }
                if (data.Read())
                {
                    a = true;
                }
                else
                {
                    a = false;
                }
                conn.Close();
                return a;
            }
        }

    }
}
