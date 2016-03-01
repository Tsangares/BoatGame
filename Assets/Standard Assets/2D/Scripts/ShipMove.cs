using UnityEngine;
using System.Collections;

public class ShipMove : MonoBehaviour {
    public Rigidbody2D eL, eR, hull, ball;
    public int engineForce = 35, hopForce = -1000;
    private float hopTime;
    public float timeBetweenHop = .5F;
    public float tractForce = 35, tractDistance = 1;
    private Vector2 ballHullDif;
    public string pL = "pushL_P1", pR = "pushR_P1", hop = "hop_P1", tractorBeam = "tract_P1";
    // Use this for initialization
    void Start () {
        hopTime = Time.time;
    }
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis(pR) != 0)
            eR.AddRelativeForce(new Vector2(0, engineForce * Input.GetAxis(pR)));
        if (Input.GetButton(pR))
        {//add force to right engine
            eR.AddRelativeForce(new Vector2(0, engineForce));
        }
        if (Input.GetAxis(pL) != 0)
            eL.AddRelativeForce(new Vector2(0, engineForce * Input.GetAxis(pL)));
        if (Input.GetButton(pL))
        {//add force to left engine
            eL.AddRelativeForce(new Vector2(0, engineForce));
        } if (Input.GetButton(hop) && (hopTime < Time.time - timeBetweenHop))
        {//hop!
            hull.AddRelativeForce(new Vector2(0, hopForce));
            hopTime = Time.time;
        } if (Input.GetButton(tractorBeam))
        {
            if (ball.position.x - hull.position.x < tractDistance && ball.position.y - hull.position.y < tractDistance)
            {
                ballHullDif = hull.position - ball.position;
                ballHullDif.Normalize();
                ball.AddForce(ballHullDif * tractForce);
            }
        }
    }
}
