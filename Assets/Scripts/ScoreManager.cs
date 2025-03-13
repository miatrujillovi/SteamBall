using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreTxt;

    static int scoreCounter;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            scoreCounter++;
            scoreTxt.text = scoreCounter.ToString();
        }
    }
}
