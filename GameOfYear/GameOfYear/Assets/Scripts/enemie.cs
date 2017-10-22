using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemie : MonoBehaviour {
	public float hp = 10.0f;
	private float axe;
	private int vector;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(hp < 0.0f){
			Destroy(this.gameObject);//сдыхает чел
		}
		if(axe > 0.0f){
			if(vector == 1){
				this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + axe);
			}
			if(vector == 2){
				this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - axe);
			}
			if(vector == 3){
				this.transform.position = new Vector3(this.transform.position.x - axe, this.transform.position.y, this.transform.position.z);
			}
			if(vector == 4){
				this.transform.position = new Vector3(this.transform.position.x + axe, this.transform.position.y, this.transform.position.z);
			}
			axe = axe - 0.1f;
		}
	}

	void OnTriggerStay(Collider other){
		vector = move.vect;
		hp = hp - 1.0f;
		axe = 1.0f;
	}
}
