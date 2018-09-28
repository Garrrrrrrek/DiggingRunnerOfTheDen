using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanionMovement : MonoBehaviour {

    public GameObject player;
    private float offset;
    private float offset2;

    public Sprite walkLeft;
    public Sprite walkRight;
    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        offset = transform.position.x - player.transform.position.x;
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.position.x - player.transform.position.x) < offset)
        {
            
                transform.position = new Vector3(player.transform.position.x + offset, transform.position.y, transform.position.z);
                spriteRenderer.sprite = walkRight;



        }

        if ((player.transform.position.x - transform.position.x) < offset)
        {

            transform.position = new Vector3(player.transform.position.x - offset, transform.position.y, transform.position.z);
            spriteRenderer.sprite = walkLeft;



        }

        //transform.position = new Vector3(player.transform.position.x + offset2, transform.position.y, transform.position.z);

    }

    private void LateUpdate()
    {
        
    }
}
