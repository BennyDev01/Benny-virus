﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sends user to my youtube
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UClhrh6RjoiqcjegQIUTNDbA");
        }
    }
}
