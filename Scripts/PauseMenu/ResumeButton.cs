using UnityEngine;
using System.Collections;

public class ResumeButton :MonoBehaviour {

	public GameObject PauseMenu;
	public GameObject Character;

	void OnMouseDown()
	{
		PlaneMotion.GameOn = true;
		PauseMenu.SetActive (false);
		Time.timeScale = 1f;
		PlaneMotion.GameOn = true;


	}}