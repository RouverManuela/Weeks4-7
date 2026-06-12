using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Play : MonoBehaviour
{

    public AudioSource startSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void start()
    {
        startSound.Play();
    }
}
