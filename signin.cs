﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luminarskaya2
{
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((tb_login.Text == "user") && (tb_password.Text == "user"))
            {
                MessageBox.Show("Добро пожаловать!");
            }
            else
            {
                MessageBox.Show("Учетная запись не найдена!");
            }
            tb_login.Clear();
            tb_password.Clear();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_password.Checked)
            {
                tb_password.UseSystemPasswordChar = false;
            }
            else
            {
                tb_password.UseSystemPasswordChar = true;
            }

        }
    }
}
