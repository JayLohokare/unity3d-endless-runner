using UnityEngine;
using System.Collections;

public class StartG : MonoBehaviour {

	public static bool ButtonHit;
	public GameObject PauseMenuComponents;
	public GameObject MainMenuComponents;
	public GameObject MenuComponents;
	public GameObject GamePlayButtonComponents;
	public static bool AtMainMenu;
	public GameObject MainCamera;

	public GameObject Character;
	public GameObject CharCollider;
	public GameObject EnterNameButton;

		
	void Start()
	{
		//PlayerPrefs.DeleteAll ();
		MenuComponents.SetActive (true);
		MainMenuComponents.SetActive (true);
		PauseMenuComponents.SetActive (false);
		GamePlayButtonComponents.SetActive (false);
		CharCollider.GetComponent<ObstaclesCollide> ().enabled = false;
		Character.GetComponent<CharMovement> ().enabled = false;
		Character.GetComponent<JETPACKhover> ().enabled = false;


		MainCamera.GetComponent<CameraMotionWithCharcter> ().enabled = false;


		
		AtMainMenu = false;
		ButtonHit = true;
		
		PlaneMotion.score = 0;
		NoOfBulletsText.NoOfBullets= 5;
		Stamina.stam = 100;
		
		PlaneMotion.GameOn = true;
		PlaneMotion.PlaneSpeed = 0f;

		Time.timeScale = 1.0f;
	}
	
/*	void Update()
	{
		Debug.Log (AtMainMenu);

	}*/
}