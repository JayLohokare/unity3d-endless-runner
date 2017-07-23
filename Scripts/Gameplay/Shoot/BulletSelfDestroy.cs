using UnityEngine;
using System.Collections;

public class BulletSelfDestroy : MonoBehaviour {
	
	void OnTriggerEnter(Collider Other)
	{
		if (Other.gameObject.tag == "Bullet")
						Destroy (Other.gameObject);		

}
}