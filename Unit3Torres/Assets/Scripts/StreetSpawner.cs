using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetSpawner : MonoBehaviour
{
    public GameObject StreetPrefab;
    private Vector3 spawnPos = new Vector3(0, 0, 0);
    private float startDelay = .6f;
    private float repeatRate = .6f;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnStreet", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void SpawnStreet()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(StreetPrefab, spawnPos, StreetPrefab.transform.rotation);
        }
    }
}
