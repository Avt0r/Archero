using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SlidingUI
{
    public class Page : MonoBehaviour
    {

        private Transform _targetToSlide;

        internal Action<Transform> slide;
        internal Action stop;

        private void OnEnable()
        {
            slide += StartSlide;
            stop += StopAllCoroutines;
        }

        private void OnDisable()
        {
            slide -= StartSlide;
            stop -= StopAllCoroutines;
        }

        private void StartSlide(Transform target)
        {
            _targetToSlide = target; 
            StartCoroutine(Slide());
        }

        private IEnumerator Slide()
        {
            Debug.Log("Slide started", gameObject);
            while (true)
            {
                yield return new WaitForFixedUpdate();

                Vector3 slide = Vector3.Lerp(transform.position, _targetToSlide.position, 0.3f);

                transform.position = slide;
            }
            Debug.Log("Slide stopped", gameObject);
        }
    }
}
