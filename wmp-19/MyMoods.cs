using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wmp_19
{
    internal class StyleSec // Class
    {

        static AsraMP _AnaForm = Application.OpenForms.OfType<AsraMP>().FirstOrDefault();
        static OptionsForm _OptionsForm = Application.OpenForms.OfType<OptionsForm>().FirstOrDefault();
        //static AboutBox1 _OptionsForm3 = Application.OpenForms.OfType<AboutBox1>().FirstOrDefault();


        public static void Darkmod19 () //Method
        {
            //AsraMP asramp1 = new AsraMP(); // AsraMP is Form's name
            _AnaForm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _AnaForm.anamenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _AnaForm.aboutASRAMPToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _AnaForm.aboutToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _AnaForm.anamenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _AnaForm.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _AnaForm.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _AnaForm.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _AnaForm.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            //myClass.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _AnaForm.listBoxSongs.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            //myClass.MyWMP.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _AnaForm.Openbtn1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _AnaForm.openToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _AnaForm.optionsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _AnaForm.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _AnaForm.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _AnaForm.Pausebtn1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _AnaForm.Playbtn1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _AnaForm.progressBar1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            //myClass.radioButton1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            //myClass.radioButton2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _AnaForm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _AnaForm.Stopbtn1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _AnaForm.ta7it.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _AnaForm.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _AnaForm.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _OptionsForm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _OptionsForm.tableLayoutPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _OptionsForm.radiobtnDark.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _OptionsForm.radiobtnLight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            _OptionsForm.radiobtnMavi.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            //_OptionsForm3.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            //_OptionsForm3.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            //_OptionsForm3.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            //_OptionsForm3.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            //_OptionsForm3.BackColor = System.Drawing.SystemColors.ControlDarkDark;

        }

        public static void Lightmod19() //Method
        {
            //AsraMP asramp1 = new AsraMP(); // AsraMP is Form's name
            _AnaForm.BackColor = System.Drawing.SystemColors.Control;
            _AnaForm.anamenu.BackColor = System.Drawing.SystemColors.Control;
            _AnaForm.aboutASRAMPToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            _AnaForm.aboutToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            _AnaForm.anamenu.BackColor = System.Drawing.SystemColors.Control;
            _AnaForm.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            _AnaForm.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            _AnaForm.label1.BackColor = System.Drawing.SystemColors.Control;
            _AnaForm.label2.BackColor = System.Drawing.SystemColors.Control;
            //myClass.label3.BackColor = System.Drawing.SystemColors.Control;
            _AnaForm.listBoxSongs.BackColor = System.Drawing.SystemColors.Control;
            //myClass.MyWMP.BackColor = System.Drawing.SystemColors.Control;
            _AnaForm.Openbtn1.BackColor = System.Drawing.SystemColors.Control;
            _AnaForm.openToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            _AnaForm.optionsToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            _AnaForm.panel1.BackColor = System.Drawing.SystemColors.Control;
            _AnaForm.panel2.BackColor = System.Drawing.SystemColors.Control;
            _AnaForm.Pausebtn1.BackColor = System.Drawing.SystemColors.Control;
            _AnaForm.Playbtn1.BackColor = System.Drawing.SystemColors.Control;
            _AnaForm.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            //myClass.radioButton1.BackColor = System.Drawing.SystemColors.Control;
            //myClass.radioButton2.BackColor = System.Drawing.SystemColors.Control;
            _AnaForm.BackColor = System.Drawing.SystemColors.Control;
            _AnaForm.Stopbtn1.BackColor = System.Drawing.SystemColors.Control;
            _AnaForm.ta7it.BackColor = System.Drawing.SystemColors.Control;
            _AnaForm.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            _AnaForm.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
            _OptionsForm.BackColor = System.Drawing.SystemColors.Control;
            _OptionsForm.BackColor = System.Drawing.SystemColors.Control;
            _OptionsForm.tableLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            _OptionsForm.radiobtnDark.BackColor = System.Drawing.SystemColors.Control;
            _OptionsForm.radiobtnLight.BackColor = System.Drawing.SystemColors.Control;
            _OptionsForm.radiobtnMavi.BackColor = System.Drawing.SystemColors.Control;
            //    _OptionsForm3.label3.BackColor = System.Drawing.SystemColors.Control;
            //    _OptionsForm3.panel2.BackColor = System.Drawing.SystemColors.Control;
            //    _OptionsForm3.label1.BackColor = System.Drawing.SystemColors.Control;
            //    _OptionsForm3.label4.BackColor = System.Drawing.SystemColors.Control;
            //    _OptionsForm3.BackColor = System.Drawing.SystemColors.Control;
        } 

        public static void Mavimod19() //Method
        {
            //AsraMP asramp1 = new AsraMP(); // AsraMP is Form's name
            _AnaForm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _AnaForm.anamenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _AnaForm.aboutASRAMPToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _AnaForm.aboutToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _AnaForm.anamenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _AnaForm.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _AnaForm.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _AnaForm.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _AnaForm.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            //myClass.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _AnaForm.listBoxSongs.BackColor = System.Drawing.SystemColors.MenuHighlight;
            //myClass.MyWMP.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _AnaForm.Openbtn1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _AnaForm.openToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _AnaForm.optionsToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _AnaForm.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _AnaForm.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _AnaForm.Pausebtn1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _AnaForm.Playbtn1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _AnaForm.progressBar1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            //myClass.radioButton1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            //myClass.radioButton2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _AnaForm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _AnaForm.Stopbtn1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _AnaForm.ta7it.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _AnaForm.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _AnaForm.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _OptionsForm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _OptionsForm.tableLayoutPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _OptionsForm.radiobtnDark.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _OptionsForm.radiobtnLight.BackColor = System.Drawing.SystemColors.MenuHighlight;
            _OptionsForm.radiobtnMavi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            //_OptionsForm3.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            //_OptionsForm3.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            //_OptionsForm3.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            //_OptionsForm3.label4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            //_OptionsForm3.BackColor = System.Drawing.SystemColors.MenuHighlight;
        }

    }
}