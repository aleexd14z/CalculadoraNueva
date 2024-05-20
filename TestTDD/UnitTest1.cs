namespace TestTDD
{
    public class UnitTest1
    {
        [Fact]
        public void CadenaVacia()
        {
            string numeros = "";

            Calculadora.Calculadora calculadora = new Calculadora.Calculadora();

            int resultado = calculadora.Sumar(numeros);

            Assert.Equal(0, resultado);
        }

        [Fact]
        public void UnNumeros()
        {
            string numeros = "1";

            Calculadora.Calculadora calculadora = new Calculadora.Calculadora();

            int resultado = calculadora.Sumar(numeros);

            Assert.Equal(1, resultado);
        }

        [Fact]
        public void DosNumeros()
        {
            string numeros = "1, 2";

            Calculadora.Calculadora calculadora = new Calculadora.Calculadora();

            int resultado = calculadora.Sumar(numeros);

            Assert.Equal(3, resultado);

            Assert.Equal(3, resultado);
        }

        [Fact]
        public void TresNumeros()
        {
            string numeros = "1, 2, 3";
                
            Calculadora.Calculadora calculadora = new Calculadora.Calculadora();

            int resultado = calculadora.Sumar(numeros);

            Assert.Equal(6, resultado);
        }

        /* [Fact]
         public void NuevaLinea()
         {
             string numeros = "1,2,4\n5,6";

             CalculadoraString.Calculadora calculadora = new CalculadoraString.Calculadora();

             int resultado = calculadora.Sumar(numeros);

             Assert.Equal(18, resultado);
         } */

        /*[Fact]
         public void Delimitador()
        {
            string numeros = "//;\n1;3;6;4";

            CalculadoraString.Calculadora calculadora = new CalculadoraString.Calculadora();

            int resultado = calculadora.Sumar(numeros);

            Assert.Equal(6, resultado);
        } */

        [Fact]
        public void NumNeg()
        {
            string numeros = "1, -2, 3";

            Calculadora.Calculadora calculadora = new Calculadora.Calculadora();

            int resultado = calculadora.Sumar(numeros);

            Assert.Equal(2, resultado);
        }
    }
}