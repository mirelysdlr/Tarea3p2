using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace organizadordeventos.Domain.Entities
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }
    }
}