using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wmp_19
{
    public partial class AsraMP : Form
    {
        public AsraMP()
        {
            InitializeComponent();
        }

        public string[] dosya, yol;
        private void AsraMP_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;

        }
        private void Playbtn1_Click(object sender, EventArgs e)
        {
            MyWMP.Ctlcontrols.play();
        }
        private void Pausebtn1_Click(object sender, EventArgs e)
        {
            MyWMP.Ctlcontrols.pause();
        }
        private void Stopbtn1_Click(object sender, EventArgs e)
        {
            MyWMP.Ctlcontrols.stop();
        }
        private void Openbtn1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Multiselect = true;
                ofd.Filter = "All Supported Audio | *.mp3; *.wma; *.m4a; | MP3s | *.mp3 | WMAs | *.wma |All files (*.*)|*.*";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    dosya = ofd.SafeFileNames;
                    yol = ofd.FileNames;

                    for (int i = 0; i < dosya.Length; i++)
                    {
                        listBoxSongs.Items.Add(dosya[i]);
                    }
                }
                MyWMP.URL = yol[listBoxSongs.SelectedIndex];
                timer1.Start();

            }
            catch
            {
                MessageBox.Show("Hata Dosya Oynatamıyor");
            }
        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //Baslat.Sec();
            MyWMP.URL = listBoxSongs.SelectedItem.ToString();
            timer1.Start();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyWMP.URL = listBoxSongs.SelectedItem.ToString();
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //++sayar;
            int _duration = Convert.ToInt32(MyWMP.currentMedia.duration); // Dosya'nın uzunluğu
            int _currentPosition = Convert.ToInt32(MyWMP.Ctlcontrols.currentPosition); //  Dosya'nın Çaldığı an 
            progressBar1.Maximum = _duration; // progressBar'ın en büyük değeri = len = Dosya'nın uzunluğu
            progressBar1.Value = _currentPosition; // progressBar'ın  ani değeri
            if (progressBar1.Value == _duration)
            {
                progressBar1.Value = 0;
            }
            _duration = Convert.ToInt32(MyWMP.currentMedia.duration);
            int kalan = _duration - _currentPosition;
            label4.Text = Convert.ToString(_currentPosition / 60) + ":" + Convert.ToString(_currentPosition % 60); // geçtiği Dakika ve saniye
            label3.Text = Convert.ToString(kalan / 60) + ":" + Convert.ToString(kalan % 60);  // kaldığı Dakika ve saniye
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); // kapat
        }
        private void aboutASRAMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBoxForm f2 = new AboutBoxForm();
            f2.ShowDialog(); // About Formu gösterme
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Multiselect = true;
                ofd.Filter = "All Supported Audio | *.mp3; *.wma; *.m4a; | MP3s | *.mp3 | WMAs | *.wma |All files (*.*)|*.*";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    dosya = ofd.SafeFileNames;
                    yol = ofd.FileNames;

                    for (int i = 0; i < dosya.Length; i++)
                    {
                        listBoxSongs.Items.Add(dosya[i]);
                    }
                }
                MyWMP.URL = yol[listBoxSongs.SelectedIndex];
                timer1.Start();

            }
            catch
            {
                MessageBox.Show("Hata Dosya Oynatamıyor");
            }
            //MyWMP.URL = listBoxSongs.SelectedItem.ToString();
            //timer1.Start();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm op2 = new OptionsForm();
            op2.ShowDialog(); // Options Formu gösterme
        }

        private void listBoxSongs_SelectedValueChanged(object sender, EventArgs e)
        {
            MyWMP.URL = yol[listBoxSongs.SelectedIndex];
            timer1.Start();
        }

        private void secbtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Multiselect = true;
                ofd.Filter = "All Supported Audio | *.mp3; *.wma; *.m4a; | MP3s | *.mp3 | WMAs | *.wma |All files (*.*)|*.*";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    dosya = ofd.SafeFileNames;
                    yol = ofd.FileNames;

                    for (int i = 0; i < dosya.Length; i++)
                    {
                        listBoxSongs.Items.Add(dosya[i]);
                    }
                }
                MyWMP.URL = yol[listBoxSongs.SelectedIndex];
                timer1.Start();

            }
            catch
            {
                MessageBox.Show("Hata Dosya Oynatamıyor");
            }
        }
    }

    //internal class Baslat // Başlatma Class
    //{
    //    static AsraMP _AnaForm = Application.OpenForms.OfType<AsraMP>().FirstOrDefault(); // ANAFORM 
    //    public static void Sec() //Method
    //    {
    //        try
    //        {
    //            if (_AnaForm.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
    //            {
    //                //_AnaForm.dosya = _AnaForm.openFileDialog1.SafeFileNames;
    //                //_AnaForm.yol = _AnaForm.openFileDialog1.FileNames;
    //                for (int i = 0; i < _AnaForm.openFileDialog1.SafeFileNames.Length; i++)
    //                {
    //                    _AnaForm.listBoxSongs.Items.Add(_AnaForm.openFileDialog1.SafeFileNames[i].ToString());
    //                    _AnaForm.listBoxSongs.Items.Add(_AnaForm.openFileDialog1.FileNames[i].ToString());
    //                }

    //                //for (int i = 0; i < _AnaForm.dosya.Length; i++)
    //                //{
    //                //    _AnaForm.listBoxSongs.Items.Add(_AnaForm.dosya[i]);
    //                //}
    //            }

    //        }
    //        catch
    //        {
    //            MessageBox.Show("Hata, Dosya Seçmiyor ");
    //        }
    //    }

    //public static void Oynat() //Method
    //{
    //    try
    //    {
    //        _AnaForm.MyWMP.URL = _AnaForm.listBoxSongs.SelectedItem.ToString();
    //        _AnaForm.timer1.Start();
    //    }
    //    catch
    //    {
    //        MessageBox.Show("Hata, Dosya Oynatamıyor");
    //    }
    //}
        //}
 
}








