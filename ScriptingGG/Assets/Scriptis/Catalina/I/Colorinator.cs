using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorinator : MonoBehaviour, IColorChangeinator
{
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ColorChange(Color color)
    {
        rend.material.color = color;
    }

    public void ColorChangeinator(Color color)
    {
        throw new System.NotImplementedException();
    }
}

public interface IColorChangeinator
{
    void ColorChangeinator(Color color);
}
