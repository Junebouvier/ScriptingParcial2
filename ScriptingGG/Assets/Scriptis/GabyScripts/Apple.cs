using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : EdibleFruit {
    public override void FruitColor() {
        fruitRenderer.material.color = Color.red;
    }
    public override void EatFruit() {
        Debug.Log("Te comiste una manzana");
    }
}
