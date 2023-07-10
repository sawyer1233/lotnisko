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
namespace bazyddanych
{
    public partial class CRUD_Samoloty : Form
    {
        public CRUD_Samoloty()
        {
            InitializeComponent();
        }

        private void insert_loty_Click(object sender, EventArgs e)
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
                        string model = textBox3.Text;
                        int liczba_miejsc = Convert.ToInt32(textBox4.Text);
                        int klucz = Convert.ToInt32(textBox5.Text);
                        SqlCommand cmd = new SqlCommand($"Insert into Samoloty (ID, Nazwa, Model, Liczba_miejsc,SAM_PRZEWOZNIK_ID) values (@ID,@Nazwa,@Model,@Liczba_miejsc,@SAM_PRZEWOZNIK_ID)", con);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.Parameters.AddWithValue("@Nazwa", nazwa);
                        cmd.Parameters.AddWithValue("@Model", model);
                        cmd.Parameters.AddWithValue("@Liczba_miejsc", liczba_miejsc);
                        cmd.Parameters.AddWithValue("SAM_PRZEWOZNIK_ID", klucz);
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
                        string model = textBox3.Text;
                        int liczba_miejsc = Convert.ToInt32(textBox4.Text);
                        int klucz = Convert.ToInt32(textBox5.Text);
                        SqlCommand cmd = new SqlCommand($"Update Samoloty set ID=@ID, Nazwa=@Nazwa, Model=@Model, Liczba_miejsc=@Liczba_miejsc,SAM_PRZEWOZNIK_ID=@SAM_PRZEWOZNIK_ID where ID=@ID", con);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.Parameters.AddWithValue("@Nazwa", nazwa);
                        cmd.Parameters.AddWithValue("@Model", model);
                        cmd.Parameters.AddWithValue("@Liczba_miejsc", liczba_miejsc);
                        cmd.Parameters.AddWithValue("SAM_PRZEWOZNIK_ID", klucz);
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
                        SqlCommand cmd = new SqlCommand($"Delete Samoloty where ID=@ID", con);
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
                MessageBox.Show(blad, "blaad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (localdb)\Local; Initial Catalog = samolot; Integrated Security = True");
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand($" Select * from Samoloty", con);
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
