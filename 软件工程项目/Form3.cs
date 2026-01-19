using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 软件工程项目
{
	//public delegate void UpdateView();

	public partial class Form3 : System.Windows.Forms.Form
	{
		private Form1 form1;
		//Action updateView;
		public Form3(Form1 form1)//Action updateView
		{
			this.form1 = form1;
			InitializeComponent();  
			//this.updateView = updateView;
		}
		public Form3()//Action updateView
		{
			InitializeComponent();
			//this.updateView = updateView;
		}
		private void Form2_Load(object sender,EventArgs e)
		{
		}
		private void button1_Click(object sender,EventArgs e)
		{
			//获取性别和课程的集合值
			string gender1=comboBox1.Items[comboBox1.SelectedIndex].ToString();
			string course1 = comboBox2.Items[comboBox2.SelectedIndex].ToString();
			//插入数据到数据库
			form1.userinsert(textBox1.Text,textBox2.Text,gender1,course1,textBox5.Text,textBox6.Text);
			//更新数据库
			form1.userbind();
			//updateView();

		}
		//以下为输入框判定
		private void textBox1_Validating(object sender,CancelEventArgs e)
		{
			//判断是否为中文
			string pattern = @"^[\u4e00-\u9fff\ufe30-\uffa0]+$";
			if(textBox1.Text=="")
			{

			}
			else
			{
				if(!Regex.IsMatch(textBox1.Text,pattern))
				{
					e.Cancel=true;
					MessageBox.Show("输入类型错误，请重新输入");
					textBox1.Text="";
				}else if(textBox1.Text=="");
			}
		}
		private void textBox2_Validating(object sender,CancelEventArgs e)
		{
			//判断是否为数值
			if(textBox2.Text=="")
			{

			}
			else
			{
				if(!int.TryParse(textBox2.Text,out int a))
				{
					e.Cancel=true;
					MessageBox.Show("输入类型错误，请重新输入");
					textBox2.Text="";
				}
			}	
		}
		private void textBox5_Validating(object sender,CancelEventArgs e)
		{
			//判断是否为中文
			string pattern = @"^[\u4e00-\u9fff\ufe30-\uffa0]+$";
			if(textBox5.Text=="")
			{

			}
			else
			{
				if(!Regex.IsMatch(textBox5.Text,pattern))
				{
					e.Cancel=true;
					MessageBox.Show("输入类型错误，请重新输入");
					textBox5.Text="";
				}else if(textBox1.Text=="");
			}
		}
		private void textBox6_Validating(object sender,CancelEventArgs e)
		{
			if(textBox6.Text=="")
			{

			}
			else
			{
				//判断是否为数值
				if(!int.TryParse(textBox6.Text,out int a))
				{
					e.Cancel=true;
					MessageBox.Show("输入类型错误，请重新输入");
					textBox6.Text="";
				}else if(textBox1.Text=="");
			}
		}
	}
}
