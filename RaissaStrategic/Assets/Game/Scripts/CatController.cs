using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    float horizontalInput = Input.GetAxis ("Horizontal"); 
    float verticalInput = Input.GetAxis ("Vertical");
    float normalMoveSpeed = 1.0f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ControlarGato();
    }

    public void ControlarGato()
    {

        transform.position += transform.forward * normalMoveSpeed * Input.GetAxis("Vertical") * Time.unscaledDeltaTime;
        transform.position += transform.right * normalMoveSpeed * Input.GetAxis("Horizontal") * Time.unscaledDeltaTime;

    }
}
