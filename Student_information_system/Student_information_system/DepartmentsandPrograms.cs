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
    public partial class DepartmentsandPrograms : Form
    {
      
        public DepartmentsandPrograms()
        {
          
            InitializeComponent();
        }

        private void DepartmentsandPrograms_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BringDepartments();
        }
        private void BringDepartments()
        {


           SqlConnection con= new SqlConnection(DALC.GetConnectionString());
            con.Open(); 
            
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("SELECT * FROM DEPARTMENTS", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    departments_dgw.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("NO ROW");
                }

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                cmd.ExecuteReader();    //update insert delete -ExecuteNoNQuery()
                                        //ExecueScalar()-select
                                        //ExecuteReader()- select
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {

                con.Close();
                con.Dispose(); //garbage collector
            }
        }

        

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main().Show();

        }

        private void btn_depp_Click(object sender, EventArgs e)
        {

        }

        private void btn_structure_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Course_Structure().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new courseschedule().Show();
        }
    }

    }
