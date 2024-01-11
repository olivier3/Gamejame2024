using System.Collections.Generic;
using UnityEngine;

public class StoryText : MonoBehaviour
{
    public Dictionary<string, string> texts = new()
    {
        // Pour cette scene, l'épreuve est de chercher a sonner la cloche plusieurs fois. Les indices permettent d'indiquer au joueurs le nombre de fois qu'il doit sonner
        // Pour cette enigme, il faut qu'une pleine lune soit visible quelque part dans le niveau, afin de pieger le joueur a ne sonner que 2 fois.
        {"Livre1_1", "A l'aube de la troisième journée, trois cavaliers provenant de la cité des trois lunes arrivèrent. " +
            "Chacun offrit une offrande à notre maître vénéré. Nous répétons ces offrandes par trois coups de cloches successifs." },
        {"Livre1_2", "Malheureusement, le guerrier de la pleine lune trahit la volonté de notre maître. Ainsi, un coup de moins retentira les soirs de lunes rondes." },

        // Dans cette scene, le joueur devrait trouver quoi sacrifier au grand gourou. Les indices permettent de trouver quoi sacrifier
        {"Livre2", "Un sacrifice sacré, une offrande vénérée, a notre grand maître, devra être donnée." },
        {"Sacrifice1", "Voulez-vous sacrifier cette tête de Mickey ?" },
        {"Sacrifice2", "Voulez-vous sacrifier cette poupée ?" },
        {"Sacrifice3", "Voulez-vous sacrifier ce Brocolli !?" },
        {"Sacrifice4", "Voulez-vous sacrifier cette pauvre chèvre ?" },
        {"Discussion1_1", "Je me demande ce que je vais faire a cuisiner a notre maître vénéré ce soir, aurais-tu une idée ?" },
        {"Discussion1_2", "Hmmmm..... je verrais bien un BON GROS STEAK ! N'est-ce pas une bonne idée." },
        {"Discussion1_3", "Es-tu fou ? Notre grand maître est végétarien, il ne faudrait pas attiser sa colère." },

        // Dans cette scene, le joueur doit effectuer la bonne priere. Des dessins ou des artworks sur les murs pour trouver comment prier
        {"PriereChoix1", "Voulez-vous effectuer une danse nuptiale ?" },
        {"PriereChoix2", "Voulez-vous rester immobile dans l'ombre ?" },
        {"PriereChoix3", "Voulez-vous vous assoir pour méditer ?" },

        // Scene des lampions, le joueur va devoir allumer certains lampions.
        {"Lampions1", "J'ai besoin d'aide pour allumer ces chandelles. Je ne me souviens plus lesquelles je dois allumer." },
        {"Livre3", "Au début de la 8eme journée, notre maître regarda au nord, et ne vis que désolation. Au sud, désespoir." +
            " Ici, terreur. Seul la terre de l'Ouest et celle de l'Est furent choisies pour établir ses saints préceptes." },

        // Scene du mot de passe, la r�ponse est visible dans une autre salle, le message sera codé
        {"PassRoom1", "Quel est le premier enseignement de notre grand maître ?" },
        {"PassChoix1", "Harmonie" },
        {"PassChoix2", "Barbie" },
        {"PassChoix3", "Pamplemousse" },
        {"PassChoix4", "Charbonnier" },
        {"PassRoom2", "Ouiiii, c'est la bonne réponse! Peut être ?" },
        {"PostIt1", "Certains mots sont effacés, mais on peut distinguer certaines lettres \"Oub ie  as, l'ense gn me t est :  ar on  \"" },
        {"PostIt2", "BOB ! On m'a apprie que tu as 'ENCORE' oublié l'enseignement.... ca rime avec 'AEROPHAGIE'" },


        // Scene de la clef
        {"KeyRoom1", "Hey te voilà le nouveau ! Tiens, voilà ta clef personnelle. Fais en bon usage !" },
        {"KeyRoom2", "Nouvel objet obtenu : Clef personnelle. \n Vos initiales sont gravées dessus." },
        {"KeyRoom3", "Vous avez utilisé la clef sur le vieux coffre. \n Nouvel objet obtenu: Gros cristal brillant." },
        {"Livre4_1", "Dans l'ombre du culte, le pouvoir de la clé est loué,\nMais ne sois pas esclave de son éclat doré." },
        {"Livre4_2", "Car derrière chaque serrure, un destin est brodé,\nEt l'imprudence peut t'égarer dans l'obscurité." },

        // Scene finale, qui va définir si nos choix sont bon.
        // Les "manque" représentent si l'action n'a pas été faite.
        {"ManqueSacrifice", "\"Un sacrifice pour son maître\", pourquoi n'ai-je rien recu ?" },
        {"ManqueCloche", "\"Un son de cloche pour son maître\", je n'ai rien entendu !" },
        {"ManquePriere", "\"Une priere pour son maître\", je n'ai pas entendu m'implorer ?" },
        {"ManqueLampions", "\"Un guide pour son maître\", je ne connais pas le chemin." },
        {"ManqueClef", "\"Un artéfact sacré\", qui êtes vous ?" },
        {"ManquePass", "\"Un enseignement pour les aligner tous\", je ne l'ai pas entendu" },

        // Les "Fin" représentent si l'action a été mal faite
        {"FinLampions", "Les lumières sacrées ne correspondent pas a nos préceptes" },
        {"FinCloche", "La cloche n'a pas sonnée le nombre correcte de fois." },
        {"FinSacrifice", "Que m'avez vous donné en sacrifice ? Sauvage !" },
        {"FinPriere", "La prière est très importante pour moi, comment OSEZ VOUS vous moquer ainsi ?" },
        {"FinPass", "Je n'ai qu'un enseignement, et vous avez été capable de vous tromper ? Vous vous moquez de moi ?" },
        {"FinClef", "Avez vous votre artéfact ? NON ? Vous aviez UN JOB !" },

        {"BonneFin", "Vous êtes définitivement un grand réprésentant de notre ordre. Félicitation !" },

        // Textes génériques
        {"NouvellePartie", "Vous êtes une nouvelle recrue de la secte du Culte de l'Acier, a vous de trouver un moyen de vous élever." },
        {"FinDePartie", "Le grand gourou a a détécté l'imposture.\n Fin de partie" },
        // Je les met pour de la généricité. Si on met de l'anglais, ca va faciliter la chose
        {"Oui", "Oui" },
        {"Non", "Non" },
    };

    public string GetRandomName()
    {
        return nomAleatoire[Random.Range(0, nomAleatoire.Count)];
    }

    private List<string> nomAleatoire = new()
    {
        "Absolon",
        "Adolphe",
        "Adrien",
        "Aimé",
        "Alain",
        "Alphonse",
        "Amaury",
        "Ambroise",
        "Anatole",
        "Anselme",
        "Antoine",
        "Apollinaire",
        "Aristide",
        "Armand",
        "Armel",
        "Arnaud",
        "Auguste",
        "Augustin",
        "Aurelien",
        "Baptiste",
        "Bastien",
        "Benoit",
        "Blaise",
        "Brice",
        "Célestin",
        "Cesaire",
        "Charlot",
        "Christophe",
        "Clément",
        "Colombain",
        "Corin",
        "Damien",
        "Didier",
        "Edgard",
        "Edmond",
        "Edouard",
        "Emile",
        "Emilien",
        "Etienne",
        "Eugène",
        "Eustache",
        "Fabien",
        "Fabrice",
        "Felicien",
        "Félix",
        "Fernand",
        "Fiacre",
        "Firmin",
        "Florentin",
        "Franck",
        "Francois",
        "Frédéric",
        "Gaspard",
        "Gaston",
        "Gautier",
        "Georges",
        "Germain",
        "Gervais",
        "Ghislain",
        "Gilles",
        "Gratien",
        "Gr�goire",
        "Guillaume",
        "Gustave",
        "Henri",
        "Hercule",
        "Hervé",
        "Ignace",
        "Jacques",
        "Jean",
        "Jean-Baptiste",
        "Jean-Marie",
        "Jérémie",
        "Julien",
        "Juste",
        "Laurent",
        "Léon",
        "Léonard",
        "Lionel",
        "Luc",
        "Lucien",
        "Marc",
        "Mathieu",
        "Maxime",
        "Modeste",
        "Nicolas",
        "Olivier",
        "Papillion",
        "Pascal",
        "Patrice",
        "Perceval",
        "Philippe",
        "Pierre",
        "Raphael",
        "Régis",
        "Rémi",
        "Renaud",
        "Rodolphe",
        "Rodrigue",
        "Romain",
        "Sébastien",
        "Serge",
        "Sylvain",
        "Thibault",
        "Thierry",
        "Yves",
        "Zacharie",
    };


}
