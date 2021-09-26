using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sizeinator : MonoBehaviour, IChangeSize
{
    void Start()
    {

    }
    public void SizeChange (int scale)
    {
        transform.localScale = new Vector3(1, 1, 1) * scale;
    }
    public void SizeChangeinator(int scale)
    {
        throw new System.NotImplementedException();
    }
}

public interface IChangeSize
{
    void SizeChangeinator(int scale);
}
