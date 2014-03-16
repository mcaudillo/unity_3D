using UnityEngine;
using System.Collections;
using Sfs2X;
using Sfs2X.Core;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Sfs2X.Entities.Variables;
using Sfs2X.Requests;
using Sfs2X.Logging;
using Sfs2X.FSM;

public class Trigger : MonoBehaviour {
	bool atEnd = false;
	void OnGUI(){
		if (atEnd) {
			GUI.BeginGroup(new Rect((Screen.width/2)-50,(Screen.height/2)-60,100,120));
			GUI.Label (new Rect(0,0,100,20),"You Win!");
			if(GUI.Button(new Rect(0,20,100,50),"Play Again")){
				Application.LoadLevel(0);
			}
			if(GUI.Button(new Rect(0,70,100,50),"Quit")){
				Application.Quit();
			}
			GUI.EndGroup();
			           
		}
	}

	void OnCollisionEnter(Collision collision){
		if (collision.collider.name == "endPoint") {
			atEnd=true;		
		}
	}
}
