using System.Collections.Generic;
using UnityEngine;

public class StoryText : MonoBehaviour
{
    public Dictionary<string, string> texts = new()
    {
        // Pour cette scene, l'Èpreuve est de chercher a sonner la cloche plusieurs fois. Les indices permettent d'indiquer au joueurs le nombre de fois qu'il doit sonner
        // Pour cette enigme, il faut qu'une pleine lune soit visible quelque part dans le niveau, afin de pieger le joueur a ne sonner que 2 fois.
        {"Livre1_1", "¿ l'aube de la troisiËme journÈe, trois cavaliers provenant de la citÈ des trois lunes arrivËrent. Chacun offrit une offrande ‡ notre maÓtre vÈnÈrÈ. Nous rÈpÈtons ces offrandes par trois coups de cloches successifs." },
        {"Livre1_2", "Malheureusement, le guerrier de la pleine lune trahit la volontÈ de notre maÓtre. Ainsi, un coup de moins retentira les soirs de lunes rondes." },

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

        // Scene du mot de passe, la rÈponse est visible dans une autre salle, le message sera codÈ
        {"PassRoom1", "Quel est le premier enseignement de notre grand maÓtre ?" },
        {"PassChoix1", "Harmonie" },
        {"PassChoix2", "Barbie" },
        {"PassChoix3", "Pamplemousse" },
        {"PassChoix4", "Charbonnier" },
        {"PassRoom2", "Ouiiii, c'est la bonne rÈponse! Peut Ítre ?" },
        {"PostIt1", "Certains mots sont effacÈs, mais on peut distinguer les mots \"Oub ie  as,  e  o  de  a se est :  ar on  \"" },
        {"PostIt2", "BOB ! On m'a apprie que tu as 'ENCORE' oubliÈ le mot de passe.... ca rime avec 'AEROPHAGIE'" },


        // Scene de la clef
        {"KeyRoom1", "TODO" },
        {"KeyRoom2", "TODO" },
        {"Livre4_1", "TODO" },
        {"Livre4_2", "TODO" },
        {"Livre4_3", "TODO" },
        {"Livre4_4", "TODO" },

        // Scene finale, qui va dÈfinir si nos choix sont bon.
        {"ManqueSacrifice", "TODO" },
        {"ManqueCloche", "TODO" },
        {"ManquePriere", "TODO" },
        {"ManqueLampions", "TODO" },
        {"FinLampions", "TODO" },
        {"FinCloche", "TODO" },
        {"FinSacrifice", "TODO" },
        {"FinPriere", "TODO" },
        {"BonneFin", "TODO" },

        // Textes gÈnÈriques
        {"NouvellePartie", "TODO" },

    };

    public string GetRandomName()
    {
        return nomAlÈatoire[Random.Range(0, nomAlÈatoire.Count)];
    }

    private List<string> nomAlÈatoire = new()
    {
        "Absolon",
        "Adolphe",
        "Adrien",
        "AimÈ",
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
        "AurËçle",
        "Aurelien",
        "Baptiste",
        "Bastien",
        "Benoit",
        "Blaise",
        "Brice",
        "CÈlestin",
        "Cesaire",
        "Charlot",
        "Christophe",
        "ClÈment",
        "Colombain",
        "Corin",
        "Damien",
        "DÈsirÈ",
        "Didier",
        "Edgard",
        "Edmond",
        "Edouard",
        "Emile",
        "Emilien",
        "Etienne",
        "EugËçne",
        "Eustache",
        "Fabien",
        "Fabrice",
        "Felicien",
        "FÈlix",
        "Fernand",
        "Fiacre",
        "Firmin",
        "Florentin",
        "Franck",
        "Francois",
        "FrÈdÈric",
        "GaÈtan",
        "Gaspard",
        "Gaston",
        "Gautier",
        "Georges",
        "Germain",
        "Gervais",
        "Ghislain",
        "Gilles",
        "Gratien",
        "GrÈgoire",
        "Guillaume",
        "Gustave",
        "Henri",
        "Hercule",
        "HervÈ",
        "Ignace",
        "Jacques",
        "Jean",
        "Jean-Baptiste",
        "Jean-Marie",
        "JÈrÈmie",
        "Julien",
        "Juste",
        "Laurent",
        "LÈon",
        "LÈonard",
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
        "RaphaËl",
        "RÈgis",
        "RÈmi",
        "Renaud",
        "Rodolphe",
        "Rodrigue",
        "Romain",
        "SÈbastien",
        "Serge",
        "Sylvain",
        "Thibault",
        "Thierry",
        "Yves",
        "Zacharie",
    };


}
