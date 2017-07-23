using UnityEngine;
using System.Collections;

public class CameraMotionWithCharcter : MonoBehaviour {

	public GameObject Character;

	private Vector3 CharPosition;
	private Vector3 Position1;
	private Vector3 Position2;


	void Start()
	{
		Position1 = transform.position;

	
	}

	void Update()
	{ if (!CharMovement.jumping) {
						Position2 = Position1;
						CharPosition = Character.transform.position;

						Debug.Log ("Char Position" + Character.transform.position);
						Position2 = Position1;
						Position2.y = CharPosition.y + 4;
						camera.transform.position = Vector3.Lerp (Position1, Position2, 1.0f);
				}

	
	}

}


