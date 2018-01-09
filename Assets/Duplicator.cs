using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicator : MonoBehaviour {
    public GameObject pickup;
    public float range;
    public float spawnInterval;
    float spawnTimer;
	// Use this for initialization
	void Start () {
        spawnTimer = 0;
	}
	
    void spawnPickup()
    {
        GameObject spawnedPickUp = Instantiate(pickup);
        float randX = Random.Range(-range, range);
        float randZ = Random.Range(-range, range);
        spawnedPickUp.transform.position = transform.position + new Vector3(randX, 0, randZ);
        spawnedPickUp.GetComponent<PickUp>().scoreAdded = Random.Range(-5, 30);
    }

	// Update is called once per frame
	void Update () {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            spawnTimer = spawnInterval;
            spawnPickup();
        }
	}
}
