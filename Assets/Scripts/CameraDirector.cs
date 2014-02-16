using UnityEngine;
using System.Collections;

public class CameraDirector : MonoBehaviour {

    public float yOffset = 1.3F;
    public float yBase = 0F;

    private GameObject playerObject;

	// Use this for initialization
	void Start () {
        if(GameObject.FindGameObjectWithTag("Player") != null)
        {
            playerObject = GameObject.FindGameObjectWithTag("Player");
            transform.position = new Vector3(playerObject.transform.position.x, playerObject.transform.position.y + yOffset, transform.position.z);
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.FindGameObjectWithTag("Player") != null)
            transform.position = new Vector3(playerObject.transform.position.x, playerObject.transform.position.y + yOffset, transform.position.z);

        if (transform.position.y <= yBase)
            transform.position = new Vector3(playerObject.transform.position.x, yBase, transform.position.z);
	}
}
