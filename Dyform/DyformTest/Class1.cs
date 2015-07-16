﻿using System;
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

            Assert.AreEqual("Emilie/Lol", a.uniqueName);
            Assert.AreEqual("John/Doe", c.uniqueName);

        }

        [Test]
        public void CreateQuestionFolder()
        {
            Form f=new Form();
            f.Questions.Title = "HG67-Bis";
            Assert.AreEqual("HG67-Bis",f.Title);
            QuestionBase q1 = f.Questions.AddNewQuestion(typeof(CompositeQuestion));
            QuestionBase q2 = f.Questions.AddNewQuestion(typeof(CompositeQuestion));
            Assert.AreEqual(0,q1.Index);
            Assert.AreEqual(1, q2.Index);
            q2.Index = 0;
            Assert.AreEqual(0,q2.Index);
            Assert.AreEqual(1, q1.Index);
            q2.Parent = null;
            Assert.AreEqual(0,q1.Index);
            q2.Parent = q1;
            Assert.IsTrue(f.Questions.Countains(q1));
            Assert.IsTrue(f.Questions.Countains(q2));
                

        }

        [Test]
        public void LaTotale()
        {
            Form f = new Form();

            OpenQuestion qOpen = (OpenQuestion)f.Questions.AddNewQuestion(typeof(OpenQuestion));
            qOpen.Title = "First question in the world!";
            qOpen.AllowEmptyAnswer = false;

            FormAnswer a = f.FindOrCreateAnswer("Emilie", "Lol");
            AnswerBase theAnswerOfEmilieToQOpen = a.FindAnswer(qOpen);
            if(theAnswerOfEmilieToQOpen == null)
            {
                theAnswerOfEmilieToQOpen = a.AddAnswerFor(qOpen);
            }
            Assert.IsInstanceOf(typeof(OpenAnswer), theAnswerOfEmilieToQOpen);

            OpenAnswer emilieAnswer = (OpenAnswer)theAnswerOfEmilieToQOpen;
            emilieAnswer.openLabel = "I'm very happy tobe there";
        }
    }

 
}
