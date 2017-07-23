using UnityEngine;
using System.Collections;

public class JETPACKhover : MonoBehaviour {

	public GameObject Character;
	private Vector3 pos1;
	private Vector3 pos2;



	void Update()
	{	

				pos1 = Character.transform.position;
				pos2 = Character.transform.position;
				pos1.x = 5.8f;
				pos2.x = -5.8f;


				if (PlaneMotion.GameOn && Character.transform.position.x >= -6 && Character.transform.position.x <= 6)
						transform.Translate (Input.acceleration.x, 0, 0);

				if (Character.transform.position.x > 6) {
						Character.transform.position = Vector3.MoveTowards (Character.transform.position, pos1, 1f);
				}
				
				if (Character.transform.position.x < -6) {
						Character.transform.position = Vector3.MoveTowards (Character.transform.position, pos2, 1f);
				}
		}

}