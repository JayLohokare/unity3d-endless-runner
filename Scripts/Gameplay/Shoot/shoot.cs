using UnityEngine;
using System.Collections;
	
public class shoot : MonoBehaviour {

	public GameObject projectile;
	public Transform InstantiatePosition;
	public Transform InstantiateRotation;


	void OnMouseDown() 
	{
		if (NoOfBulletsText.NoOfBullets > 0 && !ObstaclesCollide.Jetpack && AvoidDoubleJump.CollisionTrue) {
			Instantiate (projectile, InstantiatePosition.position, InstantiateRotation.rotation);
			NoOfBulletsText.NoOfBullets -= 1;
				}


	}
}
