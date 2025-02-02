﻿// Anthony Franklin afranklin18@cnm.edu
//FranklinStudentFormDemo
//Form1.cs
//02/17/2022

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FranklinStudentFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void rbIT_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void rbProgramming_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbWebDesign_CheckedChanged(object sender, EventArgs e)
        {

        }
        

        private void txbScore1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbScore2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbScore3_TextChanged(object sender, EventArgs e)
        {

        }
        private void txbScore4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {            //Figure out major
            string major = "TBD";
            if (rbProgramming.Checked) major = rbProgramming.Text;
            else if (rbWebDesign.Checked) major = rbWebDesign.Text;
            else if (rbIT.Checked) major = rbIT.Text;

            //Instantiate a student
            Student st = new Student(txbStudentID.Text, txbFirstName.Text, txbLastName.Text, major);
            st.StudentNumber = txbStudentID.Text;

            //Count number of check boxes checked
            int count = 0;
            if (cbxCIS101.Checked) count++;
            if (cbxCIS102.Checked) count++;
            if (cbxCIS103.Checked) count++;
            if (cbxCIS104.Checked) count++;


            string[] courses = new string[count];
            int[] scores = new int[count];

            int index = 0;
            if (cbxCIS101.Checked)
            {
                courses[index] = cbxCIS101.Text;
                int.TryParse(txbScore1.Text, out scores[index++]);
            }
            if (cbxCIS102.Checked)
            {
                courses[index] = cbxCIS102.Text;
                int.TryParse(txbScore2.Text, out scores[index++]);
            }
            if (cbxCIS103.Checked)
            {
                courses[index] = cbxCIS103.Text;
                int.TryParse(txbScore3.Text, out scores[index++]);
            }
            if (cbxCIS104.Checked)
            {
                courses[index] = cbxCIS104.Text;
                int.TryParse(txbScore4.Text, out scores[index++]);
            }

            //Set new arrays into student object
            st.Scores = scores;
            st.Courses = courses;

            //display output
            txbResult.Text = st.ToString();
        }               
    }
}
