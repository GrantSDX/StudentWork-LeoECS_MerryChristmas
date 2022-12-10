using System.Collections;
using UnityEngine;

namespace ScriptsComponents
{
    public class CircleSwitcher : MonoBehaviour, ICircleSwitcher
    {
        [SerializeField] private Transform switcher;      
        [SerializeField] private float greenZoneAngleMin;
        [SerializeField] private float greenZoneAngleMax;
        [SerializeField] private float yellowZoneAngleMin;
        [SerializeField] private float yellowZoneAngleMax;
        [SerializeField] private bool switchPressed = false;


        public void SwitcherRotate(float angle)
        {           
            if(!switchPressed)
            switcher.rotation *= Quaternion.AngleAxis(angle * Time.deltaTime, Vector3.forward);      
        }


        public void PressedSwitch(IFireplace fireplace)
        {
            switchPressed = true;

            //Debug.Log("Min green = " + greenZoneAngleMin + " Max green = " + greenZoneAngleMax);
            //Debug.Log("Min yellow = " + yellowZoneAngleMin + " Max yellow = " + yellowZoneAngleMax);
            if ((int)switcher.eulerAngles.z > yellowZoneAngleMin && (int)switcher.eulerAngles.z < yellowZoneAngleMax)
            {
                if ((int)switcher.eulerAngles.z > greenZoneAngleMin && (int)switcher.eulerAngles.z < greenZoneAngleMax)
                {
                    Debug.Log("GreenZone" + (int)switcher.eulerAngles.z);
                    fireplace.AddLightingToWall(1f);
                   
                }
                else
                {
                    Debug.Log("YelowZone" + (int)switcher.eulerAngles.z);
                    fireplace.AddLightingToWall(0.5f);
                }
            }
            else
            {
                Debug.Log("RedZone" + (int)switcher.eulerAngles.z);
                fireplace.RemoveLightingToWall(1f);
            }
        }
      
    }
}