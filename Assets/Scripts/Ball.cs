using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public Vector2 startingVelocity = new Vector2(15, -20);
    private Vector3 startingPosition;
    public GameObject gameOverSign;
    public GameObject youWinSign;
    public UnityEngine.UI.Text livesValue;
    public UnityEngine.UI.Text pointsValue;

    int lives = 3;
    int points = 0;
    public int bricks;

    // Use this for initialization
    void Start()
    {
        startingPosition = transform.position;
        GetComponent<Rigidbody2D>().velocity = startingVelocity;
        livesValue.text = lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -3.6f)
        {
            GetOut();
        }

        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().velocity = startingVelocity;
        }

    }

    void GetOut()
    {
        Debug.Log("You are out");
        lives = lives - 1;
        livesValue.text = lives.ToString();

        transform.position = startingPosition;
        GetComponent<Rigidbody2D>().velocity = new Vector2();
        if (lives == 0)
        {
            DoGameOver();
        }



    }
    void DoGameOver()
    {
        gameOverSign.SetActive(true);
    }

    public void YouBrokeABrick()
    {
        points += 1;
        pointsValue.text = points.ToString();
        bricks--;
        if (bricks == 0)
        {
            youWinSign.SetActive(true);
            gameObject.SetActive(false);
        }

    }
}