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
            //Patron triple A
            //Arrange
            this.persona = new Person("","");
        }
        [Test]
        //Se testea que sucede cuando al contructor se le pasan strings vacios "" 
        public void ConstructorNombreVacio()
        {
            Assert.AreEqual(this.persona.Name,null);
        }
        public void ConstructorIdVacio()
        {
            Assert.AreEqual(this.persona.ID,null);
        }
        [Test]
        //Se testea la asignacion de null
        public void NameNull()
        {
            //Arragne

            //Act: llamar a lo que queremos probar (metodo, propiedad)
            this.persona.Name = null;
            //Assert
            Assert.AreEqual(persona.Name,"");
        }

    }
}