using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.name == "Box011")
        {
            if (butStartAnimScr.move)
                if (butStartAnimScr.kolvo >= 0 && butStartAnimScr.kolvo < 10)
                    butStartAnimScr.kolvo++;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        
    }
}
