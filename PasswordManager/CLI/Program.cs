using PasswordManager;
using System;
using System.Collections.Generic;
using Newtonsoft;
using System.Text;

namespace CLI
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            string login;
            string password;
            string pathLoc;
            bool cont = true;
            string mpass;
            if (Entry.pth == null)
            {
                Console.WriteLine("Proszę podać ścieżkę pliku");
                Entry.changePath(Console.ReadLine());
            }
            Console.WriteLine("Proszę wpisać hasło");
            mpass = Entry.Hash(Console.ReadLine()).ToString();
            string MPassC = Entry.loadMasterPassword(Console.ReadLine());
            bool firstTime =true;
            if (MPassC == "")
            {
                firstTime = true;
            }
            if (mpass == MPassC || firstTime==true)
            {
                while (cont == true)
                {
                    List<Entry> objEntry = Entry.readFileAlt();
                    Console.WriteLine("Jeśli chcesz wyświetlić zapisane hasła wpisz /check.Jeśli chcesz wyszukać hasło wpisz /search." +
                        "Jeśli chcesz zmianić hasło dostępu wpisz /change.Jeśli chcesz zmienić folder z hasłami wpisz /folder. " +
                        "Jeśli chcesz dodać wpis wpisz /add. Jeśli chcesz zmienić salt do hashowania wpisz /changeSalt " +
                        "Jeśli chcesz zmodyfikować wpis wpisz /modifyentry.Jeśli chcesz usunąć wpis wpisz /removeentry." +
                        "Jeśli chcesz zamkąć program wpisz /exit.");
                    switch (Console.ReadLine())
                    {
                        case "/add":
                            Console.WriteLine($"Wpisz nazwę serwisu");
                            name = Console.ReadLine();
                            Console.WriteLine($"Wpisz login");
                            login = Console.ReadLine();
                            Console.WriteLine($"Wpisz hasło");
                            password = Console.ReadLine();
                            Entry.SaveToFileAlt(name, login, password);
                            break;
                        case "/changeSalt":
                            Console.WriteLine($"Wpisz salt");
                            Entry.changeSalt(Console.ReadLine());
                            break;
                        case "/change":
                            Console.WriteLine($"Wpisz hasło dostępu");
                            Entry.changeMasterPassword(Console.ReadLine());
                            break;
                        case "/folder":
                            Console.WriteLine($"Wpisz ścieżke");
                            pathLoc = Console.ReadLine();
                            Entry.changePath(pathLoc);
                            break;
                        case "/modifyentry":
                            Console.WriteLine($"Wpisz nazwę wpisu do modyfikacji");
                            name = Console.ReadLine();
                            Console.WriteLine($"Wpisz nowy login");
                            login = Console.ReadLine();
                            Console.WriteLine($"Wpisz nowe hasło");
                            password = Console.ReadLine();
                            Entry.changeEntry(name, login, password);
                            break;
                        case "/removeentry":
                            Console.WriteLine($"Wpisz nazwę wpisu do usunięcia");
                            Entry.removeEntry(Console.ReadLine());
                            break;
                        case "/search":
                            Console.WriteLine($"Wpisz nazwę");
                            string searchName = Console.ReadLine();
                            List<Entry> searchRes =Entry.searchPasswords(searchName,objEntry);
                            for (int i = 0; i <= objEntry.Count - 1; i++)
                            {
                                Console.WriteLine("Nazwa: " + searchRes[i].Name + Environment.NewLine + "Login: " + searchRes[i].Login
                                + Environment.NewLine + "Hasło: " + searchRes[i].Password);
                            }
                            break;
                        case "/check":
                            if (objEntry !=null)
                            {
                                for (int i = 0; i <= objEntry.Count - 1; i++)
                                {
                                    Console.WriteLine("Nazwa: " + objEntry[i].Name + Environment.NewLine + "Login: " + objEntry[i].Login
                                    + Environment.NewLine + "Hasło: " + objEntry[i].Password);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Brak zapisanych haseł");
                            }
                            break;
                        case "/exit":
                            cont = false;
                            break;
                    }
                }
            }
        }
    }
}
