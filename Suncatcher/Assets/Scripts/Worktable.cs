using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worktable : MonoBehaviour
{
    private int     pieceLayer => LayerMask.NameToLayer("Piece");

    [SerializeField] Transform  center;      // reference point for parenting shards
    [SerializeField] GameObject suncatcher; // prefab for suncatchers

    public void Assemble() {

        // detect what colliders are in box at the time of this function
        Collider[] shardsList = Physics.OverlapBox(gameObject.transform.position, transform.localScale, Quaternion.identity, pieceLayer);

        if (shardsList != null) {
            GameObject child;
            GameObject parent;
            parent = Instantiate(suncatcher, center.position, Quaternion.identity);

            // goes through detected shards and puts them under the new suncatcher parent
            foreach (Collider shard in shardsList)
            {
                child = shard.gameObject;
                if (child.layer == pieceLayer) {
                    Debug.Log("PARENT: " + parent.name);
                    Debug.Log("shard: " + child.name);
                    child.transform.SetParent(parent.transform);
                }
            }
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireCube(transform.position, transform.localScale);
    }
}
