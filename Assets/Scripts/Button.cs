using UnityEngine;

public class Button : MonoBehaviour
{
    protected ScoreManager scoreManager;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    virtual public void AddScore()
    {
        scoreManager.Score += 1;
    }
}
