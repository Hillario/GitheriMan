using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateSaw : MonoBehaviour {

    [SerializeField]
    private float speed = 60f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate() {
        transform.Rotate(new Vector3(0f, 0f, -speed * Time.deltaTime));
    }
}
