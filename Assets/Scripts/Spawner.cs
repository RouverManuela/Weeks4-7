using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{
    public GameObject runnerPrefab;
    public Vector3 spawnPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Instantiate(runnerPrefab, transform);

            //position of zero
            Vector3 zeroVector = Vector3.zero;

            //rotation of zero
            Quaternion zeroQuaternion = Quaternion.identity;

            //spawn at specific position with no rotation
            Instantiate(runnerPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
