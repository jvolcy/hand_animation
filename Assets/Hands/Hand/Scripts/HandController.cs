using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class HandController : MonoBehaviour
{
    //weight of the "select" animation layer
    [Range(0f, 1f)]
    public float select;

    //weight of the "activation" animation layer
    [Range(0f, 1f)]
    public float activate;

    //public bool RightHand = true;

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //transform.localScale = new Vector3(transform.localScale.x * (RightHand ? 1f : -1f), transform.localScale.y, transform.localScale.z);
    }

    // Update is called once per frame
    void Update()
    {
        //set the value of the animation layers
        animator.SetLayerWeight(animator.GetLayerIndex("select"), select);
        animator.SetLayerWeight(animator.GetLayerIndex("activate"), activate);
    }
}
