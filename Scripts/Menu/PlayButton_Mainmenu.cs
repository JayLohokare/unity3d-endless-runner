using UnityEngine;
using System.Collections;

public class PlayButton_Mainmenu : MonoBehaviour {
	

	public GameObject GamePlayButtons;

	public Transform PositionCamera;






void Update()
{
			

	 	if (!StartG.ButtonHit) 
		{	
			transform.position = Vector3.Lerp (transform.position, PositionCamera.position, Time.deltaTime * 2.5f);				
			transform.rotation = Quaternion.Slerp (transform.rotation, PositionCamera.rotation, 1.0f);
			//RenderSettings.fogDensity = 0.02f;
			//CamRandomMotion.AtMainMenu = false;
		}
				
		if (transform.position == PositionCamera.position) {
								GamePlayButtons.SetActive (true);
								PlaneMotion.GameOn = true;
								Time.timeScale = 1.0f;
								PlaneMotion.PlaneSpeed = 0.1f;
								StartG.ButtonHit  = true;
		
		}}}