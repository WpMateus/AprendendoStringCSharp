using System;

namespace AprendendoString{

    class Program{

        static void Main(string[] args){

            var texto = "Este texto é um teste";

        //Starts With, compara o inicio
        Console.WriteLine(texto.StartsWith("Este"));
        Console.WriteLine(texto.StartsWith("este"));
        Console.WriteLine(texto.StartsWith("texto"));
        //Ends With, compara final
        Console.WriteLine(texto.EndsWith("teste"));
        Console.WriteLine(texto.EndsWith("Teste"));
        Console.WriteLine(texto.EndsWith("Xpto"));

        Console.WriteLine("");

        //Equals , um texto é igual, true ou false, tem que ser exatamente igual.
        Console.WriteLine(texto.Equals("Este texto é um teste"));
        Console.WriteLine(texto.Equals("este texto é um teste"));
        Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("");

        //indíce - a posição do item no array, lista começa em 0
        Console.WriteLine(texto.IndexOf("é"));
        Console.WriteLine(texto.LastIndexOf("s"));


        Console.WriteLine("");
        //toUpper- converte o texto todo para maiusculo toLower - converte o texto todo para minusculo

        Console.WriteLine(texto.ToUpper());
        Console.WriteLine(texto.ToLower());
        Console.WriteLine(texto.Insert(5, "AQUI ")); //inserir caracter
        Console.WriteLine(texto.Remove(5, 5));
        Console.WriteLine(texto.Length);

        Console.WriteLine("");

        //replace - pede um caracter antigo e um nove, serve para trocar

        Console.WriteLine(texto.Replace("e", "X"));
        //split, dividir o texto
        var divisao = texto.Split(" ");
        Console.WriteLine(divisao[0]);
        Console.WriteLine(divisao[1]);
        Console.WriteLine(divisao[2]);
        Console.WriteLine(divisao[3]);
        Console.WriteLine(divisao[4]);

        
        }
    }
}