using UnityEngine;

public class CreatureMovementScript : MonoBehaviour
{
    public float speed;

    public float leftEdge;
    public float rightEdge;

    private float moveDirection = 1f;

    private float lifespan = 0f;
    private float lifeDuration = 10f;

    public GameObject creature;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;

        transform.position += Vector3.right * moveDirection * speed * Time.deltaTime;

        if (newPosition.x > rightEdge)
        {
            moveDirection = -1f;
        }

        if (newPosition.x < leftEdge)
        {
            moveDirection = 1f;
        }

        lifespan += 1f * Time.deltaTime;

        if(lifespan > lifeDuration)
        {
            Destroy(creature);
        }

    }

    public void ChangeSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}
