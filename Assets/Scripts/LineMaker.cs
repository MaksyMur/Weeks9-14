using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class LineMaker : MonoBehaviour
{
    public float growDuration;

    public Vector3 startPoint; //starting point of the line
    public Vector3 endPoint;

    LineRenderer lineRenderer; //reference to the LineRenderer component
    Coroutine growCoroutine; //reference to the coroutine that will be used to grow the line


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
       lineRenderer = GetComponent<LineRenderer>(); //get the LineRenderer component attached to this GameObject

        if (lineRenderer == null)         {
            Debug.LogError("LineRenderer doesnt have a component.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //when the players presses the left mouse button, draw a line from the player to the mouse position

    }

    public void OnJump(InputAction.CallbackContext context)
    {
        
        //start growing the line from left to right
        if (context.performed)
        {
            if (growCoroutine != null) //if the coroutine is already running, stop it
            {
                StopCoroutine(growCoroutine);
            }
            growCoroutine =  StartCoroutine(GrowUpdate()); 

        }
    }

    IEnumerator GrowUpdate() //need to study for the EXAM!
    {
        float t = 0;
        lineRenderer.positionCount = 2; //set the number of points in the line to 2
        lineRenderer.SetPosition(0, startPoint); //set the first point of the line to the start point
        lineRenderer.SetPosition(1, startPoint); //make sure you start with 0, not with 1

        while (t < growDuration)
        {
            Vector2 currentSecondPosition = Vector2.Lerp(startPoint, endPoint, t / growDuration); //calculate the current position of the second point based on the time elapsed(EXAM)
            lineRenderer.SetPosition(1, currentSecondPosition);
            t += Time.deltaTime;
            yield return null; //wait for the next frame
        }
    }
}
