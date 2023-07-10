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
    public partial class Inner_join : Form
    {
        public Inner_join()
        {
            InitializeComponent();
        }

        private void bagaze_loty_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (localdb)\Local; Initial Catalog = samolot; Integrated Security = True");
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand($"Select Bagaze.ID, Bagaze.Nazwa, Bagaze.Waga, Bagaze.BAGAZ_PASAZ_ID, Loty.ID, Loty.Skad_miasto, Loty.Dokad_miasto, Loty.Data_wylotu, Loty.Data_przylotu, Loty.LOTY_SAM_ID from Bagaze inner join Loty on Bagaze.ID = Loty.ID ", con);
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
                MessageBox.Show(blad, "blaad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bag_Pas_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (localdb)\Local; Initial Catalog = samolot; Integrated Security = True");
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand($"Select Bagaze.ID, Bagaze.Nazwa, Bagaze.Waga, Bagaze.BAGAZ_PASAZ_ID, Pasazerowie.ID, Pasazerowie.Imie, Pasazerowie.Nazwisko, Pasazerowie.Wiek, Pasazerowie.Kraj, Pasazerowie.Miasto, Pasazerowie.PASAZ_LOTY_ID from Bagaze inner join Pasazerowie on Bagaze.ID = Pasazerowie.ID", con);
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
                MessageBox.Show(blad, "blaad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bagaze_pr_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (localdb)\Local; Initial Catalog = samolot; Integrated Security = True");
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand($"Select Bagaze.ID, Bagaze.Nazwa, Bagaze.Waga, Bagaze.BAGAZ_PASAZ_ID, Przewoznik.ID, Przewoznik.Nazwa, Przewoznik.Kraj, Przewoznik.Miasto, Przewoznik.Ulica, Przewoznik.Telefon from Bagaze inner join Przewoznik on Bagaze.ID = Przewoznik.ID", con);
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
                MessageBox.Show(blad, "blaad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (localdb)\Local; Initial Catalog = samolot; Integrated Security = True");
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand($"Select Bagaze.ID, Bagaze.Nazwa, Bagaze.Waga, Bagaze.BAGAZ_PASAZ_ID,Samoloty.ID, Samoloty.Nazwa, Samoloty.Model,Samoloty.Liczba_miejsc,Samoloty.SAM_PRZEWOZNIK_ID from Bagaze inner join Samoloty on Bagaze.ID = Samoloty.ID", con);
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
                MessageBox.Show(blad, "blaad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Form2 crud = new Form2();
            crud.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (localdb)\Local; Initial Catalog = samolot; Integrated Security = True");
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand($"Select  Loty.ID, Loty.Skad_miasto, Loty.Dokad_miasto, Loty.Data_wylotu, Loty.Data_przylotu, Loty.LOTY_SAM_ID,Pasazerowie.ID, Pasazerowie.Imie, Pasazerowie.Nazwisko, Pasazerowie.Wiek, Pasazerowie.Kraj, Pasazerowie.Miasto, Pasazerowie.PASAZ_LOTY_ID from Loty inner join Pasazerowie on Loty.ID = Pasazerowie.ID ", con);
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
                MessageBox.Show(blad, "blaad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (localdb)\Local; Initial Catalog = samolot; Integrated Security = True");
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand($"Select  Loty.ID, Loty.Skad_miasto, Loty.Dokad_miasto, Loty.Data_wylotu, Loty.Data_przylotu, Loty.LOTY_SAM_ID,Przewoznik.ID, Przewoznik.Nazwa, Przewoznik.Kraj, Przewoznik.Miasto, Przewoznik.Ulica, Przewoznik.Telefon from Loty inner join Przewoznik on Loty.ID = Przewoznik.ID ", con);
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
                MessageBox.Show(blad, "blaad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (localdb)\Local; Initial Catalog = samolot; Integrated Security = True");
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand($"Select  Loty.ID, Loty.Skad_miasto, Loty.Dokad_miasto, Loty.Data_wylotu, Loty.Data_przylotu, Loty.LOTY_SAM_ID, Samoloty.ID, Samoloty.Nazwa, Samoloty.Model,Samoloty.Liczba_miejsc,Samoloty.SAM_PRZEWOZNIK_ID from Loty inner join Samoloty on Loty.ID = Samoloty.ID ", con);
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
                MessageBox.Show(blad, "blaad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (localdb)\Local; Initial Catalog = samolot; Integrated Security = True");
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand($"Select Pasazerowie.ID, Pasazerowie.Imie, Pasazerowie.Nazwisko, Pasazerowie.Wiek, Pasazerowie.Kraj, Pasazerowie.Miasto, Pasazerowie.PASAZ_LOTY_ID,Przewoznik.ID, Przewoznik.Nazwa, Przewoznik.Kraj, Przewoznik.Miasto, Przewoznik.Ulica, Przewoznik.Telefon from Pasazerowie inner join Przewoznik on Pasazerowie.ID = Przewoznik.ID ", con);
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
                MessageBox.Show(blad, "blaad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (localdb)\Local; Initial Catalog = samolot; Integrated Security = True");
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand($"Select Pasazerowie.ID, Pasazerowie.Imie, Pasazerowie.Nazwisko, Pasazerowie.Wiek, Pasazerowie.Kraj, Pasazerowie.Miasto, Pasazerowie.PASAZ_LOTY_ID,Samoloty.ID, Samoloty.Nazwa, Samoloty.Model,Samoloty.Liczba_miejsc,Samoloty.SAM_PRZEWOZNIK_ID from Pasazerowie inner join Samoloty on Pasazerowie.ID = Samoloty.ID ", con);
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
                MessageBox.Show(blad, "blaad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (localdb)\Local; Initial Catalog = samolot; Integrated Security = True");
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand($" Select Przewoznik.ID, Przewoznik.Nazwa, Przewoznik.Kraj, Przewoznik.Miasto, Przewoznik.Ulica, Przewoznik.Telefon,Samoloty.ID, Samoloty.Nazwa, Samoloty.Model,Samoloty.Liczba_miejsc,Samoloty.SAM_PRZEWOZNIK_ID from Przewoznik inner join Samoloty on Przewoznik.ID = Samoloty.ID ", con);
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
                MessageBox.Show(blad, "blaad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
