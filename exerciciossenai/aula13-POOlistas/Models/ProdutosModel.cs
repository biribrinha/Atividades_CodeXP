namespace aula13_POOlistas.Models
{
    public class ProdutosModel
    {
        public int IdProduto {get; set;}
        public string NomeProduto {get; set;}
        public string Descricao {get; set;}
        public double Preco {get; set;}
        
        //utilizamos sobrecarga para poder instanciar 
        //passando ou não os atributos
        public ProdutosModel(){

        }

        //tudo oq se coloca em parenteses se coloca dentro do método
        public ProdutosModel(int idproduto, string nomeproduto, string descricao, double preco){
            this.IdProduto = idproduto;
            this.NomeProduto = nomeproduto;
            this.Descricao = descricao;
            this.Preco = preco;
        }
    }
}