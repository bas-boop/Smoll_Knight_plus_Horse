using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Baz_geluk9.HKU
{
    public sealed class HorseSelector : MonoBehaviour
    {
        [SerializeField] private HorseType playerHorse;

        private DontDestroyOnLoad _test;
            
        private void Awake()
        {
            _test = FindObjectOfType<DontDestroyOnLoad>();
            Debug.Log(_test.name);
        }

    }
}