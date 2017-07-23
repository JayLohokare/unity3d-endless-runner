using UnityEngine;
using System.Collections;

public class PlayerPrefabs : MonoBehaviour {

	public static bool FirstTimePlay;


	void Start () 
	{
		if (PlayerPrefs.GetInt ("HighScore") == 0) 
		{
			FirstTimePlay = true;
			PlayerPrefs.SetInt ("TotalCoins", 0);	
			PlayerPrefs.SetInt("SuperJumpTime",10);
			PlayerPrefs.SetInt("JetPackTime",10);
			PlayerPrefs.SetInt("MagnetCollectTime",100);
		}
	


}
}