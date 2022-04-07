using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worktable : MonoBehaviour
{
    Collider[] shardsList = null;
    private int maskLayer => LayerMask.NameToLayer("Default");

    // reference point for parenting shards
    [SerializeField] Transform center;
    // prefab for suncatchers
    [SerializeField] GameObject suncatcher;

    void Button() {
        // input action function to activate assemble
    }

    void Assemble() {

        // piece prefabs should be split before reaching this function

        // detect what colliders are in box at the time of this function
        Collider[] shardsList = Physics.OverlapBox(gameObject.transform.position, transform.localScale / 2, Quaternion.identity, maskLayer);

        GameObject child;
        GameObject parent;
        parent = Instantiate(suncatcher, center.position, Quaternion.identity);
        // parent.AddComponent<>(); // TODO: add interactable component here

        foreach (Collider shard in shardsList)
        {
            child = shard.gameObject;
            child.transform.SetParent(parent.transform);
        }

        // PrefabUtility.UnpackPrefabInstance(shards, OutermostRoot, AutomatedAction);

    }
}
