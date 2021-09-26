using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public ICube m_EstadoAct;
    public TransformSO transformSO;

    void Start()
    {
        transformSO.cantidadSizeChange = 0.5f;
    }

    public void Big()
    {
        m_EstadoAct = new BigState();
        m_EstadoAct.Execute(transformSO);
    }

    public void Small()
    {
        m_EstadoAct = new SmallState();
        m_EstadoAct.Execute(transformSO);
    }
}
