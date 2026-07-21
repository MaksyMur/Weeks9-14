using UnityEngine;
using UnityEngine.InputSystem;

public class BarrelLook : MonoBehaviour
{
     //stores the look input
    Vector2 look;

    //speed of the barrel rotation
    public float rotationSpeed = 200f;

   
    public void Look(InputAction.CallbackContext context)
    {
        //read the mouse movement
        look = context.action.ReadValue<Vector2>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotate the barrel using the x
        transform.eulerAngles += new Vector3(
            0,
            0,
            look.x * rotationSpeed * Time.deltaTime
        ); 
    }
}