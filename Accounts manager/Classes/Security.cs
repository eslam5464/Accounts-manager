using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.IO;
using Accounts_manager.Classes.Models;
using System.Reflection;

namespace Accounts_manager.Classes
{
    class Security
    {
        internal readonly static byte[] saltBytes = randomSalt();
        internal readonly static int salt_length = 8;
        internal readonly static int Keysize = 256;
        internal readonly static int DerivationIterations = 1000;

        internal static string PassKey = "";

        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]

        public static extern bool ZeroMemory(IntPtr Destination, int Length);

        public bool checkMasterKey(string MasterKey)
        {
            //string output = "Welcome to the DB";



            return false;
        }

        public static async Task<AccountModel> EncryptOneAccount(AccountModel account)
        {
            account.Answer = await Task.Run(() => Encrypt(account.Answer));
            account.DateCreated = await Task.Run(() => Encrypt(account.DateCreated));
            account.Email = await Task.Run(() => Encrypt(account.Email));
            account.OtherInfo = await Task.Run(() => Encrypt(account.OtherInfo));
            account.Password = await Task.Run(() => Encrypt(account.Password));
            account.Phone = await Task.Run(() => Encrypt(account.Phone));
            account.Question = await Task.Run(() => Encrypt(account.Question));
            account.SiteName = await Task.Run(() => Encrypt(account.SiteName));
            account.Username = await Task.Run(() => Encrypt(account.Username));

            return account;
        }

        public static async Task<List<AccountModel>> EncryptAccounts(List<AccountModel> accounts)
        {
            if (accounts.Count > 0)
                foreach (AccountModel account in accounts)
                {
                    account.Answer = await Task.Run(() => Encrypt(account.Answer));
                    account.DateCreated = await Task.Run(() => Encrypt(account.DateCreated));
                    account.Email = await Task.Run(() => Encrypt(account.Email));
                    account.OtherInfo = await Task.Run(() => Encrypt(account.OtherInfo));
                    account.Password = await Task.Run(() => Encrypt(account.Password));
                    account.Phone = await Task.Run(() => Encrypt(account.Phone));
                    account.Question = await Task.Run(() => Encrypt(account.Question));
                    account.SiteName = await Task.Run(() => Encrypt(account.SiteName));
                    account.Username = await Task.Run(() => Encrypt(account.Username));
                }
            return accounts;
        }

        public static async Task<AccountModel> DecryptOneAccount(AccountModel account)
        {
            account.Answer = await Task.Run(() => Decrypt(account.Answer));
            account.DateCreated = await Task.Run(() => Decrypt(account.DateCreated));
            account.Email = await Task.Run(() => Decrypt(account.Email));
            account.OtherInfo = await Task.Run(() => Decrypt(account.OtherInfo));
            account.Password = await Task.Run(() => Decrypt(account.Password));
            account.Phone = await Task.Run(() => Decrypt(account.Phone));
            account.Question = await Task.Run(() => Decrypt(account.Question));
            account.SiteName = await Task.Run(() => Decrypt(account.SiteName));
            account.Username = await Task.Run(() => Decrypt(account.Username));

            return account;
        }

        public static async Task<List<AccountModel>> DecryptAccounts(List<AccountModel> accounts)
        {
            if (accounts.Count > 0)
                foreach (AccountModel account in accounts)
                {
                    account.Answer = await Task.Run(() => Decrypt(account.Answer));
                    account.DateCreated = await Task.Run(() => Decrypt(account.DateCreated));
                    account.Email = await Task.Run(() => Decrypt(account.Email));
                    account.OtherInfo = await Task.Run(() => Decrypt(account.OtherInfo));
                    account.Password = await Task.Run(() => Decrypt(account.Password));
                    account.Phone = await Task.Run(() => Decrypt(account.Phone));
                    account.Question = await Task.Run(() => Decrypt(account.Question));
                    account.SiteName = await Task.Run(() => Decrypt(account.SiteName));
                    account.Username = await Task.Run(() => Decrypt(account.Username));
                }
            return accounts;
        }

        private async Task FileEncrypt(string inputFile)
        {
            byte[] salt = await Task.Run(() => GenerateRandomSalt());

            FileStream fsCrypt = new FileStream(inputFile + ".aes", FileMode.Create);

            byte[] passwordBytes = await Task.Run(() => System.Text.Encoding.UTF8.GetBytes(PassKey));

            RijndaelManaged AES = new RijndaelManaged
            {
                KeySize = 256,
                BlockSize = 128,
                Padding = PaddingMode.PKCS7
            };

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
                while ((read = await Task.Run(() => fsIn.Read(buffer, 0, buffer.Length))) > 0)
                {
                    System.Windows.Forms.Application.DoEvents();
                    await Task.Run(() => cs.Write(buffer, 0, read));
                }

                await Task.Run(() => fsIn.Close());
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

        public async Task FileDecrypt(string inputFile, string outputFile)
        {
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(PassKey);
            byte[] salt = new byte[32];

            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);
            await Task.Run(() => fsCrypt.Read(salt, 0, salt.Length));

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
                while ((read = await Task.Run(() => cs.Read(buffer, 0, buffer.Length))) > 0)
                {
                    await Task.Run(() => System.Windows.Forms.Application.DoEvents());
                    await Task.Run(() => fsOut.Write(buffer, 0, read));
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
            var saltStringBytes = Generate256BitsOfRandomEntropy();
            var ivStringBytes = Generate256BitsOfRandomEntropy();
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using (var password = new Rfc2898DeriveBytes(PassKey, saltStringBytes, DerivationIterations))
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
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

            using (var password = new Rfc2898DeriveBytes(PassKey, saltStringBytes, DerivationIterations))
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

        public static byte[] GenerateRandomSalt()
        {
            byte[] data = new byte[32];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
                for (int i = 0; i < 10; i++)
                    rng.GetBytes(data);

            return data;
        }
    }
}
