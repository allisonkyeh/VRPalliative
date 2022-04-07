using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worktable : MonoBehaviour
{
    List<GameObject> piecesList;
	// ????bool??? button

    void OnTriggerEnter () {
        // add to shardsList
        // need some way to only add bottle pieces? or should whole bottles also be allowed
        // then need to remove bottle if it’s broken, and add pieces when it breaks

    }

    void Assemble() {
        // Scripting API: Transform.SetParent
        // child.transform.SetParent(newParent);

        // piece prefabs should be split before reaching this function

        GameObject suncatcher;

        foreach (GameObject piece in piecesList)
        {
            // piece.transform.SetParent(suncatcher);
            // add interactable component to suncatcher
        }
    }
}
