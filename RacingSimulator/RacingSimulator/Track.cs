namespace RacingSimulator.Models;

public sealed class Track : ICloneable
{
    public string Type { get; }
    public string Name { get; set; }
    public double LengthKm { get; set; }
    public string Weather { get; set; }
    public int Laps { get; set; }

    public Track(string type, string name, double lengthKm, string weather, int laps)
    {
        Type = type;
        Name = name;
        LengthKm = lengthKm;
        Weather = weather;
        Laps = laps;
    }

    public object Clone()
    {
        return new Track(Type, Name, LengthKm, Weather, Laps);
    }

    public override string ToString() =>
        $"[{Type}] «{Name}» | Длина: {LengthKm} км | Погода: {Weather} | Кругов: {Laps}";
}