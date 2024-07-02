using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takaraScript : MonoBehaviour
{
    [SerializeField] GameObject takara;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag=="Player")
        {
           
            Debug.Log("Player touched the treasure!");
        }
      }
      void OnTriggerStay(Collider col)
    {
        if(col.gameObject.tag=="Player")
        {
            Destroy(takara);
           
        }

    }


}
