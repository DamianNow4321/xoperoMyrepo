using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordManager;
using GUI;
using CLI;
using System.Collections.Generic;

namespace PasswordManagerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LoadPasswordAndFiles()
        {
            Entry.pth = "C:/Data";
            string pass = Entry.loadMasterPassword();
            List<Entry> objEntry = Entry.readFile();
            for (int i = 0; i <= objEntry.Count - 1; i++)
            {
            }
        }
        [TestMethod]
        public void AddEntry()
        {
            Entry.pth = "C:/Data";
            Entry.SaveToFile("TEST", "TEST", "TEST");
        }
    }
}
