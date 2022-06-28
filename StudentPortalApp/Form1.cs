﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPortalApp
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        List<Module> modules = new List<Module>();
        string name, gender, idNum, yearOfStudy;
        int age;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void nameTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void IDTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void GenderTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void YearOfStudyTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // get marks 
            int projectMark = Convert.ToInt32(ProjectMarksList.Text);
            int examMark = Convert.ToInt32(ExamMarksList.Text);
            int semesterMark = Convert.ToInt32(SemesterMarksList.Text);

            Module module = new Module(ModuleList.Text,projectMark,semesterMark,examMark) ;
            name = nameTextBox.Text;
            idNum = IDTextBox.Text;
            age = Convert.ToInt32(AgeTextBox.Text);
            yearOfStudy = YearOfStudyTextBox.Text;
            
            Student student = new Student(name, idNum, age, gender, yearOfStudy, module);

            students.Add(student);


        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

        }

        private void ResultsTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void AverageMarksTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void ExamMarksList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SemesterMarksList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProjectMarksList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ModuleList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StudentsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
