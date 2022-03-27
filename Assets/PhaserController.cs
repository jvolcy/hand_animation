using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PhaserController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject barrel;
    public GameObject HandController;
    XRInteractorLineVisual interactorLineVisual;
    //bool interactorLineVisualState;

    // Start is called before the first frame update
    void Start()
    {
        interactorLineVisual = HandController.GetComponentInParent<XRInteractorLineVisual>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Shoot()
    {
        Debug.Log("shoot!");
        Instantiate(bulletPrefab, barrel.transform.position, barrel.transform.rotation);
    }

    public void SelectEnter()
    {
        //store the current state of the interactorLineVisual
        //interactorLineVisualState = interactorLineVisual.enabled;

        //turn off the ray interactor visual when we have the phaser.
        interactorLineVisual.enabled = false;
    }

    public void SelectExit()
    {
        //restore the ray interactor visual when we have the phaser.
        //interactorLineVisual.enabled = interactorLineVisualState;

        interactorLineVisual.enabled = true;
    }
}
