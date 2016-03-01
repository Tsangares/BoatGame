using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {
    private ScoreController scoreController;
    // Use this for initialization
    void Start () {
        GameObject scoreControllerObject = GameObject.FindWithTag("ScoreManager");
        if (scoreControllerObject != null)
        {
            scoreController = scoreControllerObject.GetComponent<ScoreController>();
        }
        if (scoreController == null)
        {
            Debug.Log("Cannot find 'ScoreController' script");
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "GoalL")
        {
            scoreController.AddScoreL();
        } if(other.gameObject.tag == "GoalR")
        {
            scoreController.AddScoreR();
        }
    }
}
