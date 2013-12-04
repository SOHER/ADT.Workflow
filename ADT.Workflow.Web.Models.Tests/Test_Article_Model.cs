using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

using ADT.Workflow.Web.Models;

namespace ADT.Workflow.Web.Models.Tests
{
        [TestFixture]
    class Test_Article_Model
        {
            private ARTICLE _a;
            [SetUp]
            public void SetUp()
            {

                _a = new ARTICLE()
                         {
                             ANGLE = "none",
                             ARTICLE_NBR = 1587,
                             AUTHOR = "Dufour",
                             CHAPO = "none",
                             DESCRIPTION = "Descritpion test",
                             SOURCES = "none",
                             TITLE = "Article test",
                             
                             
                         };

            }




        }
}
