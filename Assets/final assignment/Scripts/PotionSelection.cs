using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class PotionSelection : MonoBehaviour
{
    //stores which potions are currently selected
    public bool blueSelected = false;
    public bool redSelected = false;
    public bool yellowSelected = false;

    //potion images
    public Transform bluePotion;
    public Transform redPotion;
    public Transform yellowPotion;

    public float selectedSize = 1.2f;//size of the potion when selected

    Vector3 originalBlueScale;
    Vector3 originalRedScale;
    Vector3 originalYellowScale;
  


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalBlueScale = bluePotion.localScale;
        originalRedScale = redPotion.localScale;
        originalYellowScale = yellowPotion.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //called by the Blue Potion UI button
    public void SelectBlue()
    {
        //switch between selected and not selected
        blueSelected = !blueSelected;

        //change the potion size to show its selection
        if (blueSelected)
        {
            bluePotion.localScale = originalBlueScale * selectedSize;
        }
        else
        {
            bluePotion.localScale = originalBlueScale;
        }
    }

    //called by the Red Potion UI button
    public void SelectRed()
    {
        redSelected = !redSelected;
        //change the potion size to show its selection
        if (redSelected)
        {
            redPotion.localScale = originalRedScale * selectedSize;
        }
        else
        {
            redPotion.localScale = originalRedScale;
        }
    }

    //called by the Yellow Potion UI button
    public void SelectYellow()
    {
        yellowSelected = !yellowSelected;
        //change the potion size to show its selection
        if (yellowSelected)
        {
            yellowPotion.localScale = originalYellowScale * selectedSize;
        }
        else
        {
            yellowPotion.localScale = originalYellowScale;
        }
    }

    public void UsePotion(InputAction.CallbackContext context)
{
    // Performed makes sure the function runs only once per button press
    if (context.performed)
    {
        Debug.Log("Potion used!");

        //shows which potions are currently selected
        Debug.Log("Blue: " + blueSelected);
        Debug.Log("Red: " + redSelected);
        Debug.Log("Yellow: " + yellowSelected);
    }
}
}
