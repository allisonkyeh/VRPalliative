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
    // private Material    bottleMat;

    private void Start() {
        // gameObject.GetComponent<Renderer>().material = bottleMat;
    }

	public void Break() {

        // stores bottle transform
        bottleTransform = this.transform;

        // maybe play some particles here for the break like sparks or w/e

        // instantiate copy of broken bottle at stored transformed
        GameObject b = Instantiate(brokenMesh, bottleTransform.position, bottleTransform.rotation);
        
        // unpacks shards prefab
        // PrefabUtility.UnpackPrefabInstance(b, PrefabUnpackMode.OutermostRoot, InteractionMode.AutomatedAction);
        // oh ig you don't actually need this for instances

        // gets rid of whole bottle
        // Debug.Log("Destroying: " + gameObject.name);
        Destroy(gameObject);

	}


}
