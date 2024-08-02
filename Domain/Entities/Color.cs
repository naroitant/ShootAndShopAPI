using System.ComponentModel.DataAnnotations.Schema;

namespace ShootAndShopAPI.Domain.Entities;

[Table("color")]
public class Color : Quality
{
    private Color() : base() { }
    
    public Color(string name) : base(name) { }
}
