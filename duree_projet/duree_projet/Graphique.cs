using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace duree_projet
{
    public class Graphique
    {
        private Form f = new Form();
        public List<Date> date { get; set; }
        public List<Fichier> fichier { get; set; }
        public int longueurX { get; set; }
        public int longueurY { get; set; }
        public Graphics graphic { get; set; }
        
        public void TracerY()
        {
            int y = longueurY - 50;
            Point p0 = new Point(50, 50);
            Point p1 = new Point(50, longueurY);
            graphic.DrawLine(Pens.Black, p0, p1);

            int distanceEntreDeuxY = y / fichier.Count;
            int distance = longueurY;
            foreach (var axeY in fichier)
            {
                distance -= distanceEntreDeuxY;
                p0 = new Point(50, distance);
                p1 = new Point(45, distance);
                graphic.DrawLine(Pens.Black, p0, p1);
                p0 = new Point(25, distance - 5);
                graphic.DrawString(axeY.Taches, f.Font, Brushes.Black, p0);
            }
        }

        public void TracerX()
        {
            Point p0 = new Point(50, longueurY);
            Point p1 = new Point(longueurX - 50 , longueurY);
            graphic.DrawLine(Pens.Black, p0, p1);

            var trieListe = fichier.OrderBy(x => x.Dates).ToList();
            int nbrTemps = 750 / (Convert.ToInt32(fichier.Max(x => x.Dates))+1);
            List<Fichier> listeTemp = new List<Fichier>();
            int distance = 50;
            bool emplacement = true;
            int emplacementDate = 560;

            foreach (var dates in trieListe)
            {
                var test = listeTemp.Exists(x => x.Dates == dates.Dates);
                if (!test)
                {
                    listeTemp.Add(new Fichier
                    {
                        Dates = dates.Dates
                    });
                    if (emplacement)
                    {
                        emplacementDate = 560;
                        emplacement = false;
                    }
                    else
                    {
                        emplacementDate = 570;
                        emplacement = true;
                    }
                    distance = 50 + (nbrTemps * (Convert.ToInt32(dates.Dates)));
                    Point x0 = new Point(distance, 550);
                    Point x1 = new Point(distance, 555);
                    graphic.DrawLine(Pens.Black, x0, x1);
                    graphic.DrawString(date.First(x => x.Taches == dates.Taches).Dates, f.Font, Brushes.Black, new Point(distance - 25, emplacementDate));
                }
            }
        }

        public void tracerCourbe()
        {
            
            Pen critique = new Pen(Color.Red, 10);
            Pen normal = new Pen(Color.BlueViolet, 10);
            Pen marge_libre = new Pen(Color.Bisque, 10);
           
            int distanceEntreDeuxY = (longueurY - 50 ) / (fichier.Count);
            int _y = longueurY - distanceEntreDeuxY;
            int _x = longueurX - 50;
            int distance = 50;
            int nbrTemps = 750 / (Convert.ToInt32(fichier.Max(x => x.Dates))+1);
            List<Fichier> f = fichier.OrderBy(w => w.Taches).ToList();
            foreach (var courbe in f)
            {
                Point p0 = new Point(distance + ((Convert.ToInt32(courbe.Dates)) * nbrTemps), _y);
                Point p1 = new Point(distance + (Convert.ToInt32(courbe.Dates)-Convert.ToInt32(courbe.Durees)) * nbrTemps, _y);
                if(courbe.Marge_Total==0)
                    graphic.DrawLine(critique, p0, p1);
                else
                    graphic.DrawLine(normal, p0, p1);

                if (courbe.Marge_Libre != 0)
                {
                    p1 = new Point(distance + (Convert.ToInt32(courbe.Dates) + Convert.ToInt32(courbe.Marge_Libre)) * nbrTemps, _y);
                    graphic.DrawLine(marge_libre, p1, p0);
                }

                _y -= distanceEntreDeuxY;
            }
        }
        

    }
}
