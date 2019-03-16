using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemesShow : MonoBehaviour
{

    public GameObject Pictures;

    public GameObject Button;




    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider collider)
    {

        Debug.Log("I hit");

        if (PortalManager.EnteredFromPortal == true)
        {

            if (Button.activeInHierarchy == false)
            {
                Button.SetActive(true);

            }

            if (Pictures.activeInHierarchy == false)
            {
                Pictures.SetActive(true);

            }

        }



    }

}

