﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{

    public class Entry
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public static string pth;
        public static string salt;
        public override string ToString() => Name;
        public Entry(string login,string password,string name)
        {
            Login = login;
            Password = password;
            Name = name;
        }
        public static string changePath(string NewPth)
        {
            pth = NewPth;
            if (!File.Exists(Path.Combine(pth,"dane.json")))
            {
                using (System.IO.StreamWriter sw = File.CreateText(Path.Combine(pth, "mpass.json")))
                {

                }
            }
            if (!File.Exists(Path.Combine(pth, "mpass.json")))
            {
                using (System.IO.StreamWriter sw = File.CreateText(Path.Combine(pth, "mpass.json")))
                {

                }
            }
            return pth;
        }
        public string Serialize(Entry objEntry)
        {
            string json = JsonConvert.SerializeObject(objEntry);
            return json;
        }
        public Entry Deserialize(string Json)
        {
            Entry objEntry = JsonConvert.DeserializeObject<Entry>(Json);
            return objEntry;
        }
        public static string Hash(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            return Convert.ToBase64String(hashBytes);
        }
        public static bool SaveToFile(string name,string login,string password)
        {
            Entry newEntry = new Entry(login, password, name);
            newEntry.Serialize(newEntry);
            string fileName = "dane.json";
            string pthFile = Path.Combine(pth, fileName);
            if (!File.Exists(pthFile))
            {
                using (System.IO.StreamWriter sw = File.CreateText(pthFile))
                {

                }
            }
            var json = System.IO.File.ReadAllText(pthFile);
            var fileData = JsonConvert.DeserializeObject<List<Entry>>(json)
                ?? new List<Entry>();
            fileData.Add(newEntry);
            json = JsonConvert.SerializeObject(fileData);
            System.IO.File.WriteAllText(pthFile, json);
            return true;
        }
        public static List<Entry> readFile()
        {
            string fileName = "dane.json";
            string pthFile = Path.Combine(pth, fileName);
            string fileDataRead = File.ReadAllText(pthFile);
            var objEntry = JsonConvert.DeserializeObject<List<Entry>>(fileDataRead);
            return objEntry;
        }
        public static void changeMasterPassword(string MpassC)
        {
            string fileName = "mpass.json";
            string pthPass = Path.Combine(pth, fileName);
            if (!File.Exists(pthPass))
            {
                using (System.IO.StreamWriter sw = File.CreateText(pth))
                {
                }
            }
            System.IO.File.WriteAllText(pthPass, Hash(MpassC));
        }
        public static string loadMasterPassword()
        {
            string fileName = "mpass.json";
            string pthPass = Path.Combine(pth, fileName);
            string fileDataRead = File.ReadAllText(pthPass);
            return fileDataRead;
        }
        public static List<Entry> searchPasswords(string sName)
        {
            List<Entry> file = readFile();
            for (int i = 0; i <= file.Count - 1; i++)
            {
                if(file[i].Name != sName)
                {
                    file.RemoveAt(i);
                }
            }
            return file;
        }
    }
}
