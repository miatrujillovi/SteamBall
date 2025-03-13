using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool ballOnField;
    public GameObject endGame;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballOnField = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            if (BallManager.ballCounter == 3)
            {
                ballOnField = false;
                collision.gameObject.SetActive(false);
                endGame.SetActive(true);
            }
            else
            {
                ballOnField = false;
                collision.gameObject.SetActive(false);
            }
        }
    }
}
