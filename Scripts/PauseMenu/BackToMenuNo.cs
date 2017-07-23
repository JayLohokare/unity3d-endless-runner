using UnityEngine;
using System.Collections;

public class BackToMenuNo : MonoBehaviour {

	public GameObject PauseMenu;
	public GameObject BackToMenu;

	void OnMouseDown(){
		BackToMenu.SetActive (false);
		PauseMenu.SetActive (true);
}
}