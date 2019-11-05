using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatisticsPlayer : Statistics
{
    private int age { get; set; }
    private float height { get; set; }
    private float averageScore { get; set; }

    public StatisticsPlayer(int age, float height, float averageScore)
    {
        this.age = age;
        this.height = height;
        this.averageScore = averageScore;
    }
}
