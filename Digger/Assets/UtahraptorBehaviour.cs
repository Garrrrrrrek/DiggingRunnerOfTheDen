using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtahraptorBehaviour : MonoBehaviour {

    public Rigidbody2D utahraptorBody;
    public Sprite walkLeft;
    public Sprite walkRight;
    private SpriteRenderer spriteRenderer;

    public float maxSpeed = 10f;

    public int walkingCycle = 0;
    public bool walkingLeft = true;

	// Use this for initialization
	void Start () {

        spriteRenderer = GetComponent<SpriteRenderer>();

    }
	
	// Update is called once per frame
	void FixedUpdate () {

        if(walkingCycle < 100 && walkingLeft)
        {

            utahraptorBody.AddForce(new Vector2(-5, 0), ForceMode2D.Impulse);

            if (utahraptorBody.velocity.magnitude > maxSpeed)
            {
                utahraptorBody.velocity = utahraptorBody.velocity.normalized * maxSpeed;

            }

            walkingCycle++;

            if(walkingCycle == 100)
            {
                walkingLeft = false;
                spriteRenderer.sprite = walkRight;
            }

        }

        if (walkingCycle > 0 && !walkingLeft)
        {

            utahraptorBody.AddForce(new Vector2(5, 0), ForceMode2D.Impulse);

            if (utahraptorBody.velocity.magnitude > maxSpeed)
            {
                utahraptorBody.velocity = utahraptorBody.velocity.normalized * maxSpeed;

            }

            walkingCycle--;

            if (walkingCycle == 0)
            {
                walkingLeft = true;
                spriteRenderer.sprite = walkLeft;
            }

        }

    }
}
