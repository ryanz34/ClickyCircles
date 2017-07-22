using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public Transform mount;

	void Start () {
        float zScale = transform.position.z - mount.position.z;
        float height = Mathf.Abs(2.0f * Mathf.Tan(0.5f * Camera.main.fieldOfView * Mathf.Deg2Rad) * zScale);
        float width = Mathf.Abs(height * Screen.width / Screen.height);

        transform.localScale = new Vector3(width, height, 1f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
