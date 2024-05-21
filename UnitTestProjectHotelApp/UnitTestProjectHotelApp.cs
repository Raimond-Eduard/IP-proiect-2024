using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HotelManagement.Tests
{
    [TestClass]//3 teste de logare
    public class LoginTests
    {
        private LoginService _loginService;

        [TestInitialize]
        public void Setup()
        {
            // Inițializăm serviciul de logare (presupunem că există o clasă LoginService în proiectul principal)
            _loginService = new LoginService();
        }

        [TestMethod]
        public void Login_WithValidCredentials_ShouldReturnTrue()
        {
            // Arrange
            string username = "admin";
            string password = "admin";

            // Act
            bool result = _loginService.Login(username, password);

            // Assert
            Assert.IsTrue(result, "Logarea ar trebui să fie reușită cu credențialele corecte.");
        }

        [TestMethod]
        public void Login_WithInvalidUsername_ShouldReturnFalse()
        {
            // Arrange
            string username = "invalid";
            string password = "admin";

            // Act
            bool result = _loginService.Login(username, password);

            // Assert
            Assert.IsFalse(result, "Logarea nu ar trebui să fie reușită cu un username invalid.");
        }

        [TestMethod]
        public void Login_WithInvalidPassword_ShouldReturnFalse()
        {
            // Arrange
            string username = "admin";
            string password = "invalid";

            // Act
            bool result = _loginService.Login(username, password);

            // Assert
            Assert.IsFalse(result, "Logarea nu ar trebui să fie reușită cu o parolă invalidă.");
        }
    }

    // Exemplu de implementare a clasei LoginService (acesta ar trebui să fie în proiectul principal)
    public class LoginService
    {
        private const string CorrectUsername = "admin";
        private const string CorrectPassword = "admin";

        public bool Login(string username, string password)
        {
            return username == CorrectUsername && password == CorrectPassword;
        }
    }
    [TestClass]//4 teste de inregistrare
    public class SignupTests
    {
        private RegistrationService _registrationService;

        [TestInitialize]
        public void Setup()
        {
            // Inițializăm serviciul de înregistrare (presupunem că există o clasă RegistrationService în proiectul principal)
            _registrationService = new RegistrationService();
        }

        [TestMethod]
        public void Signup_WithValidData_ShouldReturnSuccessMessage()
        {
            // Arrange
            string username = "jamal";
            string password = "1234";
            string lastName = "Guriuc";
            string firstName = "Vlad";
            string phone = "0787654321";
            string email = "jami@yahoo.com";
            DateTime birthDate = new DateTime(2002, 1, 1);

            // Act
            string result = _registrationService.Signup(username, password, lastName, firstName, phone, email, birthDate);

            // Assert
            Assert.AreEqual("Inregistrare reusita!", result, "Mesajul de succes pentru înregistrare nu este corect.");
        }

        [TestMethod]
        public void Signup_WithInvalidPhoneNumber_ShouldReturnErrorMessage()
        {
            // Arrange
            string username = "jamal";
            string password = "1234";
            string lastName = "Guriuc";
            string firstName = "Vlad";
            string phone = "invalid_phone"; // Număr de telefon incorect
            string email = "jami@yahoo.com";
            DateTime birthDate = new DateTime(2002, 1, 1);

            // Act
            string result = _registrationService.Signup(username, password, lastName, firstName, phone, email, birthDate);

            // Assert
            Assert.AreEqual("Numar de telefon invalid!", result, "Mesajul de eroare pentru numărul de telefon.");
        }

        public void Signup_WithInvalidEmail_ShouldReturnErrorMessage()
        {
            // Arrange
            string username = "jamal";
            string password = "1234";
            string lastName = "Guriuc";
            string firstName = "Vlad";
            string phone = "0787654321";
            string email = "jami"; //email incorect
            DateTime birthDate = new DateTime(2002, 1, 1);

            // Act
            string result = _registrationService.Signup(username, password, lastName, firstName, phone, email, birthDate);

            // Assert
            Assert.AreEqual("Numar de telefon invalid!", result, "Mesajul de eroare pentru numărul de telefon.");
        }

        public void Signup_WithInvalidAge_ShouldReturnErrorMessage()
        {
            // Arrange
            string username = "jamal";
            string password = "1234";
            string lastName = "Guriuc";
            string firstName = "Vlad";
            string phone = "0787654321";
            string email = "jami"; //email incorect
            DateTime birthDate = new DateTime(2009, 1, 1);

            // Act
            string result = _registrationService.Signup(username, password, lastName, firstName, phone, email, birthDate);

            // Assert
            Assert.AreEqual("Data de nastere invalida!", result, "Mesajul de eroare pentru data de nastere.");
        }
    }

    // Exemplu de implementare a clasei RegistrationService (aceasta ar trebui să fie în proiectul principal)
    public class RegistrationService
    {
        public string Signup(string username, string password, string lastName, string firstName, string phone, string email, DateTime birthDate)
        {
            // Verificare simplificată a numărului de telefon
            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{10}$"))
            {
                return "Numar de telefon invalid!";
            }
            //IMPLEMENTARE IF CU VALIDARE EMAIL

            DateTime currentYear = DateTime.Now;
            if (currentYear.Year-birthDate.Year < 18)
            {
                return "Data de nastere invalida";
            }

            // Logică simplificată de înregistrare
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) &&
                !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(firstName) &&
                !string.IsNullOrEmpty(phone) && !string.IsNullOrEmpty(email) && birthDate != default)
            {
                // Aici ar trebui să adăugăm logica de înregistrare în baza de date sau în sistem
                return "Inregistrare reusita!";
            }
            else
            {
                return "Inregistrare esuata!";
            }
        }
    }
}
