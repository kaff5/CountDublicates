using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckCountDubl.Tests
{
    [TestClass]
    public class CountDublTests
    {
        [TestMethod]
        public void Count_exilic_1returned()
        {
            //arange 
            string str = "exilic";
            int expected = 1;


            //act 
            CountDubl c = new CountDubl();
            int actual = c.Count(str);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_aaaacccccccccbb_3returned()
        {
            //arange 
            string str = "aaaacccccccccbb";
            int expected = 3;


            //act 
            CountDubl c = new CountDubl();
            int actual = c.Count(str);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Count_momentaneously_4returned()
        {
            //arange 
            string str = "momentaneously";
            int expected = 4;


            //act 
            CountDubl c = new CountDubl();
            int actual = c.Count(str);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_hydramnios_0returned()
        {
            //arange 
            string str = "hydramnios";
            int expected = 0;


            //act 
            CountDubl c = new CountDubl();
            int actual = c.Count(str);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_a_0returned()
        {
            //arange 
            string str = "a";
            int expected = 0;


            //act 
            CountDubl c = new CountDubl();
            int actual = c.Count(str);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_AAAAAbb44_3returned()
        {
            //arange 
            string str = "AAAAAbb44";
            int expected = 3;


            //act 
            CountDubl c = new CountDubl();
            int actual = c.Count(str);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_iamuncous_1returned()
        {
            //arange 
            string str = "iamuncous";
            int expected = 1;


            //act 
            CountDubl c = new CountDubl();
            int actual = c.Count(str);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_BINDOREE_1returned()
        {
            //arange 
            string str = "BINDOREE";
            int expected = 1;


            //act 
            CountDubl c = new CountDubl();
            int actual = c.Count(str);

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Count_BINDOREe_1returned()
        {
            //arange 
            string str = "BINDOREe";
            int expected = 1;


            //act 
            CountDubl c = new CountDubl();
            int actual = c.Count(str);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_hErpe123123tography_7returned()
        {
            //arange 
            string str = "hErpe123123tography";
            int expected = 7;


            //act 
            CountDubl c = new CountDubl();
            int actual = c.Count(str);

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Count_mA1thematics_3returned()
        {
            //arange 
            string str = "mA1thematics";
            int expected = 3;


            //act 
            CountDubl c = new CountDubl();
            int actual = c.Count(str);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_Uncopyrightable_0returned()
        {
            //arange 
            string str = "Uncopyrightable";
            int expected = 0;


            //act 
            CountDubl c = new CountDubl();
            int actual = c.Count(str);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_Euouae_2returned()
        {
            //arange 
            string str = "Euouae";
            int expected = 2;


            //act 
            CountDubl c = new CountDubl();
            int actual = c.Count(str);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Count_1a2b3c4d56789_1a2b3c4d67890_12returned()
        {
            //arange 
            string str = "1a2b3c4d56789_1a2b3c4d67890";
            int expected = 12;


            //act 
            CountDubl c = new CountDubl();
            int actual = c.Count(str);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_1a2b3c4d5679zg_1a2b3c467890777774z_11returned()
        {
            //arange 
            string str = "1a2b3c4d5679zg_1a2b3c467890777774z";
            int expected = 11;


            //act 
            CountDubl c = new CountDubl();
            int actual = c.Count(str);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
