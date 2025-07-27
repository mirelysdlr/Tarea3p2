using System;
using System.Collections.Generic;

namespace organizadordeventos.Infrastructure.Models;

public partial class Evento
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string Lugar { get; set; } = null!;
}
