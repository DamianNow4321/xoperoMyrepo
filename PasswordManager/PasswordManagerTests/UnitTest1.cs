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
            string pass = Entry.loadMasterPassword();
            List<Entry> objEntry = Entry.readFile();
            for (int i = 0; i <= objEntry.Count - 1; i++)
            {
            }
        }
    }
}
