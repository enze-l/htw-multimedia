using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARSpawner : MonoBehaviour
{
    public Transform myPrefab;
    public Transform quad;
    public int objectAmount;
    public Renderer quadRenderer;
    private List<Transform> items = new List<Transform>();
    // Start is called before the first frame update
    void Start()
    {
        float quadScaleX = quad.transform.localScale.x;
        float quadScaleY = quad.transform.localScale.y;
        for(int gem = 0; gem<objectAmount; gem++)
        {
            float randomY = Random.Range(-(quadScaleY / 2), quadScaleY/2);
            float randomX = Random.Range(-(quadScaleX / 2), quadScaleX/2);
            Transform blub = Instantiate(myPrefab, this.transform, false);
            blub.position = new Vector3(randomX, 0.2f, randomY);
            blub.GetComponent<Renderer>().enabled = false;
            items.Add(blub);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(quadRenderer.isVisible){
            foreach (var item in items){
                item.GetComponent<Renderer>().enabled = true;
            }
        }
    }
}
