using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faceScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float ScaleSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.rotation += 4f;
        transform.localScale -= new Vector3(ScaleSpeed, ScaleSpeed, ScaleSpeed);
        if (transform.localScale.x < .05f)
            gameObject.SetActive(false);
    }
}
