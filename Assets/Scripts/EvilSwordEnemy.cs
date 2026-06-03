using NUnit.Framework;
using TMPro;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class EvilSwordEnemy : MonoBehaviour
{
  
    public float Health;
    public GameObject sword;
 
    public Button button;

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
            Health -= 1f;
            
        }
        if(Health < 0f)
        {
            Destroy(sword);
        }

        button.GetComponentInChildren<TextMeshProUGUI>().text = Health.ToString();
    }
}
