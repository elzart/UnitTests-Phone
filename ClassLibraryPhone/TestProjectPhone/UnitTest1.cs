using ClassLibrary;

namespace TestProjectPhone
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Konstruktor_Dane_Poprawne_OK()
        {
            // AAA

            // Arrange
            var wlasciciel = "Torbicz";
            var numer = "123456789";


            // Act
            var telefon = new Phone(wlasciciel, numer);

            // Assert
            Assert.AreEqual(wlasciciel, telefon.Owner);

        }

        [TestMethod]
        public void Konstruktor_ZaKrotkiNumerTelefonu_ArgumentException()
        {
            // Arrange
            var wlasciciel = "Torbicz";
            var numer = "12345678";

            // Act
            // Assert
            Assert.ThrowsException<ArgumentException>(() => new Phone(wlasciciel, numer));



        }
    }
}