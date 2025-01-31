﻿using System.ComponentModel.DataAnnotations.Schema;

namespace FazendaFeliz.ApplicationCore.Business
{
    public class Reclamacao : Entity
    {
        [ForeignKey("Usuario")]
        public int Id_Usuario { get; set; }
        [ForeignKey("Anuncio")]
        public int Id_Anuncio { get; set; }
        public string Titulo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem_Base64 { get; set; }
    }
}
