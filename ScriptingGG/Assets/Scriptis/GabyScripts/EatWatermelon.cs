using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatWatermelon : MonoBehaviour
{
    [SerializeField] private EatSO channel;
    [SerializeField] private Watermelon myFruit;

    private void OnEnable() {
        channel.WatermelonEaten += FruitUpdate;
    }

    private void OnDisable() {
        channel.WatermelonEaten -= FruitUpdate;
    }

    void FruitUpdate(int eatenFruits) {
        myFruit.FruitColor();
        myFruit.EatFruit();
        Debug.Log($"Has comido {eatenFruits} frutas");
    }
}
