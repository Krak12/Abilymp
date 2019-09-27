﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abilymp
{
    public partial class ChangePassCrMen : Form
    {
        public ChangePassCrMen()
        {
            InitializeComponent();
        }

        //закрытие формы
        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        //переход на форму CreatorMenu
        private void Button2_Click(object sender, EventArgs e)
        {
            Data.ChangePassCrMen = textBox2.Text;
            Form cm = new CreatorMenu();
            Hide();
            DialogResult res = cm.ShowDialog();
            if (res != DialogResult.Cancel)
            {
                Show();
            }
            else Close();
        }
    }
}
