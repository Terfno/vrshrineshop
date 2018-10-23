using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class omamori : MonoBehaviour {
	public GameObject price;

	// Use this for initialization
	void Start () {
		price.SetActive(false);
	}
	
	void OnCollisionStay(Collision col){
		if(col.gameObject.tag == "hand"){
			price.SetActive(true);
		}
	}

	void OnCollisionExit(Collision col){
		price.SetActive(false);
	}
}
