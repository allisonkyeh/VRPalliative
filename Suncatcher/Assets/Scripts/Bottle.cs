using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Bottle : MonoBehaviour
{
    // attach broken prefab here; maybe can randomize pf +  mat later on
	[SerializeField]
    private GameObject  brokenMesh;
    private Transform   bottleTransform;

    void Button () {
        // input action function to activate break, or just combine into it
    }

	void Break() {

        // stores bottle transform
        bottleTransform = this.transform;

        // maybe play some particles here for the break like sparks or w/e

        // instantiate copy of broken bottle at stored transformed
        GameObject b = Instantiate(brokenMesh, bottleTransform.position, bottleTransform.rotation);
        // unpacks shrads prefab
        PrefabUtility.UnpackPrefabInstance(b, PrefabUnpackMode.OutermostRoot, InteractionMode.AutomatedAction);

        // gets rid of whole bottle
        Destroy(gameObject);

	}


}
