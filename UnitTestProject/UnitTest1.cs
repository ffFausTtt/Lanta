using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LantaSystem;
using System.Linq;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NotAvtoriseLogin()
        {
            var user = DataBase.BaseModel.User.FirstOrDefault(x => x.Login_User == "" && x.Password_User == "pas1");
            Assert.IsNull(user);
        }

        [TestMethod]
        public void Avtorise()
        {
            var user = DataBase.BaseModel.User.FirstOrDefault(x => x.Login_User == "log1" && x.Password_User == "pas1");
            Assert.IsNotNull(user);
        }

        [TestMethod]
        public void NotAvtorisePassword()
        {
            var user = DataBase.BaseModel.User.FirstOrDefault(x => x.Login_User == "log1" && x.Password_User == "");
            Assert.IsNull(user);
        }

        [TestMethod]
        public void NotAvtorise()
        {
            var user = DataBase.BaseModel.User.FirstOrDefault(x => x.Login_User == "" && x.Password_User == "");
            Assert.IsNull(user);
        }

        [TestMethod]
        public void CreateAccount()
        {
            var user = DataBase.BaseModel.User.Add(new User
            {
                Surname_User = "Иванов",
                Name_User = "Иван",
                Login_User = "log4",
                Password_User = "pas4",
                Phone_User = "89677108688",
                Address_User = "Нижний Новгород"
            });
            Assert.IsNotNull(user);
        }

        [TestMethod]
        public void NotCreateAccount()
        {
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<SystemException>(() =>

                DataBase.BaseModel.User.Add(new User
                {
                    Surname_User = "",
                    Name_User = "",
                    Login_User = "",
                    Password_User = "",
                    Phone_User = "",
                    Address_User = "",
                    ID_User = 1,
                    ID_Role = 5
                })
            ));
        }
    }
}
