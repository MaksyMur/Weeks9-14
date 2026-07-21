using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

  
    public Sprite[] sprites;

    //sprite index
    int index = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
     {
        //first sprite
        spriteRenderer.sprite = sprites[index];
    }

    //change to the next sprite
    public void ChangeSprite()
    {
        //move to the next sprite
        index++;

        //return to the first sprite if the end of the array is reached
        if (index >= sprites.Length)
        {
            index = 0;
        }

        //current sprite
        spriteRenderer.sprite = sprites[index];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
