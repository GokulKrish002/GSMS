﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSMS
{
    public partial class Landing_app : Form
    {
        public Landing_app()
        {
            InitializeComponent();
        }

        private void Btn_Sign_in_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
