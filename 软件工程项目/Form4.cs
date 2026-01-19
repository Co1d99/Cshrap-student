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

namespace 软件工程项目
{
	public partial class Form4 :Form
	{
		//private Form1 _form1;
		Form1 form1;
		private object currentCellValue;

		public Form4(Form1 form1)
		{
			InitializeComponent();
			this.form1=form1;
	

		}
		
		//更新数据库数据
		public void changeupdate()
		{
			string sqlstr = "server=.;pwd=123456;uid=sa;database=StudentDatabase";
			SqlConnection conn = new SqlConnection(sqlstr);
			conn.Open();
			string sql = "select*from Student where id = "+(int)currentCellValue;
			SqlDataAdapter adpdata = new SqlDataAdapter(sql,conn);
			DataTable dt = new DataTable();
			adpdata.Fill(dt);
			this.textBox1.Text=dt.Rows[0]["Name"].ToString();
			this.textBox2.Text=dt.Rows[0]["age"].ToString();
			this.textBox3.Text=dt.Rows[0]["Gender"].ToString();
			this.textBox4.Text=dt.Rows[0]["course"].ToString();
			this.textBox5.Text=dt.Rows[0]["HomeAddress"].ToString();
			this.textBox6.Text=dt.Rows[0]["Phone"].ToString();
			conn.Close();
		}

		private void Form4_Load(object sender,EventArgs e)
		{
			



		}

		private void button2_Click(object sender,EventArgs e)
		{
			DataGridView dgv = form1.GetDataGridView();
			if(dgv.CurrentCell.Value!=null)
			{
				currentCellValue = dgv.CurrentCell.Value;
				changeupdate();
			}

		}

		private void button1_Click(object sender,EventArgs e)
		{
			string sqlstr = "server=.;pwd=123456;uid=sa;database=StudentDatabase";
			SqlConnection conn = new SqlConnection(sqlstr);
			conn.Open();
			string sql = string.Format("update Student set Name='{0}',age={1},Gender='{2}',course='{3}',HomeAddress='{4}',Phone='{5}'where id={6}"
				,this.textBox1.Text,this.textBox2.Text,this.textBox3.Text,this.textBox4.Text,this.textBox5.Text,this.textBox6.Text,currentCellValue);
			SqlDataAdapter adpdata = new SqlDataAdapter(sql,conn);
			DataTable dt = new DataTable();
			adpdata.Fill(dt);
			conn.Close();

			form1.userbind();
		}
	}
}
