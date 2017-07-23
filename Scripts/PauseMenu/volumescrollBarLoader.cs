using UnityEngine;
using System.Collections;

public class volumescrollBarLoader : MonoBehaviour {

	public GameObject PauseMenu;
	public GameObject MainCamera;

	void Update()
	{
		if (PauseMenu.activeSelf) {
			MainCamera.GetComponent<VolumeScrollBar> ().enabled = true;
				} 
		else {
			MainCamera.GetComponent<VolumeScrollBar> ().enabled = false;
			}

	}
}