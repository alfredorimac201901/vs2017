using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Chinook.Data.Test
{
    [TestClass]
    public class ArtistTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var da = new ArtistDA();
            var cantidad = da.getCount();
            Assert.IsTrue(cantidad > 0);


        }

        [TestMethod]
        public void GetListado()
        {
            var da = new ArtistDA();
            var listado = da.Gets();
            Assert.IsTrue(listado.Count()>0);


        }

        [TestMethod]
        public void GetsWithParam()
        {
            var da = new ArtistDA();
            var listado = da.GetsWithParam("a%");
            Assert.IsTrue(listado.Count() > 0);


        }

        [TestMethod]
        public void InsertArtist()
        {
            var da = new ArtistDA();
            var id = da.InsertArtist(new Entities.Artist() { Name= "Prueba" });
            Assert.IsTrue(id>0);


        }
    }
}
