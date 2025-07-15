using Robust.Shared.Prototypes;
using Robust.Shared.Serialization;

namespace Content.Shared._Funkystation.Cargo.Prototypes;

[Prototype, Serializable, NetSerializable]
public sealed partial class CargoTradeShuttlePrototype : IPrototype
{
    /// <summary>
    /// ID of the shuttle
    /// </summary>
    [IdDataField]
    public string ID { get; private set; } = default!;

    [DataField(required: true)]
    public LocId Name { get; private set; }

    [DataField]
    public List<CargoTradeShuttleInventoryItemPrototype> Inventory { get; set; } = new();
}
