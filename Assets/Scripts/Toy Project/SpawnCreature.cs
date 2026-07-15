using UnityEngine;

public class SpawnCreature : MonoBehaviour
{
    //stores creature prefab
    public GameObject creaturePrefab;

    //used for the range of the random spawn position
    public Vector3 minimumSpawnPosition;
    public Vector3 maximumSpawnPosition;

    public SliderScript SliderScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSpawn() //the script acts as a form of bridge, the speed is changed in the slider script
                          //then the spawner feeds it into the next creature spawned.
                          //So each creature spawend can have its on unique speed, rather than all creature having same speed.
                          //This was a change from my original plan. But one I prefer.
    {
        //spawn creatures in a random location in a range randomly 
        Vector3 randomSpawnPosition = new Vector3(Random.Range(minimumSpawnPosition.x, maximumSpawnPosition.x), Random.Range(minimumSpawnPosition.y, maximumSpawnPosition.y), 0f);

        GameObject spawnedObject = Instantiate(creaturePrefab,randomSpawnPosition,Quaternion.identity);
        CreatureMovementScript spawnedCreature = spawnedObject.GetComponent<CreatureMovementScript>();

        if (spawnedCreature != null) //checks if creature contains the movement script when being spawned
        {
            spawnedCreature.ChangeSpeed(SliderScript.currentSpeed);
        }
    }
}
