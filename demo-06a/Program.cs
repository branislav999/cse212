/*
 * CSE 212 Lesson 6a
 * Demonstrate how dictionaries (maps) work.
 */

// Create an empty dictionary

using System.Collections.Specialized;

var student = new Dictionary<string, string>();
Console.WriteLine($"Empty dictionary: {{{string.Join(", ", student)}}}");

// Add name, credits, and the major to the student.

Console.WriteLine($"Populated student: {{{string.Join(", ", student)}}}");
student.Add("name","Branislav Bogosavac");
student["credits"] = "84";
student["major"] = "Software Engineering";
student["classGrades"] = new Dictionary<string, string>();
((Dictionary<string, string>)student["classGrades"]).Add("CSE212", "A");


// Display just the student credits
var credits = student["credits"];

Console.WriteLine($"Student credits: {credits}");

// Display just the keys.
Console.WriteLine($"Keys: ");

Console.WriteLine($"Keys: {string.Join(", ", student.Keys)}");

// foreach (var key in student.Keys)
// {
//     Console.WriteLine(key);
// }


// Display just the values
Console.WriteLine($"Values: ");
Console.WriteLine($"Values: {string.Join(", ", student.Values)}");

// Display all Key/Value pairs
foreach (var key in student.Keys )
{
  Console.WriteLine($"{key}: {student[key]}");
}

foreach (var pair in student)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}

foreach (var (key, value) in student)
{
    Console.WriteLine($"{key}: {value}");
}


// Remove major from the student

student.Remove("major");
Console.WriteLine($"After deleting the major: {{{string.Join(", ", student)}}}");
