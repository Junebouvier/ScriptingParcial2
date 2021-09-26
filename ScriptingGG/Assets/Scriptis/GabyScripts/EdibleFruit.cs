using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdibleFruit : MonoBehaviour
{
    public Renderer fruitRenderer;
    void Start() {
        fruitRenderer = GetComponent<Renderer>();
    }
    public virtual void FruitColor() {
        fruitRenderer.material.color = Color.white;
    }
    public virtual void EatFruit() {
        Debug.Log("Fruta comida con exito");
    }

}
