using Robust.Shared.Prototypes;

namespace Content.Shared._Funkystation.Cargo.Prototypes;

[ImplicitDataDefinitionForInheritors, Serializable]
public sealed partial class CargoTradeShuttleInventoryItemPrototype
{
    [DataField]
    public LocId Name { get; set; } = string.Empty;

    [DataField]
    public ProtoId<EntityPrototype> Item { get; set; } = string.Empty;

    [DataField]
    public int Amount { get; set; }

    [DataField]
    public int Cost { get; set; }
}
