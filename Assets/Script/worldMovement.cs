using UnityEngine;
using System.Collections;

public class worldMovement : MonoBehaviour {
    public int xAngle = 0;
    public int yAngle = 0;
    public int zAngle = 0;
    public int speed = 3;
    //Android use public void and attach to UI button for control
    //Computer use input.getKey
    //Moves "object" forward 10 paces
    public void moveCharForward()
    {
        transform.Translate(0, 0, 10);
    }

    public void moveCharLeft()
    {
        transform.Translate(-10, 0, 0);
    }

    public void moveCharRight()
    {
        transform.Translate(10, 0, 0);
    }

    public void moveCharBack()
    {
        transform.Translate(0, 0, -10);
    }

    public void rotateCharRight()
    {
        transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0, yAngle, 0), Time.deltaTime * speed);
    }

    public void rotateCharLeft()
    {
        transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0, -yAngle, 0), Time.deltaTime * speed);
    }

    public void rotateCharForward()
    {
        transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0, 0, 0), Time.deltaTime * speed);
    }

    //Not working as expected
    public void rotateCharRear()
    {
        transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0, -180, 0), Time.deltaTime * speed);
    }
}
