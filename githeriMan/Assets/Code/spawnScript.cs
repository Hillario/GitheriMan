using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour {


    public GameObject[] toSpawn;   //spawnable prefabs
    public float minInterval = 1f;   //minimum interval for spawning a prefab
    public float maxInterval = 2f;   //maximum interval for spawning a prefab

    private Rigidbody2D myRigidBody;
    public float speed = 12f;

    private float lastx = 0f;
	// Use this for initialization
	void Start () {
        myRigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate() {
        myRigidBody.velocity = new Vector2(1f * speed, myRigidBody.velocity.y);
     //has enough time passed since last spawn
        if (transform.position.x>(lastx+38))
        {                     
            //select and instantiate a random prefab
            int randomIndex = Random.Range(0, toSpawn.Length);
            Instantiate(toSpawn[randomIndex], transform.position, Quaternion.identity);
            lastx = transform.position.x;            
        }
        
    }
}
