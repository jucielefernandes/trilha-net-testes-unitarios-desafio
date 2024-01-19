namespace TestesUnitarios.Desafio.Console.Tests
{
    
    public class ValidacoesListaTests
    {
        [Test]
        public void TestarDesempenhoMultiplicacaoNumerosLista()
        {
            // Arrange
            ValidacoesLista validacoesLista = new ValidacoesLista();
            List<int> listaGrande = new List<int>();

            // Adicionar 1 milhão de elementos à lista
            for (int i = 0; i < 1000000; i++)
            {
                listaGrande.Add(i);
            }

            // Act
            Stopwatch stopwatch = Stopwatch.StartNew();
            List<int> resultado = validacoesLista.MultiplicarNumerosLista(listaGrande, 2);
            stopwatch.Stop();

            // Assert
            // Verificar se o tempo de execução está abaixo de um limite aceitável
            Assert.Less(stopwatch.ElapsedMilliseconds, 100, "O teste excedeu o limite de tempo permitido.");
        }
    }
}