using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Core
{
    public interface IObserver
    {
        public void Update(float timeOfDay);
    }
}