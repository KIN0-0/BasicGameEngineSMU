using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JerkyGenerator : MonoBehaviour
{
    public GameObject jerkyPrefab;
    float span = 1.5f;
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject copyJerky = Instantiate(jerkyPrefab) as GameObject;
            int range = Random.Range(-3, 2);
            copyJerky.transform.position = new Vector3(range, 8, 0);
        }
    }
}
