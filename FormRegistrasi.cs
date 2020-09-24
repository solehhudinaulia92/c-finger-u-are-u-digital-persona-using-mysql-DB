using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace fingerprint
{
    public partial class FormRegistrasi : Form
    {
        public db dbHandle = new db();
        private DPFP.Template Template;
        private fingerdbEntities contexto;
        public FormRegistrasi()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            FormCaptureCode fc = new FormCaptureCode();
            fc.OnTemplate += this.OnTemplate;
            fc.ShowDialog();
        }

        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                btnsimpan.Enabled = (Template != null);
                if (Template != null)
                {
                    MessageBox.Show("The fingerprint template is ready for fingerprint verification.", "Fingerprint Enrollment");
                    txtcode.Text = "capture correct";
                }
                else
                {
                    MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment");
                }
            }));
        }

        private void FormRegistrasi_Load(object sender, EventArgs e)
        {
            contexto = new fingerdbEntities();
            Listar();
        }

        private void Limpiar()
        {
            txtnama.Text = "";
            txtid.Text = "";
        }

        private void Listar()
        {
            try
            {
                var empleados = from emp in contexto.t_employee
                                select new
                                {
                                    ID = emp.id,
                                    EMPLEADO = emp.name
                                };
                if (empleados != null)
                {
                    dgvlist.DataSource = empleados.ToList();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        byte[] byted;
        private void featureS()
        {
            this.Invoke(new Function(delegate ()
            {
                MemoryStream fingerprintData = new MemoryStream();
                Template.Serialize(fingerprintData);
                byted = fingerprintData.ToArray();
                string base64 = System.Convert.ToBase64String(byted);
                //dbHandle.ExecuteQuery("INSERT INTO t_employee(`name`,`fingercode`) VALUES('" + txtnama.Text + "','" + byted + "')");


                //MySqlConnection conn = new MySqlConnection("Your connection string");
                dbHandle.openConn();
                MySqlCommand cmd = new MySqlCommand();



                string CmdString = "INSERT INTO t_employee(name, fingercode) VALUES(@FirstName, @Image)";
                cmd = new MySqlCommand(CmdString, dbHandle.con);
                cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@Image", MySqlDbType.Blob);
                cmd.Parameters["@FirstName"].Value = txtnama.Text;
                cmd.Parameters["@Image"].Value = byted;

                dbHandle.openConn();
                int RowsAffected = cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Image saved sucessfully!");
                }
                dbHandle.closeConn();
                //insert your mysql command here then
            }));
        }
        private void btnsimpan_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] streamHuella = Template.Bytes;
                t_employee empleado = new t_employee()
                {
                    id = Convert.ToInt16(txtid.Text),
                    name = txtnama.Text,
                    fingercode = streamHuella
                };

                featureS();
                contexto.t_employee.Add(empleado);
                contexto.SaveChanges();
                MessageBox.Show("Record added successfully Bro");
                Limpiar();
                Listar();
                Template = null;
                btnsimpan.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
