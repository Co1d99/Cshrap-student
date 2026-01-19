namespace 软件工程项目
{
	partial class Form3
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing&&(components!=null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.name = new System.Windows.Forms.Label();
			this.age = new System.Windows.Forms.Label();
			this.gender = new System.Windows.Forms.Label();
			this.course = new System.Windows.Forms.Label();
			this.homeaddress = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.phone = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(126, 297);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(248, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "确认添加";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// name
			// 
			this.name.AutoSize = true;
			this.name.Location = new System.Drawing.Point(126, 81);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(29, 12);
			this.name.TabIndex = 1;
			this.name.Text = "姓名";
			// 
			// age
			// 
			this.age.AutoSize = true;
			this.age.Location = new System.Drawing.Point(126, 114);
			this.age.Name = "age";
			this.age.Size = new System.Drawing.Size(29, 12);
			this.age.TabIndex = 2;
			this.age.Text = "年龄";
			// 
			// gender
			// 
			this.gender.AutoSize = true;
			this.gender.Location = new System.Drawing.Point(126, 147);
			this.gender.Name = "gender";
			this.gender.Size = new System.Drawing.Size(29, 12);
			this.gender.TabIndex = 3;
			this.gender.Text = "性别";
			// 
			// course
			// 
			this.course.AutoSize = true;
			this.course.Location = new System.Drawing.Point(124, 180);
			this.course.Name = "course";
			this.course.Size = new System.Drawing.Size(29, 12);
			this.course.TabIndex = 4;
			this.course.Text = "课程";
			// 
			// homeaddress
			// 
			this.homeaddress.AutoSize = true;
			this.homeaddress.Location = new System.Drawing.Point(126, 213);
			this.homeaddress.Name = "homeaddress";
			this.homeaddress.Size = new System.Drawing.Size(29, 12);
			this.homeaddress.TabIndex = 5;
			this.homeaddress.Text = "住址";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(229, 78);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(145, 21);
			this.textBox1.TabIndex = 6;
			this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(229, 111);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(145, 21);
			this.textBox2.TabIndex = 7;
			this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(229, 210);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(145, 21);
			this.textBox5.TabIndex = 10;
			this.textBox5.Validating += new System.ComponentModel.CancelEventHandler(this.textBox5_Validating);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label6.Location = new System.Drawing.Point(166, 20);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(160, 24);
			this.label6.TabIndex = 11;
			this.label6.Text = "新增学生数据";
			// 
			// phone
			// 
			this.phone.AutoSize = true;
			this.phone.Location = new System.Drawing.Point(126, 246);
			this.phone.Name = "phone";
			this.phone.Size = new System.Drawing.Size(53, 12);
			this.phone.TabIndex = 12;
			this.phone.Text = "联系方式";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(229, 243);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(145, 21);
			this.textBox6.TabIndex = 13;
			this.textBox6.Validating += new System.ComponentModel.CancelEventHandler(this.textBox6_Validating);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "男",
            "女",
            "未知"});
			this.comboBox1.Location = new System.Drawing.Point(229, 147);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(145, 20);
			this.comboBox1.TabIndex = 14;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "水彩",
            "素描",
            "油画"});
			this.comboBox2.Location = new System.Drawing.Point(229, 177);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(145, 20);
			this.comboBox2.TabIndex = 15;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 361);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.phone);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.homeaddress);
			this.Controls.Add(this.course);
			this.Controls.Add(this.gender);
			this.Controls.Add(this.age);
			this.Controls.Add(this.name);
			this.Controls.Add(this.button1);
			this.Name = "Form3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label name;
		private System.Windows.Forms.Label age;
		private System.Windows.Forms.Label gender;
		private System.Windows.Forms.Label course;
		private System.Windows.Forms.Label homeaddress;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label phone;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
	}
}