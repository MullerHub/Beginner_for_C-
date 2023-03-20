using System;
using static System.Console;
using Libraryclass;

namespace Biblioteca_V2;
    class Program
    {
        static void Main(string[] args)
        {
                    //inicializando nossa nova classe com herança
            Revistas MinhasRevistas = new Revistas(3,2021);
                    //Inicializando as outas propriedades da classe que foram herdadas
            MinhasRevistas.Autor = "Microsoft";
            MinhasRevistas.Titulo = "MSDN Magazine";
            MinhasRevistas.Paginas = 20;
            MinhasRevistas.Status = true;
                    //imprimindo os valores de minha classe
            WriteLine("Revista Mes: "+  MinhasRevistas.MesPublicacao);
            WriteLine("Revista Ano: "+  MinhasRevistas.AnoPublicacao);
            WriteLine("Revista Autor: "+ MinhasRevistas.Autor);
            WriteLine("Revista Titulo: "+MinhasRevistas.Titulo);
            WriteLine("Revista Paginas: "+MinhasRevistas.Paginas);
            WriteLine("Revista Status: "+MinhasRevistas.Status);
            WriteLine();
                    //Inicializando nossa classe com o construtor nulo
            Biblioteca MinhaBiblioteca = new Biblioteca()
;
                    //Por isso a necessidade de "setar" o valor de cada propriedade
            MinhaBiblioteca.Autor = "Des Dearlove";
            MinhaBiblioteca.Titulo = "O  Estilo  Bill  Gates de Gerir";
            MinhaBiblioteca.Paginas = 203;
            MinhaBiblioteca.Status = true;
                    //imprimindo os valores de minha classe
            WriteLine("Autor: "+ MinhaBiblioteca.Autor);
            WriteLine("Titulo: "+ MinhaBiblioteca.Titulo);
            WriteLine("Paginas: "+ MinhaBiblioteca.Paginas);
            WriteLine("Status: "+ MinhaBiblioteca.Status);
            WriteLine();
                    //Inicializando nossa classe com o novo construtor
             Biblioteca MeusLivros =  new Biblioteca("Juan Garcia Sola", "Linguagem C", 296, true);
                    //imprimindo os valores de minha classe
            WriteLine("Autor: "+ MeusLivros.Autor);
            WriteLine("Titulo: "+ MeusLivros.Titulo);
            WriteLine("Paginas: "+ MeusLivros.Paginas);
            WriteLine("Status: "+ MeusLivros.Status);
            WriteLine();
        }
    }