using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallState : ICube
{
    public void Execute(TransformSO transformSO)
    {

        Debug.Log("Soy peque�ooo");
        transformSO.cantidadSizeChange = 0.5f;

    }
}
