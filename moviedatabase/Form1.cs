using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace moviedatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NpgsqlConnection connect = new NpgsqlConnection("server=localHost;port=5432;UserId=postgres;password=habibe;database=mdb");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            string table = comboBox1.Text;
            string query = "select * from" + table;
            NpgsqlDataAdapter adapt = new NpgsqlDataAdapter(query, connect);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            connect.Open();
            NpgsqlCommand command1 = new NpgsqlCommand("insert into \"Movies\" values(@movie_id, @movie_title, @release_year)", connect);
            command1.Parameters.AddWithValue("@movie_id", int.Parse(txtBox_id.Text));
            command1.Parameters.AddWithValue("@movie_title", txtBox_title.Text);
            command1.Parameters.AddWithValue("@release_year", int.Parse(txtBox_year.Text));
            command1.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Insert operation has been done successfully.");
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            connect.Open();
            NpgsqlCommand command2 = new NpgsqlCommand("delete from \"Movies\" where \"movie_id\"=@movie_id", connect);
            command2.Parameters.AddWithValue("@movie_id", txtBox_id.Text);
            command2.Parameters.AddWithValue("@movie_title", txtBox_title.Text);
            command2.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Delete operation has been done successfully.");
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            connect.Open();
            NpgsqlCommand command3 = new NpgsqlCommand("update \"Movies\" set  \"movie_title\"=@movie_title , \"release_year\"=@release_year where \"movie_id\"=@movie_id", connect);
            command3.Parameters.AddWithValue("@movie_title", txtBox_title.Text);
            command3.Parameters.AddWithValue("@release_year", int.Parse(txtBox_year.Text));
            command3.Parameters.AddWithValue("@movie_id", txtBox_id.Text);
            command3.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Update operation has been done successfully.");
            connect.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_tableName_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            string table = comboBox1.Text;
            string query = "select * from" + table;
            NpgsqlDataAdapter adapt = new NpgsqlDataAdapter(query, connect);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_insert_Click_1(object sender, EventArgs e)
        {
            connect.Open();
            NpgsqlCommand command1 = new NpgsqlCommand("insert into \"Movies\" values(@movie_id, @movie_title, @release_year)", connect);
            command1.Parameters.AddWithValue("@movie_id", int.Parse(txtBox_id.Text));
            command1.Parameters.AddWithValue("@movie_title", txtBox_title.Text);
            command1.Parameters.AddWithValue("@release_year", int.Parse(txtBox_year.Text));
            command1.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Insert operation has been done successfully.");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label_tableName_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            connect.Open();
            NpgsqlCommand command2 = new NpgsqlCommand("delete from \"Movies\" where \"movie_id\"=@movie_id", connect);
            command2.Parameters.AddWithValue("@movie_id", txtBox_id.Text);
            command2.Parameters.AddWithValue("@movie_title", txtBox_title.Text);
            command2.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Delete operation has been done successfully.");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            connect.Open();
            NpgsqlCommand command3 = new NpgsqlCommand("update \"Movies\" set  \"movie_title\"=@movie_title , \"release_year\"=@release_year where \"movie_id\"=@movie_id", connect);
            command3.Parameters.AddWithValue("@movie_title", txtBox_title.Text);
            command3.Parameters.AddWithValue("@release_year", int.Parse(txtBox_year.Text));
            command3.Parameters.AddWithValue("@movie_id", txtBox_id.Text);
            command3.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Update operation has been done successfully.");
            connect.Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        
    }
}
