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
    public partial class TAForm : Form
    {

        public string ordb = "Data source=orcl; User Id=hr; Password=hr";
        OracleConnection conn;
        public TAForm()
        {
            InitializeComponent();

            tabControl1.TabPages.Remove(searchPage);
            tabControl1.TabPages.Remove(projectsPage);
            tabControl1.TabPages.Remove(addpPage);
            tabControl1.TabPages.Remove(gradesPage);
            tabControl1.TabPages.Remove(studPage);

            idLblTA.Text = StartForm.id;
            nameLblTA.Text = StartForm.name;

            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void TAForm_Load(object sender, EventArgs e)
        {
         
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm startForm = new StartForm();
            startForm.ShowDialog();
            this.Close();
        }

        private void backBtn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(searchPage);
            tabControl1.TabPages.Add(mainPage);
        }

        private void backBtn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(projectsPage);
            tabControl1.TabPages.Add(mainPage);
        }

        private void searchBtn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(mainPage);
            tabControl1.TabPages.Add(searchPage);
        }

        private void projectsBtn_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(mainPage);
            tabControl1.TabPages.Add(projectsPage);

            refreshDGV2();
        }

        private void searchBtn2_Click(object sender, EventArgs e)
        {
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

        private void gradesBtn_Click(object sender, EventArgs e)
        {

        }

        private void disenBtn_Click(object sender, EventArgs e)
        {

        }

        private void backBtn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(gradesPage);
            tabControl1.TabPages.Add(mainPage);
        }

        private void gradesBtn_Click_1(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(mainPage);
            tabControl1.TabPages.Add(this.gradesPage);

            refreshDGV3();
            
        }

        private void updGradesBtn_Click(object sender, EventArgs e)
        {
            // requirement 3 update

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update course_organization set grades = :grade where stud_id = :sid and course_id = :cid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("grade", textBox4.Text);
            cmd.Parameters.Add("sid", textBox2.Text);
            cmd.Parameters.Add("cid", textBox5.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
                MessageBox.Show("grades updated");
            refreshDGV3();

        }
        private void refreshDGV3()
        {
            dataGridView3.Rows.Clear();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from course_organization where ta_id = :tid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("tid", StartForm.id);

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView3.Rows.Add(dr[0].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
        }

        private void refreshDGV2()
        {
            dataGridView2.Rows.Clear();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from project where ta_id = :tid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("tid", StartForm.id);

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView2.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
        }

        private void upAttBtn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update course_organization set attendance = :att where stud_id = :sid and course_id = :cid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("att", textBox3.Text);
            cmd.Parameters.Add("sid", textBox2.Text);
            cmd.Parameters.Add("cid", textBox5.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
                MessageBox.Show("attendance updated");
            refreshDGV3();

        }

        private void projectsPage_Click(object sender, EventArgs e)
        {

        }

        private void backBtn5_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(studPage);
            tabControl1.TabPages.Add(mainPage);
        }

        private void backBtn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(addpPage);
            tabControl1.TabPages.Add(projectsPage);
        }

        private void addBtn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(projectsPage);
            tabControl1.TabPages.Add(addpPage);
        }

        private void studBtn_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(mainPage);
            tabControl1.TabPages.Add(studPage);

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from student";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView4.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            // requirement 6 delete
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "ta_deleteproj";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("pnum", textBox6.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
                MessageBox.Show("project deleted successfully");
            refreshDGV2();

        }

        private void updateBtn2_Click(object sender, EventArgs e)
        {
            // requirement 6 update
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "ta_updateprojname";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("pnum", textBox6.Text);
            cmd.Parameters.Add("pname", textBox9.Text);
            int r = cmd.ExecuteNonQuery();
            
                MessageBox.Show("project updated successfully");
            refreshDGV2();
        }

        private void updateBtn1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "ta_updateprojdes";
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "update project set p_description = :pdes where p_num = :pnum";
            cmd.Parameters.Add("pdes", textBox9.Text);
            cmd.Parameters.Add("pnum", textBox6.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
                MessageBox.Show("project updated successfully");
            refreshDGV2();
        }

        private void addBtn2_Click(object sender, EventArgs e)
        {
            // requirement 6 insert

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "ta_addproj";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("pnum", textBox7.Text);
            cmd.Parameters.Add("pname", textBox10.Text);
            cmd.Parameters.Add("pdes", textBox8.Text);
            cmd.Parameters.Add("tid", StartForm.id);
            int r = cmd.ExecuteNonQuery();
            /*if (r != -1)
                MessageBox.Show("project added successfully");*/
            MessageBox.Show("project added successfully");
            refreshDGV2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            crystalform2 reportForm = new crystalform2();
            reportForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            crystalform3 reportForm = new crystalform3();
            reportForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            crystalform1 reportForm = new crystalform1();
            reportForm.ShowDialog();
            this.Close();
        }
    }
}
