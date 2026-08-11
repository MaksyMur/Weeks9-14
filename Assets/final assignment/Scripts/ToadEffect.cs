using UnityEngine;

public class ToadEffect : MonoBehaviour
{
    // How much bigger the toad becomes
    public float growSize = 1.5f;

    // How high the toad moves when floating
    public float floatHeight = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 // Makes the toad bigger
    public void Grow()
    {
        transform.localScale = transform.localScale * growSize;

        Debug.Log("Toad grows!");
    }


    // Moves the toad upward
    public void Float()
    {
        transform.position += Vector3.up * floatHeight;

        Debug.Log("Toad floats!");
    }

}
