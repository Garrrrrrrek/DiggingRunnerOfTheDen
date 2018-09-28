using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteControl : MonoBehaviour {

    public Sprite walkLeft;
    public Sprite walkRight;
    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("d"))
        {

            spriteRenderer.sprite = walkRight;


        }

        if (Input.GetKey("a"))
        {

            spriteRenderer.sprite = walkLeft;

        }
    }
}
