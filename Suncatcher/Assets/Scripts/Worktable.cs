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

        // detect what colliders are in box at the time of this function
        Collider[] shardsList = Physics.OverlapBox(gameObject.transform.position, transform.localScale / 2, Quaternion.identity, maskLayer);

        GameObject child;
        GameObject parent;
        parent = Instantiate(suncatcher, center.position, Quaternion.identity);

        // goes through detected shards and puts them under the new suncatcher parent
        foreach (Collider shard in shardsList)
        {
            child = shard.gameObject;
            child.transform.SetParent(parent.transform);
        }
    }
}
