using UnityEngine;
using System.Collections;

public class LerpRotateOnPlay : MonoBehaviour {

	public Transform PositionCamera;
	public GameObject GamePlayButtons;
	//public GameObject FrontCollider;
	public static bool CamAtChar;

	public GameObject character;
	public GameObject charCollider;
	//public GameObject GameCam;


	void Start()
	{
		CamAtChar = false;
		}

	void FixedUpdate()
	{
		if (!StartG.ButtonHit) {	
			StartG.AtMainMenu = true;

			transform.position = Vector3.Lerp (transform.position, PositionCamera.position, Time.deltaTime * 2.0f);				
			transform.rotation = Quaternion.Slerp (transform.rotation, PositionCamera.rotation, Time.deltaTime*1.0f);		

			if (transform.position == PositionCamera.position)
			{
				CamAtChar = true;
				character.GetComponent<CharMovement> ().enabled = true;	
				charCollider.GetComponent<ObstaclesCollide> ().enabled = true;	
				
				StartG.ButtonHit = true;
				GamePlayButtons.SetActive (true);
				PlaneMotion.GameOn = true;
				Time.timeScale = 1.0f;
				PlaneMotion.PlaneSpeed = 0.5f;
				GetComponent<CameraMotionWithCharcter>().enabled =true;
				//PlaneMotion.ScriptOn = true;

			}
		}






		}



}