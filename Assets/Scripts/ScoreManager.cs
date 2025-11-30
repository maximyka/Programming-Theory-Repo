using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // ENCAPSULATION
    private int _score;
    public int Score 
    {
        get
        {
            return _score;
        }
        set
        {
            if (_score < 0)
            {
                _score = value;
            } else 
            {
                Debug.Log("Score < 0");
                _score = 0;
            }
            TextUpdate();
        }
    }

    void Start()
    {
        TextUpdate();
    }

    // ABSTRACTION
    void TextUpdate()
    {
        TMP_Text tmpText = GetComponent<TMP_Text>();
        tmpText.text = Score.ToString();
    }
}
