using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr56 : MonoBehaviour
{
    bool move = false;
    float speed = 0.01f;
    float offset = 0;
    Vector3 startPosition;
    Vector3 needPosition;
    Quaternion startRotation;
    Quaternion needRotaton;
    public GameObject need;

    public void NeedPositionObjext()
    {
        startPosition = this.transform.position;
        startRotation = this.transform.rotation;
        needPosition = need.transform.position;
        needRotaton = need.transform.rotation;
        move = true;
    }

    void Update()
    {
        if (move)
        {
            offset += speed;
            transform.position = Vector3.Lerp(startPosition, needPosition, offset);
            transform.rotation = Quaternion.Slerp(startRotation, needRotaton, offset);
            if (offset >= 1)
            {
                move = false;
                offset = 0;
            }
        }

    }
}
