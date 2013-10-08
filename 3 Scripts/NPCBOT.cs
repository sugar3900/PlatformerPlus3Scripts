using UnityEngine;
using System.Collections;

public class NPCBOT : MonoBehaviour {
	
	void Start () {}
			
	void Update () {
		rigidbody.AddForce( Vector3.forward );
	}
	
	
	void FixedUpdate() {
		
		Vector3 forward = transform.TransformDirection(Vector3.forward) ;
		RaycastHit hit;
		Ray collisionRay = new Ray( transform.position, Vector3.forward );
		Debug.DrawLine(transform.position, Vector3.forward, Color.red);
		
		
		
		if (Physics.Raycast( collisionRay, out hit, 3 ) ){	
			int randNum = Random.Range (0,10);
			
			if( randNum < 5 ) {
				transform.Rotate(Vector3.up, 90 * 5* Time.smoothDeltaTime);
			}
			
			else {
				transform.Rotate ( Vector3.up, -90 * 5 * Time.smoothDeltaTime );
			}
	
		}
		
		
	}
}