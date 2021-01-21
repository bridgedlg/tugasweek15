using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasweek15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public string[] food = new string[12];
        public string[] drink = new string[12];
        public int temp = 5;
        public int temp1 = 4;
        

        private void textBoxitem_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxmakanan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttoninput_Click(object sender, EventArgs e)
        {
            food[0] = "Mie Instan";
            food[1] = "Telor";
            food[2] = "Roti";
            food[3] = "Keju";
            food[4] = "Daging Giling";
            drink[0] = "Susu Sapi";
            drink[1] = "Kopi";
            drink[2] = "Teh";
            drink[3] = "Bir";
            if (radioButtmakanan.Checked == true)
            {
                if (textBoxitem.Text == food[0] || textBoxitem.Text == food[1] || textBoxitem.Text == food[2] || textBoxitem.Text == food[3] || textBoxitem.Text == food[4] || textBoxitem.Text == food[5] || textBoxitem.Text == food[6] || textBoxitem.Text == food[7] || textBoxitem.Text == food[8] || textBoxitem.Text == food[9] || textBoxitem.Text == food[10] || textBoxitem.Text == food[11] )
                {
                    MessageBox.Show("Error! Inputan sudah terdapat di list");
                }

                else
                {
                    listBoxmenu.Items.Add(textBoxitem.Text);
                    food[temp] = textBoxitem.Text;
                    temp++;
                    listBoxmakanan.Items.Add(textBoxitem.Text);

                }
            }

            if(radioButtminuman.Checked == true)
            {
                if (textBoxitem.Text == drink[0] || textBoxitem.Text == drink[1] || textBoxitem.Text == drink[2] || textBoxitem.Text == drink[3] || textBoxitem.Text == drink[4] || textBoxitem.Text == drink[5] || textBoxitem.Text == drink[6] || textBoxitem.Text == drink[7] || textBoxitem.Text == drink[8] || textBoxitem.Text == drink[9] || textBoxitem.Text == drink[10] || textBoxitem.Text == drink[11])
                {
                    MessageBox.Show("Error! Inputan sudah terdapat di list");
                }

                else
                {
                    listBoxmenu.Items.Add(textBoxitem.Text);
                    drink[temp1] = textBoxitem.Text;
                    temp1++;
                    listBoxminuman.Items.Add(textBoxitem.Text);
                }
            }
            radioButtmakanan.Checked = false;
            radioButtminuman.Checked = false;
            textBoxitem.Text = "";

        }

        private void buttonpanah_Click(object sender, EventArgs e)
        {
            foreach(object makananbesar in listBoxmakanan.SelectedItems)
            {
                listboxF.Items.Add(makananbesar); 
            }

            foreach (object minumanbesar in listBoxminuman.SelectedItems)
            {
                listboxF.Items.Add(minumanbesar);
            }

            foreach (object semua in listBoxmenu.SelectedItems)
            {
                listboxF.Items.Add(semua);
            }

            
        }

        private void checkBoxmakanan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxmakanan.Checked == true)
            {
                listBoxmakanan.Show();
                listBoxmenu.Hide();
                listBoxminuman.Hide();
            }

            if (checkBoxmakanan.Checked == false)
            {
                listBoxmakanan.Hide();
                listBoxmenu.Show();
                listBoxminuman.Hide();
            }

            if (checkBoxmakanan.Checked == true && checkBoxminuman.Checked == true)
            {
                listBoxmakanan.Hide();
                listBoxmenu.Show();
                listBoxminuman.Hide();
            }

            if (checkBoxmakanan.Checked == true && checkBoxminuman.Checked == false)
            {
                listBoxmakanan.Show();
                listBoxmenu.Hide();
                listBoxminuman.Hide();
            }

            if (checkBoxmakanan.Checked == false && checkBoxminuman.Checked == true)
            {
                listBoxmakanan.Hide();
                listBoxmenu.Hide();
                listBoxminuman.Show();
            }

        }

        private void checkBoxminuman_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxminuman.Checked == true)
            {
                listBoxmakanan.Hide();
                listBoxmenu.Hide();
                listBoxminuman.Show();
            }

            if (checkBoxminuman.Checked == false)
            {
                listBoxmakanan.Hide();
                listBoxmenu.Show();
                listBoxminuman.Hide();
            }

            if (checkBoxmakanan.Checked == true && checkBoxminuman.Checked == true)
            {
                listBoxmakanan.Hide();
                listBoxmenu.Show();
                listBoxminuman.Hide();
            }

            if (checkBoxmakanan.Checked == true && checkBoxminuman.Checked == false)
            {
                listBoxmakanan.Show();
                listBoxmenu.Hide();
                listBoxminuman.Hide();
            }

            if (checkBoxmakanan.Checked == false && checkBoxminuman.Checked == true)
            {
                listBoxmakanan.Hide();
                listBoxmenu.Hide();
                listBoxminuman.Show();
            }




        }

        private void buttonsilang_Click(object sender, EventArgs e)
        {
            listboxF.Items.Clear();
        }
    }
}
