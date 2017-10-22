using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vrag : MonoBehaviour {
	public float hp = 10.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(hp < 0.0f){
			Destroy(this.gameObject);//сдыхает чел
		}
	}

	void OnTriggerStay(Collider other){
		hp = hp - 1.0f;
	}
}
