using ScriptsComponents;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "FireplaceInitData", menuName = "ScriptableObjects/FireplaceInitData", order =0)]
    public class FireplaceInitData : ScriptableObject
    {
        [SerializeField] private Fireplace fireplace;
        public Fireplace Fireplace => fireplace;
    }
}