﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML_Project._Core;

namespace UML_Project._Forms
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Explorer_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "../../Save";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Core._myPath = openFileDialog.FileName;
                    BinaryConversion.DeserializationDictionary();
                    MessageBox.Show("Загрузка успешно завершена");
                }
            }
            int s = Core.Figures[0];
            int s1 = Core.Figures[1];
            int s2 = Core.Figures[2];
            int s3 = Core.Figures[3];
            MessageBox.Show($"s = {s} s1 = {s1} s2 = {s2} s3 = {s3}");
            NewProject newProject = new NewProject();
            Hide();
            newProject.Show();
        }
    }
}
