// CSE 212 Lesson 5A
// Demonstrate how sets work.

HashSet<string> names = new HashSet<string>(); // Create an empty set of names
Console.WriteLine($"Empty set: {{{string.Join(", ", names)}}}");

// Create a set of two names: Bob and Tim
names.Add("Bob");
names.Add("Tim");
Console.WriteLine($"Set with Bob and Tim: {{{string.Join(", ", names)}}}");


// Add a Sue to the set
names.Add("Sue");
Console.WriteLine($"After adding Sue (notice not in order): {{{string.Join(", ", names)}}}");


// Add Bob again (duplicate)

Console.WriteLine($"After trying to add Bob again: {{{string.Join(", ", names)}}}");
names.Add("Bob");

// Check for membership
Console.WriteLine("Enter a name: ");
/*string findName = Console.ReadLine()!;

if (names.Contains(findName)) {
    Console.WriteLine("In the Set.");
}
else {
    Console.WriteLine("Not in the Set.");
}*/

Console.WriteLine(1234.GetHashCode());
Console.WriteLine(12.34.GetHashCode());
Console.WriteLine("1234".GetHashCode());
Console.WriteLine("1234".GetHashCode());
var myString = "1" + "23" + "4";
Console.WriteLine(myString.GetHashCode());

// Remove Bob from the set

Console.WriteLine($"After removing Bob: {{{string.Join(", ", names)}}}");