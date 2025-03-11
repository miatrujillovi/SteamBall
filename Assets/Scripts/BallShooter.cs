using UnityEngine;

public class BallShooter : MonoBehaviour
{
    public GameObject[] ballsArray;
    public float launchForce;

    //Function that uses the RigidBody of its respective ball to throw upwards with AddForce
    void BallThrower(GameObject ball)
    {
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        Vector2 launchVector = new Vector2(0f, 1f);
        rb.AddForce(launchVector * launchForce);
    }

    //Function that detects which ball should be throw next
    void BallDetector()
    {
        
    }
}
