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
            if (!File.Exists(Path.Combine(pth, "mpass")))
            {
                using (System.IO.StreamWriter sw = File.CreateText(Path.Combine(pth, "mpass")))
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
        public static bool SaveToFileAlt(string name, string login, string password,string mpass)
        {
            string EncryptedPass = EncryptString(mpass, password);
            Entry newEntry = new Entry(login, EncryptedPass, name);
            newEntry.Serialize(newEntry);
            string fileName = name+".json";
            string pthFile = Path.Combine(pth, fileName);
            if (!File.Exists(pthFile))
            {
                using (System.IO.StreamWriter sw = File.CreateText(pthFile))
                {
                }
            }
            else
            {
                return false;
            }
            var json = System.IO.File.ReadAllText(pthFile);
            var fileData = JsonConvert.DeserializeObject<List<Entry>>(json)
                ?? new List<Entry>();
            fileData.Add(newEntry);
            json = JsonConvert.SerializeObject(fileData);
            System.IO.File.WriteAllText(pthFile, json);
            return true;
        }
        public static List<Entry> readFileAlt(string mpass)
        {
            int i=0;
            var objEntry=new List<Entry>();
            foreach (string fileName in Directory.GetFiles(pth, "*.json")){
                string pthFile = Path.Combine(pth, fileName);
                string fileDataRead = File.ReadAllText(pthFile);
                objEntry.AddRange(JsonConvert.DeserializeObject<List<Entry>>(fileDataRead));
                objEntry[i].Password = DecryptString(mpass,objEntry[i].Password);
                i = i + 1;
            }
            return objEntry;
        }
        public static void changeMasterPassword(string MpassC)
        {
            string fileName = "mpass";
            string pthPass = Path.Combine(pth, fileName);
            if (!File.Exists(pthPass))
            {
                using (System.IO.StreamWriter sw = File.CreateText(pthPass))
                {
                }
            }
            string hashpass = System.Text.Encoding.Default.GetString(Hash(MpassC));
            System.IO.File.WriteAllText(pthPass, hashpass);
        }
        public static void changeSalt(string salt)
        {
            string fileName = "salt";
            string pthPass = Path.Combine(pth, fileName);
            if (!File.Exists(pthPass))
            {
                using (System.IO.StreamWriter sw = File.CreateText(pthPass))
                {
                }
            }
            System.IO.File.WriteAllText(pthPass, salt);
        }

        public static string loadMasterPassword(string MpassC)
        {
            string fileName = "mpass";
            string pthPass = Path.Combine(pth, fileName);
            if (!File.Exists(pthPass))
            {
                using (System.IO.StreamWriter sw = File.CreateText(pthPass))
                {
                }
                System.IO.File.WriteAllText(pthPass, Hash(MpassC).ToString());
            }
            string fileDataRead = File.ReadAllText(pthPass);
            return fileDataRead;
        }
        public static List<Entry> searchPasswords(string sName, List<Entry> objEntry)
        {
            List<Entry> fileSearched = new List<Entry>();
            for (int i = 0; i <= objEntry.Count - 1; i++)
            {
                if(objEntry[i].Name == sName)
                {
                    fileSearched.Add(objEntry[i]);
                }
            }
            return fileSearched;
        }
        public static bool removeEntry(string name)
        {
            string fileName = name+".json";
            string pthFile = Path.Combine(pth, fileName);
            if (File.Exists(pthFile))
            {
                File.Delete(pthFile);
                return true;
            }
            else
            {
                return false;
            }
        }

       public static bool changeEntry(string name, string login, string password)
        {
            string fileName = name+".json";
            string pthFile = Path.Combine(pth, fileName);
            if (!File.Exists(pthFile))
            {
               return false;
            }
            var json = System.IO.File.ReadAllText(pthFile);
            var fileData = JsonConvert.DeserializeObject<List<Entry>>(json)
                ?? new List<Entry>();
            File.Delete(pthFile);
            //fileData[0].Name = name;
            fileData[0].Login = login;
            fileData[0].Password = password;
            json = JsonConvert.SerializeObject(fileData);
            System.IO.File.WriteAllText(pthFile, json);
            return true;
        }
        public static string EncryptString(string key, string plainText)
        {
            byte[] iv = new byte[16];
            byte[] array;
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }
                        array = memoryStream.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(array);
        }
        public static string DecryptString(string key, string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
