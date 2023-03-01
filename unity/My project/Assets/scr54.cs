using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr54 : MonoBehaviour
{
    public GameObject gameObj;
    float inputH;
    float inputV;
    public float speed;

    public Transform targetPos;
    float x;
    float y;
    float z;
    public int maxdistance;
    public int mindistance;

    bool ControlDistance(float distance)
    {
        if (distance > mindistance && distance < maxdistance) return true;
        return false;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            inputH = Input.GetAxis("Mouse X") * speed;
            transform.RotateAround(gameObj.transform.position, Vector3.up, inputH);

            inputV = -Input.GetAxis("Mouse Y") * speed;
            transform.RotateAround(gameObj.transform.position, Vector3.right, inputV);


            x = Input.GetAxis("Horizontal");
            y = Input.GetAxis("Vertical");
            z = Input.GetAxis("Mouse ScrollWheel");
            if (x != 0 || y != 0)
            {
                Vector3 newpos = transform.position + (transform.TransformDirection(new Vector3(x, 0, 0)) + Vector3.up * y) / speed;
                if (ControlDistance(Vector3.Distance(newpos, targetPos.position))) transform.position = newpos;
            }

            if (z != 0) //произошел скролл
            {
                Vector3 newpos = transform.position + transform.TransformDirection(new Vector3(0, 0, z));
                if (ControlDistance(Vector3.Distance(targetPos.position, newpos))) transform.position = newpos;
            }
        }




    }
}
