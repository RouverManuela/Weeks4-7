using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SpawnCreature : MonoBehaviour
{
    public GameObject creaturePrefab;

    public Vector3 minimumSpawnPosition;
    public Vector3 maximumSpawnPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSpawn() 
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(minimumSpawnPosition.x, maximumSpawnPosition.x), 
            Random.Range(minimumSpawnPosition.y, maximumSpawnPosition.y), 0f);

        Instantiate(creaturePrefab,randomSpawnPosition,Quaternion.identity);
    }
}
