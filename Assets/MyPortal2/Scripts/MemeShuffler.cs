using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemeShuffler : MonoBehaviour {

    System.Random random = new System.Random();
    
    // Set the materials in the inspector

    public GameObject[] myMemesObjects = new GameObject[5];

    public Texture[] myTextures = new Texture[5];
    // Assigns a random material at start

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   public void onButtonClick()
    {
        for (int i =0;i< myMemesObjects.Length;i++)
        {

            myMemesObjects[i].GetComponent<Renderer>().material.mainTexture = myTextures[random.Next(0, myTextures.Length)];

        }

    }
}
