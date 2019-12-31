using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{

    float distance = 7.67f;
    int count = 2;
    int index = 2;

    public GameObject[] grounds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0)
            return;

        gameObject.transform.localPosition += new Vector3(-0.05f, 0, 0);
        count = 2 + (int)(-gameObject.transform.localPosition.x / 7.67f);

        if(index != count)
        {
            grounds[(index - 2) % 3].transform.localPosition = new Vector3(distance * count, 0, 0);
            index = count;
        }
    }
}
