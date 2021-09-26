using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class EatSO : ScriptableObject {
    [SerializeField] private int eatenFruits = 0;

    public event UnityAction<int> AppleEaten;
    public event UnityAction<int> BananaEaten;
    public event UnityAction<int> WatermelonEaten;

    public void EatApple() {
        eatenFruits++;
        AppleEaten?.Invoke(eatenFruits);
    }
    public void EatBanana() {
        eatenFruits++;
        BananaEaten?.Invoke(eatenFruits);
    }
    public void EatWatermelon() {
        eatenFruits++;
        WatermelonEaten?.Invoke(eatenFruits);
    }

}
