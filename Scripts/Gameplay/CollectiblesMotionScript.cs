using UnityEngine;
using System.Collections;

public class CollectiblesMotionScript : MonoBehaviour {

	void Update()

	{
		if(PlaneMotion.GameOn)
		rigidbody.transform.Rotate (new Vector3 (90, 0, 0) * Time.deltaTime);

	}



}
