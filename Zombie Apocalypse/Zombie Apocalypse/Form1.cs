using System;
using System.Collections;
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
        public NPC[] npece;
        public Form1()
        {
            InitializeComponent();
            number_of_humans_textBox.Text = "10";
            number_of_zombie_textBox.Text = "2";
            number_of_soldier_textBox.Text = "2";
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        //private void label3_Click(object sender, EventArgs e){}
        private TextBox postac_spawn(NPC _npc)
        {
            Color _kolor= Color.DimGray;
            if (_npc.type == 1) _kolor = Color.Crimson;
            if (_npc.type == 2) _kolor = Color.DarkOliveGreen;
            if (_npc.type == 0) _kolor = Color.DeepSkyBlue;
            
            TextBox element =
            
             new TextBox()
            {
                Width = 20,
                ReadOnly = true,
                Text = _npc.Litera(),
                BackColor = _kolor,
               

        };
           
           
            
            ToolTip dymek = new ToolTip();
            dymek.InitialDelay=0;
            // dymek.SetToolTip(element, $"rodzaj: {_npc.type}\npieniadze: {_npc.money}\n sila: {_npc.str}\n wytrzymalosc: {_npc.health}\n pozostalo: {_npc.liczba_tur_do_konca}");
            if(_npc.type==0) dymek.SetToolTip(element, $"rodzaj: {_npc.Nazwa()}\npieniadze: {_npc.money}");
            if (_npc.type == 1) dymek.SetToolTip(element, $"rodzaj: {_npc.Nazwa()}\npieniadze: {_npc.money}\nsila: {_npc.str}\npozostalo: {_npc.liczba_tur_do_konca}");
            if (_npc.type == 2) dymek.SetToolTip(element, $"rodzaj: {_npc.Nazwa()}\nwytrzymalosc: {_npc.health}");

            return element;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Plansza.Controls.Clear();
            UpdateFrame(npece);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Plansza.Controls.Clear();
           
            Begin(
                Convert.ToInt32(number_of_humans_textBox.Text),
                Convert.ToInt32(number_of_zombie_textBox.Text),
                Convert.ToInt32(number_of_soldier_textBox.Text)
                );
            
        }

        //private void label5_Click(object sender, EventArgs e) { }
        
        //------------------------------------------------------------------------------
        /////////////////////////////////////////////////////////////////////////////////
        ///
        
        private void Begin(int n_humans,int n_zombie,int n_soldier)
        {
            //if ((number_of_humans_textBox.Text || number_of_soldier_textBox.Text || number_of_zombie_textBox.Text) == "")
            // System.Windows.Forms.Application.Exit();
            /*
            int n_humans = 10;// Convert.ToInt32(number_of_humans_textBox.Text);
            int n_zombie = 2; // Convert.ToInt32(number_of_zombie_textBox.Text);
            int n_soldier = 3; //Convert.ToInt32(number_of_soldier_textBox.Text);
            */
            int n_razem = n_humans + n_zombie + n_soldier;

            NPC[] npcs = new NPC[n_razem];
            for (int i = 0; i < npcs.Length; i++)
                npcs[i] = new NPC();

            Random rng = new Random();

            int counter = 0;
            foreach (var item in npcs)
            {

                if (counter < n_humans) item.type = 0;
                if (counter >= n_humans && counter < n_humans + n_zombie) item.type = 1;
                if (counter > n_humans + n_zombie) item.type = 2;
                item.x = rng.Next(0, Plansza.Width - 20);
                item.y = rng.Next(0, Plansza.Height - 20);
                item.money = rng.Next(0, 1000);
                item.str = rng.Next(0, 100);
                item.health = rng.Next(0, 100);
                item.liczba_tur_do_konca = rng.Next(4, 20);
                counter++;
            }

            Spawn(npcs);
            npece = npcs;
            
        }
        private void Spawn(NPC[] _npcs)
        {
            
            TextBox[] _ikony = new TextBox[_npcs.Length];
            for (int i = 0; i < _ikony.Length; i++)
            {
                _ikony[i] = new TextBox();
                _ikony[i] = postac_spawn(_npcs[i]);
                _ikony[i].Location = new Point(_npcs[i].x, _npcs[i].y);
                Plansza.Controls.Add(_ikony[i]);
            }
        }
        private void UpdateFrame(NPC[] npcs)
        {
            UpdateState(npcs);
            int n_razem = npcs.Length;
            Random rng = new Random();
            int znak;
            int przesuniecie;
            foreach (var item in npcs)
            {
                przesuniecie = rng.Next(0, 20);
                znak = rng.Next(0, 2);
                if (znak == 0) znak = -1;
                else znak = 1;

                if ((item.x + przesuniecie < Plansza.Width - 20) && (item.x - przesuniecie > 0)) item.x += przesuniecie * znak;
                if ((item.y + przesuniecie < Plansza.Height - 20) && (item.y - przesuniecie > 0)) item.y += przesuniecie * znak;

            }
            Spawn(npcs);
            Update_time_remaining(npcs);

        }
        private void Update_time_remaining(NPC[] npcs)
        {
            foreach (var item in npcs)            
                if (item.type == 1)
                {
                    item.liczba_tur_do_konca--;
                    if (item.liczba_tur_do_konca <= 0) item.type = 0;
                }
            
        }
        private void UpdateState(NPC[] npcs)
        {
            Random rng = new Random();
            foreach (var item2 in npcs)
                foreach (var item1 in npcs)
                {
                    if((item1.x<=item2.x && item1.x+20>=item2.x) || (item2.x <= item1.x && item2.x + 20 >= item1.x))
                        if ((item1.y<=item2.y && item1.y+20>=item2.y) || (item2.y <= item1.y && item2.y + 20 >= item1.y))
                        {
                            switch (item2.type)//  0human, 1zombie, 2 soldier
                            {
                                //human = 0
                                case 0:
                                    {
                                        if (item1.type == 1)
                                        {
                                            item2.type = 1;
                                            break;
                                        }
                                        if (item1.type == 2)
                                        {
                                            item2.money -= rng.Next(0, 100);
                                            if (item2.money <= 0)
                                            {
                                                item2.type = 2;
                                                item2.health = rng.Next(0, 100);
                                            }
                                            break;
                                        }
                                        break;

                                    }
                                //zombie = 1
                                case 1:
                                    {
                                        if (item1.type == 0)
                                        {
                                            item2.type = 1;
                                            item2.liczba_tur_do_konca = rng.Next(4, 20);
                                            break;
                                        }
                                        if (item1.type == 2)
                                        {
                                            item2.str = -item1.health;
                                            if (item2.str <= 0) item2.type = 0;
                                            break;
                                        }
                                        break;
                                    }
                                //soldier = 2
                                case 2:
                                    {
                                        if (item1.type == 0)
                                        {
                                            item2.money -= rng.Next(100, 1001);
                                            break;
                                        }
                                        if (item1.type == 1)
                                        {
                                            item2.health -= item1.str;
                                            if (item2.health <= 0) item2.type = 1;
                                            break;
                                        }

                                        break;
                                    }
                                    
                            }
                        }
                }
            
        }

        
    }
}
