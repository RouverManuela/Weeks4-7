using UnityEngine;

public class CreatureMovementScript : MonoBehaviour
{
    public float speed;

    public float leftEdge;
    public float rightEdge;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.x += speed * Time.deltaTime;


        if (newPosition.x < leftEdge)
        {
            speed = -speed;
        }

        if (newPosition.x > rightEdge)
        {
            speed = -speed;
        }

        transform.position = newPosition;

    }
}
