using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Dyform;

namespace DyformTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void CreateAnswers()
        {
            Form f = new Form();
            Assert.IsNull(f.Title);
            f.Title = "jj";
            Assert.AreEqual("jj", f.Title);

            FormAnswer a = f.FindOrCreateAnswer("Emilie", "Lol");
            Assert.IsNotNull(a);
            FormAnswer b = f.FindOrCreateAnswer("Emilie", "Lol");
            Assert.AreSame(a, b);

            Assert.AreEqual(1, f.AnswerCount);
            FormAnswer c = f.FindOrCreateAnswer("John", "Doe");
            Assert.AreNotSame(a, c);

            Assert.AreEqual("Emilie", a.uniqueName);
            Assert.AreEqual("John", c.uniqueName);

        }
    }
}
