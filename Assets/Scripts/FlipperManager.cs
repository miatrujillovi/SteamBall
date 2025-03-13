using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlipperManager : MonoBehaviour
{
    public HingeJoint2D rFlipper, lFlipper;

    //Llamando al Input System
    public InputSystem_Actions inputAction;
    public InputAction Right_Flipper, Left_Flipper;

    //Subscribing...
    private void OnEnable()
    {
        Right_Flipper = inputAction.Player.Right_Flipper;
        Right_Flipper.Enable();
        Right_Flipper.performed += RightFlipperButton; //For Buttons

        Left_Flipper = inputAction.Player.Left_Flipper;
        Left_Flipper.Enable();
        Left_Flipper.performed += LeftFlipperButton; //For Buttons
    }

    //Desubscribing...
    /*private void OnDisable()
    {
        Right_Flipper.Disable();
        Left_Flipper.Disable();
    }*/

    //Inicializando
    private void Awake()
    {
        inputAction = new InputSystem_Actions();
    }

    //move.ReadValue<Vector2D>(); Esto es si Action Type del Input es un Value

    public void RightFlipperButton(InputAction.CallbackContext context)
    {
        rFlipper.useMotor = true;
        StartCoroutine(RetreatFlipper(rFlipper));
    }

    public void LeftFlipperButton(InputAction.CallbackContext context)
    {
        lFlipper.useMotor = true;
        StartCoroutine(RetreatFlipper(lFlipper));
    }

    IEnumerator RetreatFlipper(HingeJoint2D _flipper)
    {
        yield return new WaitForSeconds(0.1f);
        _flipper.useMotor = false;
    }
}
