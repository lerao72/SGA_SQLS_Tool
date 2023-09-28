using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LT48;

namespace SGA_SQLS_Tool
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            Log.setModoGuardado(Log.ModoGuardado.Directo);
        }



        #region Procedimientos

        private bool restaurarCopiaDeSeguridad()
        {
            bool resultado = false;
            string DB_name = tb_db_name.Text;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.RestoreDirectory = true;
            ofd.FileName = "CS_SQL_SGA.bak";
            ofd.Filter = "Copia de seguridad (*.bak) |*.bak";

            if (ofd.ShowDialog() == DialogResult.OK)
                try
                {
                    DBConexion conexion = new DBConexion(DBConexion.Tipo.SQLServer, tb_DataSource.Text.Trim(), tb_user.Text, tb_psw.Text, "master");
                    conexion.Abre();
                    DB.ejecutaSQL("RESTORE DATABASE [" + DB_name + "] FROM  DISK = N'" + ofd.FileName + "' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 10", conexion);

                    while (conexion.getConexionAbierta())
                        conexion.Cierra();

                    resultado = true;
                }
                catch (Exception ex) { Log.log(ex.Message); }

            return resultado;
        }

        private bool hacerCopiaDeSeguridad()
        {
            bool resultado = false;
            string DB_name = tb_db_name.Text;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.RestoreDirectory = true;
            sfd.FileName = "CS_SQL_SGA.bak";
            sfd.Filter = "Copia de seguridad (*.bak) |*.bak";

            if (sfd.ShowDialog() == DialogResult.OK)
                try
                {
                    DBConexion conexion = new DBConexion(DBConexion.Tipo.SQLServer, tb_DataSource.Text.Trim(), tb_user.Text, tb_psw.Text, "master");
                    conexion.Abre();
                    DB.ejecutaSQL("BACKUP DATABASE [" + DB_name + "] TO  DISK = N'" + sfd.FileName + "' WITH NOFORMAT, INIT,  NAME = N'JARDB-CS', SKIP, NOREWIND, NOUNLOAD,  STATS = 10", conexion);

                    while (conexion.getConexionAbierta())
                        conexion.Cierra();

                    resultado = true;
                }
                catch (Exception ex) { Log.log(ex.Message); }

            return resultado;
        }



        private bool borraBD()
        {
            bool correcta = false;
            string DB_name = tb_db_name.Text;

            try
            {
                DBConexion conexion = null;
                conexion = new DBConexion(DBConexion.Tipo.SQLServer, tb_DataSource.Text.Trim(), tb_user.Text, tb_psw.Text, "master");
                conexion.Abre();

                try { DB.ejecutaSQL("drop database [" + DB_name + "]", conexion); correcta = true; }
                catch (Exception ex) { Log.log(ex.Message); }

                while (conexion.getConexionAbierta())
                    conexion.Cierra();
            }
            catch (Exception ex) { Log.log(ex.Message); }

            return correcta;
        }

        private bool crearBD()
        {
            bool correcta = false;

            string DB_name = tb_db_name.Text;
            DBConexion conexion = null;

            try
            {
                conexion = new DBConexion(DBConexion.Tipo.SQLServer, tb_DataSource.Text.Trim(), tb_user.Text, tb_psw.Text, "master");
                conexion.Abre();
                DB.ejecutaSQL("create database " + DB_name, conexion);
                while (conexion.getConexionAbierta())
                    conexion.Cierra();

                correcta = true;
            }
            catch (Exception ex) { Log.log(ex.Message); }

            return correcta;
        }

        private void comprobarConexionConBD()
        {
            bool conConexion = false;
            bool conBD = false;

            try
            {
                DBConexion conexion = new DBConexion(DBConexion.Tipo.SQLServer, tb_DataSource.Text.Trim(), tb_user.Text, tb_psw.Text, "master");
                conexion.Abre();
                while (conexion.getConexionAbierta())
                    conexion.Cierra();
                conConexion = true;
            }
            catch { conConexion = false; }

            b_nuevaBD.Enabled = conConexion;
            b_restaurarCS.Enabled = conConexion;
            b_generarArchivoServerCFG.Enabled = conConexion;

            if (conConexion)
                try
                {
                    string DB_name = tb_db_name.Text;
                    DBConexion conexion = new DBConexion(DBConexion.Tipo.SQLServer, tb_DataSource.Text.Trim(), tb_user.Text, tb_psw.Text, DB_name);
                    conexion.Abre();

                    System.Data.SqlClient.SqlConnection __laconexion = (System.Data.SqlClient.SqlConnection)conexion.getConexion();

                    while (conexion.getConexionAbierta())
                        conexion.Cierra();

                    __laconexion.Close();
                    __laconexion.Dispose();

                    conBD = true;
                }
                catch { conBD = false; }

            b_realizarCS.Enabled = conBD;
            b_borrarBD.Enabled = conBD;

            l_estadoDeLaConexion.Text = conConexion ? "Conexión correcta" : "Error de conexión";
            if (conBD)
                l_estadoDeLaConexion.Text += "\ny BD presente";

            l_estadoDeLaConexion.ForeColor = !conConexion ? Color.Red : conBD ? Color.Green : Color.Blue;
        }



        private bool generarArchivoServer_cfg()
        {
            bool resultado = false;
            try
            { 
                string fileName = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\server.cfg";
                string contenido = introduceEspacios(tb_DataSource.Text) + "\r\n";
                contenido += introduceEspacios(tb_db_name.Text) + "\r\n";
                contenido += introduceEspacios(tb_user.Text) + "\r\n";
                contenido += introduceEspacios(tb_psw.Text) + "\r\n";
                contenido = Encriptador.encriptarCadena(contenido);
                resultado = Files.guardaFicheroTXT(fileName, contenido) == 1;
            }
            catch (Exception ex) { Log.log(ex.Message); }

            return resultado;
        }

        private string introduceEspacios(string cadena)
        {
            Int32 tamanioPoner = Math.Max(cadena.Length, new Random(DateTime.Now.Millisecond).Next(10, 50));
            return Conversiones.getStringWidthLength(cadena, tamanioPoner, " ", false);
        }

        #endregion





        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            tb_DataSource.Text = System.Environment.MachineName + @"\" + "SQLEXPRESS";
            tb_db_name.Text = "SGA";
            tb_user.Text = "sa";
            tb_psw.Text = "1";

            if (System.IO.File.Exists(@".\borra.flg"))
                try
                {
                    System.IO.File.Delete(@".\borra.flg");
                    string msg = borraBD() ? "Base de datos SGA" : "Error al eliminar la base de datos SGA";
                    System.Windows.Forms.MessageBox.Show(msg, "SGA SQLS Tools");
                }
                catch (Exception ex) { Log.log(ex.Message); }

            comprobarConexionConBD();
        }

        private void t_comprobarConexion_Tick(object sender, EventArgs e)
        {
            t_comprobarConexion.Enabled = false;
            comprobarConexionConBD();
        }

        private void b_nuevaBD_Click(object sender, EventArgs e)
        {
            string msg = crearBD() ? "Base de datos creada" : "Error al crear la base de datos";
            System.Windows.Forms.MessageBox.Show(msg, "SGA SQLS Tools");
            comprobarConexionConBD();
        }

        private void b_borrarBD_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("¿Realmente desea eliminar esta base de datos?", "SGA SQLS Tools", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Windows.Forms.MessageBox.Show("Reinicie la aplicación para borrar la base de datos seleccionada", "SGA SQLS Tools");
                Files.guardaFicheroTXT(@"borra.flg", "");
            }
        }



        private void b_realizarCS_Click(object sender, EventArgs e)
        {
            string msg = hacerCopiaDeSeguridad() ? "Copia de seguridad realizada" : "Error al realizar la copia de seguridad";
            System.Windows.Forms.MessageBox.Show(msg, "SGA SQLS Tools");
        }

        private void b_restaurarCS_Click(object sender, EventArgs e)
        {
            string msg = restaurarCopiaDeSeguridad() ? "Copia de seguridad restaurada" : "Error al restaurar la copia de seguridad";
            System.Windows.Forms.MessageBox.Show(msg, "SGA SQLS Tools");
            comprobarConexionConBD();
        }

        private void b_generarArchivoServerCFG_Click(object sender, EventArgs e)
        {
            string msg = generarArchivoServer_cfg() ? "Archivo server.cfg creado" : "Error al crear el archivo server.cfg";
            System.Windows.Forms.MessageBox.Show(msg, "SGA SQLS Tools");
        }

    } // end class
} // end namespace
