using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootStrapper : MonoBehaviour
{
    private Star _star;
    [SerializeField] private StarView starView;
    private Sun _sun;
    [SerializeField] private SunView sunView;
    private Sky _sky;
    [SerializeField] private SkyView skyView;
    private Timer _timer;
    [SerializeField] private float duration;
    [SerializeField] private float timeOfDay;
    [SerializeField] private List<IObserver> observers;
    private void Awake()
    {
        //IENUMERABLE
        observers = new List<IObserver>();
        _star = new(starView);
        _sky=new Sky(skyView);
        _sun = new Sun(sunView);
        _timer = new Timer(duration, timeOfDay, observers);
        _timer.AddListener(_sun);
        _timer.AddListener(_sky);
        _timer.AddListener(_star);


    }

    private void Update()
    {
        _timer.Update();
    }
}
