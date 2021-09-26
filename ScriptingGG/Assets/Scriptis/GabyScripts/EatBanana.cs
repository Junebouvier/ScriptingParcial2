using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatBanana : MonoBehaviour
{
    [SerializeField] private EatSO channel;
    [SerializeField] private Banana myFruit;

    private void OnEnable() {
        channel.BananaEaten += FruitUpdate;
    }

    private void OnDisable() {
        channel.BananaEaten -= FruitUpdate;
    }

    void FruitUpdate(int eatenFruits) {
        myFruit.FruitColor();
        myFruit.EatFruit();
        Debug.Log($"Has comido {eatenFruits} frutas");
    }
}
