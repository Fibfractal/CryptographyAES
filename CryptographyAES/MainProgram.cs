// MainProgram.cs
// Created by: Robert Nilsson
// Date:       2019-04-11
using System;
using System.Windows.Forms;

namespace CryptographyAES
{
    // A program that can encrypt and decrypt, plain- and ciphertexts using AES
    static class MainProgram
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());                      // A new instance of the MainForm class is created
        }
    }
}
