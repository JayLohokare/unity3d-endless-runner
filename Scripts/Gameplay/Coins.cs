using UnityEngine;
using System.Collections;

public class Coins : MonoBehaviour {

	public GUIText CoinsText;



	void Update() {
		CoinsText.text = ObstaclesCollide.coins.ToString();
	}
}