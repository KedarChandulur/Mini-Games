using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class BallMovement : MonoBehaviour {

    private Rigidbody ballRB;

    private float speedX = 10f;
    private float speedY = 10f;

    public Text leftPlayerText;
    public Text rightPlayerText;

    int leftPlayerScore = 0;
    int rightPlayerScore = 0;

    void Start ()
    {
        ballRB = GetComponent<Rigidbody>();
	}
	
	
	void Update ()
    {
        		
	}

    private void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            ballRB.velocity = new Vector3(speedX, speedY, 0);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LeftWall")
        {
            rightPlayerScore++;
            rightPlayerText.text = rightPlayerScore.ToString();
            ballRB.velocity = Vector3.zero;
            transform.position = Vector3.zero;            
        }
        if (other.gameObject.tag == "RightWall")
        {
            leftPlayerScore++;
            leftPlayerText.text = leftPlayerScore.ToString();
            //ballRB.velocity = Vector3.zero;
            transform.position = Vector3.zero;
        }
    }
}
