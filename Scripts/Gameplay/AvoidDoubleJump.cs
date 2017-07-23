using UnityEngine;
using System.Collections;

public class AvoidDoubleJump : MonoBehaviour 
{
	private Collider Other;
	public static bool CollisionTrue;

	 void OnTriggerEnter(Collider Other)
	{
		if (Other.gameObject.tag == "Land" || Other.gameObject.tag == "JumpMultiplier") {			
			CharMovement.jumping = false;	
			CollisionTrue = true;	
				}
	}

	/*void Update()
	{
				if (CollisionTrue == true)
		{
			Debug.Log ("On Ground");
		}

				else
			Debug.Log ("In air!");
	}*/



}
