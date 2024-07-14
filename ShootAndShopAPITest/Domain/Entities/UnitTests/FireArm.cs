using Newtonsoft.Json;
using ShootAndShopAPI.Domain.Entities;
using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class FireArmTests
{
    [Fact]
    public void ShouldChangeFireArm()
    {
        // Arrange
        var fireArm = new FireArm(
            "640832006551",
            "SUB2K9MPBBLKHC",
            "Kel-Tec Model Sub 2K Gen 2 9mm, 16.1\" Barrel, Blued Finish, 1 Magazine, 17Rd, Adjustable Sights, For M&P",
            new Manufacturer("Kel-Tec"),
            new Category("Tactical Rifles"),
            new Caliber(9, Unit.Millimeters),
            new ActionType("Semi-Auto"),
            16.1,
            17);
        
        // Act
        fireArm.Change("736676169344",
            "16934",
            "Ruger American Rifle, .308 Win, 22\" Barrel, Vortex Crossfire II Scope, Mounted",
            new Manufacturer("Ruger"),
            new Category("Rifles"),
            new Caliber(0.308, Unit.Inches),
            new ActionType("Bolt"),
            22,
            4);
        
        // Assert
        Assert.Equal(
            JsonConvert.SerializeObject(new FireArm(
                "736676169344",
                "16934",
                "Ruger American Rifle, .308 Win, 22\" Barrel, Vortex Crossfire II Scope, Mounted",
                new Manufacturer("Ruger"),
                new Category("Rifles"),
                new Caliber(0.308, Unit.Inches),
                new ActionType("Bolt"),
                22,
                4)),
            JsonConvert.SerializeObject(fireArm));
    }
}
