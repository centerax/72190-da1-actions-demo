namespace CalculadoraStringsTest;

using Dominio;

[TestClass]
public class CalculadoraStringsTest
{
    private Calculadora unaCalculadora;
    
    [TestInitialize]
    public void CrearCalculadora()
    {
        this.unaCalculadora = new Calculadora();
    }
    
    [TestMethod]
    public void SumarStringVacioTest()
    {
        //AAA
        
        //Arrange
        //Calculadora unaCalculadora = new Calculadora();
        
        //Act
        int resultado = this.unaCalculadora.Sumar("");
        
        //Assert
        Assert.AreEqual(0, resultado);
    }
    
    // "3" -> 3
    [TestMethod]
    public void SumarStringUnicoNumeroTest()
    {
        //Arrange
        //Calculadora unaCalculadora = new Calculadora();
        
        //Act
        int resultado = this.unaCalculadora.Sumar("3");

        //Assert
        Assert.AreEqual(3, resultado);
    }
    
    [TestMethod]
    public void SumarStringUnicoNumero7Test()
    {
        //Arrange
        //Calculadora unaCalculadora = new Calculadora();
        
        //Act
        int resultado = this.unaCalculadora.Sumar("7");

        //Assert
        Assert.AreEqual(7, resultado);
    }
}