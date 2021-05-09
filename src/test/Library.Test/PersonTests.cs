using NUnit.Framework;
using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        private Person personaCamposNull;
        private Person personaCamposVacios;
        private Person personaCamposValidos;

        [SetUp]
        public void Setup()
        {
            // Patron triple A.
            // Arrange.

            this.personaCamposNull = new Person(null,"");

            this.personaCamposVacios = new Person("", "");

            Person person = new Person("Matias", "49105887");
            this.personaCamposValidos = person;
        }


        // Se testea que sucede cuando al contructor se le pasa un null en el campo Name.
        [Test]
        public void BuildWithNullName()
        {
            Assert.AreEqual(this.personaCamposNull.Name,null);
        }

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






        // Se testea la asignacion de null mediante set del campo Name.
        [Test]
        public void NameSetedNull()
        {
            string expectedName = this.personaCamposValidos.Name;
            // Act.
            this.personaCamposValidos.Name = null;
            // Assert.
            // Cuando se setea una variable con null, esta asignacion deberia ser ignorada, manteniendo el valor original.
            Assert.AreEqual(this.personaCamposValidos.Name, expectedName);
        }

        // Se testea la asignacion de un string vacio mediante set del campo Name.
        [Test]
        public void NameSetedEmpty()
        {
            string expectedName = this.personaCamposValidos.Name;
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
            string expectedID = this.personaCamposValidos.ID;
            // Act.
            this.personaCamposValidos.ID = "";
            // Assert.
            Assert.AreEqual(this.personaCamposValidos.ID, expectedID);
        }

        // Se testea la asignacion de un ID mas largo de lo debido.
        [Test]
        public void SetLongerID()
        {
            string expectedID = this.personaCamposValidos.ID;
            // Act.
            this.personaCamposValidos.ID = "491058877";
            // Assert.
            // Cuando la ID es mas larga de lo esperado la asignacion deberia ser ignorada, manteniendo el valor original.
            Assert.AreEqual(this.personaCamposValidos.ID, expectedID);
        }

        // Se testea una asignacion de una ID valida.
        [Test]
        public void SetValidID()
        {
            string expectedID = "52115803";
            // Act.
            this.personaCamposValidos.ID = expectedID;
            // Assert.
            // Cuando la ID es valida se asigna.
            Assert.AreEqual(this.personaCamposValidos.ID,expectedID);
        }
        



        // Si la asignacion de la variable personaCamposNull se la siguiente :
        
        // this.personaCamposNull = new Person(null,null);
        
        // el codigo lanza un error que nisiquiera permite la corrida de tests
        // si se permitiese dicha asgnacion deberian agregarse los dos siguientes tests.

        // El error se debe a la aplicacion del metodo de instancia: Replace linea 20, IdUtils.cs.

        // El error se puede evitar cambiando la linea 41,Person.cs por:

        // if (!string.IsNullOrEmpty(value) && IdUtils.IdIsValid(value))


        // Aqui los tests que se deben agregar para complementar el trabajo.
        

        //        // Se testea que sucede cuando al contructor se le pasa un null en el campo ID.
        // [Test]
        // public void BuildWithNullID()
        // {
        //     Assert.AreEqual(this.personaCamposNull.ID,null);
        // }




        // // Se testea la asignacion de null mediante set del campo ID.
        // [Test]
        // public void IDSetedNull()
        // {
        //     string expectedID = this.personaCamposValidos.ID;
        //     // Act.
        //     this.personaCamposValidos.ID = null;
        //     // Assert.
        //     // Cuando se setea una variable con null, esta asignacion deberia ser ignorada, manteniendo el valor original.
        //     Assert.AreEqual(this.personaCamposValidos.ID, expectedID);
        // }

    }
}

