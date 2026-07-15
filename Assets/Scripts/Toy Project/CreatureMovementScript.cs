using UnityEngine;

public class CreatureMovementScript : MonoBehaviour
{
    public float speed;

    public float leftEdge;
    public float rightEdge;

    private float moveDirection = 1f;

    private float lifespan = 8f;
    private float lifeTimer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lifeTimer = lifespan;
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
    }

    public void ChangeSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}
