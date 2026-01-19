using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 软件工程项目
{
	public partial class Form1 : System.Windows.Forms.Form
	{
		private Form2 form2;
		private Form4 form4;
		private int _rightClickedRowIndex = -1;
		private int _rightClickedColumnIndex = -1;

		public Form1(Form2 form)
		{
			InitializeComponent();
			this.form2=form;
		}
		public Form1(Form4 form)
		{
			InitializeComponent();
			this.form4=form;

		}

		//  重新查询数据库，更新UI
		public void userbind()
		{
			dataGridView1.AutoGenerateColumns=false;
			string sqlstr = "server=.;pwd=123456;uid=sa;database=StudentDatabase";
			SqlConnection conn = new SqlConnection(sqlstr);
			conn.Open();
			string sql = "select*from Student";
			SqlDataAdapter adpdata = new SqlDataAdapter(sql,conn);
			DataTable dt = new DataTable();
			adpdata.Fill(dt);
			dataGridView1.DataSource=dt;
			adpdata.SelectCommand.CommandText="select count(*) from Student";
			int count = (int)adpdata.SelectCommand.ExecuteScalar();
			label3.Text="当前班级人数为："+count;
			conn.Close();
		}

		//插入数据库数据
		public void userinsert(string a,string b,string c,string d,string e,string f)
		{

			string sqlstr = "server=.;uid=sa;pwd=123456;database=StudentDatabase";
			SqlConnection conn = new SqlConnection(sqlstr);
			conn.Open();
			string sql = string.Format("INSERT INTO Student (Name, age,Gender, course, HomeAddress, Phone)VALUES('{0}','{1}','{2}','{3}','{4}','{5}')"
				,a,b,c,d,e,f);
			SqlDataAdapter adp = new SqlDataAdapter(sql,conn);
			int t = adp.SelectCommand.ExecuteNonQuery();
			conn.Close();
			if(t==1)
			{
				MessageBox.Show("添加成功");
				form2=new Form2();
				form2.Close();
			}
			else
			{
				MessageBox.Show("添加失败");
			}
		}

		//删除数据库数据
		public void userdelete()
		{
			int usermia = Convert.ToInt32(dataGridView1.Rows[_rightClickedRowIndex].Cells[_rightClickedColumnIndex].Value);
			string sqlstr = "server=.;pwd=123456;uid=sa;database=StudentDatabase";
			SqlConnection conn = new SqlConnection(sqlstr);
			conn.Open();
			string sql = "delete from Student where id="+usermia;
			SqlDataAdapter adpdata = new SqlDataAdapter(sql,conn);
			DataTable dt = new DataTable();
			adpdata.Fill(dt);
			dataGridView1.DataSource=dt;
			conn.Close();
			userbind();	
		}
		//查询数据库数据
		public void userselect(string a,string b)
		{
			string sqlstr = "server=.;pwd=123456;uid=sa;database=StudentDatabase";
			SqlConnection conn = new SqlConnection(sqlstr);
			conn.Open();
			string sql=null;
			if(a!=""&&b=="")
			{
				sql=string.Format("select * from Student where course='{0}'",a);
			}
			else if(a=="--全部--"&&b!="")
			{
				sql = string.Format("select * from Student where name='{0}'",b);
			}
			else if(a!=""&&b!="")
			{
				sql =string.Format("select * from Student where course='{0}'and name='{1}'",a,b);
			}
			SqlDataAdapter adpdata = new SqlDataAdapter(sql,conn);
			DataTable dt = new DataTable();
			adpdata.Fill(dt);
			dataGridView1.DataSource=dt;
			conn.Close();
		}
		

		private void Form2_Load(object sender,EventArgs e)
		{
			//this.dataGridView1.AutoSizeColumnsMode=System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			userbind();
			comboBox1.SelectedIndex=0; // 选中第一项
			comboBox1.SelectedItem="--全部--"; // 选中特定项
			string sqlstr= "server=.;pwd=123456;uid=sa;database=StudentDatabase";
			SqlConnection conn = new SqlConnection(sqlstr);
			conn.Open();
			string sql= "select*from Student";
			SqlDataAdapter adpdata=new SqlDataAdapter(sql,conn);
			DataTable dt = new DataTable();
			adpdata.Fill(dt);
			dataGridView1.DataSource = dt;
			conn.Close();
		}
		private void Form2_FormClosing(object sender,FormClosingEventArgs e)
		{
			form2.Close();
		}
		private void button2_Click(object sender,EventArgs e)
		{
			//Form2 form = new Form2(userbind);
			Form3 form = new Form3(this);
			form.ShowDialog();
		}
		private void 删除ToolStripMenuItem_Click(object sender,EventArgs e)
		{
			userdelete();
		}
		private void dataGridView1_CellMouseClick(object sender,DataGridViewCellMouseEventArgs e)
		{
			if(e.Button==MouseButtons.Right&&e.RowIndex>=0&&e.ColumnIndex>=0)
			{
				// 检查是否点击的是第一列（索引为0）
				if(e.ColumnIndex==0)
				{

					_rightClickedRowIndex=e.RowIndex;
					_rightClickedColumnIndex=e.ColumnIndex;
					// 选中当前单元格
					dataGridView1.CurrentCell=dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

					// 显示ContextMenuStrip1
					contextMenuStrip1.Show(Cursor.Position);

				
				}
			}
		}

		private void button1_Click(object sender,EventArgs e)
		{
			string course = comboBox1.Items[comboBox1.SelectedIndex].ToString();
			string Name = textBox1.Text;
			if(course=="--全部--")
			{
				
				if(Name!="")
				{
					userbind();
					userselect(course,Name);
				}
				else
				{
					textBox1.Text="";
					userbind();
				}
				
			}
			else
			{

					userselect(course,Name);
				
			}
		}
		public DataGridView GetDataGridView()
		{
			return dataGridView1;
		}
		private void button3_Click(object sender,EventArgs e)
		{
			Form4 form4 = new Form4(this);
			form4.Show();
		}
	}
}
