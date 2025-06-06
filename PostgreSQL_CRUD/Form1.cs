﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostgreSQL_CRUD
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		string connectionString = "Server=localhost;port=5432;Database=CustomerDb;user Id = postgres;Password=123456";

		void GetAllCustomers()
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "Select * from Customers";
			var command = new NpgsqlCommand(query, connection);
			var adapter = new NpgsqlDataAdapter(command); //command ile dataTable arasında köprü oluşturduk
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			connection.Close();
		}

		private void btnCustomerList_Click(object sender, EventArgs e)
		{
			GetAllCustomers();
		}

		private void btnCustomerCreate_Click(object sender, EventArgs e)
		{
			string customerName = txtCustomerName.Text;
			string customerCity = txtCustomerCity.Text;
			string customerSurname = txtCustomerSurname.Text;

			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "insert into Customers (customerName, customerCity, customerSurname) values (@customerName, @customerSurname, @customerCity)";
			var command = new NpgsqlCommand(query,connection);
			command.Parameters.AddWithValue("@customerName", customerName);
			command.Parameters.AddWithValue("@customerSurname", customerSurname);
			command.Parameters.AddWithValue("@customerCity", customerCity);

			command.ExecuteNonQuery();
			MessageBox.Show("Ekleme işlemi başarılı");
			connection.Close();
			GetAllCustomers();	
		}

		private void btnCustomerDelete_Click(object sender, EventArgs e)
		{

			int id = int.Parse(txtCustomerId.Text);

			var connection = new NpgsqlConnection(connectionString);	
			connection.Open();
			string query = "Delete from Customers where CustomerId=@customerId";
			var command = new NpgsqlCommand(query,connection);
			command.Parameters.AddWithValue("@customerId", id);
			command.ExecuteNonQuery ();
			MessageBox.Show("Silme işlemi başarılı");
			connection.Close();
			GetAllCustomers();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			GetAllCustomers();
		}

		private void btnCustomerUpdate_Click(object sender, EventArgs e)
		{
			string customerName = txtCustomerName.Text;
			string customerCity = txtCustomerCity.Text;
			string customerSurname = txtCustomerSurname.Text;

			int id = int.Parse(txtCustomerId.Text);

			var connection = new NpgsqlConnection(connectionString);
			connection.Open();

			string query = "Update Customers Set CustomerName = @customerName, CustomerSurname = @customerSurname, CustomerCity = @customerCity where CustomerId = @customerId";
			var command = new NpgsqlCommand (query,connection);
			command.Parameters.AddWithValue("@customerName", customerName);
			command.Parameters.AddWithValue("@customerSurname", customerSurname);
			command.Parameters.AddWithValue("@customerCity", customerCity);
			command.Parameters.AddWithValue("@customerId", id);
			command.ExecuteNonQuery ();
			MessageBox.Show("Güncelleme işlemi başarılı");
			connection.Close();
			GetAllCustomers();
		}
	}
}
