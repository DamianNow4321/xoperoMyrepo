using PasswordManager;
using System;
using System.Collections.Generic;
using Newtonsoft;
namespace CLI
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            string login;
            string password;
            string Mpassword;
            bool cont = true;
            string mpass;
            string MPassC=Entry.loadMasterPassword();
            Console.WriteLine("Proszę wpisać hasło");
            mpass = Entry.Hash(Console.ReadLine());
            bool firstTime=true;
            if (MPassC == "")
            {
                firstTime = true;
            }
            if (mpass == MPassC || firstTime==true)
            {
                while (cont == true)
                {
                    List<Entry> objEntry = Entry.readFile();
                    Console.WriteLine("Jeśli chcesz wyświetlić zapisane hasła wpisz /check.Jeśli chcesz wyszukać hasło wpisz /search.Jeśli chcesz zmianić hasło dostępu wpisz /change. Jeśli chcesz dodać hasło wpisz /add. Jeśli chcesz zamkąć program wpisz /exit");
                    switch (Console.ReadLine())
                    {
                        case "/add":
                            Console.WriteLine($"Wpisz nazwę serwisu");
                            name = Console.ReadLine();
                            Console.WriteLine($"Wpisz login");
                            login = Console.ReadLine();
                            Console.WriteLine($"Wpisz hasło");
                            password = Console.ReadLine();
                            Entry.SaveToFile(name, login, password);
                            break;
                        case "/change":
                            Console.WriteLine($"Wpisz hasło dostępu");
                            Mpassword = Console.ReadLine();
                            Mpassword = MPassC;
                            Entry.changeMasterPassword(MPassC);
                            break;
                        case "/search":
                            Console.WriteLine($"Wpisz nazwę");
                            string searchName = Console.ReadLine();
                            objEntry=Entry.searchPasswords(searchName);
                            for (int i = 0; i <= objEntry.Count - 1; i++)
                            {
                                Console.WriteLine("Nazwa: " + objEntry[i].Name + Environment.NewLine + "Login: " + objEntry[i].Login
                                + Environment.NewLine + "Hasło: " + objEntry[i].Password);
                            }
                            break;
                        case "/check":
                            for (int i = 0; i <= objEntry.Count - 1; i++)
                            {
                                Console.WriteLine("Nazwa: " + objEntry[i].Name + Environment.NewLine + "Login: " + objEntry[i].Login
                                + Environment.NewLine + "Hasło: " + objEntry[i].Password);
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
