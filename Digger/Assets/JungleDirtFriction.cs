using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JungleDirtFriction : MonoBehaviour {

    public BoxCollider2D jungleDirtCollider = new BoxCollider2D();

	// Use this for initialization
	void Start () {

        jungleDirtCollider.sharedMaterial.friction = 0.0f;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
