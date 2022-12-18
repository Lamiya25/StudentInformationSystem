using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Student_information_system
{
    public partial class gradelist : Form
    {
        public gradelist()
        {
            InitializeComponent();
        }

        private void cb_sem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_sem.SelectedItem.ToString() == "(2020-2021) 1. Semester")
            {
                Bring20202021firstsem();
            }

            else if(cb_sem.SelectedItem.ToString() == "(2020-2021) 2. Semester")
            {
                Bring20202021secondsem();
            }

        
        }


        private void Bring20202021firstsem()
        {
            SqlConnection con = new SqlConnection(DALC.GetConnectionString());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("SELECT [Lesson Code], N, M, L, [Name of the Lesoon], AKTS, Dav, [SDF-1], TSI, DVM, [S-SI], AVERAGE FROM semestr_2020_2021_1 WHERE STD_ID='" + Variables.userId + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                grades_dgw.DataSource = dt;
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
                cmd.ExecuteReader();   
                                       
                                        
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {

                con.Close();
                con.Dispose(); 
            }
        }


        private void Bring20202021secondsem()
        {
            SqlConnection con = new SqlConnection(DALC.GetConnectionString());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("SELECT [Lesson code], N, M, L, [Lesson name], AKTS, Dav, SDF1, TSI, DVM, SSI, [AVERAGE POINT] FROM semestr_2020_2021_2 WHERE STD_ID='" + Variables.userId + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                grades_dgw.DataSource = dt;
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
                cmd.ExecuteReader();    
                                        
                                     
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {

                con.Close();
                con.Dispose(); 
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main().Show();

        }

        private void btn_depp_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DepartmentsandPrograms().Show();
        }

        private void bnt_schedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            new courseschedule().Show();
        }

        private void btn_structure_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Course_Structure().Show();
        }

        private void menubutton_Click(object sender, EventArgs e)
        {
            sidebar.Visible= !sidebar.Visible;
        }

       
    }
}
