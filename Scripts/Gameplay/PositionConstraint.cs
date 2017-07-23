using UnityEngine;
using System.Collections;

public class PositionConstraint : MonoBehaviour 
{


	private Vector3 pos1;
	private Vector3 pos2;
	private Vector3 pos3;
	private Vector3 pos4;

	void Start()
	{
		pos1 = transform.position;
      //  pos2 = transform.position;
 		//pos3 = transform.position;
		pos4 = transform.position;

		pos1.x = -6f;
		//pos2.x = -2f;
		//pos3.x = 2f;
		pos4.x = 6f;
	}


	void Update()
	{
		if (transform.position.x < -6 && transform.position != pos1) {
			if((ObstaclesCollide.Jetpack) && (Input.acceleration.x	<0))		
			     transform.Translate (-Input.acceleration.x ,0,0);


				}

		if (transform.position.x > 6 && transform.position != pos4) {
			if((ObstaclesCollide.Jetpack) && (Input.acceleration.x	>0))	
				transform.Translate (-Input.acceleration.x ,0,0);


				}
				}




}






