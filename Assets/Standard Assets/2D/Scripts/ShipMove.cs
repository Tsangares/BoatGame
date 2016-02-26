using UnityEngine;
using System.Collections;

public class ShipMove : MonoBehaviour {
    public Rigidbody2D eL, eR, hull;
    public int engineForce = 25, hopForce = -1000;
    private float hopTime;
    public float timeBetweenHop = .5F;
    public string pL = "pushL_P1", pR = "pushR_P1", hop = "hop_P1";
    // Use this for initialization
    void Start () {
        hopTime = Time.time;
	}
	// Update is called once per frame
	void Update () {
        if (Input.GetButton(pR) || Input.GetAxis(pR) != 0)
        {//add force to right engine
            eR.AddRelativeForce(new Vector2(0, engineForce * Input.GetAxis(pR)));
        } if (Input.GetButton(pL) || Input.GetAxis(pL) != 0)
        {//add force to left engine
            eL.AddRelativeForce(new Vector2(0, engineForce * Input.GetAxis(pL)));
        } if (Input.GetButton(hop) && (hopTime < Time.time - timeBetweenHop))
        {//hop!
            hull.AddRelativeForce(new Vector2(0, hopForce));
            hopTime = Time.time;
        }
    }
}
