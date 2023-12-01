using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.HangmanGame
{
    internal static class WordBank
    {
        private static Dictionary<string, string> techDictionary = new Dictionary<string, string>()
        {
            {"computer", "Electronic device for processing data"},
            {"software", "Programs and applications of a computer system"},
            {"internet", "Global network of interconnected computers"},
            {"keyboard", "Input device with keys to enter data"},
            {"mouse", "Pointing device used to interact with the computer"},
            {"algorithm", "Sequence of steps to perform a specific task"},
            {"programming", "Activity of developing computer programs"},
            {"database", "Organized storage of data"},
            {"hardware", "Physical components of a computer system"},
            {"source code", "Programmer-readable text written in a programming language"},
            {"webcam", "Video camera used for internet broadcasts"},
            {"backup", "Data backup to prevent loss"},
            {"server", "Computer that provides services to other computers on the network"},
            {"interface", "Means of interaction between the user and a system"},         
            {"wifi", "Wireless internet connection technology"},
            {"malware", "Malicious software designed to cause harm to a computer"}
        };

        private static Dictionary<string, string> countriesDictionary = new Dictionary<string, string>()
        {
            {"brazil", "Largest country in South America"},
            {"usa", "United States of America"},
            {"china", "Country in East Asia"},
            {"india", "Country in South Asia"},
            {"russia", "Largest country in the world"},
            {"japan", "Country known for its technology and sushi"},
            {"france", "Country in Western Europe"},
            {"germany", "Country in Central Europe"},
            {"italy", "Country in Southern Europe"},
            {"spain", "Country in Southwestern Europe"},
            {"mexico", "Country in North America"},
            {"canada", "Country in North America"},
            {"australia", "Country in Oceania"},
            {"south africa", "Country in Southern Africa"},
            {"egypt", "Country spanning the northeast corner of Africa and southwest corner of Asia"}
        };

        private static Dictionary<string, string> animalsDictionary = new Dictionary<string, string>()
        {
            {"lion", "Large cat species known for its mane"},
            {"elephant", "Big mammal with a trunk"},
            {"penguin", "Bird species that cannot fly but excels in swimming"},
            {"giraffe", "Tall African mammal with a long neck"},
            {"tiger", "Large cat species known for its stripes"},
            {"panda", "Bear-like mammal native to China"},
            {"koala", "Marsupial native to Australia"},
            {"zebra", "African mammal with black and white stripes"},
            {"monkey", "Primate known for its playful behavior"},
            {"dolphin", "Marine mammal known for its intelligence"},
            {"kangaroo", "Marsupial native to Australia with powerful hind legs"},
            {"polar bear", "Large carnivorous bear native to the Arctic"},
            {"hippopotamus", "Large herbivorous mammal found in rivers and lakes in Africa"},
            {"crocodile", "Large aquatic reptile with a long snout"},
            {"gorilla", "Large primate native to Africa"}
        };

        private static Dictionary<string, string> brazilianFootballTeamsDictionary = new Dictionary<string, string>()
        {
            {"flamengo", "Rio de Janeiro-based club with a passionate fanbase"},
            {"corinthians", "São Paulo-based club known for its large fanbase"},
            {"palmeiras", "São Paulo-based club with a history of success"},
            {"santos", "Coastal club known for producing legendary players"},
            {"saopaulo", "São Paulo-based club with a strong tradition"},
            {"fluminense", "Rio de Janeiro-based club with a rich history"},
            {"vasco", "Club from Rio de Janeiro with a historical rivalry with Flamengo"},
            {"cruzeiro", "Club based in Belo Horizonte known for its blue colors"},
            {"atleticomg", "Belo Horizonte-based club with a passionate fanbase"},
            {"internacional", "Club based in Porto Alegre, known for international success"},
            {"gremio", "Porto Alegre-based club with a strong fanbase"},
            {"bahia", "Salvador-based club with a distinctive tricolor kit"},
            {"botafogo", "Rio de Janeiro-based club with a rich history"},
            {"athleticopr", "Curitiba-based club known for its red and black colors"},
            {"coritiba", "Curitiba-based club with a green and white kit"}
        };

        public static KeyValuePair<string, string> GetRandomWordAndHint(Dictionary<string, string> selectedDictionary)
        {
            if (selectedDictionary == null || selectedDictionary.Count == 0)
            {
                throw new ArgumentException("O dicionário fornecido está vazio ou é nulo.");
            }

            Random random = new Random();
            int randomIndex = random.Next(selectedDictionary.Count);
            KeyValuePair<string, string> randomPair = selectedDictionary.ElementAt(randomIndex);

            return randomPair;
        }

        public static Dictionary<string, string> FindDictionary(int option)
        {
            switch (option)
            {
                case 1:
                    return techDictionary;
                case 2:
                    return countriesDictionary;
                case 3:
                    return animalsDictionary;
                case 4:
                    return brazilianFootballTeamsDictionary;
                default:
                    throw new ArgumentException("Opção inválida");
            }
        }
    }
}

