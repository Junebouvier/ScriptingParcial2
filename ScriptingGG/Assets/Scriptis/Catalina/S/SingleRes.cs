using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleRes : MonoBehaviour
{
    public GameObject capsule;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
            capsule.GetComponent<ColorS>().ColorChange(Color.red);

        if (Input.GetKey(KeyCode.B))
            capsule.GetComponent<ColorS>().ColorChange(Color.blue);
        
        if (Input.GetKey(KeyCode.S))
            capsule.GetComponent<SizeS>().Tamano(2);
        
        if (Input.GetKey(KeyCode.A))
            capsule.GetComponent<SizeS>().Tamano(5);
    }
}

