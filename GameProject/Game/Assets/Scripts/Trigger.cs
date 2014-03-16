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
	void OnTriggerEnter (Collider other){
		GUI.Label("YOU WON.");
		GUI.Button("Return to login");
	}
}
