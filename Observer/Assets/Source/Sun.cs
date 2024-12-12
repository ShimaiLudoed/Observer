using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : IObserver
{
    private SunView _view;

    public Sun(SunView view)
    {
        _view = view;
    }

    public void Update(float timeOfDay)
    {
        _view.SunOrbit(timeOfDay);
    }
}
