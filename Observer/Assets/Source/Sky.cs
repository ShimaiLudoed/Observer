using Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace space
{
    public class Sky : IObserver
    {
        private SkyView _skyView;

        public Sky(SkyView skyView)
        {
            _skyView = skyView;
        }

        public void Update(float timeOfDay)
        {
            _skyView.ChangeColor(timeOfDay);
        }
    }
}