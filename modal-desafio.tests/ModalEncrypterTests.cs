using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace modal_desafio.tests
{
    [TestClass]
    public class ModalEncrypterTests
    {
        [TestMethod]
        public void GetNextWord_When_a_ShouldReturn_b()
        {
            var modalEncrypter = new ModalEncrypter();
            var nextWord = modalEncrypter.GetNextWord("a");
            Assert.AreEqual("b", nextWord);
        }

        [TestMethod]
        [Timeout(30000)]
        public void GetNextWord_When_zzzz_ShouldReturn_aaaaa()
        {
            var modalEncrypter = new ModalEncrypter();
            var nextWord = modalEncrypter.GetNextWord("zzzz");
            Assert.AreEqual("aaaaa", nextWord);
        }

        [TestMethod]
        public void Encrypt_When_a_ShouldReturn_1()
        {
            var modalEncrypter = new ModalEncrypter();
            var encryptionResult = modalEncrypter.Encrypt("a");
            Assert.AreEqual(1, encryptionResult);
        }
        [TestMethod]
        public void Encrypt_When_b_ShouldReturn_2()
        {
            var modalEncrypter = new ModalEncrypter();
            var encryptionResult = modalEncrypter.Encrypt("b");
            Assert.AreEqual(2, encryptionResult);
        }

        [TestMethod]
        public void Encrypt_When_z_ShouldReturn_26()
        {
            var modalEncrypter = new ModalEncrypter();
            var encryptionResult = modalEncrypter.Encrypt("z");
            Assert.AreEqual(26, encryptionResult);
        }

        [TestMethod]
        public void Encrypt_When_ab_ShouldReturn_27()
        {
            var modalEncrypter = new ModalEncrypter();
            var encryptionResult = modalEncrypter.Encrypt("ab");
            Assert.AreEqual(27, encryptionResult);
        }

        [TestMethod]
        public void Encrypt_When_ac_ShouldReturn_28()
        {
            var modalEncrypter = new ModalEncrypter();
            var encryptionResult = modalEncrypter.Encrypt("ac");
            Assert.AreEqual(28, encryptionResult);
        }

        [TestMethod]
        public void Encrypt_When_az_ShouldReturn_51()
        {
            var modalEncrypter = new ModalEncrypter();
            var encryptionResult = modalEncrypter.Encrypt("az");
            Assert.AreEqual(51, encryptionResult);
        }

        [TestMethod]
        public void Encrypt_When_bc_ShouldReturn_52()
        {
            var modalEncrypter = new ModalEncrypter();
            var encryptionResult = modalEncrypter.Encrypt("bc");
            Assert.AreEqual(52, encryptionResult);
        }

        [TestMethod]
        [Timeout(30000)]
        public void Encrypt_When_vwxyz_ShouldReturn_83681()
        {
            var modalEncrypter = new ModalEncrypter();
            var encryptionResult = modalEncrypter.Encrypt("vwxyz");
            Assert.AreEqual(83681, encryptionResult);
        }

        [TestMethod]
        public void Encrypt_When_cat_ShouldReturn_0()
        {
            var modalEncrypter = new ModalEncrypter();
            var encryptionResult = modalEncrypter.Encrypt("cat");
            Assert.AreEqual(0, encryptionResult);
        }

        [TestMethod]
        public void Encrypt_When_aab_ShouldReturn_0()
        {
            var modalEncrypter = new ModalEncrypter();
            var encryptionResult = modalEncrypter.Encrypt("aab");
            Assert.AreEqual(0, encryptionResult);
        }

        [TestMethod]
        public void Encrypt_When_are_ShouldReturn_0()
        {
            var modalEncrypter = new ModalEncrypter();
            var encryptionResult = modalEncrypter.Encrypt("are");
            Assert.AreEqual(0, encryptionResult);
        }

    }
}
