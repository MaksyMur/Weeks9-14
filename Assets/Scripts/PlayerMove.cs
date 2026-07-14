using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    Vector2 movementDirection = Vector2.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.position += (Vector3)movementDirection * speed * Time.deltaTime; //if we have vector2, we need to cast it to vector3 to add it to the position
    }
    public void OnMove(InputAction.CallbackContext context)
    {
      movementDirection = context.ReadValue<Vector2>(); //this will read the value of the input action and store it in the movementDirection variable
    }
    public void OnAttack(InputAction.CallbackContext context) //this function will be called when the attack input action is triggered
    {
        
        {
            if(context.performed) 
          
            Debug.Log("Attack " + context.phase);
        }
    }
}
