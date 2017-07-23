using UnityEngine;
using System.Collections;

public class BackToMenuYes : MonoBehaviour {

	void OnMouseDown()
	{
	Application.LoadLevel("GamePlay");
		if(PlaneMotion.score > PlayerPrefs.GetInt("HighScore"))
			PlayerPrefs.SetInt("HighScore",PlaneMotion.score);
	}


}