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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //wrong dev pin
            MessageBox.Show("I said dont close it!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Information);
            for (int i = 0; i < 100; i++)
            {
                MessageBox.Show("Lol you cant close this message. you sholdent have tried the dev key if you wherent a dev lol", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
