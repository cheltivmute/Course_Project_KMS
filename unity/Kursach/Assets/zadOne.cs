using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadOne : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SliderEnabled()
    {
        transform.gameObject.SetActive(true);
    }
    public void SliderDisabled()
    {
        transform.gameObject.SetActive(false);
    }
}
