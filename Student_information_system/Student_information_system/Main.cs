using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_information_system
{
    public partial class Main : Form
    {
          public Main()
        {        
            InitializeComponent();
        }

        bool sidebarExpand;

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            //SET the Minimum and maximum size of sidebar Panel
            if (sidebarExpand)
            {
                //if sidebar is expand , minimize
                sidebar.Width -= 10;

                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
             }

            }
        }
        private void menubutton_Click(object sender, EventArgs e)
        {
            //set timer interval to lowest to make it smoother
            sidebarTimer.Start();
          
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            SqlConnection con = new SqlConnection(DALC.GetConnectionString());
            con.Open();
               SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("SELECT * FROM STD_INFO WHERE STD_ID='" + Variables.userId + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    std_number.Text = dr["STD_NUMBER"].ToString();
                    std_name.Text = dr["INFO_NAME"].ToString();
                    std_speciality.Text = dr["INFO_SPECIALITY"].ToString();
                    std_grcode.Text = dr["INFO_GRCODE"].ToString();
                    std_adviser.Text = dr["INFO_ACADVISER"].ToString();
                    std_status.Text = dr["INFO_STATUS"].ToString();
                    std_distopic.Text = dr["INFO_DISTOPIC"].ToString();
                    std_tuidebt.Text = dr["INFO_TUIDEBT"].ToString();
                    std_hosteldebt.Text = dr["INFO_HOSTELDEBT"].ToString();
                    std_tuifee.Text = dr["INFO_ANNUALDEBT"].ToString();
                    std_payform.Text = dr["INFO_PAYFORM"].ToString();
                    std_score.Text = dr["INFO_ENTSCORE"].ToString();
                    std_gmail.Text = dr["INFO_GMAIL"].ToString();
                }
                con.Close();
                con.Dispose();

            

        }
             private void upload_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog= new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation= dialog.FileName;
                    uploadpic.ImageLocation = imageLocation;

                    uploadpic.ImageLocation = imageLocation;
                }
            }
            catch
            {
                MessageBox.Show("An Error Occured","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn__dprt_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DepartmentsandPrograms().Show();
        }
        
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_crsstructure_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Course_Structure().Show();
            
        }

        private void btn_schedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            courseschedule schedule = new courseschedule();
            schedule.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            gradelist grdlist= new gradelist();
            grdlist.Show();
        }
    }
    }

