using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    float rotationSpeed = 120f;
    float movementSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.deltaTime;

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        bool turnLeft = Input.GetKey(KeyCode.Q);
        bool turnRight = Input.GetKey(KeyCode.E);
        if (turnLeft){
            transform.Rotate(0,-rotationSpeed*time,0);
        }
        if(turnRight){
            transform.Rotate(0,rotationSpeed*time,0);
        }

        transform.position += transform.forward*time*moveVertical*movementSpeed;
        transform.position += transform.right*time*moveHorizontal*movementSpeed;
    }
}
