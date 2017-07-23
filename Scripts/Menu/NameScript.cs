using UnityEngine;
using System.Collections;

public class NameScript : MonoBehaviour {

	private string defaultString;
	private string playerName;	
	private TouchScreenKeyboard keyboard;
	private bool iskBoardOpen;


	void OnMouseDown()
	{
		keyboard = TouchScreenKeyboard.Open( defaultString, TouchScreenKeyboardType.Default, false, false, false, false, "Default Keyboard" );
		iskBoardOpen = true;
	}

	void Update() {
		if(iskBoardOpen){
		
		if ( keyboard.done )
		{
			playerName = keyboard.text;
			defaultString = "";
			PlayerPrefs.SetString("PlayerName",playerName);
			iskBoardOpen = false;
		}
		else
		{
			playerName = keyboard.text;
		}




		
		}}}