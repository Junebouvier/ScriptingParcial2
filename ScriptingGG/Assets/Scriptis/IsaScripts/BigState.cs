using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigState : ICube
{
    public void Execute(TransformSO transformSO)
    {

        transformSO.cantidadSizeChange = 5;

    }
}
