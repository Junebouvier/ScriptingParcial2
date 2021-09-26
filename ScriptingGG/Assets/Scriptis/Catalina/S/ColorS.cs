using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorS : MonoBehaviour
{
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();

    }

    public void ColorChange(Color color)
    {
        rend.material.color = color;
    }
}
