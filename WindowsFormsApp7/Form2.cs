﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form2 : Form
    {
        int o;
        int lo;
        int Sp;
        int sk;
        //int Sf;
        int lu;
        int a;
       


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\imrag\Documents\Visual Studio 2017\Projects\WindowsFormsApp7\resouse\spin.wav");

            Game rd = new Game();
            Sp = rd.rdm();

            button3.Enabled = true;
            button2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sp = 0;
            (new Form2()).Show();
            this.Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // below code helps to show the picbox
            pictureBox1.Visible = true;
            Image img = Image.FromFile(@"C:\Users\Rupinder Singh Com\Pictures\WindowsFormsApp7\resouse\load.gif");
            pictureBox1.Image = img;
            //below code is for uploading sound affect
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Rupinder Singh Com\Pictures\WindowsFormsApp7\resouse\loading.wav");

            // below code is helps to load only 1 bullet.
            lo = 1;


            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // below code helps to show the picbox
            pictureBox1.Visible = true;
            //below code is for uploading the image
            Image img = Image.FromFile(@"C:\Users\Rupinder Singh Com\Pictures\WindowsFormsApp7\resouse\shots.gif");
            pictureBox1.Image = img;
            // below code is for uploading the sound
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Rupinder Singh Com\Pictures\WindowsFormsApp7\resouse\gun.wav");
            player.Play();

            do
            {
                if (sk == 0 && lo== Sp)
                {
                    MessageBox.Show("you won and your score is 10");
                    sk = 3;
                    button4.Enabled = false;
                }
                else if (sk == 1 && lo == Sp)
                {
                    MessageBox.Show("you won and your score is 5");
                    sk = 3;
                    a = a - 1;

                }
                else if (sk == 2)
                {
                    MessageBox.Show("you loose");
                    sk = 3;
                    a = a - 1;

                }
                else
                {
                    sk++;
                    Game Spinobj = new Game();
                    Sp = Spinobj.spin(Sp);
                  
                }
            }
            while (sk <= 2);

            if (a == 0)
            {
                button3.Enabled = false;
                button4.Enabled = true;
               
                a = 2;
            }

        }
    }
  }
