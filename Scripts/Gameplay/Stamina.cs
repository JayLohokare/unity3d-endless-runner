using UnityEngine;
using System.Collections;

public class Stamina : MonoBehaviour {

	public GUIText stamina;
	public static int stam;
	
	// Update is called once per frame
	void Update () {
		stamina.text = stam.ToString();

		if (stam<= 0){
			Invoke ("Stop", Random.Range (1,5));
		}

		if (stam <= 0) {
			PlaneMotion.GameOn = false;
			PlaneMotion.PlaneSpeed = 0f;
			if(PlaneMotion.score > PlayerPrefs.GetInt("HighScore"))
				PlayerPrefs.SetInt("HighScore",PlaneMotion.score);
			PlayerPrefs.SetInt("TotalCoins",PlayerPrefs.GetInt("TotalCoins")+ObstaclesCollide.coins);

				}
	}
}
