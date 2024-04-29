using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace BaursakRun.Controllers
{
  public class BaursakController : MonoBehaviour
  {     
  
        private Rigidbody2D _rb;
        [SerializeField] private float _jumpForce;    
        [SerializeField] private TMP_Text _scoretext;
        private int _score;
        private bool _isground = false;      
        private int _health = 3 ;
        [SerializeField] private GameObject[] _lifes;
        void Start()
        {
            InitBaursak();
            _health = _lifes.Length;
            _score = 0;
            _scoretext.text = _score.ToString();
        }

        private void InitBaursak()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            try
            {
                var touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began&& _isground == true)
                {
                     Jump();                                                                           
                }                              
            }
            catch (System.Exception)
            {

            }
        }
        private void Jump()
        {
            _rb.AddForce(new Vector2(0, _jumpForce));
            _isground = false;           
            _score++;
            _scoretext.text = _score.ToString();

        }

        private void TakeDamage()
        {
           // _rb.AddForce(Vector2.up * _jumpForce);
            if (_health >= 1)
            {
               _health = _health - 1;

               Destroy(_lifes[_health].gameObject);

               if (_health < 1)
               {
                  Destroy(gameObject);
               }  
            }
           
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                if (_isground == false)
                {
                    _isground = true;
                }
            }

            if (collision.gameObject.CompareTag("Obstacle"))
            {              
                TakeDamage();
               
            }
        }
        


  }

}

