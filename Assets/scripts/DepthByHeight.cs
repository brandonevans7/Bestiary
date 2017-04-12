using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepthByHeight : MonoBehaviour {


	protected Vector3 pos;
	protected float depth;

	public bool DBH = false;

	// Use this for initialization
	void Start () 
	{
		if (DBH == true) {
			pos = this.transform.position;
			pos.z = pos.y;

			this.transform.position = pos;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (DBH == true) 
		{
			pos = this.transform.position;
			pos.z = pos.y;
			this.transform.position = pos;

		}
	}
}
