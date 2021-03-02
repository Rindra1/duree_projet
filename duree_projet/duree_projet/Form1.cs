using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace duree_projet
{
    public partial class Form1 : Form
    {
        private Graphics graphic;
        private List<Fichier> liste;
        private List<Date> date;

        private Date dp;
        
        public Form1()
        {
            InitializeComponent();
            graphic = pictureBox1.CreateGraphics();
            CenterToScreen();
            
        }

        private void peindre(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void bt_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_calculer_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            dp = new Date();
            date = dp.RecupererDate(liste, Convert.ToDateTime(txt_date.Text), chk_samedi.Checked, chk_dimanche.Checked);
            Graphique g = new Graphique();
            g.date = date;
            g.fichier = liste;
            g.longueurX = 850;
            g.longueurY = 550;
            g.graphic = graphic;
            g.TracerY();
            g.TracerX();
            g.tracerCourbe();
        }

        private void bt_fichier_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Filter = "Fichier csv|*.csv";
            openFileDialog1.Title = "Fichier csv";
            openFileDialog1.FileName = "";
            DialogResult res;
            if ((res = openFileDialog1.ShowDialog()) == DialogResult.OK)
            {
                Fichier fichier = new Fichier();
                liste = fichier.Recuperer(openFileDialog1.FileName);
            }
        }

    }
}
