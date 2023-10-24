using System;
using System.Collections.Generic;

namespace Entity.Entitiy;

public partial class User
{
    /// <summary>
    /// 主键
    /// </summary>
    public int Uid { get; set; }

    public string? Upass { get; set; }

    public string? Uname { get; set; }

    public int? Uage { get; set; }

    public string? Utel { get; set; }

    public string? Udesc { get; set; }

    public string? Uimg { get; set; }

    public int? Upost { get; set; }

    public int? Ustate { get; set; }
}
