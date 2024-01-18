namespace TestesUnitarios.Desafio.Console.Tests
{
    
    public class ValidacoesListaTests
    {
        
        public void TestarDesempenhoMultiplicacaoNumerosLista()
        {
            
            ValidacoesLista validacoesLista = new ValidacoesLista();
            List<int> listaGrande = new List<int>();

            
            for (int i = 0; i < 1000000; i++)
            {
                listaGrande.Add(i);
            }

          
            Stopwatch stopwatch = Stopwatch.StartNew();
            List<int> resultado = validacoesLista.MultiplicarNumerosLista(listaGrande, 2);
            stopwatch.Stop();

            
            Assert.Less(stopwatch.ElapsedMilliseconds, 100, "O teste excedeu o limite de tempo permitido.");
        }
    }
// legal