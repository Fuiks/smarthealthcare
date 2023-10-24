using System;
using System.Collections.Generic;

namespace Entity.Entitiy;

public partial class Order
{
    public string Oid { get; set; } = null!;

    public DateTime? Odata { get; set; }

    public string? Prid { get; set; }

    public double? Oprice { get; set; }
}
