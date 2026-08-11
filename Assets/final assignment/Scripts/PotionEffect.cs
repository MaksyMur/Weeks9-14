using UnityEngine;
using UnityEngine.Events;

public class PotionEffect : MonoBehaviour
{
    //event that will be called when this potion effect is activated
    public UnityEvent onPotionUsed;

    // Activates the event
    public void UseEffect()
    {
        Debug.Log("PotionEffect UnityEvent invoked!");

        onPotionUsed.Invoke();
    }
}
