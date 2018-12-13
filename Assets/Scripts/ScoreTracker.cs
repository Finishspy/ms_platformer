using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using TMPro; //<- "namespace"

public class ScoreTracker : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // visar  hur mycket score man har 
    public int totalScore;

    private void Update()
    {
        scoreText.text = string.Format("Score: {0}", totalScore);
    }
}
