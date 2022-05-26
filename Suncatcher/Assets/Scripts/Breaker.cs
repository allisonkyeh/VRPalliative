using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Breaker : MonoBehaviour
{
    private int breakLayer => LayerMask.NameToLayer("Breakable");
    private int buttonLayer => LayerMask.NameToLayer("Button");
    private int handLayer => LayerMask.NameToLayer("Hand");

    public Worktable table;
    public ParticleSystem hitParticles;

    [SerializeField] UnityEvent onHit;
    [SerializeField] UnityEvent onBreak; // could move to bottle but eh

    void Awake()
    {
        table = FindObjectOfType<Worktable>();
    }


    private void OnTriggerEnter(Collider other) {
        // Debug.Log("Hitting something on this layer: " + other.gameObject.layer);
        
        if (other.gameObject.layer != handLayer) {
            onHit?.Invoke();

            if (other.gameObject.layer == breakLayer){
                onBreak?.Invoke();
                other.transform.parent.gameObject.GetComponent<Bottle>().Break();
            }
            if (other.gameObject.layer == buttonLayer){
                table.GetComponent<Worktable>().Assemble();
            }
        }
    }
}
