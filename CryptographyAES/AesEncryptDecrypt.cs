// AesEncryptDecrypt.cs
// Created by: Robert Nilsson
// Date:       2019-04-11
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CryptographyAES
{
    // The class performs symmetric encryption and decryption using the
    // Advanced Encryption Standard (AES) algorithm. It uses the class
    // AesCryptoServiceProvider in the System.Security.Cryptography 
    // namespace. Values of the key, initialization vector, blocksize,
    // keysize, ciphermode and paddingmode, initializes an object
    // of the AesCryptoServiceProvider class in the constructor.
    // The class has two methods. One method encrypts a textstring and   
    // returns the string result. The other method  decrypts a textstring 
    // and returns the string result.
    class AesEncryptDecrypt
    {
        // Declaring an instance variabel from the
        // AesCryptoServiceProvider class
        private AesCryptoServiceProvider cryptProvider;
        // The IV as a string instance variabel
        private string myIV;   

        // Constructor
        public AesEncryptDecrypt()
        {
            // The 256 bit key (8*32)
            string key = "clsdiO1P61Wu70%_DdzlAXYCbsOLC?=.";   

            // Using this class from the Security.Cryptography namespace
            // Creating a new object of the AesCryptoServiceProvider class
            cryptProvider = new AesCryptoServiceProvider();                         

            // -- Initializing the instance varibles of cryptoProvider --

            // AES is a block cipher operating with 128 bit blocks
            cryptProvider.BlockSize = 128;
            // Can use keys 128, 192, 256 bits long, size 256 bits is used
            cryptProvider.KeySize = 256;
            // A random initialization vector is set 
            cryptProvider.GenerateIV();
            // The key is set by converting it to bytes
            cryptProvider.Key = ASCIIEncoding.ASCII.GetBytes(key);
            // Cipher block chaining mode (CBC) is the cipher mode used. The CBC is a field   
            // of the CipherMode enum. Difficult to find pattern in encryption using this mode.
            cryptProvider.Mode = CipherMode.CBC;
            // The PKCS7 is the padding mode used. The PKCS7 is a field of the PaddingMode enum.
            cryptProvider.Padding = PaddingMode.PKCS7;                              
        }

        // Method to get the string value of the IV, returns the IV
        public string GetIV()
        {
            myIV = ASCIIEncoding.ASCII.GetString(cryptProvider.IV);
            return myIV;
        }

        // Method to set the IV as a byte array from the IV as a
        // string value. Which is a parameter of the method.
        public void SetIV(string newIV)
        {
            cryptProvider.IV = ASCIIEncoding.ASCII.GetBytes(newIV);
        }

        // The metod takes a string plaintext as argument and encrypts it, and returns a string ciphertext
        public string EncryptPlainText(string plainText)
        {
            // CreateEncryptor() creates a symmetric AES encryptor object using 
            // the current key and initialization vector (IV).
            // ICryptoTransform defines the basic operations of cryptographic transformations.
            ICryptoTransform transform = cryptProvider.CreateEncryptor();

            // The plaintext is first transformed into a bytes array and and then
            // transformed into an encrypted bytes array.
            // TransformFinalBlock, transforms the specified region of the specified byte array.
            byte[] encryptedBytes = transform.TransformFinalBlock(ASCIIEncoding.ASCII.GetBytes(plainText),
                0, plainText.Length);

            // The encrypted bytes array is converted to a cipher textstring
            string cipherText = Convert.ToBase64String(encryptedBytes);

            // The ciphertext is returned
            return cipherText;
        }

        // The metod takes a string ciphertext as argument and decrypts it, 
        // and returns a string original plaintext
        public string DecryptCipherText(string cipherText)
        {
            // CreateDecryptor() creates a symmetric AES decryptor object using 
            // the current key and initialization vector (IV).
            // ICryptoTransform defines the basic operations of cryptographic transformations.
            ICryptoTransform transform = cryptProvider.CreateDecryptor();

            // The ciphertext is converted back to an encrypted bytes array
            byte[] encryptedBytes = Convert.FromBase64String(cipherText);

            // The encrypted bytes array is transformed into a decrypted bytes array.
            // TransformFinalBlock, transforms the specified region of the specified byte array.
            byte[] decryptedBytes = transform.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

            // The decrypted bytes array is converted to a stringtext, the original plaintext.
            string plainText = ASCIIEncoding.ASCII.GetString(decryptedBytes);
            
            // The plaintext is returned
            return plainText;
        }
    }
}
