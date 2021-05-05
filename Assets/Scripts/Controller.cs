using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float rotationSpeed = 1.5f;
    public float movementSpeed = 3f;
    float angle = 0f;
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
            angle += -rotationSpeed*time;
        }
        if(turnRight){
            angle += +rotationSpeed*time;
        }

        Vector3 targetDirection = new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle));
        this.transform.rotation = Quaternion.LookRotation(targetDirection);
        
        transform.position += transform.forward*time*moveVertical*movementSpeed;
        transform.position += transform.right*time*moveHorizontal*movementSpeed;
    }
}
