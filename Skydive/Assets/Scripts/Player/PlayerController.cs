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

    //public Transform movementAnchors;
    public Transform anchorCenter;
    public Transform anchorUp;
    public Transform anchorRight;
    public Transform anchorDown;
    public Transform anchorLeft;

    private Transform currentAnchor;
    private string currentAnchorIdentifier;

    Rigidbody rb;

    void Start(){
        rb = gameObject.GetComponent<Rigidbody>();
        currentAnchor = anchorCenter;
        currentAnchorIdentifier = "center";
    }

    void Update(){
        movement();
    }

    private void movement(){
        if (Input.GetKeyDown("w")){
            Transform toAnchor = checkIfValidMove("up");
            if (toAnchor != null){
                currentAnchor = toAnchor;
                transform.position = currentAnchor.position;
                // transform.position = Vector3.Lerp(transform.position, currentAnchor.position, movementSpeed * Time.deltaTime);
            }
        }
        else if (Input.GetKeyDown("a")){
            Transform toAnchor = checkIfValidMove("left");
            if (toAnchor != null){
                currentAnchor = toAnchor;
                transform.position = currentAnchor.position;
            }
        }
        else if (Input.GetKeyDown("s")){
            Transform toAnchor = checkIfValidMove("down");
            if (toAnchor != null){
                currentAnchor = toAnchor;
                transform.position = currentAnchor.position;
            }
        }
        else if (Input.GetKeyDown("d")){
            Transform toAnchor = checkIfValidMove("right");
            if (toAnchor != null){
                currentAnchor = toAnchor;
                transform.position = currentAnchor.position;
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
