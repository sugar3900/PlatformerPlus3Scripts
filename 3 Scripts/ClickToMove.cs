using UnityEngine;
using System.Collections;

public class ClickToMove : MonoBehaviour {
	
	public Vector3 destination = new Vector3(0,0,0);
	public float stopDistance = 3f;
	
	
	

	void Start () {
	
	}
	
	void Update () {
		
		Ray ray1 = Camera.main.ScreenPointToRay( Input.mousePosition );
		RaycastHit rayHit = new RaycastHit();
		

		
		if( Mathf.Abs( (destination - transform.position).magnitude ) > stopDistance ) {
			rigidbody.AddForce( Vector3.Normalize((destination - transform.position)*100) );
		}
		
		if ( Input.GetMouseButtonDown(0) ) {
			
			if ( Physics.Raycast( ray1, out rayHit, 100000f ) ) {
			destination = rayHit.point;
			}
		}
		
	}
}
