﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelo_ASP_NET.Models
{
    [Serializable] //Enviar o objeto para um aplicativo remoto usando um serviço Web.
    public class Autores // Abrir a classe publica com nome de Autores.
    {
        //Criando os atributos publicos com Get e Set.
        public decimal aut_id_autor { get; set; }
        public string aut_nm_nome { get; set; }
        public string aut_nm_sobrenome { get; set; }
        public string aut_ds_email { get; set; }

        // Criando construtor da classe com parâmetros de referência aos atributos.
        public Autores(decimal aut_id_autor, string aut_nm_nome, string aut_nm_sobrenome, string aut_ds_email)
        {
            this.aut_id_autor = aut_id_autor;
            this.aut_nm_nome = aut_nm_nome;
            this.aut_nm_sobrenome = aut_nm_sobrenome;
            this.aut_ds_email = aut_ds_email;
        }
    }
}