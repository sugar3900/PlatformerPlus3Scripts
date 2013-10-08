using UnityEngine;
using System.Collections;

public class Platformer : MonoBehaviour {

	public bool onGround = true;
	
	void Start () {
	
	}
	
	
	void Update () {
		
		
		//test if on ground
		if ( Physics.Raycast( transform.position, Vector3.down, (transform.localScale.y)/2 + (transform.localScale.y)/5 ) ) {
			onGround = true;
		}
		else { onGround = false; }
		
		//jump
		if (Input.GetKey ( "space" ) && onGround ) {
			rigidbody.AddForce ( 0, 100 + transform.localScale.y , 0 );
		}
		
		
		//left or right
		if ( Input.GetKey(KeyCode.LeftArrow) ) {
			rigidbody.AddForce( -20, 0, 0 );
		}
		if ( Input.GetKey ( KeyCode.RightArrow ) ) {
			rigidbody.AddForce( 20, 0, 0 );
		}

		
		//grow or shrink
		if (Input.GetKey (KeyCode.UpArrow )) {
			transform.localScale += new Vector3( 0.5f, 0.5f, 0.5f ) * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.DownArrow )) {
			transform.localScale -= new Vector3( 0.5f, 0.5f, 0.5f ) * Time.deltaTime;
		}
		
		
		
		
		
		
		
		
	}
		
}
