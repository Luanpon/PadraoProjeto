using System;

using System.Collections.Generic;

 
namespace Padrao.Builder

{

  public class PrincipalApp

  {

    public static void Main()

    {


      Montadora montadora = new Montadora();


      ConstroiPalio palio = new ConstroiPalio();

      ConstroiUno uno = new ConstroiUno();
 

      // Constrói os dois produtos

      montadora.Construir(palio);

      Carro carro1 = palio.GetCarro();

      carro1.MostrarPartes();

 

      montadora.Construir(uno);

      Carro carro2 = uno.GetCarro();

      carro2.MostrarPartes();
      

    }

  }


// Director ----------------------------------------------------

  class Montadora

  {

    public void Construir(ConstroiCarro constroicarro)

    {

      constroicarro.CriaNome();

      constroicarro.CriaPreco();

    }

  }


// Builder ---------------------------------------------------

  abstract class ConstroiCarro

  {

    public abstract void CriaNome();

    public abstract void CriaPreco();

    public abstract Carro GetCarro();

  }

 
 // Concrete Builders --------------------------------------------

  class ConstroiPalio : ConstroiCarro

  {

    private Carro carro = new Carro();


    public override void CriaNome()

    {

      carro.nome = "Palio";

    }

 

    public override void CriaPreco()

    {

      carro.preco = "25.500";

    }

 

    public override Carro GetCarro()

    {

      return carro;

    }
    

  }

 

  class ConstroiUno : ConstroiCarro

  {

    private Carro carro = new Carro();


    public override void CriaNome()

    {

      carro.nome = "Uno";

    }

 

    public override void CriaPreco()

    {

      carro.preco = "30.000";

    }

 

    public override Carro GetCarro()

    {

      return carro;

    }
    

  }

 
 //produto -------------------

  class Carro 

  {

    
    public string nome;
    public string preco;


    public void MostrarPartes()

    {

      Console.WriteLine("Partes do Produto");
      Console.WriteLine(nome);
      Console.WriteLine(preco);

    }

  }

}