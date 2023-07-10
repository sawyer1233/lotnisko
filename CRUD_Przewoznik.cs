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
    public partial class CRUD_Przewoznik : Form
    {
        public CRUD_Przewoznik()
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
                        string kraj = textBox3.Text;
                        string miasto = textBox4.Text;
                        string ulica = textBox5.Text;
                        int telefon = Convert.ToInt32(textBox6.Text);
                        SqlCommand cmd = new SqlCommand($"Insert into Przewoznik (ID, Nazwa, Kraj, Miasto, Ulica, Telefon) values (@ID,@Nazwa,@Kraj,@Miasto,@Ulica,@Telefon)", con);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.Parameters.AddWithValue("@Nazwa", nazwa);
                        cmd.Parameters.AddWithValue("@Kraj", kraj);
                        cmd.Parameters.AddWithValue("@Miasto", miasto);
                        cmd.Parameters.AddWithValue("@Ulica", ulica);
                        cmd.Parameters.AddWithValue("@Telefon", telefon);
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
                        string kraj = textBox3.Text;
                        string miasto = textBox4.Text;
                        string ulica = textBox5.Text;
                        int telefon = Convert.ToInt32(textBox6.Text);
                        SqlCommand cmd = new SqlCommand($"Update Przewoznik set Nazwa=@Nazwa, Kraj=@Kraj, Miasto=@Miasto, Ulica=@Ulica, Telefon=@Telefon where ID=@ID", con);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.Parameters.AddWithValue("@Nazwa", nazwa);
                        cmd.Parameters.AddWithValue("@Kraj", kraj);
                        cmd.Parameters.AddWithValue("@Miasto", miasto);
                        cmd.Parameters.AddWithValue("@Ulica", ulica);
                        cmd.Parameters.AddWithValue("@Telefon", telefon);
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

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (localdb)\Local; Initial Catalog = samolot; Integrated Security = True");
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand($" Select * from Przewoznik", con);
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
                        SqlCommand cmd = new SqlCommand($"Delete Przewoznik where ID=@ID", con);
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
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
