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
    public partial class LecturerForm : Form
    {
        public string ordb = "Data source=orcl; User Id=hr; Password=hr";
        OracleConnection conn;

        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;

        public LecturerForm()
        {
            InitializeComponent();

            tabControl1.TabPages.Remove(searchPage);
            tabControl1.TabPages.Remove(coursesPage);
            tabControl1.TabPages.Remove(taPage);

            idLblLec.Text = StartForm.id;
            nameLblLec.Text = StartForm.name;

            conn = new OracleConnection(ordb);
            conn.Open();
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
            tabControl1.TabPages.Remove(coursesPage);
            tabControl1.TabPages.Add(mainPage);
        }

        private void searchBtn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(mainPage);
            tabControl1.TabPages.Add(searchPage);
        }

        private void coursesBtn_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(mainPage);
            tabControl1.TabPages.Add(coursesPage);

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

        private void taBtn_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(mainPage);
            tabControl1.TabPages.Add(taPage);

            // disconnected 2

            string cmdstr = "select * from TA ";
            adapter = new OracleDataAdapter(cmdstr, ordb);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
        }

        private void LecturerForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(taPage);
            tabControl1.TabPages.Add(mainPage);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox5.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox4.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            // disconnected 3 insert

            string cmdstr = "insert into courses values (:cname, :cdes, :cid, :lid, :tid)";
            adapter = new OracleDataAdapter(cmdstr, ordb);
            adapter.SelectCommand.Parameters.Add("cname", textBox5.Text);
            adapter.SelectCommand.Parameters.Add("cdes", textBox2.Text);
            adapter.SelectCommand.Parameters.Add("cid", textBox4.Text);
            adapter.SelectCommand.Parameters.Add("lid", StartForm.id);
            adapter.SelectCommand.Parameters.Add("tid", textBox3.Text);

            builder = new OracleCommandBuilder(adapter);
            //ds = new DataSet();
            adapter.Fill(ds);
            adapter.Update(ds.Tables[0]);
            //dataGridView2.DataSource = ds.Tables[0];
            refreshDGV2();
        }
        private void refreshDGV2()
        {
            //dataGridView2.Rows.Clear();

            //disconnected 1

            string cmdstr = "select * from courses where lec_id = :id ";
            adapter = new OracleDataAdapter(cmdstr, ordb);
            adapter.SelectCommand.Parameters.Add("id", StartForm.id);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            
            //disconnected 3 update
            
            string cmdstr = "update courses set course_name = :cname, c_description = :cdes, ta_id = :tid where course_id = :cid and lec_id = :lid";
            adapter = new OracleDataAdapter(cmdstr, ordb);
            adapter.SelectCommand.Parameters.Add("cname", textBox5.Text);
            adapter.SelectCommand.Parameters.Add("cdes", textBox2.Text);
            adapter.SelectCommand.Parameters.Add("tid", textBox3.Text);
            adapter.SelectCommand.Parameters.Add("cid", textBox4.Text);
            adapter.SelectCommand.Parameters.Add("lid", StartForm.id);

            builder = new OracleCommandBuilder(adapter);
            adapter.Fill(ds);
            adapter.Update(ds.Tables[0]);
            refreshDGV2();
        }

        private void coursesPage_Click(object sender, EventArgs e)
        {

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            //disconnected 3 delete
            
            string cmdstr = "delete from courses where course_id = :cid";
            adapter = new OracleDataAdapter(cmdstr, ordb);
            adapter.SelectCommand.Parameters.Add("cid", textBox4.Text);

            builder = new OracleCommandBuilder(adapter);
            adapter.Fill(ds);
            adapter.Update(ds.Tables[0]);
            refreshDGV2();
        }
    }
}
