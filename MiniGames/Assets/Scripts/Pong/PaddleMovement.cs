using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaddleMovement : MonoBehaviour
{
    

    public Transform leftPaddle;
    public Transform rightPaddle;


    public float moveSpeed = 4f;

    private float maximumYPos;
    private float minimumYPos;

    void Start ()
    {
        maximumYPos = Camera.main.orthographicSize - leftPaddle.localScale.y / 2;
        minimumYPos = -maximumYPos;
	}
	
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.W))
        {
            leftPaddle.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            leftPaddle.Translate(-Vector3.up * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rightPaddle.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rightPaddle.Translate(-Vector3.up * moveSpeed * Time.deltaTime);
        }

        Vector3 lPos = leftPaddle.position;
        lPos.y = Mathf.Clamp(lPos.y, minimumYPos, maximumYPos);
        leftPaddle.position = lPos;

        Vector3 rPos = rightPaddle.position;
        rPos.y = Mathf.Clamp(rPos.y, minimumYPos, maximumYPos);
        rightPaddle.position = rPos;
    }
}
