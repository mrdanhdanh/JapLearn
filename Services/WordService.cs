using JapLearn.Models;

namespace JapLearn.Services;

public class WordService
{
    private readonly Random _random = new();

    public JapaneseWord GetRandomWord(string? type = null)
    {
        var filtered = type switch
        {
            null => JapaneseWord.All,
            _ => JapaneseWord.All.Where(w => w.Type == type).ToList()
        };
        return filtered[_random.Next(filtered.Count)];
    }

    public (JapaneseWord correct, List<JapaneseWord> options) GetQuizOptions(string? type = null, int optionCount = 4)
    {
        var pool = type switch
        {
            null => JapaneseWord.All,
            _ => JapaneseWord.All.Where(w => w.Type == type).ToList()
        };

        if (pool.Count < 2) return (pool[0], pool);

        var correct = pool[_random.Next(pool.Count)];
        var distractors = pool
            .Where(w => w.Word != correct.Word && w.Meaning != correct.Meaning)
            .OrderBy(_ => _random.Next())
            .Take(optionCount - 1)
            .ToList();

        var options = new List<JapaneseWord> { correct }
            .Concat(distractors)
            .OrderBy(_ => _random.Next())
            .ToList();

        return (correct, options);
    }

    public List<string> GetTypes()
    {
        return JapaneseWord.All
            .Select(w => w.Type)
            .Distinct()
            .OrderBy(t => t)
            .ToList();
    }
}