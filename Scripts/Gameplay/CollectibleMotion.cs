using UnityEngine;
using System.Collections;

public class CollectibleMotion : MonoBehaviour {

	void Update()
	{
		rigidbody.transform.Rotate (new Vector3 (90, 0, 0) * Time.deltaTime);
	}
}
