using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SlidingUI
{
    public class Sliding : MonoBehaviour
    {

        [SerializeField] private Transform _targetToSlide;

        [SerializeField] private Page _equipment;
        [SerializeField] private Page _home;

        public void ShowPageEquipment()
        {
            _home.stop?.Invoke();

            Debug.Log("Show Equipment");
            
            _equipment.slide(_targetToSlide);          
        }

        public void ShowPageHome()
        {
            _equipment.stop?.Invoke();

            Debug.Log("Show Home");

            _home.slide(_targetToSlide);
        }
    }
}
