using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace SpringfieldNuclear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
            label2.BackColor = Color.Red;

            startButton.BackColor = Color.Red;

            outputLabel.Text = "Meltdown Happening !!!!";

            SoundPlayer alertplayer = new SoundPlayer();
            alertplayer.Play();

            Refresh();
            Thread.Sleep(500);

            label1.BackColor = Color.White;
            label2.BackColor = Color.White;

            Refresh();
            Thread.Sleep(500);

            label1.BackColor = Color.Red;
            label2.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(500);

            label1.BackColor = Color.White;
            label2.BackColor = Color.White;

            Refresh();
            Thread.Sleep(500);

            label1.BackColor = Color.Red;
            label2.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(500);

            label1.BackColor = Color.White;
            label2.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
