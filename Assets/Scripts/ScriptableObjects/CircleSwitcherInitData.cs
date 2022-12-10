using ScriptsComponents;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "CircleSwitcherInitData", menuName = "ScriptableObjects/CircleSwitcherInitData", order = 0)]
    public class CircleSwitcherInitData : ScriptableObject
    {
        [SerializeField] private CircleSwitcher circleSwitcher;
        public CircleSwitcher CircleSwitcher => circleSwitcher;
    }
}