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
    public partial class CRUD_loty : Form
    {
        public CRUD_loty()
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
                {   if (textBox1.Text != "")
                    {
                        int id = Convert.ToInt32(textBox1.Text);
                        string skad = textBox2.Text;
                        string dokad = textBox3.Text;
                        DateTime wylot = dateTimePicker1.Value;
                        DateTime przylot = dateTimePicker2.Value;
                        int klucz = Convert.ToInt32(textBox6.Text);

                        SqlCommand cmd = new SqlCommand($"Insert into Loty (ID, Skad_miasto,Dokad_miasto,Data_wylotu,Data_przylotu,LOTY_SAM_ID) values (@ID,@Skad_miasto,@Dokad_miasto,@Data_wylotu,@Data_przylotu,@LOTY_SAM_ID)", con);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.Parameters.AddWithValue("@Skad_miasto", skad);
                        cmd.Parameters.AddWithValue("@Dokad_miasto", dokad);
                        cmd.Parameters.AddWithValue("@Data_wylotu", wylot);
                        cmd.Parameters.AddWithValue("@Data_przylotu", przylot);
                        cmd.Parameters.AddWithValue("@LOTY_SAM_ID", klucz);
                        SqlDataReader sdr = cmd.ExecuteReader();

                        MessageBox.Show("Operacja zostala wykonana pomyslnie!");
                    }
                    else
                    {
                        MessageBox.Show("Textbox is empty");
                    }
                }

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
                    SqlCommand cmd = new SqlCommand($" Select * from Loty", con);
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
                        SqlCommand cmd = new SqlCommand($"Delete Loty where ID=@ID", con);
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
                        string skad = Convert.ToString(textBox2.Text);
                        string dokad = Convert.ToString(textBox3.Text);
                        DateTime wylot = dateTimePicker1.Value;
                        DateTime przylot = dateTimePicker2.Value;
                        int klucz = Convert.ToInt32(textBox6);
                        SqlCommand cmd = new SqlCommand($"Update Loty set Skad_miasto=@Skad_miasto,Dokad_Miasto=@Dokad_miasto,Data_wylotu=@Data_wylotu,Data_przylotu=@Data_przylotu,LOTY_SAM_ID=@LOTY_SAM_ID where ID=@ID", con);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.Parameters.AddWithValue("@Skad_miasto", skad);
                        cmd.Parameters.AddWithValue("@Dokad_miasto", dokad);
                        cmd.Parameters.AddWithValue("@Data_wylotu", wylot);
                        cmd.Parameters.AddWithValue("@Data_przylotu", przylot);
                        cmd.Parameters.AddWithValue("@LOTY_SAM_ID", klucz);
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

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
    