int tahmax = 0;
int x = 1, y = 100;

Random rasgele = new Random();

Console.Clear();

Console.WriteLine("1-100 arasi bir sayi tutunuz");
int sayi = int.Parse(Console.ReadLine());
while (true)
{
    int tahmin = rasgele.Next(x, y);

    if (tahmin < sayi)
    {
        tahmax++;
        x = tahmin;

        Console.WriteLine("AYI tahminini " + tahmin + "  olarak yapti.");
        Console.WriteLine("Yeniden tahmin yapiyor...");
        Console.ReadKey();
    }
    else if (tahmin > sayi)
    {
        tahmax++;
        y = tahmin + 1;
        Console.WriteLine("AYI tahminini " + tahmin + "  olarak yapti.");
        Console.WriteLine("Yeniden tahmin yapiyor...");
        Console.ReadKey();
    }
    else if (tahmin == sayi)
    {
        tahmax++;
        Console.WriteLine("Tebrikler " + sayi + " sayisini " + tahmax + ". tahmininizde " + "buldunuz!");
        break;
    }
}




