using System;
using System.Collections.Generic;

namespace Entity.Entitiy;

public partial class LogManagement
{
    public int Lid { get; set; }

    public string? Lcontent { get; set; }

    public string? Lstatus { get; set; }

    public DateTime? Ldata { get; set; }

    public string? Ltype { get; set; }

    public string? Lmethod { get; set; }

    public string? Lerror { get; set; }

    public string? Lname { get; set; }
}
