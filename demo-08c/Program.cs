namespace demo_08c;

public static class Program {
    private static int Permutations(string letters, string word = "") {
        
        
        
        // Base Case
        
        if (letters.Length == 0) {
            // If there are no more letters to choose from, then
            // display the word

            Console.WriteLine(word);
            return 1;
        }
        else
        {
            
            // Find each permutation starting with 'word' and adding
            // each of the remaining letters one at a time.
            
            for (var index = 0; index < letters.Length; index++)
            {
                var letter = letters[index];
                var remainingLetters = letters.Remove(index, 1);
                Permutations(remainingLetters, word + letter);
            }
        }

        return 0;
    }

    private static void Main() {
        var result = Permutations("ABCD");
        // Console.WriteLine(result);

        Console.WriteLine("====================");

        // result = Permutations("ABCDEFG");
        // Console.WriteLine(result);
    }
}