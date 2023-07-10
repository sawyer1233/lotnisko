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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\Local;Initial Catalog=samolot;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        

        private void logowanie_Click(object sender, EventArgs e)
        {
            String uzytkownik, haslo;
            uzytkownik = txt_uzytkownik.Text;
            haslo = txt_haslo.Text;

            try
            {
                String querry = "SELECT * FROM logowanie_1 WHERE uzytkownik = '" + txt_uzytkownik.Text + "' AND haslo ='" + txt_haslo.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    uzytkownik = txt_uzytkownik.Text;
                    haslo = txt_haslo.Text;
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Niepoprawne dane", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_haslo.Clear();
                    txt_uzytkownik.Clear();

                    txt_uzytkownik.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void zamknij_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
