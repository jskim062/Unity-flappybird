using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {
	//void OnGUI() {
		//if (GUILayout.Button ("RESTART")) {
	//	if(GUILayout.Button(Rect(Screen.width /2 - 100,Screen.height /2 - 90,250,50), "Quit"))
	//	{	
	//		Application.LoadLevel ("Game");
	//			Time.timeScale = 1;

	//	}	
	//}

	public Font font; //set it in the inspector
	private GUIStyle guiStyle;



	void OnGUI() {
		
		//font.name = "FlappyFont";
		//in awake or start use these lines of code to set the size of the font
		guiStyle = new GUIStyle();
		guiStyle.font = font;
		//guiStyle.font = "FlappyFont";
		guiStyle.normal.textColor = Color.white;
		//guiStyle.font.name = "FlappyFont";
		guiStyle.fontSize = 60;  //must be int, obviously...
		//guiStyle.alignment = TextAnchor.MiddleCenter;

		if(GUILayout.Button("RESTART", guiStyle, GUILayout.Width(200), GUILayout.Height(100))){
			// Debug.Log("Main Button clicked!");
					Application.LoadLevel ("Game");
						Time.timeScale = 1;
		}
}
}
