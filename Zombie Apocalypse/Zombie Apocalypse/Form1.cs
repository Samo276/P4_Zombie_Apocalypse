using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombie_Apocalypse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Begin()
        {
            //if ((number_of_humans_textBox.Text || number_of_soldier_textBox.Text || number_of_zombie_textBox.Text) == "")
            // System.Windows.Forms.Application.Exit();
            int n_humans = 10;// Convert.ToInt32(number_of_humans_textBox.Text);
            int n_zombie = 2; // Convert.ToInt32(number_of_zombie_textBox.Text);
            int n_soldier = 3; //Convert.ToInt32(number_of_soldier_textBox.Text);

            
            NPC[] npcs = new NPC[n_humans + n_soldier + n_zombie];
            for (int i = 0; i < npcs.Length; i++)
                npcs[i] = new NPC();

            Random rng = new Random();

            int counter = 0;
            foreach (var item in npcs)
            {

                if (counter < n_humans) item.type = 0;
                if (counter >= n_humans && counter < n_zombie) item.type = 1;
                if (counter > n_humans + n_zombie) item.type = 2;
                item.x = rng.Next(0, Plansza.Width - 10);
                item.y = rng.Next(0, Plansza.Height - 10);
                item.money = rng.Next(0, 1000);
                item.str = rng.Next(0, 100);
                item.health = rng.Next(0, 100);
                item.liczba_tur_do_konca = rng.Next(4, 20);
                counter++;
            }

            TextBox[] _ikony = new TextBox[n_humans + n_soldier + n_zombie];
            for (int i = 0; i < _ikony.Length; i++)
            {
                _ikony[i] = new TextBox();
                _ikony[i] = postac_spawn(npcs[i]);
                _ikony[i].Location = new Point(npcs[i].x, npcs[i].y);
                Plansza.Controls.Add(_ikony[i]);
            }
            /*foreach (var item in npcs)
            {
                Plansza.Controls.Add(postac_spawn(item));
            }
            foreach (var item in _ikony)
            {
                Plansza.Controls.Add(postac_spawn(item));
            }
            foreach (TextBox item in panel1_Paint)
            {
                
            }*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private TextBox postac_spawn(NPC _npc)
        {

            return new TextBox()
            {
                Width = 20,
                ReadOnly = true,
                Text = _npc.Litera(),
                //BackColor = _npc.Kolor();
            };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Plansza.Controls.Clear();
            Begin();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


    }
}
