using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kaurSimran_ShootGame
{
    public partial class Form1 : Form
    {
        //all global veriable for the task of the game 
        int bullet = 0, mg=0;
        int fire = 0,win=0;

        //instance object of the game 
        gameTask instance_gametast = new gameTask();

        public Form1()
        {
            InitializeComponent();
            //disable the button of the shoot and shot away 
            //fetch the random click from the random class
            fire = instance_gametast.fire();
            ShootBtn.Enabled = false;
            shootAwayBtn.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //click on the radio button to start the game after clicking on the start button we can move to other option 
            if (radioButton1.Checked==true) {
                //get  the image from the resoure folder 
                Image img = new Bitmap(Properties.Resources.machinegun);

                button1.BackgroundImage = img;
                    
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //this radio button is used to load the bullet in the gun to fire 
            if (radioButton4.Checked==true) {
                ///load the 2nd image from the resources folder 
                Image img = new Bitmap(Properties.Resources.loadmachinegun);
                button1.BackgroundImage = img;

            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //this radio button is used to spin the chamber of the gun to move 
            if (radioButton3.Checked == true)
            {
                // after that load the image from the resource folder 
                Image img = new Bitmap(Properties.Resources.machinegun);
                button1.BackgroundImage = img;
                ShootBtn.Enabled = true;
                shootAwayBtn.Enabled = true;

            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // count the shoot of the shoot trigger
            bullet++;
            //when the bullet are equal to the random clik then the player will be died and game will be auomatically restart 
            if (instance_gametast.firesound(fire, bullet) == 0)
            {
                win++;
                MessageBox.Show("Opps! Player is dead ");
                Application.Restart();
            }
            else {
                //if the random no is not matched then the player is alive message will display 
                MessageBox.Show("Player is alive ");
            }

            // when the 4 trigger are counter and the player is alive then the will restart because you won the game o

            if (bullet == 4 && win==0)
            {
                MessageBox.Show("Congrats! you win the game Hurry ");
                ShootBtn.Enabled = false;
                Application.Restart();
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            //after playing the game when the user want to try again then the user can click on this radio button 
            if (radioButton6.Checked==true) {
                //reset all the variable to use again 
                mg = 0;
                bullet = 0;
                fire = instance_gametast.fire();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this button is used to count the shootaway only two trigger are valid in this shoot of the user is alive then the user can play otherwise not 
            mg++;
            instance_gametast.trigger();

            if (mg==2) {
                //.when the two shoot are used then the button will automatically disabled 
                MessageBox.Show("your all chances are over now click on try again to start again");
                shootAwayBtn.Enabled = false;
            }

        }
    }
}
