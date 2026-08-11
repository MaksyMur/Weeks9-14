using UnityEngine;
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

    //size of the potion when selected
    public float selectedSize = 1.2f;

    private Vector3 originalBlueScale;
    private Vector3 originalRedScale;
    private Vector3 originalYellowScale;

    // References to potion effects
    public PotionEffect growEffect;
    public PotionEffect floatEffect;
    public ToadEffect toadEffect;


    void Start()
    {
        originalBlueScale = bluePotion.localScale;
        originalRedScale = redPotion.localScale;
        originalYellowScale = yellowPotion.localScale;
    }


    //called by the Blue Potion UI button
    public void SelectBlue()
    {
        blueSelected = !blueSelected;

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

        if (redSelected)
        {
            redPotion.localScale = originalRedScale * selectedSize;
        }
        else
        {
            redPotion.localScale = originalRedScale;
        }
    }


    // called by the Yellow Potion UI button
    public void SelectYellow()
    {
        yellowSelected = !yellowSelected;

        if (yellowSelected)
        {
            yellowPotion.localScale = originalYellowScale * selectedSize;
        }
        else
        {
            yellowPotion.localScale = originalYellowScale;
        }
    }


    //called when the Interact input is performed
    public void UsePotion(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            //all three potions
            if (blueSelected && redSelected && yellowSelected)
            {
                Debug.Log("BLUE + RED + YELLOW = POP");
                toadEffect.Pop();
            }

            // Blue + Red = Grow
            else if (blueSelected && redSelected)
            {
                Debug.Log("BLUE + RED = GROW");

                growEffect.UseEffect();
            }

            // Red + Yellow = Float
            else if (redSelected && yellowSelected)
            {
                Debug.Log("RED + YELLOW = FLOAT");

                floatEffect.UseEffect();
            }

            // Blue + Yellow = Glow
            else if (blueSelected && yellowSelected)
            {
                Debug.Log("BLUE + YELLOW = GLOW");
                toadEffect.Glow();
            }

            //individual potions
            else if (blueSelected)
            {
                Debug.Log("BLUE");
                toadEffect.Blue();
            }

            else if (redSelected)
            {
                Debug.Log("RED");
                toadEffect.Red();
            }

            else if (yellowSelected)
            {
                Debug.Log("YELLOW");
                toadEffect.Yellow();
            }

            else
            {
                Debug.Log("No potion selected");
            }
        }
    }
}