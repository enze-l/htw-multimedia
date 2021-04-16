using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform myPrefab;
    public Transform quad;
    public int objectAmount;
    // Start is called before the first frame update
    void Start()
    {
        float quadScaleX = quad.transform.localScale.x;
        float quadScaleY = quad.transform.localScale.y;
        for(int gem = 0; gem<objectAmount; gem++)
        {
            float randomY = Random.Range(-(quadScaleY / 2), quadScaleY/2);
            float randomX = Random.Range(-(quadScaleX / 2), quadScaleX/2);
            Instantiate(myPrefab, new Vector3(randomX, 0.2f, randomY), myPrefab.rotation);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
