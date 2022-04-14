using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breaker : MonoBehaviour
{
    private int breakLayer => LayerMask.NameToLayer("Breakable");

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.layer == breakLayer){
            other.transform.root.gameObject.GetComponent<Bottle>().Break();
        }
    }
}
