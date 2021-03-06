﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SquarFigure
{
    public partial class Form1 : Form
    {
        StatisticContext db;
        public Form1()
        {
            InitializeComponent();
            comboBoxFunc.SelectedIndex = 0;
            db = new StatisticContext();
            db.Statistics.Load();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if ((double.Parse(textBoxAX1.Text) < double.Parse(textBoxBX2.Text))&&(double.Parse(textBoxDelta.Text)<1 && double.Parse(textBoxDelta.Text) > 0))
            {
                textBoxResult.Text = await Calc.Calculate(double.Parse(textBoxAX1.Text), double.Parse(textBoxBX2.Text), double.Parse(textBoxDelta.Text), comboBoxFunc.Text, double.Parse(textBoxByPart.Text));
            }
            else
                MessageBox.Show("Некоректно введены данные.");
            
        }
    }
}
