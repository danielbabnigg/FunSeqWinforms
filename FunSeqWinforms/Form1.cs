﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunSeqWinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImageSeriesFilter isform = new ImageSeriesFilter();
            isform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewEraPumpControl nepc = new NewEraPumpControl();
            nepc.Show();
        }
    }
}
