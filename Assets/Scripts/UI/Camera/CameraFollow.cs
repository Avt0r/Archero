using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] private int _distance;
    [SerializeField] private int _speed;
    [SerializeField] private Transform _target;
    private Vector3 _offset;

    private void Start()
    {
        _offset = _target.position - transform.position;
    }

    private void Update()
    {
        Follow();
    }

    private void Follow()
    { 
        //if ((transform.position - _target.position).magnitude > _distance)
        //{
            Vector3 target = new Vector3()
            {
                x = _target.position.x,
                y = _target.position.y,
                z = _target.position.z,
            } - _offset;

            Vector3 followVector = Vector3.Lerp(this.transform.position, target, _speed * 0.02f);

            transform.position = followVector;
        //}
    }
}
