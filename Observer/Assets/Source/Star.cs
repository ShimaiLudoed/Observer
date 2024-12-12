using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : IObserver
{
    private StarView _starView;

    public Star(StarView starView)
    {
        _starView=starView;
    }
    public void Update(float timeOfDay)
    {
       _starView.ChangeStarsAlpha(timeOfDay);
    }
}