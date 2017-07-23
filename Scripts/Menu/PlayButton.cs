using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour {

	public GameObject MainMenu;



	void OnMouseDown() 
	{
		StartG.ButtonHit = false;
		//RenderSettings.fogDensity = 1f;
		MainMenu.SetActive (false);


		
	}
}
