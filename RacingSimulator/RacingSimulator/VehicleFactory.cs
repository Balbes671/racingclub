using RacingSimulator.Models;

namespace RacingSimulator.Patterns;


public sealed class SportsCar : Car
{
    public SportsCar() : base("Спорткар «Lightning»", 300, 3.2) { }

    public override void Race() =>
        Console.WriteLine($"{ModelName} идеально держит траекторию на скоростных виражах!");
}

public sealed class SuvCar : Car
{
    public SuvCar() : base("Внедорожник «Titan»", 200, 7.5) { }

    public override void Race() =>
        Console.WriteLine($"{ModelName} легко преодолевает сложные участки и неровности!");
}

public sealed class FormulaCar : Car
{
    public FormulaCar() : base("Болид Ф-1 «Apex»", 360, 2.1) { }

    public override void Race() =>
        Console.WriteLine($"{ModelName} стремительно развивает максимальную скорость на прямой!");
}

public abstract class VehicleFactory
{
    public abstract Car CreateCar();
}

public sealed class SportsCarFactory : VehicleFactory
{
    public override Car CreateCar() => new SportsCar();
}

public sealed class SuvCarFactory : VehicleFactory
{
    public override Car CreateCar() => new SuvCar();
}

public sealed class FormulaCarFactory : VehicleFactory
{
    public override Car CreateCar() => new FormulaCar();
}