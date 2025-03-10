using UnityEngine;
using UnityEngine.InputSystem;

public class FlipperController : MonoBehaviour
{
    /* Script that allows the player to interact with the flippers using the property of Use Motor
     * in Hinge Joint 2D. */

    //Bool to help differentiate between right and left flippers.
    public bool flipper;

    // Update is called once per frame
    void FixedUpdate()
    {
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
