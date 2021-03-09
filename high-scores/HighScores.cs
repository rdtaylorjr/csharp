using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> ScoresList { get;  }
    
    public HighScores(List<int> list)
    {
        ScoresList = list;
        Console.log("Hello World");
    }

    public List<int> Scores() => ScoresList;

    public int Latest()
    {
        throw new NotImplementedException();
    }

    public int PersonalBest()
    {
        throw new NotImplementedException();
    }

    public List<int> PersonalTopThree()
    {
        throw new NotImplementedException();
    }
}