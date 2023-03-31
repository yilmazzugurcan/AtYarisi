using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class Form1 : Form
    {

        private int finishLine; 
        private Random random; 
        private List<PictureBox> horses;
        public Form1()
        {
            InitializeComponent();
            finishLine = pictureBoxFinishLine.Left;
            random = new Random();
            horses = new List<PictureBox>();

            
            horses.Add(pictureBoxHorse1);
            horses.Add(pictureBoxHorse2);
            horses.Add(pictureBoxHorse3);
            horses.Add(pictureBoxHorse4);
            horses.Add(pictureBoxHorse5);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (PictureBox horse in horses)
            {
                horse.Left = pictureBoxStartLine.Left;
            }

            timerRace.Start();
        }

        private void timerRace_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox horse in horses)
            {
                int speed = random.Next(1, 5); 
                horse.Left += speed;

                
                if (horse.Right >= finishLine)
                {
                    timerRace.Stop();
                    MessageBox.Show(horse.Name + " kazandı!");
                    break;
                }
            }
        }

        private void pictureBoxStartLine_Click(object sender, EventArgs e)
        {

        }
    }

}

