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
        public void GetNextWord_When_zzzz_ShouldReturn_aaaaa()
        {
            var modalEncrypter = new ModalEncrypter();
            var nextWord = modalEncrypter.GetNextWord("zzzz");
            Assert.AreEqual("aaaaa", nextWord);
        }

        [TestMethod]
        public void GetNextWord_When_zzzy_ShouldReturn_zzzz()
        {
            var modalEncrypter = new ModalEncrypter();
            var nextWord = modalEncrypter.GetNextWord("zzzy");
            Assert.AreEqual("zzzz", nextWord);
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

        [TestMethod]
        public void WordToIntArray_When_a_ShouldReturn_00001()
        {
            var modalEncrypter = new ModalEncrypter();
            var arrayResult = modalEncrypter.WordToIntArray("a");

            Assert.AreEqual(0, arrayResult[0]);
            Assert.AreEqual(0, arrayResult[1]);
            Assert.AreEqual(0, arrayResult[2]);
            Assert.AreEqual(0, arrayResult[3]);
            Assert.AreEqual(1, arrayResult[4]);
        }

        [TestMethod]
        public void WordToIntArray_When_zzzz_ShouldReturn_026262626()
        {
            var modalEncrypter = new ModalEncrypter();
            var arrayResult = modalEncrypter.WordToIntArray("zzzz");

            Assert.AreEqual(0, arrayResult[0]);
            Assert.AreEqual(26, arrayResult[1]);
            Assert.AreEqual(26, arrayResult[2]);
            Assert.AreEqual(26, arrayResult[3]);
            Assert.AreEqual(26, arrayResult[4]);
        }

        [TestMethod]
        public void WordToIntArray_When_aaaaa_ShouldReturn_11111()
        {
            var modalEncrypter = new ModalEncrypter();
            var arrayResult = modalEncrypter.WordToIntArray("aaaaa");

            Assert.AreEqual(1, arrayResult[0]);
            Assert.AreEqual(1, arrayResult[1]);
            Assert.AreEqual(1, arrayResult[2]);
            Assert.AreEqual(1, arrayResult[3]);
            Assert.AreEqual(1, arrayResult[4]);
        }


    }
}
