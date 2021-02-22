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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //You Just Got Coconut Mall’d
            System.Threading.Thread.Sleep(1000);

            for (int i = 0; i < 8; i++)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=QTT5iHCHSn0");
            }
            System.Threading.Thread.Sleep(3000);
            MessageBox.Show("You Just Got Coconut Mall’d", "lol i really did u like that", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //eror spam thing
            System.Threading.Thread.Sleep(2000);
            MessageBox.Show("STARTING 3RD PAYLOAD!!", "lol get hacked >:)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Threading.Thread.Sleep(1000);

            //ok 100 times
            for (int i = 0; i < 10; i++)
            {
                //message for click alot
                MessageBox.Show("Press Ok 10 times and you will be free!  :D soon...", "do it", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start("https://discord.gg/fVVepm9j");
                
                //beeeeep
                Console.Beep();
            }

            this.Hide();
            var form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            

            //opens form of hacked
            System.Threading.Thread.Sleep(1000);
            for (int i = 0; i < 15; i++)
            {

                //opens 15 forms of u got hacked
                var fform4 = new Form4();
                fform4.Show();


                //make beep withch is annoying
                Console.Beep();

            }



            System.Threading.Thread.Sleep(2000);
            this.Hide();
            var form5 = new Form5();
            form5.Closed += (s, args) => this.Close();
            form5.Show();


        }

        void MyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //idk lol i was too lazy to do anything here
        }

    }
}
