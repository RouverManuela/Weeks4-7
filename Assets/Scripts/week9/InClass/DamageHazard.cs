using UnityEngine;

public class DamageHazard : MonoBehaviour
{
    public SpriteRenderer playerRenderer;
    public Explorer playerExplorer;

    bool isCurrentlyOnTrap = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if we were not on the trap and just stepped on it
        if (playerRenderer.bounds.Contains(transform.position) && !isCurrentlyOnTrap)
        {
            //we are now on the trap and take damage
            playerExplorer.health -= 10;
            isCurrentlyOnTrap=true;
        }

        //if we aew on the trap and have just stepped out
        if (!playerRenderer.bounds.Contains(transform.position) && isCurrentlyOnTrap)
        {
            //we are off the trap so don't take damage
            isCurrentlyOnTrap = false;
        }

    }
}
