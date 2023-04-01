using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        List<string> playlist;
        int count;
        public Form1()
        {
            playlist = new List<string>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                foreach (string fileName in openFileDialog1.FileNames)
                {
                    playlist.Add(fileName);
                    listBox1.Items.Add(fileName);
                }
                    string name= openFileDialog1.FileName;
                textBox1.Text= name.Substring(26);

            }
            Player.URL = openFileDialog1.FileName;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void play_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != 0) {
                openFileDialog1.FileName = listBox1.SelectedItem.ToString();
                Player.URL = openFileDialog1.FileName;
                Player.Ctlcontrols.play();
                string name = openFileDialog1.FileName;
                textBox1.Text = name.Substring(26);
            }

            Player.Ctlcontrols.play();


        }

        private void stop_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }


      

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Player.settings.volume = e.NewValue;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void geri_Click(object sender, EventArgs e)
        {
            int count = 0;int a = 0;
            foreach (var items in listBox1.Items)
            {
                count++;
                if (Player.URL == items.ToString())
                {

                    if ( count!=a)
                    {
                        int sa = count-2;

                        Player.URL = listBox1.Items[sa].ToString();
                        Player.Ctlcontrols.play();
                        textBox1.Text = Player.URL;
                        break;
                    }
                }
            }
        }

        private void ileri_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (var items in listBox1.Items)
            {
                count++;
                if (Player.URL == items.ToString())
                {

                    if (listBox1.Items.Count > count)
                    {
                        int sa = count ;

                        Player.URL = listBox1.Items[sa].ToString();
                        Player.Ctlcontrols.play();
                        textBox1.Text = Player.URL;
                        break;
                    }
                }
            }
        }
    }
}
    
