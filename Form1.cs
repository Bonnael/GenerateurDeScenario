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
            // Récupération du style sélectionné
            string style = cbStyle.SelectedItem?.ToString() ?? "Classique";

            // Initialisation des listes
            string[] typesPerso, traitsPerso, objectifs, lieux, antagonistes;

            switch (style)
            {
                case "Absurde":
                    typesPerso = new[] { "un grille-pain", "une chaussette", "un lama", "un cactus", "un nuage", "un dauphin", "une mouette", "un poney", "une fourchette", "une ampoule", "un papillon géant", "un chewing-gum conscient" };
                    traitsPerso = new[] { "bavard", "magique", "schizophrène", "explosif", "invisible", "kleptomane", "addict aux cookies", "télépathique", "superstitieux", "paranoïaque", "fluorescent", "immortel le mardi seulement" };
                    objectifs = new[] { "doit voler la tour Eiffel", "cherche le slip du destin", "tente d’ouvrir une boîte de conserve", "doit survivre à un concours de claquettes", "cherche à repeindre l’univers", "veut ressusciter un yaourt", "essaie de créer un nuage de pop-corn" };
                    lieux = new[] { "dans un frigo dimensionnel", "sur la lune en fromage", "au fond d’un pot de confiture", "dans une station spatiale IKEA", "dans un rêve collectif de l'humanité", "au beau milieu d’un champ de bananes parlantes" };
                    antagonistes = new[] { "face à une armée de bananes zombies", "contre un chat géant sarcastique", "traqué par un grille-pain dépressif", "opposé à un dieu paresseux", "poursuivi par un poulpe politicien" };
                    break;

                case "Thriller":
                    typesPerso = new[] { "un détective", "un journaliste", "un flic", "une hackeuse", "un prisonnier", "un espion", "un étudiant", "une psychiatre", "un avocat", "un médecin légiste" };
                    traitsPerso = new[] { "alcoolique", "traumatisé", "manipulateur", "paranoïaque", "sous couverture", "brillant mais instable", "solitaire", "obsédé par la vérité", "dépendant", "endurci par la guerre" };
                    objectifs = new[] { "doit percer un complot", "cherche un tueur invisible", "veut venger sa famille", "tente d’échapper à la vérité", "traque une société secrète", "cherche à effacer son passé", "doit protéger un témoin clé" };
                    lieux = new[] { "dans une ville corrompue", "dans une station de métro déserte", "dans un hôpital abandonné", "dans un manoir isolé", "au sommet d’un gratte-ciel", "dans un bunker militaire" };
                    antagonistes = new[] { "face à un tueur méthodique", "contre une IA incontrôlable", "traqué par un flic corrompu", "confronté à un passé enfoui", "poursuivi par un double psychotique" };
                    break;

                case "Fantastique":
                    typesPerso = new[] { "un elfe", "un magicien", "une guerrière", "un nécromancien", "une sirène", "un golem", "un druide", "un orc repenti", "un ange déchu", "une sorcière adolescente" };
                    traitsPerso = new[] { "rebelle", "exilé", "banni", "amnésique", "maudit", "possédé", "lié à un ancien dieu", "orphelin", "trop puissant pour son bien", "guidé par des visions" };
                    objectifs = new[] { "doit retrouver un artefact", "cherche à briser une malédiction", "doit sauver le royaume", "tente de contrôler ses pouvoirs", "doit empêcher l’éveil d’un démon", "cherche la cité perdue" };
                    lieux = new[] { "dans une forêt enchantée", "au sommet d’une montagne maudite", "dans un temple oublié", "au cœur d’un royaume en guerre", "dans une faille dimensionnelle", "dans une tour millénaire" };
                    antagonistes = new[] { "face à un roi démoniaque", "contre un ancien mentor devenu fou", "traqué par un esprit vengeur", "poursuivi par une armée spectrale", "confronté à un dragon ancestral" };
                    break;

                case "SF":
                    typesPerso = new[] { "un pilote de vaisseau", "une androïde", "un hacker", "une commandante", "un alien", "un scientifique fou", "une mercenaire", "un robot libre", "un clone", "un capitaine de station orbitale" };
                    traitsPerso = new[] { "rebelle", "cybernétique", "modifié génétiquement", "traqué", "programmé pour tuer", "déconnecté de l’humanité", "fugitif", "télépathe", "empathique", "irrationnel" };
                    objectifs = new[] { "doit empêcher l’extinction de la galaxie", "cherche la vérité sur sa création", "doit infiltrer une base ennemie", "veut retrouver son monde natal", "doit pirater un vaisseau-mère", "cherche à détruire une intelligence artificielle" };
                    lieux = new[] { "dans une station spatiale", "sur une planète désertique", "dans une ville flottante", "au cœur d’un trou noir", "dans une dimension alternative", "au bord d’une guerre interstellaire" };
                    antagonistes = new[] { "face à une IA rebelle", "contre un gouvernement totalitaire", "poursuivi par des chasseurs de primes", "confronté à une rébellion de clones", "traqué par un parasite alien" };
                    break;

                default: // CLASSIQUE
                    typesPerso = new[] { "un détective", "une professeure", "un soldat", "un adolescent", "une infirmière", "un pilote", "un écrivain", "un scientifique", "un agent secret", "un photographe", "un avocat", "une psychologue" };
                    traitsPerso = new[] { "fatigué", "alcoolique", "idéaliste", "paranoïaque", "obsédé par la vérité", "brisé par le passé", "trop curieux", "loyal jusqu’à l’absurde", "traumatisé", "pragmatique", "désabusé", "revenant de guerre" };
                    objectifs = new[] { "doit sauver la ville", "cherche à élucider un mystère", "tente de fuir son passé", "veut prouver son innocence", "doit protéger un secret", "cherche à empêcher une catastrophe", "veut retrouver une personne disparue" };
                    lieux = new[] { "dans une grande métropole", "au cœur d’un désert", "dans un train de nuit", "sur un navire en pleine mer", "dans une université abandonnée", "au sein d’une petite ville isolée", "dans une banlieue tranquille" };
                    antagonistes = new[] { "face à un tueur masqué", "contre un ancien mentor", "traqué par la police", "confronté à une secte", "poursuivi par une ombre du passé" };
                    break;
            }

            // Génération aléatoire
            Random rnd = new Random();
            string personnage = typesPerso[rnd.Next(typesPerso.Length)];
            string trait = traitsPerso[rnd.Next(traitsPerso.Length)];
            string objectif = objectifs[rnd.Next(objectifs.Length)];
            string lieu = lieux[rnd.Next(lieux.Length)];
            string antagoniste = antagonistes[rnd.Next(antagonistes.Length)];

            // Construction du scénario
            string scenario = $" {personnage} {trait} {objectif} {lieu}, {antagoniste}.";

            // Affichage
            rtbScenario.Text = scenario;

        }

        private void btnCopier_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtbScenario.Text))
            {
                Clipboard.SetText(rtbScenario.Text);
                MessageBox.Show("Scénario copié dans le presse-papiers !", "Copié", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Aucun scénario à copier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
