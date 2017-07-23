using UnityEngine;
using System.Collections;

public class AudioVolume : MonoBehaviour {

	public GameObject PauseMenu;

	void Start()
	{
		audio.volume = 1f;
	}



	void Update()

	
	{
		if(PauseMenu.activeSelf)
		audio.volume = VolumeScrollBar.hSliderValue / 100;
	}


}
