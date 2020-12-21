using Newtonsoft.Json;
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
        public override string ToString() => Name;
        public static string salt="default";
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
        public static byte[] Hash(string password)
        {
            byte[] passwordByte = Encoding.ASCII.GetBytes(password);
            byte[] saltByte = Encoding.ASCII.GetBytes(salt);
            HashAlgorithm algorithm = new SHA256Managed();
            byte[] plainTextWithSaltBytes = new byte[passwordByte.Length + saltByte.Length];
            for (int i = 0; i < passwordByte.Length; i++)
            {
                plainTextWithSaltBytes[i] = passwordByte[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                plainTextWithSaltBytes[passwordByte.Length + i] = saltByte[i];
            }
            return algorithm.ComputeHash(plainTextWithSaltBytes);
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
                using (System.IO.StreamWriter sw = File.CreateText(pthPass))
                {
                }
            }
            System.IO.File.WriteAllText(pthPass, Hash(MpassC).ToString());
        }
        public static void changeSalt(string salt)
        {
            string fileName = "salt.json";
            string pthPass = Path.Combine(pth, fileName);
            if (!File.Exists(pthPass))
            {
                using (System.IO.StreamWriter sw = File.CreateText(pthPass))
                {
                }
            }
            System.IO.File.WriteAllText(pthPass, salt);
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
        public static bool removeEntry(int index)
        {
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
            fileData.Remove(fileData[index]);
            json = JsonConvert.SerializeObject(fileData);
            System.IO.File.WriteAllText(pthFile, json);
            return true;
        }

       public static bool changeEntry(string name, string login, string password,int index)
        {
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
            fileData[index].Name = name;
            fileData[index].Login = login;
            fileData[index].Password = password;
            json = JsonConvert.SerializeObject(fileData);
            System.IO.File.WriteAllText(pthFile, json);
            return true;
        }
    }
}
