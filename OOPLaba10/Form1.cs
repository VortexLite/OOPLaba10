using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OOPLaba10
{


    public partial class Form1 : Form
    {
        Regular_Pentagon regP;
        BinaryFormatter format;
        [Serializable]
        public class Regular_Pentagon
        {
            double r;
            public double radius
            {
                set { r = value; }
                get { return r; }
            }

            public Regular_Pentagon()
            {
                radius = 0;
            }

            public Regular_Pentagon(double radius)
            {

                this.radius = radius;
            }
            public void Draw(SolidBrush sb, Pen p, Graphics g, int Ex, int Ey)
            {
                PointF[] pointF = new PointF[5];
                for (int i = 0; i < 5; i++)
                {
                    float x = (float)(Ex + radius * Math.Cos(i * 2 * Math.PI / 5));
                    float y = (float)(Ey + radius * Math.Sin(i * 2 * Math.PI / 5));
                    pointF[i] = new PointF(x, y);
                }
                g.DrawPolygon(p, pointF);
                g.FillPolygon(sb, pointF);
            }

        }

        public Form1()
        {
            InitializeComponent();

        }

        private void regPent_Click(object sender, EventArgs e)
        {
            if (TextRadius.Text == "")
            {
                regP = new Regular_Pentagon();
                MessageBox.Show("Заповніть значення r.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.Parse(TextRadius.Text) <= 1)
            {
                regP = new Regular_Pentagon();
                MessageBox.Show("Значення r не може бути меншим 1!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                regP = new Regular_Pentagon(Double.Parse(TextRadius.Text));
            }

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (regP == null)
            {
                MessageBox.Show("Об'єкт класу не створено!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Graphics g = CreateGraphics();
                Pen p = new Pen(Color.Black);
                SolidBrush solidBrush = new SolidBrush(Color.FromArgb(255, 0, 0, 0));
                g.Clear(BackColor);
                regP.Draw(solidBrush, p, g, e.X, e.Y);

            }
        }
        private void XMLSerialization_Click(object sender, EventArgs e)
        {
            if (regP == null)
            {
                MessageBox.Show("Об'єкт класу не створено!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                XmlSerializer format = new XmlSerializer(typeof(Regular_Pentagon));
                FileStream f = new FileStream("file.xml", FileMode.OpenOrCreate);
                format.Serialize(f, regP);
                f.Close();
                MessageBox.Show("Файл створено", "Створено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void XMLDESerialization_Click(object sender, EventArgs e)
        {
            if (File.Exists("file.xml"))
            {
                FileStream f;
                f = new FileStream("file.xml", FileMode.Open);
                XmlSerializer format = new XmlSerializer(typeof(Regular_Pentagon));
                regP = (Regular_Pentagon)format.Deserialize(f);
                TextRadius.Text = regP.radius.ToString();
                f.Close();
                MessageBox.Show("Десеріалізовано.", "XML", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Відсутність об'єкт для відновлення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DatSerialization_Click(object sender, EventArgs e)
        {
            if (regP == null)
            {
                MessageBox.Show("Відсутній об'єкт для зберігання", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                format = new BinaryFormatter();
                FileStream f = new FileStream("file.dat", FileMode.OpenOrCreate);
                format.Serialize(f, regP);
                f.Close();
                MessageBox.Show("Файл створенно", "Створено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void DatDeSerialization_Click(object sender, EventArgs e)
        {
            if (File.Exists("file.dat"))
            {
                FileStream f = new FileStream("file.dat", FileMode.Open);
                format = new BinaryFormatter();
                regP = (Regular_Pentagon)format.Deserialize(f);
                TextRadius.Text = regP.radius.ToString();
                f.Close();
                MessageBox.Show("Десеріалізовано.", "Binary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Відсутність об'єкт для відновлення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}
