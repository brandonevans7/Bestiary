using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepthByHeight : MonoBehaviour {


	protected Vector3 pos;
	protected float depth;

	// Use this for initialization
	void Start () 
	{
		pos = this.transform.position;
//		depth = pos.y;
		pos.z = pos.y;

		this.transform.position = pos;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
