using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChocoGenerator : MonoBehaviour
{
    public GameObject chocoPrefab;
    float span = 1.5f;
    float delta = 0; 

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject copyChoco = Instantiate(chocoPrefab) as GameObject;
            int range = Random.Range(-3, 2);
            copyChoco.transform.position = new Vector3(range, 8, 0);
        }
    }
}
