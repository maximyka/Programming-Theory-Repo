using UnityEngine;

public class ButtonMedium : Button
{
    override public void AddScore()
    {
        scoreManager.Score += 2;
    }
}
