using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform mount;
    public float speed = 0.1f;

	void Start () {
		
	}
	
	void Update () {

        transform.position = Vector3.Lerp(transform.position, mount.position, speed);

	}

    public void setMount(Transform newMount) {
        mount = newMount;
    }
}
