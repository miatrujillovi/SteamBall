using UnityEngine;
using UnityEngine.InputSystem;

public class FlipperController : MonoBehaviour
{
    //Bool to help differentiate between right and left flippers.
    public bool flipper;

    // Update is called once per frame
    void FixedUpdate()
    {
        //Depending on the button pressive, it will activate the useMotor of the respective flipper
        /*if ((flipper && OnRight_Flipper()) || (!flipper && OnLeft_Flipper()))
        {
            GetComponent<HingeJoint2D>().useMotor = true;
        }
        else
        {
            GetComponent<HingeJoint2D>().useMotor = false;
        }*/
    }
}
