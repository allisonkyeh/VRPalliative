using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    // attach broken prefab here; maybe can randomize pf +  mat later on
	[SerializeField]
    private GameObject  brokenMesh;
    private Transform   bottleTransform;

	void Break() {

        // stores bottle transform
        bottleTransform = this.transform;

        // maybe play some particles here for the break like sparks or w/e

        // instantiate copy of broken bottle at stored transformed
        Instantiate(brokenMesh, bottleTransform.position, bottleTransform.rotation);
        // gets rid of whole bottle
        Destroy(gameObject);

	}


}
