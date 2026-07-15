using UnityEngine;

public class CreatureMovementScript : MonoBehaviour
{

    //creature sprites: https://bec0.itch.io/procedural-creatures-01

    public float speed;

    public float leftEdge;
    public float rightEdge;

    //made these private as heir values are not meant to be controlled by the player
    private float moveDirection = 1f; //this will be used to help ounce the object on the edges

    private float life = 0f;
    private float lifeDuration = 10f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this part controls the movement of the player by multiplying the pos and speed in seconds 
        Vector3 newPosition = transform.position;
        transform.position += Vector3.right * moveDirection * speed * Time.deltaTime;
        if (newPosition.x > rightEdge)
        {
            //if the position of the obj is larger than the right edge value it will move backwards around -8f considering the camera limits
            moveDirection = -1f;
        }

        if (newPosition.x < leftEdge)
        {
            //same logic applies
            //its only in the x axis as the creatures shouldnt move along the y axis. only continuous horizontal motion 
            moveDirection = 1f;
        }

        //add one "year" to the creature each second
        //aging:
        life += 1f * Time.deltaTime;
        //if the life is larger than the duration (lifespan) the creature will die 
        //this is also a method of population control
        if(life > lifeDuration)
        {
            //destroys the creature 
            Destroy(gameObject);
        }
    }

    public void ChangeSpeed(float newSpeed)
    {
        //this receives a new speed value from the spawn script
        speed = newSpeed;
    }
}
