﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnterpriseMICApplicationDemo
{
    public partial class TableOption : Form
    {
        private int row;
        private int col;
        private decimal border;
        public TableOption()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            try
            {
                row = Int32.Parse(textBoxRow.Text);
                col = Int32.Parse(textBoxColumn.Text);
                border = numericBorder.Value;
                this.Close();
            }
            catch 
            {
                MessageBox.Show("Пожалуйста, введите корректные значения");
            }
        }

        public object returnTableOption()
        {
            object tOption = new {rows = row, columns = col, border = border};
            return tOption;
        }
    }
}
