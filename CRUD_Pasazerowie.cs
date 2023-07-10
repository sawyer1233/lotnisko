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
    public partial class CRUD_Pasazerowie : Form
    {
        public CRUD_Pasazerowie()
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
                        string imie = textBox2.Text;
                        string nazwisko = textBox3.Text;
                        int wiek = Convert.ToInt32(textBox4.Text);
                        string kraj = textBox5.Text;
                        string miasto = textBox6.Text;
                        int klucz = Convert.ToInt32(textBox7.Text);
                        SqlCommand cmd = new SqlCommand($"Insert into Pasazerowie (ID, Imie, Nazwisko, Wiek, Kraj, Miasto,PASAZ_LOTY_ID) values (@ID,@Imie,@Nazwisko,@Wiek,@Kraj,@Miasto,@PASAZ_LOTY_ID)", con);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.Parameters.AddWithValue("@Imie", imie);
                        cmd.Parameters.AddWithValue("@Nazwisko", nazwisko);
                        cmd.Parameters.AddWithValue("@Wiek", wiek);
                        cmd.Parameters.AddWithValue("@Kraj", kraj);
                        cmd.Parameters.AddWithValue("@Miasto", miasto);
                        cmd.Parameters.AddWithValue("@PASAZ_LOTY_ID", klucz);
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
                        string imie = textBox2.Text;
                        string nazwisko = textBox3.Text;
                        int wiek = Convert.ToInt32(textBox6.Text);
                        string kraj = textBox5.Text;
                        string miasto = textBox4.Text;
                        int klucz = Convert.ToInt32(textBox7.Text);
                        SqlCommand cmd = new SqlCommand($"Update Pasazerowie set Imie=@Imie,Nazwisko=@Nazwisko, Wiek=@Wiek, Kraj=@Kraj, Miasto=@Miasto, PASAZ_LOTY_ID=@PASAZ_LOTY_ID where ID=@ID", con);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.Parameters.AddWithValue("@Imie", imie);
                        cmd.Parameters.AddWithValue("@Nazwisko", nazwisko);
                        cmd.Parameters.AddWithValue("@Wiek", wiek);
                        cmd.Parameters.AddWithValue("@Kraj", kraj);
                        cmd.Parameters.AddWithValue("@Miasto", miasto);
                        cmd.Parameters.AddWithValue("@PASAZ_LOTY_ID", klucz);
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
                    SqlCommand cmd = new SqlCommand($" Select * from Pasazerowie", con);
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
                        SqlCommand cmd = new SqlCommand($"Delete Pasazerowie  where ID=@ID", con);
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

        private void label7_Click(object sender, EventArgs e)
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
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CRUD_Pasazerowie_Load(object sender, EventArgs e)
        {

        }
    }
}
