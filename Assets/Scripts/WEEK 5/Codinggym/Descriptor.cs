using UnityEngine;
using UnityEngine.InputSystem;


public class Descriptor : MonoBehaviour
{
    public SpriteRenderer character;
    public GameObject Descriptions;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        worldMousePosition.z = 0f;

        bool isOverSprite = character.bounds.Contains(worldMousePosition);

        if (isOverSprite)
        {
            Descriptions.SetActive(true);
        }
        else
        {
            Descriptions.SetActive(false);
        }
    }
}
