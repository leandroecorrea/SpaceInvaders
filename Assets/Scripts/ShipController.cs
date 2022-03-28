using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ShipController : MonoBehaviour
{
    private new Rigidbody2D rigidbody;
    private Vector2 movement;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        movement = new Vector2(moveHorizontal, 0f);
    }

    // FixedUpdate se llama en cada fixed framerate frame (50ps default)
    void FixedUpdate()
    {
        rigidbody.AddForce(movement * speed * 5f);
    }
}
