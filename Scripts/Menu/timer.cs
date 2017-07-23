using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {

	public GameObject LoadingTexture;
	public GameObject Logo;

	void Start () {
	Invoke("loadTexture", 6);
	Invoke("nextScene", 10);
	}
	
	void nextScene () {

		Application.LoadLevel("GamePlay");
	}

	void loadTexture()
	{
		Logo.SetActive (false);
	LoadingTexture.SetActive (true);
	}}

