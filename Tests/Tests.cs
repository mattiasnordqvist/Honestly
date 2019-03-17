using System;
using NUnit.Framework;

namespace HonestNamespace
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestHonestTrueBool()
        {
            var sut = Honestly.True;
            Assert.IsTrue(sut);
        }

        [Test]
        public void TestHonestFalseBool()
        {
            var sut = Honestly.False;
            Assert.IsFalse(sut);
        }

        [Test]
        public void TestHonestUnknownBool()
        {
            var sut = Honestly.DontKnow;
            Assert.Throws<InvalidOperationException>(() => { sut = !sut; });
        }


        [Test]
        public void TestHonestNullBool()
        {
            var sut = Honestly.Null;
            Assert.IsNull(sut);
        }

        [Test]
        public void TestHonestTrueBoolComparisons()
        {
            var sut = Honestly.True;
            var sut2 = Honestly.True;
            Assert.IsTrue(sut && sut2);
        }

        [Test]
        public void TestHonestTrueFalseBoolComparisons()
        {
            var sut = Honestly.True;
            var sut2 = Honestly.False;
            Assert.IsFalse(sut && sut2);
        }

        [Test]
        public void TestHonestDontKnowBoolComparisons()
        {
            var sut = Honestly.DontKnow;
            var sut2 = Honestly.False;
            Assert.Throws<InvalidOperationException>(() => { bool a = sut && sut2; });
        }

        [Test]
        public void TestHonestDoubleDontKnowBoolComparisons()
        {
            var sut = Honestly.DontKnow;
            var sut2 = Honestly.DontKnow;
            Assert.Throws<InvalidOperationException>(() => { bool a = sut && sut2; });
        }

        [Test]
        public void TestHonestNullBoolComparisons()
        {
            var sut = Honestly.Null;
            var sut2 = Honestly.DontKnow;
            Assert.Throws<NullReferenceException>(() => { bool a = sut && sut2; });
        }

        [Test]
        public void TestHonestNullBoolComparisons2()
        {
            var sut = Honestly.Null;
            var sut2 = Honestly.DontKnow;
            Assert.Throws<InvalidOperationException>(() => { bool a = sut2 && sut; });
        }

        [Test]
        public void TestHonestStringWithValue()
        {
            Honest<string> sut = "Hello";
            Assert.IsTrue(sut == "Hello");
            Assert.AreEqual(sut, "Hello");
        }

        [Test]
        public void TestHonestUnknownString()
        {
            Assert.Throws<InvalidOperationException>(() => { string sut = Honest<string>.DontKnow(); });
        }


        [Test]
        public void TestHonestNullString()
        {
            string sut = new Honest<string>(null);
            Assert.IsNull(sut);
        }
    }
}
