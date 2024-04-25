namespace DictionnaryChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Création du dictionnaire
            Dictionary<char, string> dictionary = new Dictionary<char, string>();

            // Ajout des éléments 'a', 'b' et 'c' dans le dictionnaire
            dictionary.Add('a', "Comme : Alphabet ou Abracadabra");
            dictionary.Add('b', "Comme : Beta ou Big");
            dictionary.Add('c', "Comme : Charlie ou Chance");

            // Affichage du dictionnaire avant la suppression - (clé, Valeur)
            Console.WriteLine("Dictionnaire avant suppression de la lettre 'c':");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Clé : {kvp.Key}, Valeur : {kvp.Value}");
            }

            // Suppression de la lettre 'c'
            dictionary.Remove('c');

            // Affichage du dictionnaire après la suppression - (Clé, Valeur)
            Console.WriteLine("\nDictionnaire après suppression de la lettre 'c':");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Clé : {kvp.Key}, Valeur : {kvp.Value}");
            }
        }
    }
}
