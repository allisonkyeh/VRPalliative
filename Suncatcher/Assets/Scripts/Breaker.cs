using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breaker : MonoBehaviour
{
    private int breakLayer => LayerMask.NameToLayer("Breakable");
    private int buttonLayer => LayerMask.NameToLayer("Button");
    public Worktable table;
    public ParticleSystem hitParticles;

    void Awake()
    {
        table = FindObjectOfType<Worktable>();
    }


    private void OnTriggerEnter(Collider other) {
        // Debug.Log("Hitting something on this layer: " + other.gameObject.layer);
        hitParticles.Emit(20);

        if (other.gameObject.layer == breakLayer){
            other.transform.parent.gameObject.GetComponent<Bottle>().Break();
        }
        
        if (other.gameObject.layer == buttonLayer){
            table.GetComponent<Worktable>().Assemble();
        }
    }
}
