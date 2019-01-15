using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentTarget : MonoBehaviour {

	public Transform target;
	public bool zeroTransform = true;

	void Start () {
		transform.SetParent(target, zeroTransform);
	}

}
