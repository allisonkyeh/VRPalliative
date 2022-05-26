using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Worktable : MonoBehaviour
{
    private int     pieceLayer => LayerMask.NameToLayer("Piece");
    private int     sunLayer => LayerMask.NameToLayer("Suncatcher");

    
    [SerializeField] Transform  center;      // reference point for parenting shards
    [SerializeField] GameObject suncatcher; // prefab for suncatchers

    public void Assemble() {

        // detect what colliders are in box at the time of this function
        Collider[] shardsList = Physics.OverlapBox(gameObject.transform.position, transform.localScale, Quaternion.identity);
        
        // won't do anything if a suncatcher is within work area
        foreach (Collider col in shardsList)
        {
            if (col.gameObject.layer == sunLayer) return;
        }

        if (shardsList != null) {
            GameObject child;
            GameObject parent;
            parent = Instantiate(suncatcher, center.position, Quaternion.identity);

            // goes through detected shards and puts them under the new suncatcher parent
            foreach (Collider shard in shardsList)
            {
                // Debug.Log("shard layer: " + shard.gameObject.layer);
                child = shard.gameObject;
                if (child.layer == pieceLayer) {
                    Destroy(child.GetComponent<XRGrabInteractable>());
                    Destroy(child.GetComponent<Rigidbody>());
                    Destroy(child.GetComponent<BoxCollider>());
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
