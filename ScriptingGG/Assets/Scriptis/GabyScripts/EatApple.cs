using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatApple : MonoBehaviour
{
    [SerializeField] private EatSO channel;
    [SerializeField] private Apple myFruit;

    private void OnEnable() {
        channel.AppleEaten += FruitUpdate;
    }

    private void OnDisable() {
        channel.AppleEaten -= FruitUpdate;
    }

    void FruitUpdate(int eatenFruits) {
        myFruit.FruitColor();
        myFruit.EatFruit();
        Debug.Log($"Has comido {eatenFruits} frutas");
    }
}
