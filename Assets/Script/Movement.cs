using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector2 movement;
    [SerializeField] Rigidbody2D rigidbody2D;
    [SerializeField] private float speed = 3;
    void Start()
    {
        rigidbody2D = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        rigidbody2D.MovePosition(rigidbody2D.position + speed * movement * Time.deltaTime);
    }
}
