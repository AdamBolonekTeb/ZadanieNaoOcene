using Księgarnia;

void menu(string? message = "")
{
    Console.Clear();
        /*************************************
         * Wyswietla menu konsoli
         *************************************/
    if (!string.IsNullOrEmpty(message)) Console.WriteLine(message);
    Console.WriteLine("1 Wszystkie Ksiazki");
    Console.WriteLine("2 Wyswietl wybrana ksiazke");
    Console.WriteLine("3 Dodaj ksiazke");
    Console.WriteLine("4 Usun ksiazke");

    int i = Convert.ToInt16(Console.ReadLine());

    switch (i)
    {
        default:
            menu();
            break;

        case 1:
            Ksiazka.ShowAll();
            Console.ReadKey();

            menu();
            break;
            /*************************************
            * kod oczekuje na id ksiazki aby ja wyswietlic
            *************************************/

        case 2:
            Console.WriteLine("Podaj id ksiazki, ktora chcesz wyswietlic");
            Ksiazka.Show(Convert.ToInt16(Console.ReadLine()));
            Console.ReadKey();

            menu();
            break;
            /*************************************
            * Podaje ci tytul ksiazki z bazy
            *************************************/
        case 3:
            Console.WriteLine("Tytul Ksiazki");
            string title = Console.ReadLine();
            /*************************************
            * Podaje ci autora ksiazki z bazy
            *************************************/
            Console.WriteLine("Autor ksiazki");
            string author = Console.ReadLine();
            /*************************************
            * Podaje ci rok wydania ksiazki z bazy
            *************************************/
            Console.WriteLine("Rok wydania ksiazki");
            int releaseDate = Convert.ToInt16(Console.ReadLine());
            /*************************************
            * Podaje ci gatunek ksiazki z bazy
            *************************************/
            Console.WriteLine("Gatunek ksiazki");
            string genre = Console.ReadLine();
            /*************************************
            * Kod informuje czy ksiazka zostala poprawnie dodana
            *************************************/
            Ksiazka.Add(title, author, releaseDate, genre);

            menu("Ksiazka zostala dodana poprawnie");
            break;
            /*************************************
            * Kod czeka na podanie id ksiazki aby usunac ja z bazy
             *************************************/
        case 4:
            Console.WriteLine("Daj id ksiazki, ktora ma zostac usunieta");
            Ksiazka.Remove(Convert.ToInt16(Console.ReadLine()));
            /*************************************
            * Kod mowi ci czy usunal wybrana ksiazke
            *************************************/
            menu("Ksiezke udalo sie usunac poprawnie");
            break;
    }
}
menu();
