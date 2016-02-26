using UnityEngine;
using System.Collections;

public class EngineL : MonoBehaviour {
    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {/*
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddRelativeForce(new Vector2(0, 25));
        }*/
	}
}
