using UnityEngine;
using System.Collections;

public class VolumeScrollBar : MonoBehaviour {

	public static float hSliderValue =100f;
	public GUISkin Myskin;


	void OnGUI()
	{
		GUI.skin = this.Myskin;

		hSliderValue = GUI.HorizontalSlider(new Rect(Screen.width/2-200,Screen.height-Screen.height/3.5f,Screen.width/3.5f,Screen.height/10), hSliderValue, 0, 100);
	
	}

}
