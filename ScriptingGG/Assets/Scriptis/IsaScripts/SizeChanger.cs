using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChanger : MonoBehaviour
{
    public TransformSO channel;
    public Transform cubenderer;
    public Cube cube;

    void Start()
    {
        cubenderer = cubenderer.GetComponent<Transform>();
    }

    private void OnEnable()
    {
        channel.onsizechanged += ChangeSize;
    }

    private void OnDisable()
    {
        channel.onsizechanged -= ChangeSize;
    }

    void ChangeSize(float cantidadSizeChange)
    {
        Debug.Log("Entramos en el ChangeSize");

        if (channel.cantidadSizeChange == 5f)
        {
            cube.Small();
            cube.transform.localScale = (new Vector3(1f, 1f, 1f) * channel.cantidadSizeChange);
            Debug.Log("Lo hacemos pequeñito");
        }

        else if (channel.cantidadSizeChange == 0.5f)
        {
            cube.Big();
            cube.transform.localScale = (new Vector3(1f, 1f, 1f) * channel.cantidadSizeChange);
            Debug.Log("Lo hacemos grande");
        }

    }
}
