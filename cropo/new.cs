using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
//using system IO
namespace cropo
{
    public partial class @new : Form
    {
        Image File;
        public @new()
        {
            InitializeComponent();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butOpen_Click(object sender, EventArgs e)
        {
            //OpenFileDialog open = new OpenFileDialog();
            //open.Filter = "JPG(*.JPG)|*.jpg";

            //if (open.ShowDialog() == DialogResult.OK)
            //{
            //  File = Image.FromFile(open.FileName);
            //pictureBoxSoil.Image = File;
            //}
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = Environment.CurrentDirectory;

            open.Filter = "Image Files (*.jpg;*.jpeg;*.bmp)|*.jpg; *.jpeg; *.bmp;";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxSoil.Image = new Bitmap(open.FileName);
            }
        }

        public Color[][] getBitmapColorMatrix(string filePath)
        {
            Bitmap bmp = new Bitmap(filePath);
            Color[][] matrix;
            int height = bmp.Height;
            int width = bmp.Width;
            if (height > width)
            {
                matrix = new Color[bmp.Width][];
                for (int i = 0; i <= bmp.Width - 1; i++)
                {
                    matrix[i] = new Color[bmp.Height];
                    for (int j = 0; j < bmp.Height - 1; j++)
                    {
                        matrix[i][j] = bmp.GetPixel(i, j);
                    }
                }
            }
            else
            {
                matrix = new Color[bmp.Height][];
                for (int i = 0; i <= bmp.Height - 1; i++)
                {
                    matrix[i] = new Color[bmp.Width];
                    for (int j = 0; j < bmp.Width - 1; j++)
                    {
                        matrix[i][j] = bmp.GetPixel(i, j);
                    }
                }
            }
            return matrix;
        }

        private void butTest_Click(object sender, EventArgs e)
        {
            
            Bitmap img = new Bitmap(pictureBoxSoil.Image);
            int i, j;
            for (i = 0; i < img.Width; i++)
            {
                for (j = 0; j < img.Height; j++)
                {

                    Color pixel = img.GetPixel(i, j);
                    //RGB
                    Console.WriteLine ("RGB[" + i + "][" + j + "] : " + "[" + pixel.R + "," + pixel.G + "," + pixel.B + "]");
                    //Console.WriteLine();
                   // Console.WriteLine();
                }
            }
        }
                    
                    //string pixelColorStringValue =
                    //    pixel.R.ToString("D3") + " " +
                    //    pixel.G.ToString("D3") + " " +
                    //    pixel.B.ToString("D3") + ", ";

                    //switch (pixelColorStringValue)
                    //{
                    //    case "255 255 255":
                    //        {
                    // white pixel
                    //            break;
                    //        }
                    //    case "000 000 000":
                    //        {
                    //            // black pixel
                    //            break;
                    //        }
                    //}

                    //if(i < 1 && j < txtCode.TextLength)
                    //{


                    //  char letter = Convert.ToChar(txtCode.Text.Substring(j, 1));
                    //  int value = Convert.ToInt32(letter);
                    //  Console.WriteLine("letter : " + letter + " value : " + value);

                    //  img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, value));

                    //}
        

        private void butTest_MouseEnter(object sender, EventArgs e)
        {
            butTest.BackColor = Color.Blue;
        }

        private void butTest_MouseLeave(object sender, EventArgs e)
        {
            butTest.BackColor = Color.Black;
        }

        private void butOpen_MouseEnter(object sender, EventArgs e)
        {
            butOpen.BackColor = Color.Blue;
        }

        private void butOpen_MouseLeave(object sender, EventArgs e)
        {
            butOpen.BackColor = Color.Black;
        }

        private void butProcessing_Click(object sender, EventArgs e)
        {
            pictureBoxSoil.Image = CovertToGrayscale(new Bitmap(OutputPictureBox.Image));
            pictureBoxSoil.Refresh();

            //Bitmap img = new Bitmap(pictureBoxSoil.Image);
            //byte R, G, B;
            //Color pixelColor;
            //for (int x = 0; x < img.Width; x++)
            //{
            //    for (int y = 0; y < img.Height; y++)
            //    {
            //       pixelColor = img.GetPixel(x, y);
            //       R = (byte)Math.Abs(pixelColor.R - 255);
            //        G = (byte)Math.Abs(pixelColor.G - 255);
            //        B = (byte)Math.Abs(pixelColor.B - 255);
            //
            //        if (R < G && R < B)
            //        {
            //            pixelColor = Color.Red;
            //        }
            //        else if (G < R && G < B)
            //        {
            //            pixelColor = Color.Green;
            //        }
            //        else if (B < R && B < G)
            //        {
            //            pixelColor = Color.Blue;
            //        }
            //    }
            //}
            //OutputPictureBox.Image = img;



            //Bitmap bmp1 = new Bitmap(@"D:a.jpg");
            //pictureBoxSoil.Image = bmp1;
            //Color col = new Color();
            //int w = Int32.Parse(bmp1.Width.ToString());
            //int h = Int32.Parse(bmp1.Height.ToString());
            //int[,] redstr = new int[w, h];
            //int[,] greenstr = new int[w, h];
            //int[,] bluestr = new int[w, h];
            //int red = 0, green = 0, blue = 0;
            //for (int i = 0; i < w; i++)
            //{
            //  for (int j = 0; j < h; j++)
            //{
            //  col = bmp1.GetPixel(i, j);
            //  red = col.R;
            //  green = col.G;
            //  blue = col.B;
            //  redstr[i, j] = red;
            //  greenstr[i, j] = green;
            //  bluestr[i, j] = blue;
            //}
            //}

        }
        
        //private void GetPixel_Example(PaintEventArgs e)
        //{
            // Create a Bitmap object from an image file.
          //  Bitmap myBitmap = new Bitmap("YOURFILENAME.jpg");

            // Get the color of a pixel within myBitmap.
          //  Color pixelColor = myBitmap.GetPixel(50, 50);
        //}
        private static Bitmap CovertToGrayscale (Bitmap source)
        {
            Bitmap bm = new Bitmap(source.Width, source.Height);
            for(int y = 0; y < bm.Height; y++)
            {
                for(int x = 0; x < bm.Width; x++)
                {
                    Color c = source.GetPixel(x, y);
                    int avarage = (Convert.ToInt32(c.R) + Convert.ToInt32(c.G) + Convert.ToInt32(c.B)) / 3;
                    bm.SetPixel(x, y, Color.FromArgb(avarage, avarage, avarage));
                }
            }
            return bm;
        }
        private void butProcessing_MouseEnter(object sender, EventArgs e)
        {
            butProcessing.BackColor = Color.Blue;
        }

        private void butProcessing_MouseLeave(object sender, EventArgs e)
        {
            butProcessing.BackColor = Color.Black;
        }
        private void butSave_Click(object sender, EventArgs e)
        {
            
        }

        private void butSave_MouseEnter(object sender, EventArgs e)
        {
            butSave.BackColor = Color.Blue;
        }

        private void butSave_MouseLeave(object sender, EventArgs e)
        {
            butSave.BackColor = Color.Black;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
