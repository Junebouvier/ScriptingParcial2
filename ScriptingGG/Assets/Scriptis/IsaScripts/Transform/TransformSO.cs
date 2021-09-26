using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[CreateAssetMenu]

public class TransformSO : ScriptableObject {
    public float cantidadSizeChange = 0;

    public event UnityAction<float> onsizechanged;
    
      


    public void OnSizeChanged(float cantidadSizeChange) {

        if (onsizechanged != null) {
            onsizechanged(cantidadSizeChange);
        }

    }
}
