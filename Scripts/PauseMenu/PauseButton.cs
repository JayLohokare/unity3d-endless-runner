using UnityEngine;
using System.Collections;


public class PauseButton: MonoBehaviour
{
    public GameObject PauseMenuComponents;
	public GameObject PauseMenu;
	public GameObject BackToMenu;
	public GameObject Character;

	

    void OnMouseDown() { 

	
		PlaneMotion.GameOn = false;
		Time.timeScale = 0f;

		BackToMenu.SetActive (false);
		PauseMenuComponents.SetActive (true);
		PauseMenu.SetActive (true);

			

	}
}