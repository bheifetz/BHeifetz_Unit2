using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float xRange = 17.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 3.0f, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        float randXPos = Random.Range(-xRange, xRange);
        int animalPrefabIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 randPos = new Vector3(randXPos, 0, 21.9f);
        Instantiate(animalPrefabs[animalPrefabIndex], randPos, animalPrefabs[animalPrefabIndex].transform.rotation);
    }
}
