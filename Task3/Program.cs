Console.WriteLine("Введите строку");
string someString =Console.ReadLine();
char[] reverse = new char[someString.Length];
for(int i=someString.Length-1; i>=0; i--)
{
    reverse[i] = someString[i];
    Console.Write(reverse[i]);
}

