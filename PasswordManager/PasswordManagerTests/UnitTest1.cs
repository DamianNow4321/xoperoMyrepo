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
                List<Entry> objEntry = Entry.readFileAlt("b14ca5898a4e4133bbce2ea2315a1916");
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
                Entry.SaveToFileAlt("TEST", "TEST", "TEST", "b14ca5898a4e4133bbce2ea2315a1916");
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
            List<Entry> objEntry= Entry.readFileAlt("b14ca5898a4e4133bbce2ea2315a1916");
            Entry.searchPasswords("TEST", objEntry);
        }
        [TestMethod]
        public void Hash()
        {
            Entry.Hash("TEST");
        }
        [TestMethod]
        public void Modify()
        {
            Entry.changeEntry("TEST","TEST","TEST");
        }
        [TestMethod]
        public void Remove()
        {
            Entry.removeEntry("TEST");
        }
        [TestMethod]
        public void Read()
        {
            Entry.readFileAlt("b14ca5898a4e4133bbce2ea2315a1916");
        }
        public void EncryptDecrypt()
        {
            Entry.EncryptString("b14ca5898a4e4133bbce2ea2315a1916", "TEST");
            Entry.DecryptString("b14ca5898a4e4133bbce2ea2315a1916", "TEST");
        }
    }
}
