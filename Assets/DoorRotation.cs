using UnityEngine;
using System.Collections;

public class DoorRotation : MonoBehaviour {

    private Vector3 pivotPoint;
    public float rotationSpeed = 10.0f;

    // Use this for initialization
    void Start () {
        pivotPoint = new Vector3(0.0f, 0.0f, -6.88f);
    }
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(pivotPoint, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}