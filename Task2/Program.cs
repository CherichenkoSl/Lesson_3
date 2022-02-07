string[,] TelDirectory = new string[5, 2];
Console.WriteLine("Телефонный справочник:");
TelDirectory[0, 0] = "Василина Пак";
TelDirectory[0, 1] = "+7(918)04-67-805";
TelDirectory[1, 0] = "Виктор Петрович";
TelDirectory[1, 1] = "+7(999)17-88-045";
TelDirectory[2, 0] = "Такси";
TelDirectory[2, 1] = "+7(495)123-66-66";
TelDirectory[3, 0] = "Не брать!";
TelDirectory[3, 1] = "+7(800)555-35-35";
TelDirectory[4, 0] = "Саша";
TelDirectory[4, 1] = "+7(921)38-38-338";
for(int i = 0;i<=TelDirectory.GetUpperBound(0);i++)
{
    Console.WriteLine($"{i+1} контакт");
    for(int j = 0;j<=TelDirectory.GetUpperBound(1);j++)
    {
        Console.Write($"{TelDirectory[i,j]} ");
    }
    Console.WriteLine();
}



