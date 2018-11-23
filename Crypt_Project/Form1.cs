﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypt_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //'А','Б','В','Г','Ґ','Д','Е','Є','Ж','З',
        //'И','І','Ї','Й','К','Л','М','Н','О','П',
        //'Р','С','Т','У','Ф','Х','Ц','Ч','Ш','Щ',
        //'Ь','Ю','Я'
        static String Alphabet = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ" +
                          "абвгґдеєжзиіїйклмнопрстуфхцчшщьюя";
        static int FreeSpace = 40;
        static int LettersInLine = 11;
        int NumberOfRows = Alphabet.Length / LettersInLine;
        Font font = new Font("Times New Roman", 15.0f);
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for (int j = 0; j < NumberOfRows ; j++)
                for (int i=0; i < LettersInLine; i++ )
                    TextRenderer.DrawText(e.Graphics, Alphabet[i + (LettersInLine * j)].ToString(), font,
                    new Point(10 + (FreeSpace * i), 10+(FreeSpace * j)), SystemColors.ControlDarkDark);
        }
    }


}


