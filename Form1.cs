using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateurDeScenario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerer_Click(object sender, EventArgs e)
        {
            // Listes d’éléments pour la génération
            string[] personnages = { "Un détective alcoolique", "Une archéologue rebelle", "Un alien végétarien", "Un hacker de 12 ans", "Un dragon introverti" };
            string[] objectifs = { "doit sauver la ville", "cherche sa véritable identité", "tente de gagner un concours de danse", "prévoit de voler la lune", "doit éviter une guerre mondiale" };
            string[] lieux = { "dans un monde post-apocalyptique", "dans une école pour monstres", "dans un cybercafé abandonné", "dans un royaume sous-marin", "sur une île volante" };
            string[] antagonistes = { "face à un robot psychopathe", "traqué par ses propres souvenirs", "contre une secte millénaire", "opposé à un bébé démoniaque", "poursuivi par un double maléfique" };

            // Génération aléatoire
            Random rnd = new Random();
            string p = personnages[rnd.Next(personnages.Length)];
            string o = objectifs[rnd.Next(objectifs.Length)];
            string l = lieux[rnd.Next(lieux.Length)];
            string a = antagonistes[rnd.Next(antagonistes.Length)];

            // Construction du scénario
            string scenario = $"{p} {o} {l}, {a}.";

            // Affichage
            rtbScenario.Text = scenario;
        
    }
    }
}
