using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Lab4_test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string message;
        // Tính MD5
        private string calMD5(string message)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(message));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("X2")); // x2 = lowercase
            }
            return hash.ToString();
        }
        // Tính SHA1
        private string calSHA1(string message)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(message));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }
        // Tính SHA-256
        private string calSHA256(string message)
        {
            using (SHA256Managed sha256 = new SHA256Managed())
            {
                var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(message));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }
        private string calSHA384(string message)
        {
            using (SHA384Managed sha384 = new SHA384Managed())
            {
                var hash = sha384.ComputeHash(Encoding.UTF8.GetBytes(message));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }
        private string calSHA512(string message)
        {
            using (SHA512Managed sha512 = new SHA512Managed())
            {
                var hash = sha512.ComputeHash(Encoding.UTF8.GetBytes(message));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }
        private string calRIPEMD160(string message)
        {
            using (RIPEMD160Managed ripemd = new RIPEMD160Managed())
            {
                var hash = ripemd.ComputeHash(Encoding.UTF8.GetBytes(message));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }
        private string ToHexString(string message)
        {
            var bytes = new byte[message.Length / 2];
            string text = "";
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(message.Substring(i * 2, 2), 16);
                text += (char)bytes[i];
            }
            return text;// returns: "Hello world" for "48656C6C6F20776F726C64"
        }
        private void hashButton_Click(object sender, EventArgs e)
        {
            // Gồm 3 phần: Text, Hex, File
            if (dataBox.Text == "Hex string")
                message = ToHexString(dataText.Text);
            else
                if (dataBox.Text == "File")
            {
                importFileButton.Enabled = true;
                //message = readFile();
            }
            else
                message = dataText.Text;
            // Xuất các giá trị ra textbox
            if (checkMD5.Checked)
                MD5Hash.Text = calMD5(message);

            if (checkSHA1.Checked)
                SHA1Hash.Text = calSHA1(message);

            if (checkSHA256.Checked)
                SHA256Hash.Text = calSHA256(message);

            if (checkSHA384.Checked)
                SHA384Hash.Text = calSHA384(message);

            if (checkSHA512.Checked)
                SHA512Hash.Text = calSHA512(message);
            if (checkRIPEMD160.Checked)
                RIPEMD160Hash.Text = calRIPEMD160(message);
        }
        
        private void importFileButton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = dlg.FileName;
                dataText.Text = file;
                try
                {
                    message = File.ReadAllText(file);
                }
                catch (IOException)
                {
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
