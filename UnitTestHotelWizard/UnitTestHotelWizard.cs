using Microsoft.VisualStudio.TestTools.UnitTesting;
using proiect_2024.interfaces;
using proiect_2024.strategies;
using System;

namespace UnitTestHotelWizard
{
    [TestClass]
    public class UnitTestHotelWizard
    {
        /// <summary>
        /// Metoda de testare pentru scriptul de hash
        /// Cuvantul de hash este IP2024
        /// Metoda apartine fisierului Helpers.dll
        /// </summary>
        [TestMethod]
        public void HashCheck()
        {
            Assert.AreEqual("c910384c4455ffe36e76fd32a03aa3c7eee9c23f58e02804445fec2da6c8bb48",
                Helpers.HashHelper.GetSHA256hash("IP2024"));

        }
        /// <summary>
        /// Metoda de calcul al varstei
        /// Metoda apartine fisierului Helpers.dll
        /// </summary>
        [TestMethod]
        public void AgeCalculation()
        {
            Assert.AreEqual(21,
                Helpers.AgeCalculatorHelper.calculateAge(DateTime.Parse("2002-09-21")));
        }

        /// <summary>
        /// Sir de metode de verificare valabilate dati
        /// Metoda apartine fisierului Helpers.dll
        /// </summary>
        [TestMethod]
        //Folosim data "21-09-2027" si intervalul "06-09-2027" & "23-09-2027"
        public void DateAvailable()
        {
            Assert.IsTrue(Helpers.StopUnavailableDates.validateCheckInCheckOut(
                DateTime.Parse("2027-09-21"), DateTime.Parse("2027-09-06"),
                DateTime.Parse("2027-09-23")));
        }
        /// <summary>
        /// Verificam daca un interval de date care se afla in interiorul altui interval
        /// sau invers este valid sau nu
        /// </summary>
        [TestMethod]
        public void DateIntervalAvailable()
        {
            Assert.IsTrue(Helpers.StopUnavailableDates.validateSmallerLargerInterval(
                DateTime.Parse("2025-08-07"), DateTime.Parse("2025-08-11"),
                DateTime.Parse("2025-08-02"), DateTime.Parse("2025-08-12")));
        }

        /// <summary>
        /// Verificam daca data nasterii introdusa este varsta de major
        /// </summary>
        [TestMethod]
        public void AgeValidationCheck_Over_18()
        {
            IStrategy test = new ValidateAgeStrategy();
            Assert.IsTrue(test.Check("2002-09-21"));
        }
        [TestMethod]
        //Verificare caz de varsta mai mic de 18 ani
        public void AgeValidationCheck_Under_18()
        {
            IStrategy test = new ValidateAgeStrategy();
            Assert.IsFalse(test.Check("2008-10-07"));
        }

        [TestMethod]
        public void InValid_AgeValidationCheck_Under_18()
        {
            IStrategy test = new ValidateAgeStrategy();
            Assert.IsFalse(test.Check("2010-100"));
        }

        /// <summary>
        /// Validare email, format corect
        /// </summary>
        [TestMethod]
        public void EmailValidationCheck_CorrectForamt()
        {
            IStrategy test = new ValidateEmailStrategy();
            Assert.IsTrue(test.Check("raimond.butnaru21@gmail.com"));
        }

        [TestMethod]
        public void EmailValidateCheck_CorrectFormat2()
        {
            IStrategy test = new ValidateEmailStrategy();
            Assert.IsTrue(test.Check("jamal_africanu@yahoo.com"));
        }

        [TestMethod]
        public void EmailValidateCheck_CorrectFormat3()
        {
            IStrategy test = new ValidateEmailStrategy();
            Assert.IsTrue(test.Check("marin.puscasu@student.tuiasi.ro"));
        }

        [TestMethod]
        public void EmailValidateCheck_WrongFormat()
        {
            IStrategy test = new ValidateEmailStrategy();
            Assert.IsFalse(test.Check("un.email.invalid"));
        }

        [TestMethod]
        public void EmailValidateCheck_InvalidFormat2() 
        {
            IStrategy test = new ValidateEmailStrategy();
            Assert.IsFalse(test.Check("un.alt.email-invalid"));
        }

        /// <summary>
        /// Verificare numere de telefon.
        /// Un numar de telefon trebuie sa contina doar cifre
        /// Prezenta literelor, spatiilor sau altor caractere diferite de cifre
        /// nu este permisa
        /// </summary>
        
        //Cazuri numere bune
        [TestMethod]
        public void PhoneNumberValidation_CorrectFormat1()
        {
            IStrategy test = new ValidatePhoneStrategy();
            Assert.IsTrue(test.Check("0758387068"));
        }

        [TestMethod]
        public void PhoneNumberValidation_CorrectFormat2()
        {
            IStrategy test = new ValidatePhoneStrategy();
            Assert.IsTrue(test.Check("0234266077"));
        }
        //String-uri cu metode invalide

        [TestMethod]
        public void PhoneNumberValidation_IncorrectFormat1()
        {
            IStrategy test = new ValidatePhoneStrategy();
            Assert.IsFalse(test.Check("numar de telefon"));
        }

        [TestMethod]
        public void PhoneNumberValidation_IncorrectFormat2()
        {
            IStrategy test = new ValidatePhoneStrategy();
            Assert.IsFalse(test.Check("07 n-am cartela"));
        }

        [TestMethod]
        public void PhoneNumberValidation_IncorrectFormat3()
        {
            IStrategy test = new ValidatePhoneStrategy();
            Assert.IsTrue(test.Check(" "));
        }
        /// <summary>
        /// Validare username sa nu contina spatii
        /// </summary>
        [TestMethod]
        public void UsernameValidation_CorrectFormat1()
        {
            IStrategy test = new ValidateUsernameStrategy();
            Assert.IsTrue(test.Check("UnUsernameOarecareDarValid"));
        }

        [TestMethod]
        public void UsernameValidation_CorrectFormat2()
        {
            IStrategy test = new ValidateUsernameStrategy();
            Assert.IsTrue(test.Check("ProgramatorulNotoriu69"));
        }

        [TestMethod]
        public void UsernameValidation_CorrectFormat3()
        {
            IStrategy test = new ValidateUsernameStrategy();
            Assert.IsTrue(test.Check("User1"));
        }

        //Variante invalide

        [TestMethod]
        public void UsernameValidation_IncorrectFormat1()
        {
            IStrategy test = new ValidateUsernameStrategy();
            Assert.IsFalse(test.Check("Nume de utilizator"));
        }

        [TestMethod]
        public void UsernameValidation_IncorrectFormat2()
        {
            IStrategy test = new ValidateUsernameStrategy();
            Assert.IsFalse(test.Check("Vladut Guriuc"));
        }

        [TestMethod]
        public void UsernameValidation_IncorrectFormat3()
        {
            IStrategy test = new ValidateUsernameStrategy();
            Assert.IsFalse(test.Check(" "));
        }
    }
}
