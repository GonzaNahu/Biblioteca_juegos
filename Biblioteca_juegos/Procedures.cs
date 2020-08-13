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
    class Procedures
    {
        public static int ID { get; set; }

        public bool LOGIN(TextBox User, TextBox Pass)
        {
            bool verf = false;
            try
            {
                Global.Conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Conexión");
                Global.Conexion.Close();
            }
            try
            {
                MySqlCommand cmd = new MySqlCommand("LOGIN", Global.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pUser", User.Text);
                cmd.Parameters.AddWithValue("pPass", Pass.Text);

                cmd.ExecuteNonQuery();
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                Global.Conexion.Close();
                if (dt.Rows.Count > 0)
                {
                    DataRow datos = dt.Rows[0];
                    if (datos["usuario"].ToString() == User.Text)
                    {
                        verf = true;
                        Procedures.ID = Convert.ToInt32(datos["ID"]);
                        return verf;
                    }
                    return verf;
                }
                else
                {
                    return verf;
                }

            }
            catch (Exception)
            {
                return verf;
            }

        }

        public void CREATE_USER(TextBox User, TextBox Pass)
        {
            try
            {
                Global.Conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Conexión");
            }
            MySqlTransaction tran = Global.Conexion.BeginTransaction();
            try
            {
                MySqlCommand comand = new MySqlCommand("CREATE_USER", Global.Conexion, tran);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.AddWithValue("pUser", User.Text);
                comand.Parameters.AddWithValue("PPass", Pass.Text);
                comand.ExecuteNonQuery();
                MessageBox.Show("Usuario creado");
                tran.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al crear el usuario");
                tran.Rollback();
            }
            Global.Conexion.Close();
        }

        public bool CHECK_USER(TextBox User)
        {
            bool verf = false;
            try
            {
                Global.Conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Conexión");
                Global.Conexion.Close();
            }
            try
            {
                MySqlCommand cmd = new MySqlCommand("CHECK_USER", Global.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pUser", User.Text);
                cmd.ExecuteNonQuery();
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                Global.Conexion.Close();
                if (dt.Rows.Count > 0)
                {
                    DataRow datos = dt.Rows[0];
                    if (datos["usuario"].ToString() == User.Text)
                    {
                        verf = true;
                        return verf;
                    }
                    return verf;
                }
                else
                {
                    return verf;
                }
            }
            catch (Exception)
            {
                return verf;
            }
        }

        public bool CHECK_PLATAFORM(TextBox Name)
        {
            bool verf = false;
            try
            {
                Global.Conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Conexión");
                Global.Conexion.Close();
            }
            try
            {
                MySqlCommand cmd = new MySqlCommand("CHECK_PLATAFORM", Global.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pName", Name.Text);
                cmd.ExecuteNonQuery();
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                Global.Conexion.Close();
                if (dt.Rows.Count > 0)
                {
                    DataRow datos = dt.Rows[0];
                    if (datos["nombre"].ToString() == Name.Text)
                    {
                        verf = true;
                        return verf;
                    }
                    return verf;
                }
                else
                {
                    return verf;
                }
            }
            catch (Exception)
            {
                return verf;
            }
        }

        public void CREATE_PLATAFORM(TextBox Name, System.Windows.Forms.ComboBox Plataform)
        {
            try
            {
                Global.Conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Conexión");
            }
            MySqlTransaction tran = Global.Conexion.BeginTransaction();
            try
            {
                MySqlCommand comand = new MySqlCommand("CREATE_PLATAFORM", Global.Conexion, tran);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.AddWithValue("pID", Plataform.SelectedValue);
                comand.Parameters.AddWithValue("pName", Name.Text);
                comand.ExecuteNonQuery();
                MessageBox.Show("Plataforma añadida");
                tran.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al crear la plataforma");
                tran.Rollback();
            }
            Global.Conexion.Close();
        }

        public void ADD_GAME(TextBox Name, System.Windows.Forms.ComboBox Plataform, System.Windows.Forms.ComboBox SPlataform, int User)
        {
            try
            {
                Global.Conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Conexión");
            }
            MySqlTransaction tran = Global.Conexion.BeginTransaction();
            try
            {
                MySqlCommand comand = new MySqlCommand("ADD_GAME", Global.Conexion, tran);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.AddWithValue("pName", Name.Text);
                comand.Parameters.AddWithValue("pPlat", Plataform.SelectedValue);
                comand.Parameters.AddWithValue("pSPlat", SPlataform.SelectedValue);
                comand.Parameters.AddWithValue("pUser", User);
                comand.ExecuteNonQuery();
                MessageBox.Show("Juego agregado");
                tran.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar juego");
                tran.Rollback();
            }
            Global.Conexion.Close();
        }

        public bool CHECK_GAME(TextBox Name, System.Windows.Forms.ComboBox Plataform, System.Windows.Forms.ComboBox SPlataform, int User)
        {
            bool verf = false;
            try
            {
                Global.Conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Conexión");
                Global.Conexion.Close();
            }
            try
            {
                MySqlCommand cmd = new MySqlCommand("CHECK_GAME", Global.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pName", Name.Text);
                cmd.Parameters.AddWithValue("pPlat", Plataform.SelectedValue);
                cmd.Parameters.AddWithValue("pSPlat", SPlataform.SelectedValue);
                cmd.Parameters.AddWithValue("pUser", User);
                cmd.ExecuteNonQuery();
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                Global.Conexion.Close();
                if (dt.Rows.Count > 0)
                {
                    DataRow datos = dt.Rows[0];
                    if (datos["c1"].ToString() == Name.Text & datos["c2"].ToString() == Convert.ToString(Plataform.SelectedValue) & datos["c3"].ToString() == Convert.ToString(SPlataform.SelectedValue) & datos["c4"].ToString() == Convert.ToString(User))
                    {
                        verf = true;
                        return verf;
                    }
                    return verf;
                }
                else
                {
                    return verf;
                }
            }
            catch (Exception)
            {
                return verf;
            }
        }

        public void USER_DATA(int User, DataGridView Data)
        {
            try
            {
                Global.Conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Conexión");
            }
            try
            {
                MySqlCommand cmd = new MySqlCommand("USER_DATA", Global.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("pUser", User);
                cmd.ExecuteNonQuery();
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                Data.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al buscar los datos del usuario");
            }
            Global.Conexion.Close();
        }

        public void DATA_DELETE (int ID, int User)
        {
            try
            {
                Global.Conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Conexion");
                Global.Conexion.Close();
            }
            MySqlTransaction tran = Global.Conexion.BeginTransaction();
            try
            {
                MySqlCommand comand = new MySqlCommand("DATA_DELETE", Global.Conexion, tran);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.AddWithValue("pID", ID);
                comand.Parameters.AddWithValue("pUser", User);
                comand.ExecuteNonQuery();
                tran.Commit();
                Global.Conexion.Close();
                MessageBox.Show("Juego quitado de la biblioteca");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo borrar el juego");
                tran.Rollback();
                Global.Conexion.Close();
            }
        }

        public void DATA_MOD (int ID, TextBox Name, System.Windows.Forms.ComboBox Plataform, System.Windows.Forms.ComboBox SPlataform, int User)
        {
            try
            {
                Global.Conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Conexion");
                Global.Conexion.Close();
            }
            MySqlTransaction tran = Global.Conexion.BeginTransaction();
            try
            {
                MySqlCommand comand = new MySqlCommand("DATA_MOD", Global.Conexion, tran);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.AddWithValue("pID", ID);
                comand.Parameters.AddWithValue("pName", Name.Text);
                comand.Parameters.AddWithValue("pPlat", Plataform.SelectedValue);
                comand.Parameters.AddWithValue("pSPlat", SPlataform.SelectedValue);
                comand.Parameters.AddWithValue("pUser", User);
                comand.ExecuteNonQuery();
                tran.Commit();
                Global.Conexion.Close();
                MessageBox.Show("Juego Modificado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo modificar el juego");
                tran.Rollback();
                Global.Conexion.Close();
            }
        }

    }
}
