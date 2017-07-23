using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour {

	public GUIText HighScoreText;



	void Update() {
		HighScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
	}
}