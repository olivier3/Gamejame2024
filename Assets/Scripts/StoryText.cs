using System.Collections.Generic;
using UnityEngine;

public class StoryText : MonoBehaviour
{
    public static Dictionary<string, string> texts = new()
    {
        // Pour cette scene, l'epreuve est de chercher a sonner la cloche plusieurs fois. Les indices permettent d'indiquer au joueurs le nombre de fois qu'il doit sonner
        // Pour cette enigme, il faut qu'une pleine lune soit visible quelque part dans le niveau, afin de pieger le joueur a ne sonner que 2 fois.
        {"Livre1_1", "A l'aube de la troisieme journee, trois cavaliers provenant de la cite des trois lunes arriverent. " +
            "Chacun offrit une offrande a notre maitre venere. Nous repetons ces offrandes par trois coups de cloches successifs." },
        {"Livre1_2", "Malheureusement, le guerrier de la pleine lune trahit la volonte de notre maitre. Ainsi, un coup de moins retentira les soirs de lunes rondes." },
        {"Cloche1", "La nuit est eclairee par une pleine lune d'une etrange clarte" },

        // Dans cette scene, le joueur devrait trouver quoi sacrifier au grand gourou. Les indices permettent de trouver quoi sacrifier
        {"Livre2", "Un sacrifice sacre, une offrande veneree, a notre grand maitre, devra etre donnee." },
        {"Sacrifice1", "Voulez-vous sacrifier cette tete de Mickey ?" },
        {"Sacrifice2", "Voulez-vous sacrifier cette poupee ?" },
        {"Sacrifice3", "Voulez-vous sacrifier ce Brocolli !?" },
        {"Sacrifice4", "Voulez-vous sacrifier cette pauvre chevre ?" },
        {"Discussion1_1", "Je me demande ce que je vais faire a cuisiner a notre maitre venere ce soir, aurais-tu une idee ?" },
        {"Discussion1_2", "Hmmmm..... je verrais bien un BON GROS STEAK ! N'est-ce pas une bonne idee." },
        {"Discussion1_3", "Es-tu fou ? Notre grand maitre est vegetarien, il ne faudrait pas attiser sa colere." },

        // Dans cette scene, le joueur doit effectuer la bonne priere. Des dessins ou des artworks sur les murs pour trouver comment prier
        {"PriereChoix1", "Voulez-vous hocher la tête a sa terreur ?" },
        {"PriereChoix2", "Voulez-vous vous prosterner devant sa sainteté ?" },
        {"PriereChoix3", "Voulez-vous vous accroupir devant sa grandeur ?" },

        // Scene des lampions, le joueur va devoir allumer certains lampions.
        {"Lampions1", "J'ai besoin d'aide pour allumer ces chandelles. Je ne me souviens plus lesquelles je dois allumer." },
        {"Livre3", "Au debut de la 8eme journee, notre maitre regarda au nord, et ne vis que desolation. Au sud, desespoir." +
            " Ici, terreur. Seul la terre de l'Ouest et celle de l'Est furent choisies pour etablir ses saints preceptes." },

        // Scene du mot de passe, la r�ponse est visible dans une autre salle, le message sera code
        {"PassRoom1", "Quel est le premier enseignement de notre grand maitre ?" },
        {"PassChoix1", "Harmonie" },
        {"PassChoix2", "Barbie" },
        {"PassChoix3", "Pamplemousse" },
        {"PassChoix4", "Charbonnier" },
        {"PassRoom2", "Ouiiii, c'est la bonne reponse! Peut etre ?" },
        {"PostIt1", "Certains mots sont effaces, mais on peut distinguer certaines lettres \"Oub ie  as, l'ense gn me t est :  ar on  \"" },
        {"PostIt2", "BOB ! On m'a apprie que tu as 'ENCORE' oublie l'enseignement.... ca rime avec 'AEROPHAGIE'" },


        // Scene de la clef
        {"KeyRoom1", "Hey te voila le nouveau ! Tiens, voila ta clef personnelle. Fais en bon usage !" },
        {"KeyRoom2", "Nouvel objet obtenu : Clef personnelle. \n Vos initiales sont gravees dessus." },
        {"KeyRoom3", "Vous avez utilise la clef sur le vieux coffre. \n Nouvel objet obtenu: Gros cristal brillant." },
        {"Livre4_1", "Dans l'ombre du culte, le pouvoir de la cle est loue,\nMais ne sois pas esclave de son eclat dore." },
        {"Livre4_2", "Car derriere chaque serrure, un destin est brode,\nEt l'imprudence peut t'egarer dans l'obscurite." },

        // Scene finale, qui va definir si nos choix sont bon.
        // Les "manque" representent si l'action n'a pas ete faite.
        {"ManqueSacrifice", "\"Un sacrifice pour son maitre\", pourquoi n'ai-je rien recu ?" },
        {"ManqueCloche", "\"Un son de cloche pour son maitre\", je n'ai rien entendu !" },
        {"ManquePriere", "\"Une priere pour son maitre\", je n'ai pas entendu m'implorer ?" },
        {"ManqueLampions", "\"Un guide pour son maitre\", je ne connais pas le chemin." },
        {"ManqueClef", "\"Un artefact sacre\", qui etes vous ?" },
        {"ManquePass", "\"Un enseignement pour les aligner tous\", je ne l'ai pas entendu" },

        // Les "Fin" representent si l'action a ete mal faite
        {"FinLampions", "Les lumieres sacrees ne correspondent pas a nos preceptes" },
        {"FinCloche", "La cloche n'a pas sonnee le nombre correcte de fois." },
        {"FinSacrifice", "Que m'avez vous donne en sacrifice ? Sauvage !" },
        {"FinPriere", "La priere est tres importante pour moi, comment OSEZ VOUS vous moquer ainsi ?" },
        {"FinPass", "Je n'ai qu'un enseignement, et vous avez ete capable de vous tromper ? Vous vous moquez de moi ?" },
        {"FinClef", "Avez vous votre artefact ? NON ? Vous aviez UN JOB !" },

        {"BonneFin", "Vous etes definitivement un grand representant de notre ordre. Felicitations !" },

        // Textes generiques
        {"NouvellePartie", "Vous etes une nouvelle recrue de la secte du Culte de l'Acier, a vous de trouver un moyen de vous elever." },
        {"FinDePartie", "Le grand gourou a a detecte l'imposture.\n Fin de partie" },
        // Je les met pour de la genericite. Si on met de l'anglais, ca va faciliter la chose
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
        "Aime",
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
        "Celestin",
        "Cesaire",
        "Charlot",
        "Christophe",
        "Clement",
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
        "Eugene",
        "Eustache",
        "Fabien",
        "Fabrice",
        "Felicien",
        "Felix",
        "Fernand",
        "Fiacre",
        "Firmin",
        "Florentin",
        "Franck",
        "Francois",
        "Frederic",
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
        "Herve",
        "Ignace",
        "Jacques",
        "Jean",
        "Jean-Baptiste",
        "Jean-Marie",
        "Jeremie",
        "Julien",
        "Juste",
        "Laurent",
        "Leon",
        "Leonard",
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
        "Regis",
        "Remi",
        "Renaud",
        "Rodolphe",
        "Rodrigue",
        "Romain",
        "Sebastien",
        "Serge",
        "Sylvain",
        "Thibault",
        "Thierry",
        "Yves",
        "Zacharie",
    };


}
