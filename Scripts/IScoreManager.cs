﻿namespace a;

public class IScoreManager
{
    float GetScore();
    float  SetScore(float score);
    float  AddScore(float score);
    float  SubtractScore(float score);
    float  ResetScore();
}