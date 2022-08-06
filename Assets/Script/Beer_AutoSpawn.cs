using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beer_AutoSpawn : MonoBehaviour
{
    [SerializeField] private GameObject beerPrefabs;
    [SerializeField] public float spawnTime = 3f;
    [SerializeField] public bool loopEnable = true;
    [SerializeField] private float minPosion;
    [SerializeField] private float maxPositon;

    private void Start()
    {
        
    }
    void Update()
    {
        if (loopEnable == true)
        {
            StartCoroutine(autoSpawn());
        }
    }
    IEnumerator autoSpawn()
    {
        var spawnLength = Random.Range(minPosion, maxPositon);
        var positon = new Vector3(spawnLength, transform.position.y);
        Instantiate(beerPrefabs, positon, Quaternion.identity);
        loopEnable = false;
        yield return new WaitForSeconds(spawnTime);
        loopEnable = true;

    }
}
