using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaursakRun.Controllers.Environment
{
    public class Obstacle : ObstItem
    {
        [SerializeField] private float _speed;
        //[SerializeField] private Rigidbody2D _rigidbody;

        private void Update()
        {
            transform.Translate(Vector2.left * _speed * Time.deltaTime);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Destroy"))
            {
                Destroy(this.gameObject);
            }             
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                Destroy(this.gameObject);
            }
        }

    }
}

 