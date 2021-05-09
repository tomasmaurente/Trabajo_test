using NUnit.Framework;
using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        private Person persona;

        [SetUp]
        public void Setup()
        {
            // Patron triple A.
            // Arrange.
            this.persona = new Person("", "");
        }

        [Test]
        // Se testea que sucede cuando al contructor se le pasan strings vacios "". 
        public void ConstructorNombreVacio()
        {
            Assert.AreEqual(this.persona.Name, null);
        }

        [Test]
        public void ConstructorIdVacio()
        {
            Assert.AreEqual(this.persona.ID, null);
        }

        [Test]
        // Se testea la asignacion de null.
        public void NameNull()
        {
            // Act: llamar a lo que queremos probar (metodo, propiedad).
            this.persona.Name = null;
            //Assert
            Assert.AreEqual(null, persona.Name);
        }

        [Test]
        // Se testea que la cedula sea "null" si se ingresa con un formato incorrecto.
        // Encontramos que el programa no tiene en cuenta el formato de el Id.
        public void IdFormatoIncorrecto()
        {
            // Act.
            this.persona.ID = "52115803";
            // Assert.
            Assert.AreEqual(null, persona.ID);
        }

        [Test]
        // Se testea que la cedula sea "null" si se ingresa con numeros de más.
        public void IdNumeroInCorrecto()
        {
            // Act.
            this.persona.ID = "52115856803";
            // Assert.
            Assert.AreEqual(null, persona.ID);
        }
    }
}