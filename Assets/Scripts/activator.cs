using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activator : MonoBehaviour
{
    public GameObject[] firsGroup;
    public GameObject[] secondGroup;
    public activator button;
    public Material normal;
    public Material transparent;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Cube") || other.CompareTag("Player"))
            {

            foreach(GameObject first in firsGroup)
            {
                first.GetComponent<Renderer>().material = normal;
                first.GetComponent<Collider>().isTrigger = false; 
            }
            foreach (GameObject second in secondGroup)
            {
                second.GetComponent<Renderer>().material = transparent;
                second.GetComponent<Collider>().isTrigger = true;
            }
            GetComponent<Renderer>().material = transparent;
            button.GetComponent<Renderer>().material = normal;
             
            }
    }
}
