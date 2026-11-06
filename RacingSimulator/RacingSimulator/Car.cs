namespace RacingSimulator.Models;

public abstract class Car
{
    public string ModelName { get; }
    public int MaxSpeed { get; }
    public double Acceleration { get; } 

    protected Car(string modelName, int maxSpeed, double acceleration)
    {
        ModelName = modelName;
        MaxSpeed = maxSpeed;
        Acceleration = acceleration;
    }

    public abstract void Race();

    public override string ToString() =>
        $"{ModelName} (Макс. скорость: {MaxSpeed} км/ч, Разгон: {Acceleration} с до 100 км/ч)";
}