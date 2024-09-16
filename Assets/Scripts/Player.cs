using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Player : MonoBehaviour
{
    [SerializeField] KeyCode keyOne; // указываем клавишу для движения 1
    [SerializeField] KeyCode keyTwo; // указываем клавишу для движения 2
    [SerializeField] Vector3 moveDirection; 
                                            
    private void FixedUpdate() 
    {
        if (Input.GetKey(keyOne))
        {
            GetComponent<Rigidbody>().velocity += moveDirection; 

        }
        if (Input.GetKey(keyTwo)) 
        {
            GetComponent<Rigidbody>().velocity -= moveDirection; 

        }
        if (Input.GetKey(KeyCode.R)) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
        }
        if (Input.GetKey(KeyCode.Q)) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
        }
    }
    private void OnTriggerEnter(Collider other) 
    {
        if (this.CompareTag("Player") && other.CompareTag("Finish"))  
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }


}