using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    AudioSource audioData;
    public Text countText;
    public GameObject pickups;

    private int count, startcount;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
        count = 0;
        startcount = 0;
        SetCountText();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal")*speed;
        float moveVertical = Input.GetAxis("Vertical")*speed;

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);

        transform.position = movement + transform.position;

        if (movement == new Vector3(0.0f, 0.0f, 0.0f))
            transform.position = movement;

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            SetCountText();
        }

        if (other.gameObject.CompareTag("Wall"))
        {
            transform.position = new Vector3(0.0f, 0.0f, 0.0f);

            count = startcount;
            pickups.SetActiveRecursively(true);

            audioData.Play(0);
        }
        
    }

    void SetCountText()
    {
        //Set the text property of our our countText object to "Count: " followed by the number stored in our count variable.
        countText.text = count.ToString();
    }
}