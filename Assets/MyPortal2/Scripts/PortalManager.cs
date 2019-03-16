using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
public class PortalManager : MonoBehaviour {

    public GameObject MainCamera;
    public GameObject Sponza;
    public GameObject Pictures;


    private Material[] SponzaMaterials;
    public AudioSource mySong;
    public GameObject Button;

    public static bool EnteredFromPortal;
    private bool ButtonReady;


    // Use this for initialization


    void Start () {
        SponzaMaterials = Sponza.GetComponent<Renderer>().sharedMaterials;
         


    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider collider)
    {

        if (Pictures.activeInHierarchy == false)
        {
            EnteredFromPortal = true;
           // Pictures.SetActive(true);

        }
        else
        {
            EnteredFromPortal = false;


        }

        if (mySong.volume == 1)
        {
            mySong.volume = Mathf.Lerp(1, 0.105f, 5);

        }
        mySong.volume = Mathf.Lerp(0.105f, 1, 5);

        //else mySong.Pause();

      

    }
    private void OnTriggerExit(Collider other)
    {
        
            Pictures.SetActive(false);

            Button.SetActive(false);


    }
    void OnTriggerStay (Collider collider) {

        Vector3 camPositionInPortalSpace = transform.InverseTransformPoint(MainCamera.transform.position);

      
        if (camPositionInPortalSpace.y < 0.5f)
        {
            for (int i =0; i< SponzaMaterials.Length; i++)
            {

                SponzaMaterials[i].SetInt("_StencilComp", (int)CompareFunction.Always);
            }

        }
        else
        {
            for (int i = 0; i < SponzaMaterials.Length; i++)
            {

                SponzaMaterials[i].SetInt("_StencilComp", (int)CompareFunction.Equal);
            }

        }
	}
}
