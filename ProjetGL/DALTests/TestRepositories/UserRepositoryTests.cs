using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using DAL.Repositories;

namespace DALTests
{
    [TestClass]
    public class UserRepositoryTests
    {
        [TestInitialize()]
        public void Initialyse()
        {
            TestRepository.ClearSession();
            TestRepository.ResetBDD();
        }
        [TestMethod]
        public void UserGetAllTest()
        {
            var userRepository = new UserRepository();
            var allUsers = userRepository.GetAll();
            Assert.AreEqual(3, allUsers.Count);
            string actualUsers = "";
            foreach (User aa in allUsers) 
            {
                actualUsers+=aa.ToString()+", ";
            }
            string expectedUsers = "Martin Devreese, Tangi Maneux, Toto Lambda, ";
            Assert.AreEqual(actualUsers, expectedUsers);
        }
        [TestMethod]
        public void GetUserTest()
        {
            var userRepository = new UserRepository();
            var user = userRepository.GetUser("mdevreese@ensc.fr", "f4f263e439cf40925e6a412387a9472a6773c2580212a4fb50d224d3a817de17");
            var actualUser = user.ToString();
            var expectedUser = "Martin Devreese";
            Assert.AreEqual(actualUser, expectedUser);
        }
        [TestMethod]
        public void SaveUserTest()
        {
            var userRepository = new UserRepository();
            var newUser = new User("Mathew", "Bold", "mbold@ensc.fr", 0, "f4f263e439cf40925e6a412387a9472a6773c2580212a4fb50d224d3a817de17");
            userRepository.Save(newUser);
            var user = userRepository.GetUser("mbold@ensc.fr", "f4f263e439cf40925e6a412387a9472a6773c2580212a4fb50d224d3a817de17");
            var actualUser = user.ToString();
            var expectedUser = "Mathew Bold";
            Assert.AreEqual(actualUser, expectedUser);
        }
    }
}
