//WEEK SEVEN STUFF:
using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class CollectionsExample : MonoBehaviour
{
    public List<string> animals;
    public SpriteRenderer spriteRenderer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

        Color grey = new Color(0.3f, 0.3f, 0.3f, 1f);
        spriteRenderer.color = grey;

        animals = new List<string>();//create empty list
        animals.Add("Raccoon"); //add to list syntax
        //animals.Remove("Dog"); //remove from list


        for (int i = 0; i < animals.Count; i++)
        {
            Debug.Log(animals[i]); //access animal @ index i
        }
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}