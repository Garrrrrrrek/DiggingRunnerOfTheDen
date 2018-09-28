using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour {

    public Rigidbody2D diggerBody;
    public LayerMask groundLayer;

    // Use this for initialization
    void Start () {
		
	}

    bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 0.8f;

        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }

        return false;
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKey("space"))
        {



            if (IsGrounded())
            {
                diggerBody.AddForce(new Vector2(0, 100) * Time.deltaTime, ForceMode2D.Impulse);

            }

        }

    }
}
