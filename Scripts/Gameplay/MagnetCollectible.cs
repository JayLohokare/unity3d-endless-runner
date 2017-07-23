using UnityEngine;
using System.Collections;

public class MagnetCollectible : MonoBehaviour {

	public GameObject Character;


	void OnTriggerEnter(Collider Other )
	{

		if (Other.gameObject.tag == "Coin") {
			//Debug.Log ("Hit");
			Other.gameObject.transform.position = Vector3.MoveTowards(Other.gameObject.transform.position, Character.transform.position, Time.deltaTime*500);
			Other.GetComponent<CollectiblesMotionScript>().enabled = false;
			//Destroy (Other.gameObject,2);

		}

	}
}



			