using System.Collections.Generic;
using UnityEngine;

public class StoryText : MonoBehaviour
{
    public Dictionary<string, string> texts = new()
    {
        // Pour cette scene, l'épreuve est de chercher a sonner la cloche plusieurs fois. Les indices permettent d'indiquer au joueurs le nombre de fois qu'il doit sonner
        // Pour cette enigme, il faut qu'une pleine lune soit visible quelque part dans le niveau, afin de pieger le joueur a ne sonner que 2 fois.
        {"Livre1_1", "A l'aube de la troisième journée, trois cavaliers provenant de la cité des trois lunes arrivèrent. Chacun offrit une offrande à notre maître vénéré. Nous répétons ces offrandes par trois coups de cloches successifs." },
        {"Livre1_2", "Malheureusement, le guerrier de la pleine lune trahit la volonté de notre maître. Ainsi, un coup de moins retentira les soirs de lunes rondes." },

        // Dans cette scene, le joueur devrait trouver quoi sacrifier au grand gourou. Les indices permettent de trouver quoi sacrifier
        {"Livre2", "Un sacrifice sacré, une offrande vénérée, a notre grand maître, devra être donnée." },
        {"Discussion1_1", "Je me demande ce que je vais faire a cuisiner a notre maître vénéré ce soir, aurais-tu une idée ?" },
        {"Discussion1_2", "Hmmmm..... je verrais bien un BON GROS STEAK ! N'est-ce pas une bonne idée." },
        {"Discussion1_3", "Es-tu fou ? Notre grand maître est végétarien, il ne faudrait pas attiser sa colère." },

        // Dans cette scene, le joueur doit effectuer la bonne priere. Des dessins ou des artworks sur les murs pour trouver comment prier
        {"PriereChoix1", "TODO" },
        {"PriereChoix2", "TODO" },
        {"PriereChoix3", "TODO" },

        // Scene des lampions, le joueur va devoir allumer certains lampions.
        {"Lampions1", "TODO" },
        {"Livre3", "TODO" },

        // Scene du mot de passe, la r�ponse est visible dans une autre salle, le message sera cod�
        {"PassRoom1", "Quel est le premier enseignement de notre grand ma�tre ?" },
        {"PassChoix1", "Harmonie" },
        {"PassChoix2", "Barbie" },
        {"PassChoix3", "Pamplemousse" },
        {"PassChoix4", "Charbonnier" },
        {"PassRoom2", "Ouiiii, c'est la bonne réponse! Peut être ?" },
        {"PostIt1", "Certains mots sont effac�s, mais on peut distinguer les mots \"Oub ie  as, l'ense gn me t est :  ar on  \"" },
        {"PostIt2", "BOB ! On m'a apprie que tu as 'ENCORE' oublié le mot de passe.... ca rime avec 'AEROPHAGIE'" },


        // Scene de la clef
        {"KeyRoom1", "Hey te voilà le nouveau ! Tiens, voilà ta clef personnelle. Fais en bon usage !" },
        {"KeyRoom2", "Nouvel objet obtenu : Clef personnelle. \n Vos initiales sont gravées dessus." },
        {"KeyRoom3", "Vous avez utilisé la clef sur le vieux coffre. \n Nouvel objet obtenu: gros mottons de poussière." },
        {"Livre4_1", "Dans l'ombre du culte, le pouvoir de la clé est loué,\nMais ne sois pas esclave de son éclat doré." },
        {"Livre4_2", "Car derrière chaque serrure, un destin est brodé,\nEt l'imprudence peut t'égarer dans l'obscurité." },

        // Scene finale, qui va définir si nos choix sont bon.
        {"ManqueSacrifice", "TODO" },
        {"ManqueCloche", "TODO" },
        {"ManquePriere", "TODO" },
        {"ManqueLampions", "TODO" },
        {"FinLampions", "TODO" },
        {"FinCloche", "TODO" },
        {"FinSacrifice", "TODO" },
        {"FinPriere", "TODO" },
        {"BonneFin", "TODO" },

        // Textes génériques
        {"NouvellePartie", "Vous êtes une nouvelle recrue de la secte du Culte de l'Acier, a vous de trouver un moyen de vous élever." },

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
        "Aim�",
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
