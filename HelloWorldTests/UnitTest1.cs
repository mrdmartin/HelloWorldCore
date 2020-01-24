using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace HelloWorldTests
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World!";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                HelloWorldFrameWork.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);


                //Console.WriteLine("Ingrese un numero a sumar:");
                //int numero1 = Console.Read();
                // Console.WriteLine("Ingrese otro numero a sumar:");
                //int numero2 = Console.Read();

                //int resultado = numero1 + numero2;

                //Console.WriteLine("El resultado es", resultado);
            }
        }
    }
}
