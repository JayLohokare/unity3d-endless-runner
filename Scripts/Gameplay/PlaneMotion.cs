using UnityEngine;
using System.Collections;

public class PlaneMotion : MonoBehaviour 
{
	public static float PlaneSpeed;
	public static bool GameOn;
	public static int score;
	//public static bool ScriptOn;



	void FixedUpdate()
	{
		//if(ScriptOn)
		transform.Translate (Vector3.back * PlaneSpeed);

	}

	void Update()
	{	if (GameOn && LerpRotateOnPlay.CamAtChar)
						score += 1;

		if (GameOn) {
						Time.timeScale = 1.0f;
						
				}
		if (!GameOn) {

			Time.timeScale = 0.0f;
		}



		//Debug.Log (score);
		}
	
	}


