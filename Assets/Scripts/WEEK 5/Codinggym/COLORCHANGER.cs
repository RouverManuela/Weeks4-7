using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class COLORCHANGER : MonoBehaviour
{
    public SpriteRenderer square;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void colorChanger()
    {

            square.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
     
    }
}
