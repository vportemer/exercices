using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace link// renommer l'espace de nom selon le nom du projet
{
    public class AnalyseurLINQ
    {
        private List<DonnéesMois> _data;
        public List<DonnéesMois> Data
        {
            get { return _data; }
        }

        public AnalyseurLINQ()
        {
            _data = new List<DonnéesMois>();
        }

        public void ChargerDonnées()
        {
            string chemin = @"..\..\DonnéesMétéoParis.txt";

            int cpt = 0;
            using (StreamReader str = new StreamReader(chemin))
            {
                string ligne;

                while ((ligne = str.ReadLine()) != null)
                {
                    cpt++;
                    if (cpt == 1) continue; // On n'analyse pas la première ligne car elle contient les en-têtes

                    var tab = ligne.Split('\t');
                    try
                    {
                        var donnéesMois = new DonnéesMois
                        {
                            Mois = DateTime.Parse(tab[0]),
                            TMin = double.Parse(tab[1]),
                            TMax = double.Parse(tab[2]),
                            Précipitations = double.Parse(tab[3]),
                            Ensoleillement = double.Parse(tab[4])
                        };

                        // Ajout des données du mois à la liste
                        Data.Add(donnéesMois);
                    }
                    catch (FormatException)
                    {
                        // On ignore simplement la ligne
                        Console.WriteLine("Erreur de format à la ligne suivante :\r\n{0}", ligne);
                    }

                }

            }
            //    public IEnumerator GetEnumerator()
            //{
            //    throw new NotImplementedException();
            //}
        }

        public void AfficherStats()
        {
            // mois de la température min la plus basse, Il faut récupéré la temp min de ts les mois

            var res1 = Data.Where(m => m.TMin == Data.Min(t => t.TMin)).First();   //et on récupére le mois correspondant à la t t min ==température min du tableau
                                                                                   // le point fist veut dire qu'il en prend juste le premier s'il y a plusieurs mois avec deux tmin


            // Sommes des précipitations de l'année 2016

            var res2 = Data.Where(q => q.Mois.Year == 2016).Sum(p => p.Précipitations);

            // Durée d'ensoleillement moyenne du mois de Juillet sur toutes les années
            var res3 = Data.Where(q => q.Mois.Month == 07).Average(e => e.Ensoleillement);

            // Précipitations moyennes par année

            var annee = Data.Select(w => w.Mois.Year).Distinct();
            foreach (var a in annee)
            {
                var res4 = Data.Where(q => q.Mois.Year == a).Average(p => p.Précipitations);
            }

        }


    }

    /// <summary>
    /// Classe contenant les données d'un mois de relevé météo
    /// </summary>
    public class DonnéesMois
    {
        public DateTime Mois { get; set; }
        public double TMin { get; set; }
        public double TMax { get; set; }
        public double Précipitations { get; set; }
        public double Ensoleillement { get; set; }
    }
}
