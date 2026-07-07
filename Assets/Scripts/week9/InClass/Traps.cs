using UnityEngine;
using UnityEngine.Events;

public class Traps : MonoBehaviour
{
    public SpriteRenderer playerRenderer;
   
    public Explorer playerExplorer;

    public UnityEvent onTrappedEntered;
    public UnityEvent onTrappedExited;

    bool steppedInLava = false;
    bool isInHpGen = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerRenderer.bounds.Contains(transform.position) && !steppedInLava)
        {
            onTrappedEntered.Invoke();
            steppedInLava = true;
        }

        //if we aew on the trap and have just stepped out
        if (!playerRenderer.bounds.Contains(transform.position) && steppedInLava)
        {
            onTrappedExited.Invoke();
            //we are off the trap so don't take damage
            steppedInLava = false;

            if (playerRenderer.bounds.Contains(transform.position) && !isInHpGen)
            {
                onTrappedEntered.Invoke();
                isInHpGen = true;
            }

            //if we aew on the trap and have just stepped out
            if (!playerRenderer.bounds.Contains(transform.position) && isInHpGen)
            {
                onTrappedExited.Invoke();
                //we are off the trap so don't take damage
                steppedInLava = false;
            }
        }
    }
}
