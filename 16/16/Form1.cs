using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace _16
{
    public partial class Form1 : Form
    {
        private const int bufferSize = 1024;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string serverAddress = txtServerAddress.Text;
            string filePath = txtFilePath.Text;

            if (string.IsNullOrWhiteSpace(serverAddress) || string.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("Введіть адресу сервера та оберіть файл.");
                return;
            }

            try
            {
                using (TcpClient client = new TcpClient(serverAddress, 8888))
                using (NetworkStream stream = client.GetStream())
                using (FileStream fileStream = File.OpenRead(filePath))
                {
                    byte[] fileNameBytes = System.Text.Encoding.UTF8.GetBytes(Path.GetFileName(filePath));
                    stream.Write(fileNameBytes, 0, fileNameBytes.Length);

                    byte[] fileSizeBytes = BitConverter.GetBytes((int)fileStream.Length);
                    stream.Write(fileSizeBytes, 0, fileSizeBytes.Length);

                    byte[] buffer = new byte[bufferSize];
                    int bytesRead;
                    while ((bytesRead = fileStream.Read(buffer, 0, bufferSize)) > 0)
                    {
                        stream.Write(buffer, 0, bytesRead);
                    }

                    MessageBox.Show("Відправка файлу успішна.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
    }
}
