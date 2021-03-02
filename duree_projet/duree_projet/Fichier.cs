using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace duree_projet
{
    public class Fichier
    {
        public string Taches { get; set; }
        public string Descriptions { get; set; }
        public string Antecedents { get; set; }
        public double Durees { get; set; }
        public double Dates { get; set; }
        public double Date_Plus_Tard { get; set; }
        public double Marge_Total { get; set; }
        public double Marge_Libre { get; set; }

        public List<Fichier> Recuperer(string csv)
        {
            List<Fichier> liste = new List<Fichier>();
            Pert pert = new Pert();
            List<Pert> liste_tache = Liste_Tache(csv);
            List<Pert> details = Details(liste_tache);
            List<Pert> date = pert.Calcul_Date(details);
            List<Pert> plus_tard = pert.Calcul_Date_Au_Plus_Tard(details, date);
            List<Pert> total = pert.Calcul_Marge_total(details, plus_tard, date);
            List<Pert> libre = pert.Calcul_Marge_Libre(details, date, total, plus_tard);
            foreach (var lt in liste_tache)
            {
                var dt = date.First(x => x.Taches == lt.Taches).Durees;
                var pt = plus_tard.First(x => x.Taches == lt.Taches).Durees;
                var t = total.First(x => x.Taches == lt.Taches).Durees;
                var l = libre.First(x => x.Taches == lt.Taches).Durees;
                liste.Add(new Fichier
                {
                    Taches = lt.Taches,
                    Descriptions = lt.Nom_Taches,
                    Durees = lt.Durees,
                    Antecedents = lt.Antecedents,
                    Dates = dt,
                    Date_Plus_Tard = pt,
                    Marge_Total = t,
                    Marge_Libre = l
                });
            }

            return liste;
        }

        public List<Pert> Liste_Tache(string csv)
        {
            List<Pert> liste = new List<Pert>();
            List<Pert> lst = new List<Pert>();
            StreamReader sr = new StreamReader(csv);
            string texte = sr.ReadLine();
            string[] split = texte.Split(';');

            while ((texte = sr.ReadLine()) != null)
            {
                split = texte.Split(';');

                liste.Add(new Pert
                {
                    Taches = split[0].ToString(),
                    Antecedents = split[3].ToString(),
                    Durees = Convert.ToInt32(split[2]),
                    Nom_Taches = split[1]
                });
            }
            sr.Close();

            return liste;
        }

        public List<Pert> Details(List<Pert> liste)
        {
            List<Pert> lst = new List<Pert>();
            string[] split;
            foreach (var l in liste)
            {
                if (l.Antecedents.Contains(","))
                {
                    split = l.Antecedents.Split(',');
                    for (int i = 0; i < split.Count(); i++)
                    {
                        lst.Add(new Pert
                        {
                            Taches = l.Taches,
                            Antecedents = split[i],
                            Durees = l.Durees,
                            Nom_Taches = l.Nom_Taches
                        });
                    }
                }
                else
                {
                    lst.Add(new Pert
                    {
                        Taches = l.Taches,
                        Antecedents = l.Antecedents,
                        Durees = l.Durees,
                        Nom_Taches = l.Nom_Taches
                    });
                }
            }
            return lst;
        }


        

    }
}
