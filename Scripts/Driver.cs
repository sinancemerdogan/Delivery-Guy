using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float turnSpeed = 300f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float bumpSpped = 15f;
    [SerializeField] float boostSpeed = 30f;

    void Update()
    {
        float turnAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -turnAmount);

        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, moveAmount, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        moveSpeed = bumpSpped;
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Boost") 
        {
            moveSpeed = boostSpeed;
        }
    }
}
