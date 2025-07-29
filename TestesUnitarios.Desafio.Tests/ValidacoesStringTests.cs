using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();
    
        [Fact]
        public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
        {
            //TODO: Corrigir a variável "texto" e "resultadoEsperado" da seção Arrange
            //Implementado - Roberto - 29/07/2025

            // Arrange
            //Roberto - 29/07/2025
            var texto = "sapato";
            var resultadoEsperado = 6;

            // Act
            var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveContemAPalavraQualquerNoTexto()
        {
            //Implementado - Roberto - 29/07/2025
            // Arrange
            var texto = "Esse é um texto qualquer";
            var textoProcurado = "qualquer";

            //TODO: Corrigir a chamada do método "ContemCaractere" da seção Act
            //Roberto - 29/07/2025
            // Act
            var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

            // Assert
            //Roberto - 29/07/2025
            //TODO: Corrigir o Assert.True com base no retorno da chamada ao método
            Assert.True(resultado);
        }
    

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        //Implementado - Roberto - 29/07/2025
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        //TODO: Corrigir o Assert.False com base no retorno da chamada ao método
        //Roberto - 29/07/2025
        Assert.False(resultado);
    }

    //TODO: Corrigir a anotação 
    
     [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        //TODO: Corrigir a variável "textoProcurado" seção Arrange
        //Implementado - Roberto - 29/07/2025

        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado";//Roberto - 29/07/2025

        // Act
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }
}
