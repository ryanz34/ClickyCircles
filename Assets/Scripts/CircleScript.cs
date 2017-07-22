using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleScript : MonoBehaviour {

    public SpawnerController spawner;
    void Start () {
		
    }
	
    void Update () {
		
    }

    void OnMouseDown()
    {
        spawner.ObjectSpawned = false;
        Destroy(transform.gameObject);
    }
}
