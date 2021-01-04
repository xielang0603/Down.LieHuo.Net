using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Download by http://down.liehuo.net
using System.Data.SqlClient;

namespace Case05_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ////生成连接数据库字符串
                //string ConStr = "server=(192.168.35.206,1433);user id=sa;pwd=123456;database=pxscj";

                ////定义SqlConnection对象实例  
                //SqlConnection con = new SqlConnection(ConStr);

                ////定义Select查询语句
                //string SqlStr = "select * from 设备1";
                //SqlDataAdapter ada = new SqlDataAdapter(SqlStr, con);

                //DataSet ds = new DataSet();    //定义DataSet对象实例
                //ada.Fill(ds);
                ////连接数据表格，显示数据  

                //this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
                //********************************************************************
                string str = "network address = 192.168.35.206,1433; password = 123456; user id = sa; database = pxscj";

                //定义数据库连接
                SqlConnection conn = new SqlConnection(str);
                //进行数据库连接
                conn.Open();
                //操作数据库


                //定义Select查询语句
                string SqlStr = "select * from 设备1";
                SqlDataAdapter ada = new SqlDataAdapter(SqlStr, conn);
                DataSet ds = new DataSet();    //定义DataSet对象实例
                ada.Fill(ds);
                //连接数据表格，显示数据  
                this.dataGridView1.DataSource = ds.Tables[0].DefaultView;


                //增一行
                string sqlStr = "insert into 设备1( 日期1 , 日期2 )values( 999 , 888 )";
                //执行指定的SQL命令语句,并返回命令所影响的行数
                SqlCommand comminsert = new SqlCommand(sqlStr, conn);

                //int Succnum = comminsert.executeCommand(sqlStr);
                int Succnum = comminsert.ExecuteNonQuery();
                if (Succnum > 0) MessageBox.Show("录入成功");



                //关闭数据库
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                //********************************************************************


            }
            catch
            {
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //一：C#数据库查询之数据库连接代码：

            //SqlConnection objSqlConnection = new SqlConnection("server=192.168.35.206,1433;uid=sa;pwd=123456;database=pxscj");
            //objSqlConnection.Open();

            // 五：数据库的查询代码：

            //1.类开始：

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter();

            //2.按钮代码：
            int i = 0,n = 0;
            string s1 = "",s2 = "";
            s1 = textBox2.Text;
            s2 = textBox3.Text;
            if (textBox1.Text.Length == 0)
                i = 0;
            else
                i = Convert.ToInt32(textBox1.Text);
            SqlConnection objSqlConnection = new SqlConnection("server=192.168.35.206,1433;uid=sa;pwd=123456;database=pxscj");
            objSqlConnection.Open();
            MessageBox.Show("数据库连接成功", "好");

            string query = "SELECT * from info where id=" + i;

            DataSet objDataSet = new DataSet();

            SqlDataAdapter obj = new SqlDataAdapter();

            obj.SelectCommand = new SqlCommand(query, objSqlConnection);

            obj.Fill(objDataSet, "info");

            SqlCommand objSqlCommand = new SqlCommand(query, objSqlConnection);

            SqlDataReader objSqlReader = objSqlCommand.ExecuteReader();

            while (objSqlReader.Read())
            {
                n += 1;
                MessageBox.Show("编号:" + objSqlReader.GetValue(0) + "姓名:" + objSqlReader.GetValue(1) + "性别" + objSqlReader.GetValue(2));
            }
            if (n == 0)
                MessageBox.Show("数据库中没有这样的记录！");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //C#数据库查询代码：

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter();

            int i = 0;
            //intn=0;  
            string s1 = "",s2 = "";
            string sql;
            s1 = textBox2.Text;
            s2 = textBox3.Text;

            if (textBox1.Text.Length == 0)
            {
                i = 0;
            }

            else
            {
                i = Convert.ToInt32(textBox1.Text);
            }

            SqlConnection objSqlConnection = new SqlConnection("server=192.168.35.206,1433;uid=sa;pwd=123456;database=pxscj");
            objSqlConnection.Open();
            //MessageBox.Show("数据库连接成功", "好");
            string query = "SELECT * from 设备1 where id=日期1" + i;
            if (i == 0)
                sql = "select * from 设备1";
            else
                sql = "select * from 设备1 where 日期1=" + s1 + "And 日期2=" + s2;
            da1 = new SqlDataAdapter(sql, objSqlConnection);
            dt1.Clear();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                ////生成连接数据库字符串
                //string ConStr = "server=(192.168.35.206,1433);user id=sa;pwd=123456;database=pxscj";

                ////定义SqlConnection对象实例  
                //SqlConnection con = new SqlConnection(ConStr);

                ////定义Select查询语句
                //string SqlStr = "select * from 设备1";
                //SqlDataAdapter ada = new SqlDataAdapter(SqlStr, con);

                //DataSet ds = new DataSet();    //定义DataSet对象实例
                //ada.Fill(ds);
                ////连接数据表格，显示数据  

                //this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
                //********************************************************************
                string str = "network address = 192.168.35.206,1433; password = 123456; user id = sa; database = pxscj";

                //定义数据库连接
                SqlConnection conn = new SqlConnection(str);
                //进行数据库连接
                conn.Open();
                //操作数据库


                //定义Select查询语句
                string SqlStr = "select * from 设备1";
                SqlDataAdapter ada = new SqlDataAdapter(SqlStr, conn);
                DataSet ds = new DataSet();    //定义DataSet对象实例
                ada.Fill(ds);
                //连接数据表格，显示数据  
                this.dataGridView1.DataSource = ds.Tables[0].DefaultView;


                //增一行
                string sqlStr = "insert into 设备1( 日期1 , 日期2 )values( 999, 888 )";
                //执行指定的SQL命令语句,并返回命令所影响的行数
                SqlCommand comminsert = new SqlCommand(sqlStr, conn);

                //int Succnum = comminsert.executeCommand(sqlStr);
                int Succnum = comminsert.ExecuteNonQuery();
                //if (Succnum > 0) MessageBox.Show("录入成功");



                //关闭数据库
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                //********************************************************************


            }
            catch
            {
                return;
            }
        }
    }
}
