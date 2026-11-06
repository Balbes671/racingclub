using RacingSimulator.Models;

namespace RacingSimulator.Patterns;

public sealed class TrackRegistry
{
    private readonly Dictionary<string, Track> _templates = new();

    public void RegisterTemplate(string key, Track track)
    {
        _templates[key] = track;
    }

    public Track CreateTrack(string key)
    {
        if (!_templates.TryGetValue(key, out var template))
        {
            throw new KeyNotFoundException($"Шаблон трассы с ключом '{key}' не найден.");
        }

        return (Track)template.Clone();
    }
}