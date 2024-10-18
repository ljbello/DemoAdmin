using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class StoreAppsetting
{
    public int Id { get; set; }

    public int StoreId { get; set; }

    public string StoreName { get; set; } = null!;

    public string HostName { get; set; } = null!;

    public string? ProductImageHandlerUrl { get; set; }

    public string? ImageHandlerUrl { get; set; }

    public bool? IsSampleRequestPublic { get; set; }

    public string? AdminwebUrl { get; set; }

    public string? HubPath { get; set; }

    public string? PreviewUrl { get; set; }

    public bool Ssoenable { get; set; }

    public bool SsoapplyAuthWideStoreLevel { get; set; }

    public bool SsoacceptBackdoor { get; set; }

    public string? SsobackDoorGuid { get; set; }

    public string? SsobackdoorAuthUrl { get; set; }

    public string? SsobackdoorLogoutUrl { get; set; }

    public virtual ICollection<Ssosetting> Ssosettings { get; set; } = new List<Ssosetting>();

    public virtual Store Store { get; set; } = null!;
}
