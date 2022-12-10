using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leopotam.Ecs;
using Components;
using ScriptableObjects;
using ScriptsComponents;

namespace Systems
{
    public class FireplaceInitSystem : IEcsInitSystem
    {
        private readonly EcsWorld _world = null;
        private FireplaceInitData _fireplaceInitData;

        public void Init()
        {
            var fireplace = _world.NewEntity();
            var spawnedFireplace = GameObject.Instantiate(_fireplaceInitData.Fireplace.gameObject);

            ref var fireplaceComponent = ref fireplace.Get<FireplaceComponent>();
            fireplaceComponent.Fireplace = spawnedFireplace.GetComponent<Fireplace>();
            fireplaceComponent.Fireplace.WallInfo();
        }
    }
}