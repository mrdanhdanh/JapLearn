using JapLearn.Models;

namespace JapLearn.Services;

public class KanaService
{
    private readonly Random _random = new();

    public Kana GetRandomKana(string? type = null)
    {
        var filtered = type switch
        {
            "Hiragana" => Kana.All.Where(k => k.Type == "Hiragana").ToList(),
            "Katakana" => Kana.All.Where(k => k.Type == "Katakana").ToList(),
            _ => Kana.All
        };
        return filtered[_random.Next(filtered.Count)];
    }
}
