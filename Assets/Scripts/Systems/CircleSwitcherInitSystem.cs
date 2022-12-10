using System.Collections;
using UnityEngine;
using Leopotam.Ecs;
using Components;
using ScriptableObjects;
using ScriptsComponents;

namespace Systems
{
    public class CircleSwitcherInitSystem : IEcsInitSystem
    {
        private readonly EcsWorld _world = null;
        private CircleSwitcherInitData _circleSwitcherInitData;
        public void Init()
        {
            var circleSwitcher = _world.NewEntity();
            var switcher = GameObject.Instantiate(_circleSwitcherInitData.CircleSwitcher.gameObject);
            
            ref var circleSwitcherComponent = ref circleSwitcher.Get<CircleSwitcherComponent>();
            circleSwitcherComponent.CircleSwitcher = switcher.GetComponent<CircleSwitcher>();
            
            

        }
    }
}