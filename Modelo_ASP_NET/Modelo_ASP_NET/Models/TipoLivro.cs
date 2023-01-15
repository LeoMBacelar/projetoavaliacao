using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelo_ASP_NET.Models
{
    [Serializable] //Enviar o objeto para um aplicativo remoto usando um serviço Web.
    public class TipoLivro // Abrir a classe publica com nome de Autores.
    {
        //Criando os atributos publicos com Get e Set.
        public decimal til_id_tipo_livro { get; set; }
        public string til_ds_descricao { get; set; }

        // Criando construtor da classe com parâmetros de referência aos atributos.
        public TipoLivro(decimal til_id_tipo_livro, string til_ds_descricao)
        {
            this.til_id_tipo_livro = til_id_tipo_livro;
            this.til_ds_descricao = til_ds_descricao;
        }
    }
}