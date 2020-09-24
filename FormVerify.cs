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
    public partial class FormVerify : CaptureForm
    {

        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        private fingerdbEntities contexto;

        public void Verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }

        protected override void Init()
        {
            base.Init();
            base.Text = "Fingerprint Verification";
            Verificator = new DPFP.Verification.Verification();     // Create a fingerprint template verificator
            UpdateStatus(0);
        }

        private void UpdateStatus(int FAR)
        {
            // Show "False accept rate" value
            SetStatus(String.Format("False Accept Rate (FAR) = {0}", FAR));
        }

        protected override void Process(DPFP.Sample Sample)
        {
            //base.Process(Sample);
            //
            //// Process the sample and create a feature set for the enrollment purpose.
            //DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);
            //
            //// Check quality of the sample and start verification if it's good
            //// TODO: move to a separate task
            //if (features != null)
            //{
            //    // Compare the feature set with our template
            //    DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
            //
            //    DPFP.Template template = new DPFP.Template();
            //    Stream stream;
            //
            //    foreach (var emp in contexto.t_employee)
            //    {
            //        stream = new MemoryStream(emp.fingercode);
            //        template = new DPFP.Template(stream);
            //
            //        Verificator.Verify(features, template, ref result);
            //        UpdateStatus(result.FARAchieved);
            //        if (result.Verified)
            //        {
            //            MakeReport("The fingerprint was VERIFIED. " + emp.name);
            //            break;
            //        }
            //    }
            //
            //    
            //
            //
            //
            //}


            db dbHandle = new db();
            dbHandle.openConn();
            //MySqlConnection conn = new MySqlConnection("Your connection string");
            //conn.Open();
            MySqlCommand cmd = new MySqlCommand("select * from t_employee", dbHandle.con);
            MySqlDataAdapter sd = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            




            base.Process(Sample);
            
            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);
            
            // Check quality of the sample and start verification if it's good
            // TODO: move to a separate task
            if (features != null)
            {
                // Compare the feature set with our template
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
            
                DPFP.Template template = new DPFP.Template();
                Stream stream;
          
                foreach (DataRow dr in dt.Rows)
                    {
                    string nama = dr["name"].ToString();

                    byte[] _img = (byte[])dr["fingercode"];
                    stream = new MemoryStream(_img);
                        template = new DPFP.Template(stream);
                
                        Verificator.Verify(features, template, ref result);
                        UpdateStatus(result.FARAchieved);
                        if (result.Verified)
                        {
                            MakeReport("The fingerprint was VERIFIED.+"+ nama +"");
                            break;
                        }
                    }
          
            
            }

             dbHandle.closeConn();
        }
        public FormVerify()
        {
            contexto = new fingerdbEntities();
            InitializeComponent();
        }
    }
}
