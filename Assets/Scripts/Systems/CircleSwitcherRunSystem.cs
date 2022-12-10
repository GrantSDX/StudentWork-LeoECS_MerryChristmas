using UnityEngine;
using Leopotam.Ecs;
using Components;
using ScriptsComponents;

namespace Systems
{
    public class CircleSwitcherRunSystem : IEcsRunSystem
    {
        private EcsFilter<CircleSwitcherComponent> _filter;
        public void Run()
        {

            foreach (var i in _filter)
            {
                var circleSwitcher = _filter.Get1(i);
                
                circleSwitcher.CircleSwitcher.SwitcherRotate(-200f);

            }
        }

       
    }
}