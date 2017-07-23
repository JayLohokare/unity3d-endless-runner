using UnityEngine;
using System.Collections;

public class slider : MonoBehaviour {

	public UISlider slide;
	public float maxwidth;
	void Awake()
	{
		maxwidth = slide.foreground.localScale.x;	
	}

	 void Update()
	{
		slide.foreground.localScale = new Vector3 (Stamina.stam, slide.foreground.localScale.y, slide.foreground.localScale.z);
	}
}