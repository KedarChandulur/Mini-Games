using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour {

    public float movementSpeed = 5f;

    private Transform snakeHead;

	void Start ()
    {
        if(transform.childCount > 0)
            snakeHead = transform.GetChild(0);	
	}
	
	
	void Update () {

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;


        Vector3 dirOfTravel = (mousePosition - snakeHead.position).normalized;

        snakeHead.Translate(dirOfTravel * movementSpeed * Time.deltaTime);

        for (int i = 0; i < transform.childCount - 1; i++)
        {
            Transform parent = transform.GetChild(i);
            Transform child = transform.GetChild(i + 1);

            child.localPosition = Vector3.Lerp(child.localPosition, parent.localPosition - (dirOfTravel)/2, 15 * Time.deltaTime);
        }

	}
}
