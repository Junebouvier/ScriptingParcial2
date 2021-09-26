using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SizeS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Tamano(int scale)
    {
        transform.localScale = new Vector3 (1,1,1) * scale;
    }
}
