using ConceitosBasicos.uteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConceitosBasicos
{
    [TestClass]
    public class TesteCalculaAumento
    {
        [TestMethod]
        public void TestCalcular()
        {
            //cenário
            decimal salario = 1000;
            float percentual = 20;
            decimal resultado;
            CalculaAumento calculaAumento = new CalculaAumento();

            //ação
            resultado = calculaAumento.Calcular(salario, percentual);

            //verificação
            Assert.AreEqual(200, resultado);
        }
    }
}
