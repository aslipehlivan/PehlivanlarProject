using Pehlivanlar.Data;
using Pehlivanlar.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Pehlivanlar.Service
{
    public class PehUserService
    {
        private PehlivanlarDb db;
        public PehUserService()
        {
            db = new PehlivanlarDb();
        }
        public PehUser Login (string UserName, string Password)
        {
            string hashedPasword = hashPassword(Password);
            var loginUser = db.PehUsers.FirstOrDefault(u => u.UserName == UserName && u.Password == hashedPasword);

            return loginUser;
        }
        public bool CheckPassword(PehUser user, string password)
        {
            return user.Password == hashPassword(password);
        }

        public void ChangePassword(PehUser pehUser, string password)
        {
            var user = db.PehUsers.Find(pehUser.ID);
            user.Password = hashPassword(password);
            db.SaveChanges();
        }
        public string hashPassword (string plainPassword)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                var plainBytes = Encoding.UTF8.GetBytes(plainPassword);
                byte[] bytes = sha256Hash.ComputeHash(plainBytes);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++) {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public bool Insert (PehUser pehUser)
        {
            return true;
        }
    }
}
