using System;
using System.Collections.Generic;

namespace Entity.Entitiy;

public partial class Weekly
{
    public int Wid { get; set; }

    public int? Uid { get; set; }

    public string? Wwork { get; set; }

    public string? Werror { get; set; }

    public string? Wsum { get; set; }

    public string? Sopinion { get; set; }

    public DateTime? Wdata { get; set; }
}
