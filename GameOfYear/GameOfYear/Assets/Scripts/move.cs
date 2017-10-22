using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	private float speed_x = 0.0f;
	private float speed_z = 0.0f;
	private float offs = 3.0f;
	public float boost;
	public int vect = 1;
	private GameObject neww;
	public GameObject rage;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(neww.transform.position.x != null){
			Destroy(neww);
		}
		if(Input.GetKeyDown(KeyCode.W)){
			speed_z = 1.0f * boost;
			vect = 1;
		}
		if(Input.GetKeyUp(KeyCode.W)){
			speed_z = 0.0f;
		}
		if(Input.GetKeyDown(KeyCode.A)){
			speed_x = -1.0f * boost;
			vect = 3;
		}
		if(Input.GetKeyUp(KeyCode.A)){
			speed_x = 0.0f;
		}
		if(Input.GetKeyDown(KeyCode.S)){
			speed_z = -1.0f * boost;
			vect = 2;
		}
		if(Input.GetKeyUp(KeyCode.S)){
			speed_z = 0.0f;
		}
		if(Input.GetKeyDown(KeyCode.D)){
			speed_x = 1.0f * boost;
			vect = 4;
		}
		if(Input.GetKeyUp(KeyCode.D)){
			speed_x = 0.0f;
		}
		if(Input.GetKeyDown(KeyCode.Space)){
			if(vect == 1){
				neww = Instantiate(rage, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + offs), Quaternion.identity);
			}
			if(vect == 2){
				neww = Instantiate(rage, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - offs), Quaternion.identity);
			}
			if(vect == 3){
				neww = Instantiate(rage, new Vector3(this.transform.position.x - offs, this.transform.position.y, this.transform.position.z ), Quaternion.identity);
			}
			if(vect == 4){
				neww = Instantiate(rage, new Vector3(this.transform.position.x + offs, this.transform.position.y, this.transform.position.z ), Quaternion.identity);
			}
		}
		this.transform.position = new Vector3(this.transform.position.x + speed_x, this.transform.position.y, this.transform.position.z + speed_z);
	}


}
