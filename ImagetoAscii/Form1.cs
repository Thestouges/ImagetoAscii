using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagetoAscii
{
    public partial class Form1 : Form
    {
        PictureBox imagetoconvert;
        string ascale;
        Thread thread;

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            imagetoconvert = new PictureBox();
            imagetoconvert.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureContainer.Controls.Add(imagetoconvert);

            DirTextBox.ReadOnly = true;
            convertButton.Enabled = false;
            StopButton.Enabled = false;
            asciiTextBox.Font = new Font(FontFamily.GenericMonospace, asciiTextBox.Font.Size);

            ascale = "$@B%8&WM#*oahkbdpqwmZO0QLCJUYXzcvunxrjft/\\|()1{}[]?-_+~<>i!lI;:,\" ^`\'. ";

            SpaceComboBox.SelectedIndex = 4;
            SpaceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void DirButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dir = new OpenFileDialog();
            Dir.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            try
            {
                if (Dir.ShowDialog() == DialogResult.OK)
                {
                    DirTextBox.Text = Dir.FileName;
                    imagetoconvert.Load(DirTextBox.Text);
                }
                Dir.Dispose();

                convertButton.Enabled = true;
            }
            catch
            {
                convertButton.Enabled = false;
            }

        }

        private static int Brightness(Color c)
        {
            return (int)Math.Sqrt(
               c.R * c.R * .241 +
               c.G * c.G * .691 +
               c.B * c.B * .068);
        }

        private void converter()
        {
            int spaces = int.Parse(SpaceComboBox.SelectedItem.ToString());
            asciiTextBox.Text = "";
            convertprogressBar.Value = 0;
            try
            {
                Bitmap image = new Bitmap(imagetoconvert.Image);
                convertprogressBar.Maximum = image.Size.Width/ spaces * image.Size.Height/ spaces;
                for (int i = 0; i < image.Height; i += spaces)
                {
                    for (int j = 0; j < image.Width; j += spaces)
                    {
                        var letter = (double)Brightness(image.GetPixel(j, i)) / 255.0 * (double)(ascale.Length - 1);
                        asciiTextBox.Text += ascale[(int)Math.Round(letter)];
                        convertprogressBar.Increment(1);
                    }
                    asciiTextBox.Text += "\r\n";
                }
            }
            catch
            {

            }
            StopButton.Enabled = false;
            convertButton.Enabled = true;
        }

        private void convert_Click(object sender, EventArgs e)
        {
            thread = new Thread(converter);
            StopButton.Enabled = true;
            convertButton.Enabled = false;
            thread.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            thread.Abort();
            convertprogressBar.Value = 0;
            StopButton.Enabled = false;
            convertButton.Enabled = true;
        }
    }
}
