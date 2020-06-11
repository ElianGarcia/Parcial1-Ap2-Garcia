using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial1_Ap2_Garcia.BLL;
using Parcial1_Ap2_Garcia.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1_Ap2_Garcia.BLL.Tests
{
    [TestClass()]
    public class ArticulosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Articulos articulo = new Articulos(1, "Cable RGB", 13, Convert.ToDecimal(345.33), Convert.ToDecimal(3435.33));
            bool guardado = ArticulosBLL.Guardar(articulo);
            Assert.AreEqual(guardado, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            var eliminado = ArticulosBLL.Eliminar(1);
            Assert.IsNotNull(eliminado);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            var buscado = ArticulosBLL.Buscar(1);
            Assert.IsNotNull(buscado);
        }

        [TestMethod()]
        public void GetListTest()
        {
            List<Articulos> lista = new List<Articulos>();
            lista = ArticulosBLL.GetList(l => true);
            Assert.IsNotNull(lista);
        }
    }
}