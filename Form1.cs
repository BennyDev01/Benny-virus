using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Benny_Virus_Protection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            //start virus warning
            if (MessageBox.Show("This is a virus Made by bennybagadonuts if you click \"yes\" the virus will start. if you click \"no\" the virus will close. Once you awnser there is no going back.", "u want to do this bruv?", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                //runs the program no need for exstra code here
            }
            else
            {
                //closes program because they chose "no"
                System.Environment.Exit(0);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //checks if dev key is correct
            if (textBox1.Text == "2246")
            {
                MessageBox.Show("Dev key correct... closeing virus :D", "Dev Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Threading.Thread.Sleep(700);
                System.Environment.Exit(0);
            }
            else
            {
                //wrong dev pin
                MessageBox.Show("Wrong pin  you screwed ur self...", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                for (int i = 0; i < 100; i++)
                {
                    MessageBox.Show("Lol you cant close this message. you sholdent have tried the dev key if you wherent a dev lol", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                //why tf do u click so much messages
                MessageBox.Show("Wtf is wrong with you lol why whould you click that 100 times. you deserve to close this... press ok 6 more times", "there are 6 more errors", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Wtf is wrong with you lol why whould you click that 100 times. you deserve to close this... press ok 5 more times", "there are 5 more errors", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Wtf is wrong with you lol why whould you click that 100 times. you deserve to close this... press ok 4 more times", "there are 4 more errors", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Wtf is wrong with you lol why whould you click that 100 times. you deserve to close this... press ok 3 more times", "there are 3 more errors", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Wtf is wrong with you lol why whould you click that 100 times. you deserve to close this... press ok 2 more times", "there are 2 more errors", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Wtf is wrong with you lol why whould you click that 100 times. you deserve to close this... press ok 1 more times", "there are 1 more errors", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Threading.Thread.Sleep(1000);
                System.Environment.Exit(0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //payload 1 start
            MessageBox.Show("Just a reminder that ur an idiot for downlaoding random crap off the internet", "ur an idiot", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();


            for (int i = 0; i < 12; i++)
            {

                //opens 12 forms of kermit
                var fform2 = new Form2();
                fform2.Show();


                //make beep withch is annoying
                Console.Beep();

            }
            System.Threading.Thread.Sleep(1000);

            //shows that where just good 
            MessageBox.Show("where just getting started >:)", "lol", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Threading.Thread.Sleep(700);
            MessageBox.Show("Dont Close The Kermit Imagis Until I say So.", "dont do it lol", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //poayload 2 start message
            System.Threading.Thread.Sleep(2000);
            MessageBox.Show("well time for you to use ur pc again... oh wait", "lol get hacked >:)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Threading.Thread.Sleep(400);

            //goes to payload 3
            var ffform3 = new Form3();
            ffform3.Show();


        }

        
    }
}