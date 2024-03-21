using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 700f;
    public float sideForce = 500f;
    private bool isAlive = true;

    void FixedUpdate()
    {
        if (isAlive)
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);

            if (Input.GetKey("d"))
            {
                rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (Input.GetKey("a"))
            {
                rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (rb.position.y < -3f)
            {
                kill();
            }
        }
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            kill();
        }
    }

    void kill()
    {
        isAlive = false;
        FindObjectOfType<GameManager>().EndGame();
    }
}
