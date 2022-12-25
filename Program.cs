Random rand = new Random();
int n = rand.Next(2, 10);
string[] array = new string[n];
RandomArray(ref array);
Console.WriteLine("Исходный массив:");
Console.Write("[");
for (int i = 0; i < n; i++)
{
     Console.Write(array[i] + " ");
}
Console.WriteLine("]");
Console.WriteLine("Из него слова меньше или равно трем элементам:");
Console.Write("[");
for (int i = 0; i < n; i++)
{
     if (array[i].Length <= 3)
         Console.Write(array[i] + " ");
}
Console.WriteLine("]");


string RandomString()
{
     Random rand = new Random();
     string str = "abcdefghijklmnopqrstuvwxyz0123456789";
     int size = rand.Next(1,10);

     string randomstring = "";

     for (int i = 0; i < size; i++)
     {
         int x = rand.Next(str.Length);
         randomstring = randomstring + str[x];
     }
     return randomstring;
}

void RandomArray(ref string[] array)
{
     for (int i = 0; i < n; i++)
     {
         array[i] = RandomString();
     }
}