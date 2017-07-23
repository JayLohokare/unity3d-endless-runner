using UnityEngine;
using System.Collections;

public class CamRandomMotion : MonoBehaviour {

	private int i;
	/*public Transform Position1;
	public Transform Position2;
*/

	void Update() {

				if (!StartG.AtMainMenu) {
						transform.Rotate (Vector3.up * Time.deltaTime * 2.0f);
						//transform.position = Vector3.Lerp (Position1.position, Position2.position, 1.0f);
	
				}
		}
}
