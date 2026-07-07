using UnityEngine;
using UnityEngine.InputSystem;

public class Character : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Chara;

   public float healthMax;
    public float currentHealth;

    public float speed;

     float afterLava = 3f;
    public float progress;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 directionToMove = Vector3.zero;
        //constructor for Vector3:
        directionToMove = new Vector3(0, 0, 0);
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            directionToMove.x -= 1f;
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            directionToMove.x += 1f;
        }
        if (Keyboard.current.upArrowKey.isPressed)
        {
            directionToMove.y += 1f;
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            directionToMove.y -= 1f;
        }

        transform.position += directionToMove * speed * Time.deltaTime;

    }

    public void isInLava()
    {
        currentHealth -= 1f;
        speed -= 0.5f;

    }
    public void isNotInLava()
    {
        speed += 0.5f;
    }

    public void isInHPGen()
    {
        currentHealth = healthMax;
    }
}
