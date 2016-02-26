using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {
    private GameController gameController;
    // Use this for initialization
    void Start () {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "GoalL")
        {
            gameController.AddScoreL();
        } if(other.gameObject.tag == "GoalR")
        {
            gameController.AddScoreR();
        }
    }
}
