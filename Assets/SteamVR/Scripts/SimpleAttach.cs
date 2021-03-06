﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class SimpleAttach : MonoBehaviour
{
    private Interactable interactable;
    private bool grabOver = false;
    // Start is called before the first frame update
    void Start()
    {
        interactable = GetComponent<Interactable>();
    }

    // private void Awake()
    // {
    //     // Check if Colider is in another GameObject
    //     Collider collider = GetComponentInChildren<Collider>();
    //     if (collider.gameObject != gameObject)
    //     {
    //         BreadboardInsertion cb = collider.gameObject.AddComponent<BreadboardInsertion>();
    //         cb.Initialize(this);
    //     }
    // }

    private void onHandHoverBegin(Hand hand) {
        hand.ShowGrabHint();
    }

    private void onHandHoverEnd(Hand hand) {
        hand.HideGrabHint();
    }

    private void HandHoverUpdate(Hand hand) {
        GrabTypes grabType = hand.GetGrabStarting();
        bool isGrabEnding = hand.IsGrabEnding(gameObject);

        //GRAB
        if (interactable.attachedToHand == null && grabType != GrabTypes.None) {
            hand.AttachObject(gameObject, grabType);
            hand.HoverLock(interactable);

        //Set the position of the object to just above the hole
        //this.gameObject.transform.position = new Vector3();
        //set the hole of breadboard to be the parent of the object
        //this.gameObject.transform.parent = null;
        //turn off all the physics interactions until its grabbed again
        var rigidBody = this.gameObject.GetComponent<Rigidbody>();
        rigidBody.constraints = RigidbodyConstraints.None;
        grabOver = isGrabEnding;

        }
        //RELEASE
        else if (isGrabEnding) {
            hand.DetachObject(gameObject);
            hand.HoverUnlock(interactable);
            grabOver = isGrabEnding;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        //Collider myCollider = collision.contacts[0].thisCollider;
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "BreadboardHoles" && grabOver)
        {
            //Set the position of the object to just above the hole
            this.gameObject.transform.position = new Vector3(collision.gameObject.transform.position.x + 0.01f, collision.gameObject.transform.position.y - 0.02f, collision.gameObject.transform.position.z);
            //set the hole of breadboard to be the parent of the object
            //this.gameObject.transform.parent = collision.gameObject.transform;
            //Freeze position until it is grabbed again
            var rigidBody = this.gameObject.GetComponent<Rigidbody>();
            rigidBody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
            grabOver = false;
        }
    }

    

    //MAKE THE ONGRAB HANDLER RESET EVERYTHING


    // Update is called once per frame
    void Update()
    {
        
    }
}
