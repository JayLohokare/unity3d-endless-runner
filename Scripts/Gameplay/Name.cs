using UnityEngine;
using System.Collections;

public class Name : MonoBehaviour {

	public GUIText PlayerName;



	void Update() {
		PlayerName.text = PlayerPrefs.GetString("PlayerName").ToString();
	}
}