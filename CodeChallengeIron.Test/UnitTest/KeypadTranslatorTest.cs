using CodeChallengeIron.Business;

namespace CodeChallegeIron.Test.UnitTest
{
    [TestClass]
    public class KeypadTranslatorTest
    {
        [TestMethod]
        public void NormalCase()
        {
            string input = "222#";
            string output = KeypadTranslator.OldPhonePad(input);
            Assert.AreEqual("C", output);
        }

        [TestMethod]
        public void SpacebarWithSameNumberCase()
        {
            string input = "222 2#";
            string output = KeypadTranslator.OldPhonePad(input);
            Assert.AreEqual("CA", output);
        }

        [TestMethod]
        public void SpacebarWithDifferentNumberCase()
        {
            string input = "222 3#";
            string output = KeypadTranslator.OldPhonePad(input);
            Assert.AreEqual("CD", output);
        }

        [TestMethod]
        public void BackspaceNormalCase()
        {
            string input = "2223*#";
            string output = KeypadTranslator.OldPhonePad(input);
            Assert.AreEqual("C", output);
        }

        [TestMethod]
        public void BackspaceWithSpacebarCase()
        {
            string input = "2223 *#";
            string output = KeypadTranslator.OldPhonePad(input);
            Assert.AreEqual("C", output);
        }

        [TestMethod]
        public void RealSpacebarWithSpacebarCase()
        {
            string input = "4433555 5556660966677755531#";
            string output = KeypadTranslator.OldPhonePad(input);
            Assert.AreEqual("HELLO WORLD!", output);
        }

        [TestMethod]
        public void TheLastCaseFromInstruction()
        {
            string input = "8 88777444666*664#";
            string output = KeypadTranslator.OldPhonePad(input);
            Assert.AreEqual("TURING", output);
        }
    }
}
