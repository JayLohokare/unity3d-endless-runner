using UnityEngine;
using System.Collections;

public class TerribilisLogoLoader : MonoBehaviour 
{
	public Texture aTexture;
	public float x, y, width, height;
	Rect pos;

	void OnGUI() 
	{

		
		pos.x = 0f * Screen.width;
		pos.y = 0f* Screen.height;
		pos.width = 1f * Screen.width;
		pos.height = 1f * Screen.height;

		GUI.DrawTexture(pos, aTexture);
	}
}