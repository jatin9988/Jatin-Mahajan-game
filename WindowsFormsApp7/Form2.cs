using System;
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

        Game Obj_game = new Game();


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonspin_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;//it enables the visablility of picture box
            
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\imrag\Documents\Visual Studio 2017\Projects\WindowsFormsApp7\resouse\spin.wav");
            //it puts the the image from url to variable
            Game rd = new Game();
            Obj_game.Spin = rd.rdm();//it cosses the random number form 1 to 7

            button_spin.Enabled = false;//it diable the spin button
            button_shoot.Enabled = true;//it enables the shoot button
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            
            (new Form2()).Show();
            this.Close();// this code reset the form to its orignal state

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonload_Click(object sender, EventArgs e)
        {
            // below code  shows the picbox
            pictureBox1.Visible = true;
            //it puts the image to the variable
            Image img = Image.FromFile(@"C:\Users\Rupinder Singh Com\Pictures\WindowsFormsApp7\resouse\load.gif");
            pictureBox1.Image = img;
            //below code is for uploading sound affect
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Rupinder Singh Com\Pictures\WindowsFormsApp7\resouse\loading.wav");

            // below code is helps to load only 1 bullet.
            Obj_game.load = 1;


            button_spin.Enabled = true;//it enables the spin button
            button_load.Enabled = false;//it disables the load button
        }

        private void buttonshoot_Click(object sender, EventArgs e)
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
                if (Obj_game.shoot == 0 && Obj_game.load == Obj_game.Spin)//it checks if the shoot is eqbal to 0 and spin is equal to load
                {
                    MessageBox.Show("you won and your score is 10");//it displays the win message
                    Obj_game.shoot = 3;
                    buttonshot.Enabled = false;// it diables the shoot button
                    button_spin.Enabled = false;// it diables the spin button
                    button_load.Enabled = false;// it diables the load button
                }
                else if (Obj_game.shoot == 1 && Obj_game.load == Obj_game.Spin)//it checks if the shoot is eqbal to 1 and spin is equal to load
                {
                    MessageBox.Show("you won and your score is 5");//it shows the win message
                    Obj_game.shoot = 3;//it sets shoot to 3
                    Obj_game.replay = Obj_game.replay - 1;//it decresase the replay by 1
                   
                    buttonshot.Enabled = false;// it diables the shoot button
                    button_spin.Enabled = false;// it diables the spin button
                    button_load.Enabled = false;// it diables the load button
                }
                else if (Obj_game.shoot == 2)//it checks if the shoot is eqbal to 2
                {
                    MessageBox.Show("you loose");//it displays the loose message
                    Obj_game.shoot = 3;// it sets shoot to 3
                    Obj_game.replay = Obj_game.replay - 1;//it decresase the replay by 1
                    

                }
                else
                {
                    Obj_game.shoot++;//it increase the shoot by one
                    Game Spinobj = new Game();
                    Obj_game.Spin = Spinobj.spin(Obj_game.Spin);
                  
                }
            }
            while (Obj_game.shoot <= 2);//it runs the below code until the value of shoot is below or eqbal to 2

            if (Obj_game.replay == 0)//it checks if replay is equal to 0
            {
               
                
                button_load.Enabled = false;//this code diable the spin button
                buttonshot.Enabled = false;//this code diable the shoot button
                button_spin.Enabled = false;//this code diable the spin button


                Obj_game.replay = 2;//it sets the replay to 2
            }
            if(Obj_game.replay !=0)
                
            {
                button_load.Enabled = false;
                button_spin.Enabled = false;
                Obj_game.load=0;
                Obj_game.Spin=0;
                Obj_game.shoot=0;

                Obj_game.replay = 2;
    }

        }
    }
  }
