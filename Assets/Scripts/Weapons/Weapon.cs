using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace WeaponComponents
{
    public class Weapon : MonoBehaviour
    {
        [SerializeField] private int _damage;
        [SerializeField] private float _rate;
        [SerializeField] private float _delayBtwShots;

        [SerializeField] private Transform _shotPoint;
        [SerializeField] private Bullet _bullet;

        private bool _canShot = true;

        internal Action shot;

        private void OnEnable()
        {
            shot += MakeShot;
        }

        private void OnDisable()
        {
            shot -= MakeShot;
        }

        private void MakeShot()
        {
            if (_canShot)
            {
                StartCoroutine(WaitForDelay());
                Bullet bullet = Instantiate(_bullet, _shotPoint.position, transform.rotation);
                bullet._damage = _damage;
            }
        }

        private IEnumerator WaitForDelay()
        {
            _canShot = false;
            yield return new WaitForSeconds(_delayBtwShots / _rate);
            _canShot = true;
        }
    }
}
