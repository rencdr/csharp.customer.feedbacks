using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace customer_feedbacks
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
		SqlConnection conn = new SqlConnection("Data Source=DESKTOP-Q57TG34\\SQLEXPRESS;Initial Catalog=customerinfos;Integrated Security=True");
		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: Bu kod satırı 'customerinfosDataSet.Table_1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
			this.table_1TableAdapter.Fill(this.customerinfosDataSet.Table_1);

		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.table_1TableAdapter.Fill(this.customerinfosDataSet.Table_1);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			conn.Open();
			SqlCommand com = new SqlCommand("insert into Table_1 (FirstName,LastName,Age,Gender,Complaint) values (@p1,@p2,@p3,@p4,@p5)",conn);
			com.Parameters.AddWithValue("@p1", txtfirst.Text);
			com.Parameters.AddWithValue("@p2", txtlast.Text);
			com.Parameters.AddWithValue("@p3", mskage.Text);
			com.Parameters.AddWithValue("@p4", txtgen.Text);
			com.Parameters.AddWithValue("@p5", txtcom.Text);
			com.ExecuteNonQuery();
			conn.Close();
		}
	}
}
