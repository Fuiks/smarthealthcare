using System;
using System.Collections.Generic;

namespace Entity.Entitiy;

public partial class Post
{
    public int Pid { get; set; }

    public string? Pname { get; set; }

    public string? Pename { get; set; }

    public string? Pstatus { get; set; }

    public DateOnly? Pdata { get; set; }
}
