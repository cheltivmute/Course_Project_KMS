using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objScr : MonoBehaviour
{
    float input;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        input = Input.GetAxis("Horizontal") * 0.01f;
        transform.Translate(input, 0, 0);

    }
}
