using System;
using System.Collections.Generic;

namespace Entity.Entitiy;

public partial class UserRole
{
    /// <summary>
    /// 主键
    /// </summary>
    public int Uid { get; set; }

    public int? Rid { get; set; }
}
