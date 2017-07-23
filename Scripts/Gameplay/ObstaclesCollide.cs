using UnityEngine;
using System.Collections;

public class ObstaclesCollide : MonoBehaviour {
	
	
	public static bool Jetpack;
	public GameObject Character;
	public static int JetPackTime;
	public static bool goingup;
	private bool goingdown;
	public static int SuperJumpTime;
	public static int coins;

	public static int MagnetCollectTime;
	public GameObject MagnetCollectCollider;

	
	
	void Start()
	{
		Jetpack = false;
		coins = 0;
		SuperJumpTime = PlayerPrefs.GetInt ("SuperJumpTime");
		JetPackTime = PlayerPrefs.GetInt ("JetPackTime");
		MagnetCollectTime = PlayerPrefs.GetInt ("MagnetCollectTime");
	}
	
	void OnTriggerEnter (Collider Other) {

		if (Other.gameObject.tag == "Coin") 
		{
			Destroy (Other.gameObject);
			coins+=1;

		}


		if (Other.gameObject.tag == "MagnetCollectible") 
		{
			Destroy (Other.gameObject);
			MagnetCollectCollider.SetActive(true);
			Invoke("MagnetCollectibleOver", MagnetCollectTime);
		}

		if (Other.gameObject.tag == "Obstacle") 
		{
			PlaneMotion.GameOn = false;
			
		}
		
		if (Other.gameObject.tag == "JumpMultiplier") {
			CharMovement.jumpVar = 100;
		}
		if (Other.gameObject.tag == "BulletCollect") {
			Destroy(Other.gameObject);
			NoOfBulletsText.NoOfBullets += 5;
		}
		
		if (Other.gameObject.tag == "SuperJumpCollectible") {
			Destroy(Other.gameObject);
			CharMovement.jumpVar = 50;
			Invoke ("SuperJumpOver",SuperJumpTime);
		}
		
		if(AvoidDoubleJump.CollisionTrue)
		if (Other.gameObject.tag == "JetPackCollectible") {
			Character.GetComponent<CharMovement>().enabled = false;
			Destroy(Other.gameObject);
			goingup = true;
			Jetpack = true;
			Physics.gravity = new Vector3 (0, 0, 0);
			PlaneMotion.PlaneSpeed += 0.5f;
			
		
			Character.GetComponent<JETPACKhover>().enabled = true;


			Invoke ("JetPackOver",JetPackTime);
			
			
		}
		
	}
	
	void OnTriggerExit(Collider Other)
	{
		if (Other.gameObject.tag == "JumpMultiplier")
			CharMovement.jumpVar = 5;
	}
	
	void JetPackOver()
	{
		Jetpack = false;
		PlaneMotion.PlaneSpeed -= 0.5f;
		Physics.gravity = new Vector3 (0, -50, 0);
		Character.GetComponent<CharMovement> ().enabled = true;
		Character.GetComponent<JETPACKhover>().enabled = false;
	}
	
	void SuperJumpOver()
	{
		CharMovement.jumpVar = 5;
	}

	void MagnetCollectibleOver(){
		MagnetCollectCollider.SetActive (false);
		}

	void Update()
	{if(goingup)  {

		if (Character.transform.position.y < 25)
			Character.transform.Translate (Vector3.up * 2);

		if (Character.transform.position.y > 25) {
						goingup = false;
						return;
				}

	}	}
			
		
	
	
}
