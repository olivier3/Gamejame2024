using System.Collections.Generic;
using UnityEngine;

public class StoryText : MonoBehaviour
{
    public Dictionary<string, string> texts = new()
    {
        // Pour cette scene, l'�preuve est de chercher a sonner la cloche plusieurs fois. Les indices permettent d'indiquer au joueurs le nombre de fois qu'il doit sonner
        // Pour cette enigme, il faut qu'une pleine lune soit visible quelque part dans le niveau, afin de pieger le joueur a ne sonner que 2 fois.
        {"Livre1_1", "� l'aube de la troisi�me journ�e, trois cavaliers provenant de la cit� des trois lunes arriv�rent. Chacun offrit une offrande � notre ma�tre v�n�r�. Nous r�p�tons ces offrandes par trois coups de cloches successifs." },
        {"Livre1_2", "Malheureusement, le guerrier de la pleine lune trahit la volont� de notre ma�tre. Ainsi, un coup de moins retentira les soirs de lunes rondes." },

        // Dans cette scene, le joueur devrait trouver quoi sacrifier au grand gourou. Les indices permettent de trouver quoi sacrifier
        {"Livre2", "TODO" },
        {"Discussion1_1", "TODO" },
        {"Discussion1_2", "TODO" },
        {"Discussion1_3", "TODO" },

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
        {"PassRoom2", "Ouiiii, c'est la bonne r�ponse! Peut �tre ?" },
        {"PostIt1", "Certains mots sont effac�s, mais on peut distinguer les mots \"Oub ie  as,  e  o  de  a se est :  ar on  \"" },
        {"PostIt2", "BOB ! On m'a apprie que tu as 'ENCORE' oubli� le mot de passe.... ca rime avec 'AEROPHAGIE'" },


        // Scene de la clef
        {"KeyRoom1", "TODO" },
        {"KeyRoom2", "TODO" },
        {"Livre4_1", "TODO" },
        {"Livre4_2", "TODO" },
        {"Livre4_3", "TODO" },
        {"Livre4_4", "TODO" },

        // Scene finale, qui va d�finir si nos choix sont bon.
        {"ManqueSacrifice", "TODO" },
        {"ManqueCloche", "TODO" },
        {"ManquePriere", "TODO" },
        {"ManqueLampions", "TODO" },
        {"FinLampions", "TODO" },
        {"FinCloche", "TODO" },
        {"FinSacrifice", "TODO" },
        {"FinPriere", "TODO" },
        {"BonneFin", "TODO" },

        // Textes g�n�riques
        {"NouvellePartie", "TODO" },

    };

    public string GetRandomName()
    {
        return nomAl�atoire[Random.Range(0, nomAl�atoire.Count)];
    }

    private List<string> nomAl�atoire = new()
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
        "Aur�le",
        "Aurelien",
        "Baptiste",
        "Bastien",
        "Benoit",
        "Blaise",
        "Brice",
        "C�lestin",
        "Cesaire",
        "Charlot",
        "Christophe",
        "Cl�ment",
        "Colombain",
        "Corin",
        "Damien",
        "D�sir�",
        "Didier",
        "Edgard",
        "Edmond",
        "Edouard",
        "Emile",
        "Emilien",
        "Etienne",
        "Eug�ne",
        "Eustache",
        "Fabien",
        "Fabrice",
        "Felicien",
        "F�lix",
        "Fernand",
        "Fiacre",
        "Firmin",
        "Florentin",
        "Franck",
        "Francois",
        "Fr�d�ric",
        "Ga�tan",
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
        "Herv�",
        "Ignace",
        "Jacques",
        "Jean",
        "Jean-Baptiste",
        "Jean-Marie",
        "J�r�mie",
        "Julien",
        "Juste",
        "Laurent",
        "L�on",
        "L�onard",
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
        "Rapha�l",
        "R�gis",
        "R�mi",
        "Renaud",
        "Rodolphe",
        "Rodrigue",
        "Romain",
        "S�bastien",
        "Serge",
        "Sylvain",
        "Thibault",
        "Thierry",
        "Yves",
        "Zacharie",
    };


}
