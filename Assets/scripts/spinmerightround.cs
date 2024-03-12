using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinmerightround : MonoBehaviour
{
    Vector3 initPos;

    void Start() {
        initPos = transform.position;
    }
    void Update()
    {
        transform.Rotate(0f, 100 * Time.deltaTime, 0f, Space.Self);
        transform.position = new Vector3(initPos.x, Mathf.Sin(Time.time * 3) * 0.3f, 0);
    }
    
}
