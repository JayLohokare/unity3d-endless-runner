using UnityEngine;
using System.Collections;

public class MainMenuButton : MonoBehaviour {

	public GameObject AreYouSure;
	public GameObject PauseMenu;

	void OnMouseDown () { 
		PauseMenu.SetActive (false);
		AreYouSure.SetActive(true); }

	}
