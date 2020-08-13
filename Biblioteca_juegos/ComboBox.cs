using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Biblioteca_juegos
{
    class ComboBox
    {
        public int ID { get; set; }
        public string Plataforma { get; set; }

        public int IDS { get; set; }
        public string SPlataforma { get; set; }

        public List<ComboBox> PLATAFORMAS()
        {
            List<ComboBox> lista = new List<ComboBox>();
            Global.Conexion.Open();
            MySqlTransaction tran = Global.Conexion.BeginTransaction();
            try
            {
                MySqlCommand comand = new MySqlCommand("OBTENER_PLATAFORMAS", Global.Conexion, tran);
                comand.CommandType = CommandType.StoredProcedure;
                comand.ExecuteNonQuery();
                tran.Commit();
                MySqlDataReader lector = comand.ExecuteReader();
                while (lector.Read())
                {
                    ComboBox ent = new ComboBox();
                    ent.ID = lector.GetInt32(0);
                    ent.Plataforma = lector.GetString(1);
                    lista.Add(ent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al obtener el listado");
                tran.Rollback();
            }
            Global.Conexion.Close();
            return lista;
        }

        public List<ComboBox> SPLATAFORMAS(System.Windows.Forms.ComboBox Plataform)
        {
            List<ComboBox> lista = new List<ComboBox>();
            Global.Conexion.Open();
            MySqlTransaction tran = Global.Conexion.BeginTransaction();
            try
            {
                MySqlCommand comand = new MySqlCommand("OBTENER_SPLATAFORMAS", Global.Conexion, tran);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.AddWithValue("pID", Plataform.SelectedValue);
                comand.ExecuteNonQuery();
                tran.Commit();
                MySqlDataReader lector = comand.ExecuteReader();
                while (lector.Read())
                {
                    ComboBox ent = new ComboBox();
                    ent.IDS = lector.GetInt32(0);
                    ent.SPlataforma = lector.GetString(1);
                    lista.Add(ent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al obtener el listado");
                tran.Rollback();
            }
            Global.Conexion.Close();
            return lista;
        }
    }
}
