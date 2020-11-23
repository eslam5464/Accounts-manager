﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.IO;
using System.Data.OleDb;
using System.Data;
using System.Diagnostics;
using System.Data.SqlClient;

namespace Accounts_manager
{
    public class Methods
    {
        public string db_name = "Accounts.accdb", keyFileName = "key.txt", keyFileNameEnc = "key.txt.aes";
        public string folder_location = @Path.GetPathRoot(Environment.SystemDirectory) + @"Accounts manager\Data\";
        public string DBpassword = "";
        private string connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Data\Accounts.mdf;Integrated Security=True";

        public bool checkFiles()
        {
            if (!Directory.Exists(folder_location))
                Directory.CreateDirectory(folder_location);

            if (!File.Exists(folder_location + keyFileName) && !File.Exists(folder_location + keyFileName + ".aes"))
                File.Create(folder_location + keyFileName).Close();

            if (!File.Exists(folder_location + db_name))
                return false;

            return true;
        }

        public void createDB(string password)
        {
            string connectionString =
                  @"Provider=Microsoft.ACE.OLEDB.12.0;Data"
                + @" Source=" + folder_location + db_name
                + ";Jet OLEDB:Database Password=" + password + ";";

            ADOX.Catalog cat = new ADOX.Catalog();
            cat.Create(connectionString);

            ADODB.Connection con =
                 cat.ActiveConnection as ADODB.Connection;
            if (con != null)
                con.Close();

            //DBpassword = Encrypt(password);
            DBpassword = password;
            Debug.WriteLine(DBpassword);

            StreamWriter Fread = new StreamWriter(folder_location + keyFileName);
            Fread.WriteLine(DBpassword);
            Fread.Close();
            //FileEncrypt(folder_location + keyFileName);
        }

        internal string checkPass(string pass)
        {
            string connectionString =
                  @"Provider=Microsoft.ACE.OLEDB.12.0;Data"
                + @" Source=" + folder_location + db_name
                + ";Jet OLEDB:Database Password=" + pass + ";";

            try
            {
                OleDbConnection conn = new OleDbConnection(connectionString);
                conn.Open();
                //DBpassword = Encrypt(pass);
                DBpassword = pass;
                Debug.WriteLine(DBpassword);
                conn.Close();
                conn.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
            return "";
        }

        internal void add()
        {
            //FileDecrypt(folder_location + keyFileNameEnc, folder_location);
            //DBpassword=
            Debug.WriteLine(DBpassword);
            //String connectionString =
            //   @"Provider=Microsoft.ACE.OLEDB.12.0;Data"
            // + @" Source=C:\Users\patman\Desktop\" + db_name
            // + ";Jet OLEDB:Database Password=" + Decrypt(DBpassword) + ";";


            //ADOX.Catalog cat = new ADOX.Catalog();
            //cat.Create(connectionString);

            ////Now Close the database
            //ADODB.Connection con =
            //     cat.ActiveConnection as ADODB.Connection;
            //if (con != null)
            //    con.Close();

            //Debug.WriteLine("Database '" + db_name + "' Created");

            ////Create Table
            //String tableName = "NEW_TABLE";
            //String createSQL = "CREATE TABLE " + tableName + "("
            //   + "id INTEGER IDENTITY(1,1) PRIMARY KEY NOT NULL,"
            //   + " first_name varchar (255),"
            //   + " last_name varchar (255)"
            //   + ")";

            //OleDbConnection conn =
            //        new OleDbConnection(connectionString);
            //OleDbCommand dbCmd = new OleDbCommand();

            //try
            //{
            //    //Open Database Connection
            //    conn.Open();

            //    dbCmd.Connection = conn;
            //    dbCmd.CommandText = createSQL;
            //    dbCmd.ExecuteNonQuery();

            //    Debug.WriteLine("Table Created");

            //    //---insert into the table -----
            //    String query = "select * from " + tableName;
            //    DataSet ds = new DataSet();
            //    OleDbDataAdapter da =
            //           new OleDbDataAdapter(query, conn);
            //    OleDbCommandBuilder cmdB =
            //           new OleDbCommandBuilder(da);
            //    da.MissingSchemaAction =
            //           MissingSchemaAction.AddWithKey;

            //    //Fill the DataSet
            //    da.Fill(ds, tableName);

            //    //--- Insert row into Table
            //    DataRow row = ds.Tables[tableName].NewRow();
            //    row["first_name"] = "Patrick";
            //    row["last_name"] = "Bailey";
            //    ds.Tables[tableName].Rows.Add(row);
            //    da.Update(ds, tableName);

            //    //Close the Database Connection
            //    conn.Close();
            //    Debug.WriteLine("Data inserted into the Database");
            //}
            //catch (OleDbException exp)
            //{
            //    Debug.WriteLine(exp.Message.ToString());
            //}
            //finally
            //{
            //    if (conn.State == ConnectionState.Open)
            //    {
            //        conn.Close();
            //    }
            //}
        }

        public void connectDB()
        {
            SqlConnection connection;

            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                Debug.WriteLine("connected to DB");
                connection.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        #region security methods

        internal readonly static byte[] saltBytes = randomSalt();
        internal readonly static int salt_length = 32;
        internal readonly static int Keysize = 256;
        internal readonly static int DerivationIterations = 1000;

        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]

        public static extern bool ZeroMemory(IntPtr Destination, int Length);

        public static byte[] GenerateRandomSalt()
        {
            byte[] data = new byte[32];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
                for (int i = 0; i < 10; i++)
                    rng.GetBytes(data);

            return data;
        }

        private void FileEncrypt(string inputFile)
        {
            string password = "tDf^ss&%mllj57$#+3550Yhlz;.218QP@DL{}896#4p0uu";

            byte[] salt = GenerateRandomSalt();

            FileStream fsCrypt = new FileStream(inputFile + ".aes", FileMode.Create);

            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);

            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.PKCS7;

            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);

            AES.Mode = CipherMode.CFB;

            fsCrypt.Write(salt, 0, salt.Length);

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);

            FileStream fsIn = new FileStream(inputFile, FileMode.Open);

            byte[] buffer = new byte[1048576];
            int read;

            try
            {
                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                {
                    System.Windows.Forms.Application.DoEvents();
                    cs.Write(buffer, 0, read);
                }

                fsIn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                cs.Close();
                fsCrypt.Close();
                File.Delete(inputFile);
            }
        }

        public void FileDecrypt(string inputFile, string outputFile)
        {
            string password = "tDf^ss&%mllj57$#+3550Yhlz;.218QP@DL{}896#4p0uu";
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] salt = new byte[32];

            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);
            fsCrypt.Read(salt, 0, salt.Length);

            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Padding = PaddingMode.PKCS7;
            AES.Mode = CipherMode.CFB;

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);

            FileStream fsOut = new FileStream(outputFile, FileMode.Create);

            int read;
            byte[] buffer = new byte[1048576];

            try
            {
                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    System.Windows.Forms.Application.DoEvents();
                    fsOut.Write(buffer, 0, read);
                }
            }
            catch (CryptographicException ex_CryptographicException)
            {
                Console.WriteLine("CryptographicException error: " + ex_CryptographicException.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                cs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error by closing CryptoStream: " + ex.Message);
            }
            finally
            {
                fsOut.Close();
                fsCrypt.Close();
            }
        }

        internal static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }

        internal static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }
                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }

        internal static string Encrypt(string plainText)
        {
            string pass = "tDf^ss&%mllj57$#+3550Yhlz;.218QP@DL{}896#4p0uu";
            var saltStringBytes = Generate256BitsOfRandomEntropy();
            var ivStringBytes = Generate256BitsOfRandomEntropy();
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using (var password = new Rfc2898DeriveBytes(pass, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                var cipherTextBytes = saltStringBytes;
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
        }

        internal static string Decrypt(string cipherText)
        {
            string pass = "tDf^ss&%mllj57$#+3550Yhlz;.218QP@DL{}896#4p0uu";
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

            using (var password = new Rfc2898DeriveBytes(pass, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream(cipherTextBytes))
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                var plainTextBytes = new byte[cipherTextBytes.Length];
                                var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                            }
                        }
                    }
                }
            }
        }

        internal static byte[] Generate256BitsOfRandomEntropy()
        {
            var randomBytes = new byte[32];
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }

        internal static byte[] randomSalt()
        {
            Random r = new Random();
            byte[] by = new byte[32];
            for (int i = 0; i < (32); i++)
            {
                by[i] = Convert.ToByte(r.Next(255));
            }
            return by;
        }

        #endregion


    }
}
