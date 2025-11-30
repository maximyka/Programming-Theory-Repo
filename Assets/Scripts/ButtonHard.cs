using UnityEngine;

// INHERITANCE
public class ButtonHard: Button
{
    // POLYMORPHISM
    override public void AddScore()
    {
        scoreManager.Score += 3;
    }
}
