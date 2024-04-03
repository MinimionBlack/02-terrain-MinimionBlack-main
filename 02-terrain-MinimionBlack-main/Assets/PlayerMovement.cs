using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        transform.Translate(0, 0, 1);
    }

    public float speed;

 
}
