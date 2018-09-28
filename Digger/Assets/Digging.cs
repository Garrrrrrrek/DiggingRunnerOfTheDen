using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Digging : MonoBehaviour {

    public Sprite dug;
    public Sprite notDug;
    private SpriteRenderer spriteRenderer;

    public BoxCollider2D bc;
    public Vector2 v2dug = new Vector2(0.86f, 0.25f);
    public Vector2 v2 = new Vector2(0.86f, 0.85f);

    public LayerMask groundLayer;

    // Use this for initialization
    void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
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

        if (Input.GetKey("s"))
        {



            if (IsGrounded())
            {
               

                bc.size = v2dug;
                spriteRenderer.sprite = dug;
            }

     

        }

        if (Input.GetKey("w"))
        {



            if (IsGrounded())
            {
                bc.size = v2;
                spriteRenderer.sprite = notDug;
            }

        }

    }
}
