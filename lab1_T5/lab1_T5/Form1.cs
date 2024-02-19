using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_T5
{
    public delegate void SuperButton(object sender, EventArgs e);
    public partial class Form1 : Form
    {

        private SuperButton superButton;
        private double previousOpacity;
        private Color previousBgColor;

        public Form1()
        {
            InitializeComponent();
            previousOpacity = this.Opacity;
            previousBgColor = this.BackColor;
        }

       

        private void BtnTransparency_Click(object sender, EventArgs e)
        {
            if (this.Opacity == 1.0)
            {
                this.Opacity = 0.5;
            }
            else
            {
                this.Opacity = 1.0;
            }
        }

        private void BtnBgColor_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Yellow)
            {
                this.BackColor = previousBgColor;
            }
            else
            {
                previousBgColor = this.BackColor;
                this.BackColor = Color.Yellow;
            }
        }

        private void BtnHelloWorld_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void BtnSuperMegaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка,\nі цього мене не позбавиш!");
            superButton?.Invoke(sender, e);
        }

        private void CheckboxTransparency_CheckedChanged(object sender, EventArgs e)
        {
            superButton -= BtnTransparency_Click;
            if (CheckboxTransparency.Checked)
            {
                superButton += BtnTransparency_Click;
            }
        }

        private void CheckboxBgColor_CheckedChanged(object sender, EventArgs e)
        {
            superButton -= BtnBgColor_Click; 
            if (CheckboxBgColor.Checked)
            {
                superButton += BtnBgColor_Click; 
            }
        }

        private void CheckboxHelloWorld_CheckedChanged(object sender, EventArgs e)
        {
            superButton -= BtnHelloWorld_Click; 
            if (CheckboxHelloWorld.Checked)
            {
                superButton += BtnHelloWorld_Click; 
            }
        }

    }
}
