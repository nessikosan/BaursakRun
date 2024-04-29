using BaursakRun.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaursakRun.Controllers
{
  public class EnvController : MonoBehaviour
  {
        [SerializeField] private GameObject _env;
        [SerializeField] private GameObject _envNew;
        [SerializeField] private float _mergeDistance;
       
      
        private Vector3 _startPosition;
        void Start()
        {
            _startPosition = _env.transform.localPosition;        

        }

        void Update()
        {
            _env.transform.localPosition += 2.5f * Time.deltaTime * -Vector3.right;

            if (_env.transform.localPosition.x < -5)
            {
                if (!_envNew)
                {
                    _envNew = Instantiate(_env, new Vector3(18, 0, 0), Quaternion.identity, transform);
                    _envNew.transform.localPosition = new Vector3(_mergeDistance, 0, 0);
                }
            }

            if (_envNew)
            {
                _envNew.transform.localPosition += 2.5f * Time.deltaTime * -Vector3.right;

                if (_envNew.transform.localPosition.x < -5)
                {
                    Destroy(_envNew);
                    _env.transform.localPosition = _startPosition;
                }
            }
        }
  }
}

