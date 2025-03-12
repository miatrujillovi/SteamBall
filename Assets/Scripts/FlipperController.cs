using UnityEngine;
using UnityEngine.InputSystem;

public class FlipperController : MonoBehaviour
{
    public HingeJoint2D rFlipper, lFlipper;

    public string active;

    //Llamando al Input System
    public InputSystem_Actions inputAction;
    public InputAction Right_Flipper, Left_Flipper;

    //Subscribing...
    private void OnEnable()
    {
        Debug.Log("Llamada");
        Right_Flipper = inputAction.Player.Right_Flipper;
        Right_Flipper.Enable();
        Right_Flipper.performed += RightFlipperButton;

        Left_Flipper = inputAction.Player.Left_Flipper;
        Left_Flipper.Enable();
        Left_Flipper.performed += LeftFlipperButton;
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

    // Update is called once per frame
    void FixedUpdate()
    {
        //Depending on the button pressive, it will activate the useMotor of the respective flipper
        if (active == "Right")
        {
            Debug.Log("Paso el IF Right");
            //rFlipper.useMotor = true;
        }
        else if (active == "Left")
        {
            Debug.Log("Paso el IF Left");
            //lFlipper.useMotor = false;
        }
    }

    //move.ReadValue<Vector2D>(); Esto es si Action Type del Input es un Value

    public void RightFlipperButton(InputAction.CallbackContext context)
    {
        Debug.Log("La funcion Right NO JALA");
        active = "Right";
    }

    public void LeftFlipperButton(InputAction.CallbackContext context)
    {
        Debug.Log("La funcion Left NO JALA");
        active = "Left";
    }
}
