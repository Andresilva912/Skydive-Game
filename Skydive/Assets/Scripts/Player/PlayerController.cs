using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* NOTES:
    - Player only moves on the x and y axis. z is locked
    - All rotation is locked
*/

public class PlayerController : MonoBehaviour{

    public float movementSpeed;

    public Transform anchorCenter;
    public Transform anchorUp;
    public Transform anchorRight;
    public Transform anchorDown;
    public Transform anchorLeft;

    //Movement variables
    private Transform currentAnchor;
    private string currentAnchorIdentifier;
    private bool moveInProgress = false;

    Rigidbody rb;

    void Start(){
        rb = gameObject.GetComponent<Rigidbody>();
        currentAnchor = anchorCenter;
        currentAnchorIdentifier = "center";
    }

    void Update(){
        handleInput();
    }

    private void handleInput(){
        if (Input.GetKeyDown("w") || moveInProgress){
            p("IN 1");
            movement("up");
        }
        else if (Input.GetKeyDown("a") || moveInProgress){
            p("IN 2");
            movement("left");
        }
        else if (Input.GetKeyDown("s") || moveInProgress){
            p("IN 3");
            movement("down");
        }
        else if (Input.GetKeyDown("d") || moveInProgress){
            p("IN 4");
            movement("right");
        }

    }

    private void movement(string direction){
        if (!moveInProgress){ //Only runs once when move initiated
            Transform toAnchor = checkIfValidMove(direction);
            if (toAnchor != null ){
                currentAnchor = toAnchor;
                moveInProgress = true;
                // transform.position = currentAnchor.position;
            }
        }

        else { //Runs until player reaches new position
            transform.position = Vector3.Lerp(transform.position, currentAnchor.position, movementSpeed * Time.deltaTime);
            if (transform.position == currentAnchor.position ){
                moveInProgress = false;
            }
            else {
                Debug.Log("Player pos: " + transform.position + " Anchor pos: " + currentAnchor.position);
            }
        }
    }

    private Transform checkIfValidMove(string direction){

        if (currentAnchorIdentifier == "center"){
            if (direction == "up"){
                currentAnchorIdentifier = "top";
                return anchorUp;
            }
            if (direction == "right"){
                currentAnchorIdentifier = "right";
                return anchorRight;
            }
            if (direction == "down"){
                currentAnchorIdentifier = "bottom";
                return anchorDown;
            }
            if (direction == "left"){
                currentAnchorIdentifier = "left";
                return anchorLeft;
            }
        }

        else if (currentAnchorIdentifier == "top" && direction == "down"){
            currentAnchorIdentifier = "center";
            return anchorCenter;
        }
        else if (currentAnchorIdentifier == "right" && direction == "left"){
            currentAnchorIdentifier = "center";
            return anchorCenter;
        }
        else if (currentAnchorIdentifier == "bottom" && direction == "up"){
            currentAnchorIdentifier = "center";
            return anchorCenter;
        }
        else if (currentAnchorIdentifier == "left" && direction == "right"){
            currentAnchorIdentifier = "center";
            return anchorCenter;
        }

        return null;
    }

    private void p(string msg, GameObject g = null){ //Can be used for fast printing
        Debug.Log(msg, g);
    }

}
