using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARController : MonoBehaviour
{
    public Transform movableObject;
    private bool goforward = false;
    private bool gobackward = false;
    private bool turnleft = false;
    private bool turnright = false;

    public float rotationSpeed = 1.5f;
    public float movementSpeed = 3f;
    float angle = 0f;

    // Start is called before the first frame update
    void Start()
    {
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterOnButtonPressed(OnButtonPressed);
            vbs[i].RegisterOnButtonReleased(OnButtonReleased);
        }

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            case "ButtonTurnRight":
                turnright = true;
                break;
            case "ButtonTurnLeft":
                turnleft = true;
                break;
            case "ButtonGoForward":
                goforward = true;
                break;
            case "ButtonGoBackward":
                gobackward = true;
                break;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            case "ButtonTurnRight":
                turnright = false;
                break;
            case "ButtonTurnLeft":
                turnleft = false;
                break;
            case "ButtonGoForward":
                goforward = false;
                break;
            case "ButtonGoBackward":
                gobackward = false;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.deltaTime;

        if (turnleft)
        {
            angle += -rotationSpeed * time;
        }
        if (turnright)
        {
            angle += +rotationSpeed * time;
        }

        Vector3 targetDirection = new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle));
        movableObject.rotation = Quaternion.LookRotation(targetDirection);

        if (goforward)
        {
            movableObject.position += movableObject.forward * time * movementSpeed;
        }
        if (gobackward)
        {
            movableObject.position -= movableObject.forward * time * movementSpeed;
        }
    }
}