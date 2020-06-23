using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace project_db
{
    public partial class StartForm : Form
    {
        public string ordb = "Data source=orcl; User Id=hr; Password=hr";
        OracleConnection conn;

        public static string id, name;

        public StartForm()
        {
            InitializeComponent();
            label3.Hide();
            textBox1.Hide();
            label5.Hide();
            label6.Hide();
            textBox5.Hide();
            textBox4.Hide();
            signUpBtn.Hide();
            button1.Hide();

            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*conn = new OracleConnection(ordb);
            conn.Open();*/
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label3.Show();
            textBox1.Show();
            label5.Show();
            label6.Show();
            textBox5.Show();
            textBox4.Show();
            signUpBtn.Show();
            button1.Show();

            linkLabel1.Hide();
            signInBtn.Hide();
            startLbl.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Hide();
            textBox1.Hide();
            label5.Hide();
            label6.Hide();
            textBox5.Hide();
            textBox4.Hide();
            signUpBtn.Hide();
            button1.Hide();

            startLbl.Show();
            linkLabel1.Show();
            signInBtn.Show();
            startLbl.Show();

        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            // requirement 2

            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "select username, password from user_info where username = :usrnm and password = :pswrd";
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.Add("usrnm", textBox2.Text);
            cmd1.Parameters.Add("pswrd", textBox3.Text);
            OracleDataReader dr1 = cmd1.ExecuteReader();
            int flag = 0;
            if (dr1.Read())
            {
                flag = 1;
            }
            else
            {
                MessageBox.Show("username or password is incorrect!");
            }
            dr1.Close();
            if (flag == 1)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select stud_id, stud_name from student where username = :usrnm";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("usrnm", textBox2.Text);
                    OracleDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        id = dr[0].ToString();
                        name = dr[1].ToString();
                    }
                    dr.Close();

                    this.Hide();
                    StudentForm studForm = new StudentForm();
                    studForm.ShowDialog();
                    this.Close();
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select lec_id, lec_name from lecturer where username = :usrnm";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("usrnm", textBox2.Text);
                    OracleDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        id = dr[0].ToString();
                        name = dr[1].ToString();
                    }
                    dr.Close();

                    this.Hide();
                    LecturerForm lecForm = new LecturerForm();
                    lecForm.ShowDialog();
                    this.Close();
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select ta_id, ta_name from TA where username = :usrnm";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("usrnm", textBox2.Text);
                    OracleDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        id = dr[0].ToString();
                        name = dr[1].ToString();
                    }
                    dr.Close();

                    this.Hide();
                    TAForm taForm = new TAForm();
                    taForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please choose a role!");
                }
            }
            
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            //requirement 3 insert

            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "insert into user_info values(:usrnm, :pswrd, :email)";
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.Add("usrnm", textBox2.Text);
            cmd1.Parameters.Add("pswrd", textBox3.Text);
            cmd1.Parameters.Add("email", textBox1.Text);
            int r = cmd1.ExecuteNonQuery();
            
            if (r != -1)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                if(comboBox1.SelectedIndex == 0)
                    cmd.CommandText = "insert into student values(:id1, :name1, :usrnm)";

                else if (comboBox1.SelectedIndex == 1)
                    cmd.CommandText = "insert into lecturer values(:id1, :name1, :usrnm)";

                else if (comboBox1.SelectedIndex == 2)
                    cmd.CommandText = "insert into ta values(:id1, :name1, :usrnm)";

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("id1", textBox5.Text);
                cmd.Parameters.Add("name1", textBox4.Text);
                cmd.Parameters.Add("usrnm", textBox2.Text);
                r = cmd.ExecuteNonQuery();
                if (r != -1)
                    MessageBox.Show("done");
            }
            
            label3.Hide();
            label5.Hide();
            label6.Hide();
            textBox5.Hide();
            textBox4.Hide();
            textBox1.Hide();
            signUpBtn.Hide();
            button1.Hide();

            linkLabel1.Show();
            signInBtn.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
