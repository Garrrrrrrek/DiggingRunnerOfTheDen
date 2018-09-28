using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour {

    public Rigidbody2D diggerBody;
    

   

    public float distToGround;

    public float frameTime;
    public float xVel;
    public float maxSpeed = 10f;

    public Vector2 genericForce = new Vector2(100, 100);
    public Vector2 walkingRight = new Vector2(5, 0);
    public Vector2 walkingLeft = new Vector2(-5, 0);

    public bool couldDig = false;
    public bool grounded = false;


    // Use this for initialization
    void Start () {

        
        //diggerBody.AddForce(genericForce);

    }

    private void Update()
    {

       

    }



   

    // Update is called once per frame
    void FixedUpdate () {


        frameTime = Time.deltaTime;

        //xVel = diggerBody.velocity.x;

        if (Input.GetKey("d"))
        {
            

            diggerBody.AddForce(walkingRight * frameTime, ForceMode2D.Impulse);

            if (diggerBody.velocity.magnitude > maxSpeed)
            {
                diggerBody.velocity = diggerBody.velocity.normalized * maxSpeed;

            }

        }

        if (Input.GetKey("a"))
        {
           

            diggerBody.AddForce(walkingLeft * frameTime, ForceMode2D.Impulse);

            if (diggerBody.velocity.magnitude > maxSpeed)
            {
                diggerBody.velocity = diggerBody.velocity.normalized * maxSpeed;

            }
        }

        

        if (Input.GetKey("s") && couldDig)
        {
            Debug.Log("Would dig");
        }

      
   

    }
}
