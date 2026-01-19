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
	public partial class Form2 : System.Windows.Forms.Form
	{
		public Form2()
		{
			InitializeComponent();
		}
		public void userselect(string sql)
		{
			string sqlstr = "server=.;pwd=123456;uid=sa;database=USERDatabase";
			SqlConnection conn = new SqlConnection(sqlstr);
			conn.Open();
			SqlDataAdapter adpdata = new SqlDataAdapter(sql,conn);
			DataTable dt = new DataTable();
			adpdata.Fill(dt);
			conn.Close();
			if(dt.Rows.Count<=0)
			{
				MessageBox.Show("无此用户信息请重新输入");
			}
			else
			{
				Form1 form1 = new Form1(this);
				MessageBox.Show($"欢迎您登入此系统，尊敬的{dt.Rows[0]["Username"]}同学");
				form1.Show();
				this.Hide();
			}
		}

		private void button1_Click(object sender,EventArgs e)
		{
			string isUser= userb.Text;
			string isPwd = userb1.Text;
			string sql = $"select * from usertable where Userid='{isUser}' and Pwd='{isPwd}'";
		
			userselect(sql);

		}

	}
}
