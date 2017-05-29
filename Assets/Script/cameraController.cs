using UnityEngine;
using System.Collections;

public class cameraController : MonoBehaviour {

    public float speed;
    public GameObject player;
    private Vector3 offset;

    //Might not need Start or Update
	void Start () {
        offset = transform.position - player.transform.position;
	}

	void Update () {
        transform.position = player.transform.position + offset;
	}

    //Add the 360 rotation; May need to delete
    public void rotateCamera()
    {
        Camera.main.transform.eulerAngles = Vector3.Lerp(Camera.main.transform.eulerAngles, new Vector3(90, 0, 0), Time.deltaTime * speed);
    }
    public void rotateCameraRight()
    {
        transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0, 90, 0), Time.deltaTime * speed);
    }

    public void rotateCameraLeft()
    {
        transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0, -90, 0), Time.deltaTime * speed);
    }

    public void rotateCameraForward()
    {
        transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0, 0, 0), Time.deltaTime * speed);
    }
}
