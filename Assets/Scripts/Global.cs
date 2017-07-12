using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// godbless you connor lofdahl for making me some sweet tunes.

public class Global : MonoBehaviourSingleton <Global> {

	public static Global me;


	public Global Get() {
		if (me == null) {
			me = (Global)FindObjectOfType(typeof(Global));
		}

		return me;
	}



		
	// Use this for initialization
	void Start () {
		Get ();
	
	}



	// Update is called once per frame
	void Update () {


	}
}
