using UnityEngine;
using UnityEngine.InputSystem;

public class CodingGym_1 : MonoBehaviour
{
    public float speed;
    public GameObject barrel;
    public GameObject canvas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = transform.position;

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        if (Keyboard.current.upArrowKey.isPressed)
        {
            transform.position += transform.up * speed * Time.deltaTime;
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            transform.position -= transform.up * speed * Time.deltaTime;
        }

        if (Vector3.Distance(currentPosition, barrel.transform.position) <= 1.5f)
        {
            canvas.SetActive(true);
        }
        else
        {
            canvas.SetActive(false);
        }
        
    }
}
