using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public interface IObserverable
    {
        public void AddListener(IObserver observer);
        public void RemoveListener(IObserver observer);
        public void Notify();
    }
}