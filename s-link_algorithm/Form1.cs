using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s_link_algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                int[,] matris = new int[5, 5];
                //A
                matris[0, 0] = 0; //A
                matris[0, 1] = 1; //B
                matris[0, 2] = 2; //C
                matris[0, 3] = 3; //D
                matris[0, 4] = 4; //E
                //B
                matris[1, 0] = 1; //A
                matris[1, 1] = 0; //B
                matris[1, 2] = 1; //C
                matris[1, 3] = 2; //D
                matris[1, 4] = 5; //E
                //C
                matris[2, 0] = 2; //A
                matris[2, 1] = 1; //B
                matris[2, 2] = 0; //C
                matris[2, 3] = 3; //D
                matris[2, 4] = 2; //E
                //D
                matris[3, 0] = 3; //A
                matris[3, 1] = 2; //B
                matris[3, 2] = 3; //C
                matris[3, 3] = 0; //D
                matris[3, 4] = 1; //E
                //E
                matris[4, 0] = 4; //A
                matris[4, 1] = 5; //B
                matris[4, 2] = 2; //C
                matris[4, 3] = 1; //D
                matris[4, 4] = 0; //E
            }
            catch (Exception hata)
            {
                MessageBox.Show("Form yüklenirken bir hata oluştu. "+hata.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "")
                {
                    MessageBox.Show("Bir değer girmelisiniz");
                }
                else
                {
                    int ax = Convert.ToInt16(textBox1.Text);
                    int ay = Convert.ToInt16(textBox6.Text);
                    int bx = Convert.ToInt16(textBox2.Text);
                    int by = Convert.ToInt16(textBox7.Text);
                    int cx = Convert.ToInt16(textBox3.Text);
                    int cy = Convert.ToInt16(textBox8.Text);
                    int dx = Convert.ToInt16(textBox4.Text);
                    int dy = Convert.ToInt16(textBox9.Text);
                    int ex = Convert.ToInt16(textBox5.Text);
                    int ey = Convert.ToInt16(textBox10.Text);

                    System.Drawing.Graphics grafiknesne;
                    grafiknesne = this.CreateGraphics();
                    Pen firca = new Pen(System.Drawing.Color.Red, 5);
                    Font yazi = new System.Drawing.Font("Arial", 15, FontStyle.Italic);
                    Brush firca1 = new SolidBrush(System.Drawing.Color.Red);
                    grafiknesne.DrawString("A", yazi, firca1, ax, ay);
                    grafiknesne.DrawString("B", yazi, firca1, bx, by);
                    grafiknesne.DrawString("C", yazi, firca1, cx, cy);
                    grafiknesne.DrawString("D", yazi, firca1, dx, dy);
                    grafiknesne.DrawString("E", yazi, firca1, ex, ey);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu. "+hata.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "")
                {
                    MessageBox.Show("Bir değer girmelisiniz");
                }
                else
                {
                    int ax = Convert.ToInt16(textBox1.Text);
                    int ay = Convert.ToInt16(textBox6.Text);
                    int bx = Convert.ToInt16(textBox2.Text);
                    int by = Convert.ToInt16(textBox7.Text);
                    int cx = Convert.ToInt16(textBox3.Text);
                    int cy = Convert.ToInt16(textBox8.Text);
                    int dx = Convert.ToInt16(textBox4.Text);
                    int dy = Convert.ToInt16(textBox9.Text);
                    int ex = Convert.ToInt16(textBox5.Text);
                    int ey = Convert.ToInt16(textBox10.Text);
                    Font yazi = new System.Drawing.Font("Arial", 15, FontStyle.Italic);
                    Brush firca1 = new SolidBrush(System.Drawing.Color.Red);


                    System.Drawing.Graphics grafiknesne;
                    grafiknesne = this.CreateGraphics();
                    Pen firca = new Pen(System.Drawing.Color.Red, 5);
                    int esik = Convert.ToInt16(textBox11.Text);
                    grafiknesne.Clear(Color.WhiteSmoke);
                    grafiknesne.DrawString("A", yazi, firca1, ax, ay);
                    grafiknesne.DrawString("B", yazi, firca1, bx, by);
                    grafiknesne.DrawString("C", yazi, firca1, cx, cy);
                    grafiknesne.DrawString("D", yazi, firca1, dx, dy);
                    grafiknesne.DrawString("E", yazi, firca1, ex, ey);
                    if (esik == 0)
                    {
                        grafiknesne.DrawString("{A} , {B} , {C} , {E} , {D}", yazi, firca1, 370, 262);

                    }
                    if (esik == 1)
                    {
                        grafiknesne.DrawLine(firca, ax, ay, bx, by);
                        grafiknesne.DrawLine(firca, bx, by, cx, cy);
                        grafiknesne.DrawLine(firca, dx, dy, ex, ey);
                        grafiknesne.DrawString("{A,B,C} , {E,D}", yazi, firca1, 370, 262);


                    }
                    if (esik == 2)
                    {
                        grafiknesne.DrawLine(firca, ax, ay, bx, by);
                        grafiknesne.DrawLine(firca, bx, by, cx, cy);
                        grafiknesne.DrawLine(firca, dx, dy, ex, ey);
                        grafiknesne.DrawLine(firca, ax, ay, cx, cy);
                        grafiknesne.DrawLine(firca, bx, by, dx, dy);
                        grafiknesne.DrawLine(firca, cx, cy, ex, ey);
                        grafiknesne.DrawString("{A,B,C,E,D}", yazi, firca1, 370, 262);

                    }
                    if (esik == 3)
                    {
                        grafiknesne.DrawLine(firca, ax, ay, bx, by);
                        grafiknesne.DrawLine(firca, bx, by, cx, cy);
                        grafiknesne.DrawLine(firca, dx, dy, ex, ey);
                        grafiknesne.DrawLine(firca, ax, ay, cx, cy);
                        grafiknesne.DrawLine(firca, bx, by, dx, dy);
                        grafiknesne.DrawLine(firca, cx, cy, ex, ey);
                        grafiknesne.DrawLine(firca, ax, ay, dx, dy);
                        grafiknesne.DrawLine(firca, cx, cy, dx, dy);
                        grafiknesne.DrawString("{A,B,C,E,D}", yazi, firca1, 370, 262);

                    }
                    if (esik == 4)
                    {
                        grafiknesne.DrawLine(firca, ax, ay, bx, by);
                        grafiknesne.DrawLine(firca, bx, by, cx, cy);
                        grafiknesne.DrawLine(firca, dx, dy, ex, ey);
                        grafiknesne.DrawLine(firca, ax, ay, cx, cy);
                        grafiknesne.DrawLine(firca, bx, by, dx, dy);
                        grafiknesne.DrawLine(firca, cx, cy, ex, ey);
                        grafiknesne.DrawLine(firca, ax, ay, dx, dy);
                        grafiknesne.DrawLine(firca, cx, cy, dx, dy);
                        grafiknesne.DrawLine(firca, ax, ay, ex, ey);
                        grafiknesne.DrawString("{A,B,C,E,D}", yazi, firca1, 370, 262);

                    }
                    if (esik == 5)
                    {
                        grafiknesne.DrawLine(firca, ax, ay, bx, by);
                        grafiknesne.DrawLine(firca, bx, by, cx, cy);
                        grafiknesne.DrawLine(firca, dx, dy, ex, ey);
                        grafiknesne.DrawLine(firca, ax, ay, cx, cy);
                        grafiknesne.DrawLine(firca, bx, by, dx, dy);
                        grafiknesne.DrawLine(firca, cx, cy, ex, ey);
                        grafiknesne.DrawLine(firca, ax, ay, dx, dy);
                        grafiknesne.DrawLine(firca, cx, cy, dx, dy);
                        grafiknesne.DrawLine(firca, ax, ay, ex, ey);
                        grafiknesne.DrawLine(firca, bx, by, ex, ey);
                        grafiknesne.DrawString("{A,B,C,E,D}", yazi, firca1, 370, 262);

                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu. "+hata.ToString());
            }
            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
         
    }
}
