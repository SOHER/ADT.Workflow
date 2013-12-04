using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

using ADT.Workflow.Web.Models;

namespace ADT.Workflow.Web.Models.Tests
{
    /// <summary>
    /// L'attribut [TestFixture] indique au framework
    /// NUnit que cette classe contient des tests 
    /// unitaires à faire tourner.
    /// Inclut les test de ctor ROLE, FUNCTION, TEAM
    /// /// </summary>
    [TestFixture]
    public class Test_Person
    {


        private PERSON _p;
        private FUNCTION _f;
        private ROLE _r;
        private TEAM _t;

        /// <summary>
        /// L'attribut [SetUp] de NUnit indique que la méthode 
        /// (qui doit elle aussi être nommée "SetUp"), va être
        /// exécutée AVANT chaque méthode décorée avec l'attribut [Test]
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            _f = new FUNCTION();
            //_f.FUNCTION_ID = 11;
            _f.FUNCTION_LABEL = "Directeur";

            _r = new ROLE();
            //_r.ROLE_ID = 12;
            _r.ROLE_LABEL = "Valideur";

            _t = new TEAM();
            //_t.TEAM_ID = 13;
            _t.TEAM_LABEL = "ADTMedia";

            _p = new PERSON()
                     {
                         NAME = "Dufour",
                         FIRSTNAME = "Jean",
                         FUNCTION_ID = _f.FUNCTION_ID,
                         ROLE_ID = _r.ROLE_ID,
                         TEAM_ID = _t.TEAM_ID 
                     }
                ;

            
        }

        /// <summary>
        /// L'attribut [TearDown] de NUnit indique que la méthode 
        /// (qui doit elle aussi être nommée "TearDown"), va être
        /// exécutée APRES chaque méthode décorée avec l'attribut [Test]
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            _p = null;
        }

        [Test]
        public void Test_Constructor_Person()
        {
            



            Assert.IsInstanceOf<PERSON>(_p);

        }

        [Test]
        public void Test_Constructor_Function()
        {




            Assert.IsInstanceOf <FUNCTION> (_f);

        }

        [Test]
        public void Test_Constructor_Role()
        {




            Assert.IsInstanceOf<ROLE>(_r);

        }

        [Test]
        public void Test_Constructor_Team()
        {




            Assert.IsInstanceOf<TEAM >(_t);

        }



    }
}
