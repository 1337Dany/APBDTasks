using NUnit.Framework;
using LegacyApp;
using System;

namespace UserServiceTest
{
    public class Tests
    {
        private IUserService _userService;

        [SetUp]
        public void Setup()
        {
            _userService = new UserService();
        }

        [Test]
        public void AddUser_WithValidNormalClient_ShouldReturnTrue()
        {
            // Arrange
            string firstName = "John";
            string lastName = "Doe";
            string email = "john.doe@example.com";
            DateTime dateOfBirth = new DateTime(1990, 1, 1);
            int clientId = 1; // NormalClient

            // Act
            bool result = _userService.AddUser(firstName, lastName, email, dateOfBirth, clientId);

            // Assert
            Assert.IsTrue(result, "Should return true");
        }
    }
}