using UnityEngine;
using System.Collections;

public class DownWileJumping : MonoBehaviour 
{

	private int touchcount;
	private Vector2 initTouchPos;
	int fingercount=0;
	private Vector3 Position1;
	private Vector3 Position2;
	
	
	
	void Update()
	{   
		Position1 = transform.position;
		Position2 = Position1;
		
		foreach (Touch touch in Input.touches) {
			if (touch.phase == TouchPhase.Began) {
				initTouchPos = touch.position;
			}
			
			if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled) {
				fingercount++;
			}
			
			if (fingercount == 1 && touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Ended) {
				Vector2 touchFacing = (initTouchPos - touch.position).normalized;
				
				if (Vector2.Dot (touchFacing, Vector2.up) > 0.6 && Vector2.Distance (initTouchPos, touch.position) > 50) 
					
					
				{
					if(AvoidDoubleJump.CollisionTrue ==false)
					{
						rigidbody.AddForce(-Vector3.up * 10000);
					}
				}}}}}
