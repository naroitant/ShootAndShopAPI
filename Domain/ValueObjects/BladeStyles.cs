using System.Runtime.Serialization;

namespace ShootAndShopAPI.Domain.ValueObjects;

public enum BladeStyles
{
    [EnumMember(Value = "Clip Point")]
    ClipPoint = 0,
    [EnumMember(Value = "Drop Point")]
    DropPoint = 1,
}
