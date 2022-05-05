using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breaker : MonoBehaviour
{
    private int breakLayer => LayerMask.NameToLayer("Breakable");
    private int handsLayer => LayerMask.NameToLayer("Hands");
    public Worktable table;

    void Awake()
    {
        table = FindObjectOfType<Worktable>();
    }


    private void OnTriggerEnter(Collider other) {
        // Debug.Log("Hitting something on this layer: " + other.gameObject.layer);
        
        if (other.gameObject.layer == breakLayer){
            other.transform.root.gameObject.GetComponent<Bottle>().Break();
        }
        
        if (other.gameObject.layer == handsLayer){
            table.GetComponent<Worktable>().Assemble();
        }
    }
}
