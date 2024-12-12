using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : IObserverable
{
    private List<IObserver> _observers;
    private float _timeOfDay;
    private float _duration;

    public Timer(float duration,float timeOfDay, List<IObserver> observers)
    {
        _observers = observers;
        _duration=duration;
        _timeOfDay=timeOfDay;
    }

    public void AddListener(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_timeOfDay);
        }
    }

    public void RemoveListener(IObserver observer)
    {
        _observers.Remove(observer);
    }
    public void Update()
    {
        _timeOfDay += Time.deltaTime / _duration;
        if (_timeOfDay >= 1) _timeOfDay = 0;

        Notify();
    }
}
