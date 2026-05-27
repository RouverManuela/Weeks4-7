using UnityEngine;

public class codinggym : MonoBehaviour
{
    public SpriteRenderer GameSprite;
    float progress = 0f;
    float duration = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime;
        if(progress > duration)
        {
            GameSprite.color = Random.ColorHSV(0f, 1f,1f, 1f, 0.5f, 1f);
            progress = 0f;
        }
       
    }
}
