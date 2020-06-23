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
    public partial class StudentForm : Form
    {
        public string ordb = "Data source=orcl; User Id=hr; Password=hr";
        OracleConnection conn;
        public StudentForm()
        {
            InitializeComponent();

            tabControl1.TabPages.Remove(searchPage);
            tabControl1.TabPages.Remove(enrolledPage);
            tabControl1.TabPages.Remove(projectPage);
            

            idLblStud.Text = StartForm.id;
            nameLblStud.Text = StartForm.name;

            conn = new OracleConnection(ordb);
            conn.Open();


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(mainPage);
            tabControl1.TabPages.Add(projectPage);

            // requirement 1 

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from project ";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView3.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();

            refreshDGV4();

        }

        private void searchBtn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(mainPage);
            tabControl1.TabPages.Add(searchPage);
        }

        private void backBtn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(searchPage);
            tabControl1.TabPages.Add(mainPage);
        }

        private void coursesBtn_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(mainPage);
            tabControl1.TabPages.Add(enrolledPage);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select course_organization.course_id, course_organization.stud_id, courses.* from course_organization, courses where course_organization.stud_id = :id and course_organization.course_id = courses.course_id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", StartForm.id);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView2.Rows.Add(dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
        }

        private void backBtn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(enrolledPage);
            tabControl1.TabPages.Add(mainPage);
            dataGridView2.Rows.Clear();
            
        }

        private void backBtn3_Click(object sender, EventArgs e)
        {
            /*tabControl1.TabPages.Remove(teamsPage);
            tabControl1.TabPages.Add(mainPage);*/
        }

        private void backBtn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(projectPage);
            tabControl1.TabPages.Add(mainPage);
        }

        private void teamsBtn_Click(object sender, EventArgs e)
        {
           /* tabControl1.TabPages.Remove(mainPage);
            tabControl1.TabPages.Add(teamsPage);*/
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm startForm = new StartForm();
            startForm.ShowDialog();
            this.Close();
        }

        private void searchBtn2_Click(object sender, EventArgs e)
        {
            // requirement 5

            dataGridView1.Rows.Clear();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "searchcourses";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("cname", textBox1.Text);
            cmd.Parameters.Add("outpt", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
        }

        private void enrolledPage_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gradesBtn_Click(object sender, EventArgs e)
        {
          
            
            // requirement 4 
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "check_grades";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("grade", OracleDbType.Int32, ParameterDirection.Output);
            cmd.Parameters.Add("s_id", StartForm.id);
            cmd.Parameters.Add("c_id", textBox3.Text);

            int r = cmd.ExecuteNonQuery();
            textBox2.Text = cmd.Parameters["grade"].Value.ToString();
           
            


        }

        private void disenBtn_Click(object sender, EventArgs e)
        {
            // requirement 3 delete

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from course_organization where stud_id = :sid and course_id = :cid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("sid", StartForm.id);
            cmd.Parameters.Add("cid", textBox3.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Disenrolled from course");
            }
            else
                MessageBox.Show("error");
        }

        private void enBtn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            string taID = "";
            cmd.Connection = conn;
            cmd.CommandText = "select ta_id from courses where course_id = :id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", textBox4.Text);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                taID = dr[0].ToString();
            }
            dr.Close();

            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
           
            cmd1.CommandText = "insert into course_organization values(:sid, :tid, :cid, '0', '0')";
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.Add("sid", StartForm.id);
            cmd1.Parameters.Add("tid", taID);
            cmd1.Parameters.Add("cid", textBox4.Text);
            
            int r = cmd1.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("enrolled into course");
            }
            else
                MessageBox.Show("error");
        }

        private void joinBtn_MouseHover(object sender, EventArgs e)
        {
            messageLbl.Text = "Enter Team and Project ID";
        }

        private void createBtn_MouseHover(object sender, EventArgs e)
        {
            messageLbl.Text = "Enter Project ID only";
        }

        private void createBtn_MouseLeave(object sender, EventArgs e)
        {
            messageLbl.Text = ".";
        }

        private void joinBtn_MouseLeave(object sender, EventArgs e)
        {
            messageLbl.Text = ".";
        }

        private void joinBtn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into team values(:sid, :pnum, :tid)";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("sid", StartForm.id);
            cmd.Parameters.Add("pnum", textBox7.Text);
            cmd.Parameters.Add("tid", textBox5.Text);

            int r = cmd.ExecuteNonQuery();
            refreshDGV4();
        }

        private void refreshDGV4()
        {
            dataGridView4.Rows.Clear();
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "select * from team where stud_id = :id";
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.Add("id", StartForm.id);
            OracleDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                dataGridView4.Rows.Add(dr1[0].ToString(), dr1[1].ToString(), dr1[2].ToString());
            }
            dr1.Close();

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            int maxId, newId = 0;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "max_team_id";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("maxval", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            try
            {
                maxId = Convert.ToInt32(cmd.Parameters["maxval"].Value.ToString());
                newId = maxId + 1;
            }
            catch { newId = 1; }


            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "insert into team values(:sid, :pnum, :tid)";
            cmd1.CommandType = CommandType.Text;

            cmd1.Parameters.Add("sid", StartForm.id);
            cmd1.Parameters.Add("pnum", textBox7.Text);
            cmd1.Parameters.Add("tid", newId);

            int r = cmd1.ExecuteNonQuery();
            refreshDGV4();
        }

    }
}
