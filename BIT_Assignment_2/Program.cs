// creating an array
string[] studentNames = new string[10] { "Ahmed", "Bessy", "Chuks", "Sarah", "Mandy", 
    "Fred", "Kazim", "Terry", "Randy", "Lizzy" };

List<int> studentAges = new List<int>() { 21, 25, 19, 17, 22, 18, 23, 26, 21, 18 };

int targetAge = 18;

bool studentWithTargetAge = studentAges.Contains(targetAge);

if (studentWithTargetAge)
    Console.WriteLine("There is an {0} year old student", targetAge);
else
    Console.WriteLine("No student is {0} years old", targetAge);