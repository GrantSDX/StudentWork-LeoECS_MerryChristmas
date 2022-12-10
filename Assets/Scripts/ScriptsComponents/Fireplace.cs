using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptsComponents
{
    public class Fireplace : MonoBehaviour, IFireplace
    {
        [SerializeField] private SpriteRenderer wall;


        public void AddLightingToWall(float alpha)
        {
            wall.color = new Color(wall.color.r, wall.color.g, wall.color.b, wall.color.a - alpha);
            Debug.Log("Add = " + wall.color.a);
        }

        public void RemoveLightingToWall(float alpha)
        {

            wall.color = new Color(wall.color.r, wall.color.g, wall.color.b, wall.color.a + alpha);
            Debug.Log("Remove = " + wall.color.a);
        }

        public void WallInfo()
        {
            Debug.Log("Info = " + wall.color.a);
        }
    }
}