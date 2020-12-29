using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordManager;
using GUI;
using CLI;
using System.Collections.Generic;
using System;

namespace PasswordManagerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LoadPasswordAndFiles()
        {
            Entry.pth = "C:/Data";
                string pass = Entry.loadMasterPassword("TEST");
                List<Entry> objEntry = Entry.readFileAlt();
                for (int i = 0; i <= objEntry.Count - 1; i++)
                {
                System.Console.WriteLine("Nazwa: " + objEntry[i].Name + Environment.NewLine + "Login: " + objEntry[i].Login
                                   + Environment.NewLine + "Has³o: " + objEntry[i].Password);
                }

        }
        [TestMethod]
        public void AddEntry()
        {
            Entry.pth = "C:/Data";
                Entry.SaveToFile("TEST", "TEST", "TEST");
        }
        [TestMethod]
        public void ChangePath()
        {
            Entry.pth = "C:/Data";
                Entry.changePath("D:/Data");
        }
        [TestMethod]
        public void ChangePassword()
        {
                Entry.changeMasterPassword("TEST2");
        }
        [TestMethod]
        public void SearchPasswords()
        {
                Entry.searchPasswords("TEST");
        }
        public void Hash()
        {
            Entry.Hash("TEST");
        }
        public void Modify()
        {
            Entry.changeEntry("TEST","TEST","TEST");
        }
        public void Remove()
        {
            Entry.removeEntry("TEST");
        }
    }
}
