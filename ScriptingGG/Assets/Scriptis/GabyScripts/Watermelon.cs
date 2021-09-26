using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watermelon : EdibleFruit {
    public override void FruitColor() {
        fruitRenderer.material.color = Color.green;
    }
    public override void EatFruit() {
        Debug.Log("Te comiste una sandía");
    }
}
