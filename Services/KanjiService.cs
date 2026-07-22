using JapLearn.Models;

namespace JapLearn.Services;

public class KanjiService
{
    private readonly Random _random = new();

    public (KanjiWord correct, List<KanjiWord> options) GetQuizOptions(int optionCount = 4)
    {
        var pool = KanjiWord.All;

        if (pool.Count < 2) return (pool[0], pool);

        var correct = pool[_random.Next(pool.Count)];
        var distractors = pool
            .Where(w => w.Kanji != correct.Kanji)
            .OrderBy(_ => _random.Next())
            .Take(optionCount - 1)
            .ToList();

        var options = new List<KanjiWord> { correct }
            .Concat(distractors)
            .OrderBy(_ => _random.Next())
            .ToList();

        return (correct, options);
    }
}