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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public SqlConnection Connect()
        {
            try
            {
                var con = new SqlConnection(DALC.GetConnectionString());
                con.Open();
                return con;
            }

            catch
            {
                return null;
            }
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_status.Visible = true;
                using (var con = Connect())
                {
                    string txtUser = tb_lognumber.Text.Trim();
                    string txtpaswd = tb_loginpass.Text.Trim();

                    var sql ="SELECT std_id FROM STD_LOGIN WHERE STD_NUMBER=@user AND STD_PASSWORD=@paswd";// now only valid record will be returned..else nothing


                    using (var cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add(new SqlParameter("@user", txtUser));
                        cmd.Parameters.Add(new SqlParameter("@paswd", txtpaswd));
                        var reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            var std_id = reader.GetInt32(0).ToString();
                            Variables.userId = std_id;
                            this.Hide();
                            new Main().Show();
                            
                        }

                        else
                        {
                            tb_lognumber.Text = null;
                            tb_loginpass.Text = null;
                            lbl_status.Text = "Username or password is incorrect!";

                        }
                    }
                    con.Close();
                    con.Dispose();

                }
            }


            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

           
                
            
        }


        private void tb_lognumber_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))  // Restricts the input of letter characters from the keyboard.
            {
                e.Handled = true;
            }

        }

        private void cb_CheckedChanged_1(object sender, EventArgs e)
        {
            tb_loginpass.PasswordChar = cb.Checked ? '\0' : '•';
        }

        private void lbl_mail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch 
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
           lbl_mail.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://accounts.google.com/v3/signin/identifier?dsh=S822774928%3A1670160630026219&elo=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin&ifkv=ARgdvAsQybIQpKDQBH2z3yDNTI8BcCSPCKdZlpVd0InNPkEZR4SxkOlkU6_mhzE2h-nxhB98pNZ4"); 
    }
    }
}
