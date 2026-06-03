using NUnit.Framework;
using TMPro;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class EvilSwordEnemy : MonoBehaviour
{
  
    public float maxHealth;
    public GameObject sword;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       bool leftMouseWasPressed = Mouse.current.leftButton.wasPressedThisFrame;
        if (leftMouseWasPressed)
        {
            maxHealth -= 1f;  
            //button.GetComponent<TextMeshPro>().text = maxHealth.ToString();
        }
        if(maxHealth < 0f)
        {
            Destroy(sword);
        }
    }
}
