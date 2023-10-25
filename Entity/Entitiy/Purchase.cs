using System;
using System.Collections.Generic;

namespace Entity.Entitiy;

public partial class Purchase
{
    public int Pid { get; set; }

    public string? Pnumber { get; set; }

    public string? Pname { get; set; }

    public string? Ptype { get; set; }

    public string? Pdesc { get; set; }


    public int? Pnum { get; set; }


    public string? Pfactory { get; set; }

    public double? Pprice { get; set; }

    public DateTime? Pdate { get; set; }
}
