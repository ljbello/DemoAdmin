using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class Ssosetting
{
    public int Id { get; set; }

    public int StoreAppSettingId { get; set; }

    public int Ssotype { get; set; }

    public string? TokenAdapterPassword { get; set; }

    public string? ProfileKeys { get; set; }

    public string AuthUrl { get; set; } = null!;

    public string LogoutUrl { get; set; } = null!;

    public virtual StoreAppsetting StoreAppSetting { get; set; } = null!;
}
