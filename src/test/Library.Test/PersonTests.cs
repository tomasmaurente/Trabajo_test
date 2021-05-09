using NUnit.Framework;
using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        // private Person personaCamposNull;
        private Person personaCamposVacios;
        private Person personaCamposValidos;

        [SetUp]
        public void Setup()
        {
            // Patron triple A.
            // Arrange.

            // this.personaCamposNull = new Person(null,null);

            this.personaCamposVacios = new Person("", "");
            Person person = new Person("Matias", "49105887");
            this.personaCamposValidos = person;
        }

/*
        // Se testea que sucede cuando al contructor se le pasa un null en el campo Name.
        [Test]
        public void BuildWithNullName()
        {
            Assert.AreEqual(this.personaCamposNull.Name,null);
        }

        // Se testea que sucede cuando al contructor se le pasa un null en el campo ID.
        [Test]
        public void BuildWithNullID()
        {
            Assert.AreEqual(this.personaCamposNull.ID,null);
        }
*/

        // Se testea que sucede cuando al contructor se le pasa un string vacio en el campo Name.
        [Test]
        public void BuildWithEmptyName()
        {
            // No deberia aceptarse el valor "" en el campo Nombre, y deberia ser null como cuando se crea la variable personaCamposVacios.Name.
            Assert.AreEqual(this.personaCamposVacios.Name, null);
        }

        // Se testea que sucede cuando al contructor se le pasa un string vacio en el campo ID.
        [Test]
        public void BuildWithEmptyID()
        {
            // No deberia aceptarse el valor "" en el campo ID, y deberia ser null como cuando se crea la variable personaCamposVacios.ID.
            Assert.AreEqual(this.personaCamposVacios.ID, null);
        }

        // Se testea que sucede cuando al contructor se le pasa un string valido en el campo Name.
        [Test]
        public void BuildWithValidName()
        {
            Assert.AreEqual(this.personaCamposValidos.Name, "Matias");
        }

        // Se testea que sucede cuando al contructor se le pasa un string valido en el campo ID.
        [Test]
        public void BuildWithValidID()
        {
            Assert.AreEqual(this.personaCamposValidos.ID, "49105887");
        }





/*
        // Se testea la asignacion de null mediante set del campo Name.
        [Test]
        public void NameSetedNull()
        {
            string expectedName = personaCamposValidos.Name;
            // Act.
            this.personaCamposValidos.Name = null;
            // Assert.
            // Cuando se setea una variable con null, esta asignacion deberia ser ignorada, manteniendo el valor original.
            Assert.AreEqual(this.personaCamposValidos.Name, expectedName);
        }

        // Se testea la asignacion de null mediante set del campo ID.
        [Test]
        public void IDSetedNull()
        {
            string expectedID = personaCamposValidos.ID;
            // Act.
            this.personaCamposValidos.ID = null;
            // Assert.
            // Cuando se setea una variable con null, esta asignacion deberia ser ignorada, manteniendo el valor original.
            Assert.AreEqual(this.personaCamposValidos.ID, expectedID);
        }
*/
        // Se testea la asignacion de un string vacio mediante set del campo Name.
        [Test]
        public void NameSetedEmpty()
        {
            string expectedName = personaCamposValidos.Name;
            // Act.
            this.personaCamposValidos.Name = "";
            // Assert.
            // Cuando se setea una variable con null, esta asignacion deberia ser ignorada, manteniendo el valor original.
            Assert.AreEqual(this.personaCamposValidos.Name, expectedName);
        }

        // Se testea la asignacion de un string vacio mediante set del campo ID.
        [Test]
        public void IDSetedEmpty()
        {
            string expectedID = personaCamposValidos.ID;
            // Act.
            this.personaCamposValidos.ID = "";
            // Assert.
            Assert.AreEqual(this.personaCamposValidos.ID, expectedID);
        }



    }
}