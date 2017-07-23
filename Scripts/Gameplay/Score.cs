using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public GUIText GameScore;



	void Update() {
		GameScore.text = PlaneMotion.score.ToString();
	}
}