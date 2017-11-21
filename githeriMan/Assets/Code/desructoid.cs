using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desructoid : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        StartCoroutine("destroy");
    }
    IEnumerator destroy()
    {
        yield return new WaitForSeconds(8);
        Destroy(gameObject);
    }
}
