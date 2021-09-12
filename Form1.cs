﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Assignment2
{
    /// <summary>
    /// Game board form for Die Guess game. Assignment 2 CS 
    /// 
    /// 
    /// created by Denver Jensen 09/12/2021
    /// </summary>
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
        }
        /// <summary>
        /// validate user input is number 1-6 for dice roll. If not valid, show error label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // add validation
        }

        private void lblEnterGuess_Click(object sender, EventArgs e)
        {

        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

            for (int i = 1; i <= 6 ; i++)
            {
                pbImage.Image = Image.FromFile("die" + i.ToString() + ".gif");
                pbImage.Refresh();
                Thread.Sleep(300);



                /*
                pbImage.Image = Image.FromFile("C:/Users/jense/OneDrive/Desktop/C#/Assignments/Assignment2/images/die6.gif");
                pbImage.Refresh();
                Thread.Sleep(300);
                pbImage.Image = Image.FromFile("C:/Users/jense/OneDrive/Desktop/C#/Assignments/Assignment2/images/die5.gif");
                pbImage.Refresh();
                Thread.Sleep(300);
                pbImage.Image = Image.FromFile("C:/Users/jense/OneDrive/Desktop/C#/Assignments/Assignment2/images/die4.gif");
                pbImage.Refresh();
                Thread.Sleep(300);*/
            }
        }
    }
}
