using System;
using System.Collections.Generic;

namespace Entity.Entitiy;

public partial class PatientRegister
{
    public string Prid { get; set; } = null!;

    public DateTime? Rdata { get; set; }

    public int? Pid { get; set; }

    public int? Uid { get; set; }

    public string? Rdesc { get; set; }

    public string? Rresult { get; set; }
}
