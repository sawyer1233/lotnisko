using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bazyddanych
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bagaze_Click(object sender, EventArgs e)
        {

            CRUD_Bagaze crud = new CRUD_Bagaze();
            crud.Show();
            
        }

        private void Loty_Click(object sender, EventArgs e)
        {
            CRUD_loty crud = new CRUD_loty();
            crud.Show();
            
        }

        private void Pasazerowie_Click(object sender, EventArgs e)
        {
            CRUD_Pasazerowie crud = new CRUD_Pasazerowie();
            crud.Show();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRUD_Przewoznik crud = new CRUD_Przewoznik();
            crud.Show();
            
        }

        private void Samoloty_Click(object sender, EventArgs e)
        {
            CRUD_Samoloty crud = new CRUD_Samoloty();
            crud.Show();
            
        }

        

        private void Inner_join_Click(object sender, EventArgs e)
        {
            Inner_join crud = new Inner_join();
            crud.Show();
            this.Hide();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Form1 crud = new Form1();
            crud.Show();
            this.Hide();
        }
    }
}
