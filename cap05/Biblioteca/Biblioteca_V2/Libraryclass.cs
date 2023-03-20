//namespace que irá conter a classe de controle de livros e seus metodos
namespace Libraryclass;

    //nova classe para controlar as revistas
    public class Revistas : Biblioteca
    {
        //Propriedades da Classe
        private int _MesPublicacao;
        private int _AnoPublicacao;
        //Construtor da classe
        public Revistas(int MesPublicacao, int AnoPublicacao)
        {
            _MesPublicacao = MesPublicacao;
            _AnoPublicacao = AnoPublicacao;
        }
        public int MesPublicacao //Metodo  para  acesso a propriedade da classe
        {
                        get  {return _MesPublicacao;} set { _MesPublicacao = value;}
        }
        public int AnoPublicacao
        {
             get {return _AnoPublicacao;} set { _AnoPublicacao = value;}
        }
    }
    //principal classe de controle de livros na Biblioteca
    public class Biblioteca
    {
        private string _Titulo; //recebra o titulo do livro
        private string _Autor; //recebera o nome do autor do Livro
        private int _Paginas; ///receberá o númerp de paginas que o Livro contem
    }