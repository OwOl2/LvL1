using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall1Script : MonoBehaviour
{
    public Rigidbody2D rb;
    int i = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rb.rotation += 3f;
        float t = Mathf.PingPong(Time.time, 0.5f);
        transform.localScale -= Vector3.one * t * i;
        if (t < 0.5f)
        {
            i = i * (-1);
        }

    }


}
