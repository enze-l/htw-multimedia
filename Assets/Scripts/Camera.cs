using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = target.transform.position - transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float desiredAngel = target.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngel, 0);
        transform.position = target.transform.position - (rotation * offset);

        var focalPoint = target.transform.position;
        focalPoint.y +=.6f;

        transform.LookAt(focalPoint);
    }
}
