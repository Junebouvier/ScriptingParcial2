using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : EdibleFruit {
    public override void FruitColor() {
        fruitRenderer.material.color = Color.yellow;
    }
    public override void EatFruit() {
        Debug.Log("Te comiste una banana");
    }
}
