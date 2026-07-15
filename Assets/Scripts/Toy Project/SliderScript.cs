using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderScript : MonoBehaviour
{
    //reference to ui slider
    public Slider speedSlider;
    public TMP_Text speedText;

        //current speed selected
    public float currentSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Sets sliders starting value 
        //Displays speed value as text in UI
        speedSlider.value = currentSpeed;
        speedText.text = "Speed: " + currentSpeed;
    }

    // Update is called once per frame
    void Update()
    {

    }
  
    //recevies slider value and stores it as current speed and also updates the text.
    public void OnSpeedChange(float newSpeed)
    {
        currentSpeed = newSpeed;
        Debug.Log("Slider speed: " + currentSpeed);
        speedText.text = "Speed: " + currentSpeed;
    }
}
