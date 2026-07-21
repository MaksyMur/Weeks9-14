using UnityEngine;

public class AnimCurvwwGrow : MonoBehaviour
{

    public AnimationCurve growingCurve;
    public float growDuration;
    float treeGrowProgress = 0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        treeGrowProgress += Time.deltaTime;
        //use the animation curve to determine the scale of the tree based on the progress
        transform.localScale = Vector3.one * growingCurve.Evaluate(treeGrowProgress / growDuration); 


        if (treeGrowProgress > growDuration)
        {
            treeGrowProgress = 0f; //reset the progress so that the animation can loop
        }
    }
}
