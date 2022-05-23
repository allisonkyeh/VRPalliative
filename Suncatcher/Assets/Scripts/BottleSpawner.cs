using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleSpawner : MonoBehaviour
{
    [SerializeField]
    private List<Material> bottleModels;
    private int modelCount => bottleModels.Count;
    private int randModelNum;

    [SerializeField]
    private List<Material> bottleMats;
    private int matCount => bottleMats.Count;
    private int randMatNum;

    // Start is called before the first frame update
    void Start()
    {
        // spawn randomly while <maxnumbottles laying in area

    }

    void Spawn() {
        randModelNum = Random.Range(1, modelCount);
        randMatNum = Random.Range(1, matCount);

        // Instantiate(suncatcher, center.position, Quaternion.identity);

    }
    // Range int is: minInclusive, maxExclusive
}
