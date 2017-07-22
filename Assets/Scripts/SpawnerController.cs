using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour {

    public Transform mount;
    public bool ObjectSpawned = false;
    public Transform circles;
    private float height;
    private float width;
    public Transform Cam;

    void Start()
    {

        float zScale = transform.position.z - mount.position.z;
        height = Mathf.Abs(2.0f * Mathf.Tan(0.5f * Camera.main.fieldOfView * Mathf.Deg2Rad) * zScale);
        width = Mathf.Abs(height * Screen.width / Screen.height);

        transform.localScale = new Vector3(width, height, 1f);
    }
     
    // Update is called once per frame
    void Update () {
        if (Mathf.Round(Cam.position.z) == 10 && !ObjectSpawned)
        {
            Instantiate(circles, new Vector3(transform.position.x + Random.Range(-width / 2, width / 2), transform.position.x + Random.Range(-height / 2, height / 2), transform.position.z), transform.rotation);
            ObjectSpawned = true;
        }
	}
}
