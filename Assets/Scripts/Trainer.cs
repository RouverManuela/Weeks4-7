using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class Trainer : MonoBehaviour
{
    public SpriteRenderer creatureRenderer;
    public Camera gameCamera;
    public Color caughtColor;

    public List<SpriteRenderer> uncaughtCreatures;
    public List <SpriteRenderer> caughtCreatures;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool isClicked = Mouse.current.leftButton.wasPressedThisFrame;

        Vector3 mousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(mousePosition);
        worldMousePosition.z = 0f;


        if (isClicked)
        {
            //caught creatures
            //for each element i want to output that into console
            for (int i = 0; i < caughtCreatures.Count; i++)
            {
                //1) creating as variable int i = 0 to access the 1st element which is always 0 in an element.
                //2) How loong loop runs: when I is less than the ammount of things we have in the list it continues to run loop
                //3) Increase value of i each time it loops
                Debug.Log(caughtCreatures[i]);
            }


            if (caughtCreatures.Count > 0)
            {
                Debug.Log(caughtCreatures[0]);
            }
        }


        if (isClicked && creatureRenderer.bounds.Contains(worldMousePosition))
        {
            creatureRenderer.color = caughtColor;

            //Adds the sprite into the caught creature and removes from the uncaught list Once
            bool isCreatureCaught = caughtCreatures.Contains(creatureRenderer);
            Debug.Log("Is creature caught[" + isCreatureCaught.ToString() + "]");
            if (!isCreatureCaught)
            {
                caughtCreatures.Add(creatureRenderer);
            }
            uncaughtCreatures.Remove(creatureRenderer);
        }
    }
}
