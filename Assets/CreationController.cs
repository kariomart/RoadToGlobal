using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;


public class CreationController : MonoBehaviour {

	public TextMeshProUGUI nameInput;
	public Player player;
	public Camera camera;
	public bool enteringName = true;

	public Button role1;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Return)) {
			player.name = nameInput.text;
			Debug.Log (player.name);
			camera.transform.position = new Vector3 (1045, camera.transform.position.y, camera.transform.position.z);
			//enteringName = false;
			//Destroy (nameInput.gameObject);
		}

	}


}
