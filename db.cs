using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace fingerprint
{
    public class db
    {
        public MySqlConnection con, con2, con3, con4, con_local;//declare variable for connection
        public MySqlCommand com, com2, com3, com4, com_local;//varialbe for command
        public MySqlDataReader dr, dr2,dr3, dr4,dr_local;
        public DataTable dt,dt2,dt3, dt4,dt_local;
        public DataSet ds,ds2,ds3, ds4,ds_local;
        public DataView myview;

        //public FormKoneksi formKoneksi = new FormKoneksi();
        string db_server, db_database, db_port, db_user, db_pass, db_other;
        string db_server4, db_database4, db_port4, db_user4, db_pass4, db_other4;
        string db_server_local, db_database_local, db_port_local, db_user_local, db_pass_local, db_other_local;
        public string informasi_koneksi_gagal = "Koneksi ke database gagal !\nKlik \"Yes\" untuk melakukan setting atau \"No\" untuk keluar dari aplikasi";


        public static MySqlConnection getConnection()
        {
            MySqlConnection conn = null;
            try
            {
                string server = System.Configuration.ConfigurationManager.AppSettings["db_server"];
                string database = System.Configuration.ConfigurationManager.AppSettings["db_database"];
                string user = System.Configuration.ConfigurationManager.AppSettings["db_user"];
                string password = StringCipher.Decrypt(System.Configuration.ConfigurationManager.AppSettings["db_pass"]);
                string port = System.Configuration.ConfigurationManager.AppSettings["db_port"];

                string strConn = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + user + ";PORT=" + port + ";PASSWORD=" + password;

                conn = new MySqlConnection(strConn);
            }
            catch (MySqlException sqlex)
            {
                throw new Exception(sqlex.Message.ToString());
            }
            return conn;
        }
        public void getSetting()
        {
            db_server = ConfigurationManager.AppSettings["db_server"];
            db_database = ConfigurationManager.AppSettings["db_database"];
            db_port = ConfigurationManager.AppSettings["db_port"];
            db_user = ConfigurationManager.AppSettings["db_user"];
            db_pass = StringCipher.Decrypt(ConfigurationManager.AppSettings["db_pass"]);
            db_other = ConfigurationManager.AppSettings["db_other"];
            db_server_local = ConfigurationManager.AppSettings["db_server"];
            db_database_local = ConfigurationManager.AppSettings["db_database"];
            db_port_local = ConfigurationManager.AppSettings["db_port"];
            db_user_local = ConfigurationManager.AppSettings["db_user"];
            db_pass_local = StringCipher.Decrypt(ConfigurationManager.AppSettings["db_pass"]);
            db_other_local = ConfigurationManager.AppSettings["db_other"];

            db_server4 = ConfigurationManager.AppSettings["db_server4"];
            db_database4 = ConfigurationManager.AppSettings["db_database4"];
            db_port4 = ConfigurationManager.AppSettings["db_port4"];
            db_user4 = ConfigurationManager.AppSettings["db_user4"];
            db_pass4 = StringCipher.Decrypt(ConfigurationManager.AppSettings["db_pass4"]);
            db_other4 = ConfigurationManager.AppSettings["db_other4"];

        }

        public void getConf()
        {
            getSetting();
            con = new MySqlConnection("SERVER=" + db_server + ";Port=" + db_port + ";DATABASE=" + db_database + ";UID=" + db_user + ";PASSWORD=" + db_pass + ";" + db_other);
        }

        public void getConfLocal()
        {
            getSetting();
            con_local = new MySqlConnection("SERVER=" + db_server_local + ";Port=" + db_port_local + ";DATABASE=" + db_database_local + ";UID=" + db_user_local + ";PASSWORD=" + db_pass_local + ";" + db_other_local);
        }

        public void getConf2()
        {
            getSetting();
            con2 = new MySqlConnection("SERVER=" + db_server_local + ";Port=" + db_port_local + ";DATABASE=" + db_database_local + ";UID=" + db_user_local + ";PASSWORD=" + db_pass_local + ";" + db_other_local);
            //con2 = new MySqlConnection("SERVER=" + db_server + ";Port=" + db_port + ";DATABASE=" + db_database + ";UID=" + db_user + ";PASSWORD=" + db_pass + ";" + db_other);
        }

        public void getConf3()
        {
            getSetting();
            con3 = new MySqlConnection("SERVER=" + db_server_local + ";Port=" + db_port_local + ";DATABASE=" + db_database_local + ";UID=" + db_user_local + ";PASSWORD=" + db_pass_local + ";" + db_other_local);
            //con3 = new MySqlConnection("SERVER=" + db_server + ";Port=" + db_port + ";DATABASE=" + db_database + ";UID=" + db_user + ";PASSWORD=" + db_pass + ";" + db_other);
        }

        public void getConf4()
        {
            getSetting();
            con4 = new MySqlConnection("SERVER=" + db_server4 + ";Port=" + db_port4 + ";DATABASE=" + db_database4 + ";UID=" + db_user4 + ";PASSWORD=" + db_pass4 + ";" + db_other4);
        }

        public void openConn() //to open connection to database
        {
            if ((con != null && con.State == ConnectionState.Closed) || (con == null))//to check if conn is already open or not
            {
                try
                {
                    getConf();
                    con.Open();
                }
                catch
                {
                    DialogResult result1 = MessageBox.Show(informasi_koneksi_gagal, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result1 == DialogResult.Yes)
                    {
                        if (con.State == ConnectionState.Closed)
                        {
                            
                                getConf();
                                con.Open();
                              
                        }
                    }
                }
            }
        }

        public void openConnLocal() //to open connection to database
        {
            if ((con_local != null && con_local.State == ConnectionState.Closed) || (con_local == null))//to check if conn is already open or not
            {
                try
                {
                    getConfLocal();
                    con_local.Open();
                }
                catch
                {
                    DialogResult result1 = MessageBox.Show(informasi_koneksi_gagal, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result1 == DialogResult.Yes)
                    {
                        if (con_local.State == ConnectionState.Closed)
                        {
                           
                                getConfLocal();
                                con_local.Open();
                          
                        }
                    }
                }
            }
        }

        public void openConn2() //to open connection to database
        {
            if ((con2 != null && con2.State == ConnectionState.Closed) || (con2 == null))//to check if conn is already open or not
            {
                try
                {
                    getConf2();
                    con2.Open();
                }
                catch
                {
                    DialogResult result1 = MessageBox.Show(informasi_koneksi_gagal,"Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    if (result1 == DialogResult.Yes)
                    {
                        if (con2.State == ConnectionState.Closed)
                        {
                           
                                getConf2();
                                con2.Open();
                             
                        }
                    }
                }
            }
        }

        public void openConn3() //to open connection to database
        {
            if ((con3 != null && con3.State == ConnectionState.Closed) || (con3 == null))//to check if conn is already open or not
            {
                try
                {
                    getConf3();
                    con3.Open();
                }
                catch
                {
                    DialogResult result1 = MessageBox.Show(informasi_koneksi_gagal, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result1 == DialogResult.Yes)
                    {
                        if (con3.State == ConnectionState.Closed)
                        {
                           
                                getConf3();
                                con3.Open();
                               
                        }
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }

        public void openConn4() //to open connection to database
        {
            if ((con4 != null && con4.State == ConnectionState.Closed) || (con4 == null))//to check if conn is already open or not
            {
                try
                {
                    getConf4();
                    con4.Open();
                }
                catch
                {
                    DialogResult result1 = MessageBox.Show(informasi_koneksi_gagal, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result1 == DialogResult.Yes)
                    {
                        if (con3.State == ConnectionState.Closed)
                        {
                           
                                getConf4();
                                con4.Open();
                               
                        }
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }

        public void closeConn() //to close connection to database
        {
            if (con!=null && con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public void closeConnLocal() //to close connection to database
        {
            if (con_local != null && con_local.State == ConnectionState.Open)
            {
                con_local.Close();
            }
        }

        public void closeConn2() //to close connection to database
        {
            if (con2 != null && con2.State == ConnectionState.Open)
            {
                con2.Close();
            }
        }

        public void closeConn3() //to close connection to database
        {
            if (con3 != null && con3.State == ConnectionState.Open)
            {
                con3.Close();
            }
        }

        public void closeConn4() //to close connection to database
        {
            if (con4 != null && con3.State == ConnectionState.Open)
            {
                con4.Close();
            }
        }

        public void ExecuteQuery(string sqlQuery) //method to use sql 
        {
            openConn();
            com = new MySqlCommand(sqlQuery, con);
            com.CommandTimeout = 12000;
            com.ExecuteNonQuery();
        }

        public void ExecuteQuery4(string sqlQuery) //method to use sql 
        {
            openConn4();
            com4 = new MySqlCommand(sqlQuery, con4);
            com4.ExecuteNonQuery();
        }

        public void ExecuteQueryLocal(string sqlQuery) //method to use sql 
        {
            openConn2();
            com2 = new MySqlCommand(sqlQuery, con2);
            com2.ExecuteNonQuery();
        }

        public void ReadQuery(string sqlQuery) //method to use sql 
        {
            openConn();
            com = new MySqlCommand(sqlQuery, con);
            com.CommandTimeout = 1000;
            dr = com.ExecuteReader();
        }
        
        

        public void ReadQueryLocal(string sqlQuery) //method to use sql 
        {
            openConnLocal();
            com_local = new MySqlCommand(sqlQuery, con_local);
            dr_local = com_local.ExecuteReader();
        }

        public void ReadQuery2(string sqlQuery) //method to use sql 
        {
            openConn2();
            com2 = new MySqlCommand(sqlQuery, con2);
            com2.CommandTimeout = 1000;
            dr2 = com2.ExecuteReader();
        }

        public void ReadQuery3(string sqlQuery) //method to use sql 
        {
            openConn3();
            com3 = new MySqlCommand(sqlQuery, con3);
            dr3 = com3.ExecuteReader();
        }

        public void ReadQuery4(string sqlQuery) //method to use sql 
        {
            openConn4();
            com4 = new MySqlCommand(sqlQuery, con4);
            dr4 = com4.ExecuteReader();
        }

        public void CloseQuery() //method to use sql 
        {
            dr.Close();
        }

        public void CloseQueryLocal() //method to use sql 
        {
            dr_local.Close();
        }

        public void CloseQuery2() //method to use sql 
        {
            dr2.Close();
        }
        
        public void CloseQuery3() //method to use sql 
        {
            dr3.Close();
        }

        public void CloseQuery4() //method to use sql 
        {
            dr4.Close();
        }
    }
}
