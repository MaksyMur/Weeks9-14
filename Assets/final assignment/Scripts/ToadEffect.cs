using UnityEngine;
using System.Collections;

public class ToadEffect : MonoBehaviour
{
    //how much bigger the toad becomes
    public float growSize = 1.5f;

    //how high the toad moves when floating
    public float floatHeight = 2f;

    //sprite Renderer of the toad
    public SpriteRenderer toadSprite;
    public Sprite glowSprite;
    public Sprite popSprite;


    // Start is called once before the first execution of Update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    //changes the toad color to blue
    public void Blue()
    {
        toadSprite.color = Color.blue;

        Debug.Log("Toad is blue!");
    }


    // changes the toad color to red
    public void Red()
    {
        toadSprite.color = Color.red;

        Debug.Log("Toad is red!");
    }


    // changes the toad color to yellow
    public void Yellow()
    {
        toadSprite.color = Color.yellow;

        Debug.Log("Toad is yellow!");
    }


    //makes the toad bigger
    public void Grow()
    {
        transform.localScale = transform.localScale * growSize;

        Debug.Log("Toad grows!");
    }


    //moves the toad upward
    public void Float()
{
    StartCoroutine(FloatUp());
}

//slowly moves the toad upward
IEnumerator FloatUp()
{
    float targetHeight = transform.position.y + floatHeight;

    //keep moving until the toad reaches the target height
    while (transform.position.y < targetHeight)
    {
        transform.position += Vector3.up * Time.deltaTime;

        yield return null;
    }

    Debug.Log("Toad stopped floating!");
}

    public void Glow()
    {
        toadSprite.sprite = glowSprite;

        Debug.Log("Toad glows!");
    }

    public void Pop()
    {
        toadSprite.sprite = popSprite;

        Debug.Log("Toad pops!");
    }
}