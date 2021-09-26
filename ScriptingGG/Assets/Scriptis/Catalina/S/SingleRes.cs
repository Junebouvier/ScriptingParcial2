using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleRes : MonoBehaviour
{
    public GameObject capsule, cube;
       
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            capsule.GetComponent<Colorinator>().ColorChange(Color.red); 
        }
            
        if (Input.GetKey(KeyCode.B))
        {
            capsule.GetComponent<Colorinator>().ColorChange(Color.blue);
        }
            
        
        if (Input.GetKey(KeyCode.S))
        {
            capsule.GetComponent<Sizeinator>().SizeChange(2);
            cube.GetComponent<Sizeinator>().SizeChange(2);
        }

        if (Input.GetKey(KeyCode.A))
        {
            capsule.GetComponent<Sizeinator>().SizeChange(5);
            cube.GetComponent<Sizeinator>().SizeChange(10);
        }
  
    }
}

