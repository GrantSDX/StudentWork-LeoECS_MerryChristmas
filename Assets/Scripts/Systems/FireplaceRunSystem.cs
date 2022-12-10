using UnityEngine;
using Leopotam.Ecs;
using Components;
using ScriptsComponents;

namespace Systems
{
    public class FireplaceRunSystem : IEcsRunSystem
    {
        private EcsFilter<FireplaceComponent> _filter1;
        public void Run()
        {
            foreach (var i in _filter1)
            {
                var fireplaceComponent = _filter1.Get1(i);


                if (Input.touchCount > 0)
                {
                    var touch = Input.GetTouch(0);
                    RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(touch.position), Vector3.forward);
                    if (hit.collider)
                    {
                        if (hit.collider.TryGetComponent(out CircleSwitcher circleSwitcher) && (touch.phase == TouchPhase.Began && touch.phase != TouchPhase.Stationary))
                        {
                            Debug.Log("Contact");
                            circleSwitcher.PressedSwitch(fireplaceComponent.Fireplace);
                        }
                    }
                }

            }
        }

    }
}