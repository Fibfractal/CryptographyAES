// MainForm.cs
// Created by: Robert Nilsson
// Date:       2019-04-11

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptographyAES
{
    // The class provides a GUI where input can be read och output displayed.
    // It reads a plaintext which can be encrypted and displayed as a text.
    // The text includes the ciphertext and the initialization vector.
    // The ciphertext can be decrypted and displayed back as a plaintext. 
    // You are supposed to manualy enter text sent to you, which consists of the 
    // ciphertext and the initialization vector. And then decrypt it.
    // The class uses the AesEncryptDecrypt class to make AES encryption and 
    // decryption.
    public partial class MainForm : Form
    {
        private AesEncryptDecrypt aesObject;  // Declaring an instance variabel of the AesEncryptDecrypt class
        private string plainTextIn;           // Declaring a string instance variabel, the plaintext input
        private string plainTextOut;          // Declaring a string instance variabel, the plaintext output
        private string cipherText;            // Declaring a string instance variabel, the ciphertext 

        // Constructor, initializing the GUI and the instance variables
        public MainForm()
        {
            InitializeComponent();
            InitializeVariables();
            ClearTextBoxes();
        }

        // Initializing the instance variables
        private void InitializeVariables()
        {
            aesObject = new AesEncryptDecrypt();
            plainTextIn = string.Empty;
            plainTextOut = string.Empty;
            cipherText = string.Empty;
        }

        // Initializing the GUI
        private void ClearTextBoxes()
        {
            tbx_Plaintext.Text = string.Empty;
            tbx_CiphertextAndIV.Text = string.Empty;
            tbx_DecryptPlaintext.Text = string.Empty;
        }

        // The method is called if the Encrypt Message button is pressed in the GUI.
        // It reads the plaintext as string, encrypts it, and displays the
        // ciphertext as string in the GUI.
        private void btn_EncryptMessage_Click(object sender, EventArgs e)
        {
            InitializeVariables();
            tbx_CiphertextAndIV.Text = string.Empty;
            tbx_DecryptPlaintext.Text = string.Empty;

            // Reads the plaintext
            plainTextIn = tbx_Plaintext.Text;

            // Getting the IV and setting it to the right format.
            // So the format of IV before encryption matches
            // the format before decryption. This applies to
            // when you manualy paste the ciphertext to decrypt.
            aesObject.SetIV(aesObject.GetIV()); 


            // Is the plaintext not empty?
            if (plainTextIn != string.Empty)
            {
                // The plaintext is encrypted to a ciphertext
                cipherText = aesObject.EncryptPlainText(plainTextIn);
            }

            // Getting the IV
            string IV = aesObject.GetIV();

            // The IV is added to ciphertext, this IV is needed when the text
            // is manualy read and decrypted in this program on other computer.
            // And it's displayed in GUI.
            tbx_CiphertextAndIV.Text = cipherText + IV ;  

        }

        // The method is called if the Decrypt Message button is pressed in the GUI.
        // The ciphertext is decrypted to the original plaintext and displayed in the GUI.
        // If the plaintext input is empty you can manualy enter a text containing both 
        // the ciphertext and IV for a correct decryption.
        private void btn_DecryptMessage_Click(object sender, EventArgs e)
        {
            // Checks if it's a manual read of the ciphertext
            CipherTextManualRead();

            try
            {
                // The ciphertext is decrypted to plaintext
                plainTextOut = aesObject.DecryptCipherText(cipherText);
            }
            catch 
            {
                MessageBox.Show("The ciphertext has the wrong format!");
                InitializeVariables();
                ClearTextBoxes();
            }

            // The original plaintext is displayed in the GUI
            tbx_DecryptPlaintext.Text = plainTextOut;
        }

        // Method to check if the text is a manual input, and
        // divides the textinput to one part that is the ciphertext
        // and to a second part that is the IV in string format.
        // Both parts are needed for a correct decryption.
        private void CipherTextManualRead()
        {
            if (tbx_Plaintext.Text == string.Empty)
            {
                // All textinput is trimmed and assigned to string variabel
                string myCiphertext = tbx_CiphertextAndIV.Text.Trim();
                // The lenght of the textinput is calculated
                int myLength = myCiphertext.Length;
                // Using substring method to get the ciphertext part
                string realCiphertext = myCiphertext.Substring(0, myLength - 16);
                // Using substring method to get the IV string part
                string IV = myCiphertext.Substring(myLength - 16);
                // Setting the IV as a byte array
                // The IV has the same format as before encryption
                aesObject.SetIV(IV);

                // The ciphertext part assignes the instance variabel cipherText
                cipherText = realCiphertext; 
            }
        }

        // Method to clear the input and output textboxes in the GUI
        // and initialize the instance variables
        private void btn_ClearMessage_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            InitializeVariables();
        }
    }
}
