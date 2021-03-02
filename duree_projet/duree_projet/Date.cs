using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duree_projet
{
    public class Date
    {
        public string Taches { get; set; }
        public string Descriptions { get; set; }
        public string Antecedents { get; set; }
        public string Durees { get; set; }
        public string Dates { get; set; }
        public string Marge_Libre { get; set; }

        public List<Date> RecupererDate(List<Fichier> reseau, DateTime debut, bool sam, bool dim)
        {

            List<Date> liste = new List<Date>();

            foreach (var r in reseau)
            {
                if (r.Dates - r.Durees == 0)
                {
                    var date = Date_Fin(Convert.ToInt32(r.Dates), sam, dim, debut);
                    var libre = Date_Fin(Convert.ToInt32(r.Dates - r.Marge_Libre), sam, dim, date);
                    liste.Add(new Date
                    {
                        Taches = r.Taches,
                        Antecedents = r.Antecedents,
                        Durees = debut.ToShortDateString(),
                        Dates = date.ToShortDateString(),
                        Marge_Libre = libre.ToShortDateString()
                    });
                }
                else
                {
                    int val = Convert.ToInt32(r.Dates - r.Durees);
                    var deb = Date_Fin(val, sam, dim, debut.AddDays(1));
                    var date = Date_Fin(Convert.ToInt32(r.Durees), sam, dim, deb);
                    var libre = Date_Fin(Convert.ToInt32(r.Marge_Libre), sam, dim, date);
                    liste.Add(new Date
                    {
                        Taches = r.Taches,
                        Antecedents = r.Antecedents,
                        Durees = deb.ToShortDateString(),
                        Dates = date.ToShortDateString(),
                        Marge_Libre = libre.ToShortDateString()
                    });
                }
            }
            return liste;
        }

        private DateTime Date_Fin(int max, bool same, bool dima, DateTime debut)
        {
            DayOfWeek dim = new DayOfWeek();
            DayOfWeek sam = new DayOfWeek();

            dim = DayOfWeek.Sunday;
            sam = DayOfWeek.Saturday;
            int nbr = 0;
            while (nbr < max)
            {
                if ( (same && debut.DayOfWeek == sam) || (dima && debut.DayOfWeek == dim))
                {
                    debut = debut.AddDays(1);
                }
                else
                {
                    nbr++;
                    if (nbr == max)
                    {
                        break;
                    }
                    else
                    {
                        debut = debut.AddDays(1);
                    }
                }

            }
            return debut;
        }

        public List<Date> ListeDate(List<Date> fichier)
        {
            List<Date> listeDate = new List<Date>();
            
            listeDate.Add(new Date
            {
                Durees = Convert.ToString(fichier.First().Durees),
                Taches = fichier.First().Taches
            });
            foreach (var l in fichier)
            {
                var tmp = listeDate.Exists(x => Convert.ToDateTime(x.Durees) == Convert.ToDateTime(l.Durees));
                if (tmp == false)
                {
                    listeDate.Add(new Date
                    {
                        Durees = Convert.ToString(l.Durees),
                        Taches = l.Taches
                    });
                }
            }
            foreach (var l in fichier)
            {
                var tmp = listeDate.Exists(x => Convert.ToDateTime(x.Durees) == Convert.ToDateTime(l.Dates));
                if (tmp == false)
                {
                    listeDate.Add(new Date
                    {
                        Durees = Convert.ToString(l.Dates),
                        Taches = l.Taches
                    });
                }

            }
            foreach (var l in fichier)
            {
                var tmp = listeDate.Exists(x => Convert.ToDateTime(x.Durees) == Convert.ToDateTime(l.Marge_Libre));
                if (tmp == false)
                {
                    listeDate.Add(new Date
                    {
                        Durees = Convert.ToString(l.Marge_Libre),
                        Taches = l.Taches
                    });
                }
            }
            return listeDate.OrderBy(x=>Convert.ToDateTime(x.Durees)).ToList();
        }
        


    }
}
