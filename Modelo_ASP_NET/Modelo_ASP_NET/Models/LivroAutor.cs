using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelo_ASP_NET.Models
{
    [Serializable] //Enviar o objeto para um aplicativo remoto usando um serviço Web.

    public class LivroAutor // Abrir a classe publica com nome de Autores.
    {
        //Criando os atributos publicos com Get e Set.
        public decimal lia_id_autor { get; set; }
        public decimal lia_id_livro { get; set; }
        public decimal lia_pc_royalty { get; set; }

        // Criando construtor da classe com parâmetros de referência aos atributos.
        public LivroAutor(decimal lia_id_autor, decimal lia_id_livro, decimal lia_pc_royalty)
        {
            this.lia_id_autor = lia_id_autor;
            this.lia_id_livro = lia_id_livro;
            this.lia_pc_royalty = lia_pc_royalty;
        }
    }
}