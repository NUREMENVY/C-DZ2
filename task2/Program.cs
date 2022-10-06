
Console.Clear();
Console.WriteLine("Enter a three-digit number.");
    string input = Console.ReadLine();
    Console.WriteLine("{0}->{1}",input, input[2]);
    if (input.Length > input [2])
        Console.WriteLine("no");


