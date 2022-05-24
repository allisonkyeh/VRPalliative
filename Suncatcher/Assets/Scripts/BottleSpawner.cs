using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleSpawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> bottleModels;
    private int modelCount => bottleModels.Count;
    private int randModelNum;

    [SerializeField]
    private List<Material> bottleMats;
    private int matCount => bottleMats.Count;
    private int randMatNum;

    // make sure same order as bottleMats
    private List<Material> shardMats;

    // Start is called before the first frame update
    void Start()
    {
        // spawn randomly while <maxnumbottles laying in area

    }

    void Spawn() {
        randModelNum = Random.Range(1, modelCount);
        randMatNum = Random.Range(1, matCount);

        // TODO: position, and push to beach
        GameObject parent;
        // parent = Instantiate(bottleModels[randModelNum], center.position, Random.rotation);
        // parent.transform.GetChild(0).GetComponent<Renderer>().material = bottleMats[randMatNum];

    }
    // Range int is: minInclusive, maxExclusive
}
