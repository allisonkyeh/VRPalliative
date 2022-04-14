using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Worktable table;
    private int handLayer => LayerMask.NameToLayer("Hands");


    void Awake()
    {
        table = FindObjectOfType<Worktable>();
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.layer == handLayer) {
            table.GetComponent<Worktable>().Assemble();
        }
    }
}
