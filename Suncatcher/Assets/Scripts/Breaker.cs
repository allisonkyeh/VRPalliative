using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breaker : MonoBehaviour
{
    private int bottleLayer => LayerMask.NameToLayer("Bottle");

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.layer == bottleLayer){
            other.gameObject.GetComponent<Bottle>().Break();
        }
    }
}
