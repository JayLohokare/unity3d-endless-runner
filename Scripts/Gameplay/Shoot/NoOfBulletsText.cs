using UnityEngine;
using System.Collections;

public class NoOfBulletsText : MonoBehaviour {

	public GUIText noOfBulletsTxt;
	public static int NoOfBullets;

	void Update() {
		noOfBulletsTxt.text = NoOfBullets.ToString();

}



}
