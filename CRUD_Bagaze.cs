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
using System.Data.Sql;

namespace bazyddanych
{
    public partial class CRUD_Bagaze : Form
    {
        
        public CRUD_Bagaze()
        {
            InitializeComponent();
        }
        private void insert_Click(object sender, EventArgs e)   
        {
            
            

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (localdb)\Local; Initial Catalog = samolot; Integrated Security = True");
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    if (textBox1.Text != "" )
                    {
                        int id = Convert.ToInt32(textBox1.Text);
                        string nazwa = textBox2.Text;
                        double waga = Convert.ToDouble(textBox3.Text);
                        int klucz = Convert.ToInt32(textBox4.Text);
                        SqlCommand cmd = new SqlCommand($"Insert into Bagaze (ID, Nazwa,Waga,BAGAZ_PASAZ_ID) values (@ID,@Nazwa,@Waga,@BAGAZ_PASAZ_ID)", con);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.Parameters.AddWithValue("@Nazwa", nazwa);
                        cmd.Parameters.AddWithValue("@Waga", waga);
                        cmd.Parameters.AddWithValue("@BAGAZ_PASAZ_ID", klucz);
                        SqlDataReader sdr = cmd.ExecuteReader();

                        MessageBox.Show("Operacja zostala wykonana pomyslnie!");
                    }
                    else
                    {
                        MessageBox.Show("Textbox is empty");
                    }
                }
                
                con.Close();
            }
            catch(Exception ex)
            {
                string blad = string.Format(ex.Message);
                MessageBox.Show(blad, "blaad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (localdb)\Local; Initial Catalog = samolot; Integrated Security = True");
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    if (textBox1.Text != "")
                    {
                        int id = Convert.ToInt32(textBox1.Text);
                        string nazwa = textBox2.Text;
                        double waga = Convert.ToDouble(textBox3.Text);
                        int klucz = Convert.ToInt32(textBox4.Text);
                        SqlCommand cmd = new SqlCommand($" Update Bagaze set Nazwa=@Nazwa, Waga=@Waga, BAGAZ_PASAZ_ID=@BAGAZ_PASAZ_ID where ID=@ID", con);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.Parameters.AddWithValue("@Nazwa", nazwa);
                        cmd.Parameters.AddWithValue("@Waga", waga);
                        cmd.Parameters.AddWithValue("@BAGAZ_PASAZ_ID", klucz);
                        SqlDataReader sdr = cmd.ExecuteReader();

                        MessageBox.Show("Operacja zostala wykonana pomyslnie!");
                    }
                    else
                    {
                        MessageBox.Show("Textbox is empty");
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                string blad = string.Format(ex.Message);
                MessageBox.Show(blad, "Blad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 

        }

        private void search_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (localdb)\Local; Initial Catalog = samolot; Integrated Security = True");
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand($" Select * from Bagaze", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                   
                }
                con.Close();
            }
            catch (Exception ex)
            {
                string blad = string.Format(ex.Message);
                MessageBox.Show(blad, "Blad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            
            

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (localdb)\Local; Initial Catalog = samolot; Integrated Security = True");
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    if (textBox1.Text != "")
                    {
                        int id = Convert.ToInt32(textBox1.Text);
                        SqlCommand cmd = new SqlCommand($"Delete Bagaze where ID=@ID", con);
                        cmd.Parameters.AddWithValue("@ID", id);
                        SqlDataReader sdr = cmd.ExecuteReader();

                        MessageBox.Show("Operacja zostala wykonana pomyslnie!");
                    }
                    else
                    {
                        MessageBox.Show("Textbox is empty");
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                string blad = string.Format(ex.Message);
                MessageBox.Show(blad, "Blad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Form2 crud = new Form2();
            crud.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CRUD_Bagaze_Load(object sender, EventArgs e)
        {

        }
    }   
    
}
