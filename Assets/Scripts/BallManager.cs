using UnityEngine;
using UnityEngine.InputSystem;

public class BallManager : MonoBehaviour
{
    public Rigidbody2D[] ballsArray;
    public float launchForce;

    public InputSystem_Actions inputAction;
    public InputAction Ball;

    public static int ballCounter;

    private void OnEnable()
    {
        Ball = inputAction.Player.Ball;
        Ball.Enable();
        Ball.performed += BallButton;
    }

    public void Awake()
    {
        inputAction = new InputSystem_Actions();
        ballCounter = 1;
    }

    public void BallButton(InputAction.CallbackContext context)
    {
        BallDetector();
    }

    //Function that detects which ball should be throw next
    void BallDetector()
    {
        if (ballCounter == 1 && GameManager.ballOnField == false)
        {
            BallThrower(ballsArray[0]);
            ballCounter++;
            GameManager.ballOnField = true;
        } 
        else if (ballCounter == 2 && GameManager.ballOnField == false)
        {
            BallThrower(ballsArray[1]);
            ballCounter++;
            GameManager.ballOnField = true;
        } 
        else if (ballCounter == 3 && GameManager.ballOnField == false)
        {
            BallThrower(ballsArray[2]);
            ballCounter++;
            GameManager.ballOnField = true;
        }
    }

    //Function that uses the RigidBody of its respective ball to throw upwards with AddForce
    void BallThrower(Rigidbody2D ball)
    {
        Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();
        Vector2 launchVector = new Vector2(0f, 1f);
        rb.AddForce(launchVector * launchForce);
    }
}
