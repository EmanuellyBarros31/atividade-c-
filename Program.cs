class Animal
{
    public string Nome{get; set;}
    public int Idade{get; set;}

public Animal(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    public virtual void EmitirSom()
    {
        Console.WriteLine("Barulho");
    }
}

class Cachorro: Animal
{
public Cachorro(string nome, int idade) : base(nome,idade){}
    public override void EmitirSom()
    {
        Console.WriteLine("O cachorro está latindo: Au au!");
    }

}

class Gato : Animal
{
    public Gato(string nome, int idade) : base(nome,idade){}
    public override void EmitirSom()
    {
        Console.WriteLine("O gato está miando: Miau!");
    }
}

public class program
{
    public static void Main()
    {
        var cachorro = new Cachorro("Rex",3);
        var Gato= new Cachorro("Mimi",2);

        Console.WriteLine("Sistema de animais");
        Console.WriteLine($"Animal:{cachorro.Nome}");
        Console.WriteLine($"Idade:{cachorro.Idade}");
        Console.Write("Som: ");
        cachorro.EmitirSom();

        Console.WriteLine("Sistema de animais");
        Console.WriteLine($"Animal:{Gato.Nome}");
        Console.WriteLine($"Idade:{Gato.Idade}");
        Console.Write("Som: ");
        Gato.EmitirSom();

        Console.WriteLine("Pressione qualquer tecla para sair");
        Console.ReadKey();

    }
}

