using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementScript : MonoBehaviour {

    Transform trans;

    public GameObject playerCam;

    public float moveSpeedWS, moveSpeedAD, camSpeed;

	void Start () {
        trans = GetComponent<Transform>();
	}
	
	void Update () {
        //WASD Movement
        if (Input.GetKey(KeyCode.D))
            trans.Translate(0, 0, -moveSpeedAD);
        if (Input.GetKey(KeyCode.A))
            trans.Translate(0, 0, moveSpeedAD);

        if (Input.GetKey(KeyCode.W))
            trans.Translate(moveSpeedWS, 0, 0);
        if (Input.GetKey(KeyCode.S))
            trans.Translate(-moveSpeedWS, 0, 0);

        //Camera Movement
        if (Input.GetAxisRaw("Mouse X") > 0)
            trans.Rotate(0.0f, camSpeed, 0.0f);
        if (Input.GetAxisRaw("Mouse X") < 0)
            trans.Rotate(0.0f, -camSpeed, 0.0f);
    }
}
