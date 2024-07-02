using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float Speed = 10f;
    private bool isRotating = false;
    [SerializeField] float angle = 140f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical);
        transform.Translate(movement * Speed * Time.deltaTime);
        
        //if(Input.GetKeyDown(KeyCode.A )&& !isRotating)
        //{
        //    transform.Rotate(0, angle * Time.deltaTime, 0);
        //}
        //if(Input.GetKeyDown(KeyCode.D )&& !isRotating)
        //{
        //    transform.Rotate(0, -angle * Time.deltaTime, 0);
        //}

       
    }
  




}
