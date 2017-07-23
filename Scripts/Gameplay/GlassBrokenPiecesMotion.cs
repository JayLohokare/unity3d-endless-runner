using UnityEngine;
using System.Collections;

public class GlassBrokenPiecesMotion : MonoBehaviour {

	void FixedUpdate()
	{
		transform.Translate (Vector3.down * PlaneMotion.PlaneSpeed *0.5f);
		
	}
}
