using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WeaponComponents
{
    public class WeaponController : MonoBehaviour
    {
        [SerializeField] private Weapon _weapon;

        private void Update()
        {
            if(Input.GetMouseButton(0))
            {
                _weapon.shot?.Invoke();
            }
        }
    }
}
