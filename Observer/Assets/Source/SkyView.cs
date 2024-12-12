using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace space
{
    public class SkyView : MonoBehaviour
    {
        [SerializeField] private Color morningColor;
        [SerializeField] private Color dayColor;
        [SerializeField] private Color eveningColor;
        [SerializeField] private Color nightColor;
        [SerializeField] private Gradient skyGradient;
        [SerializeField] private SpriteRenderer _sprite;


        public void ChangeColor(float timeOfDay)
        {

            Color targetColor;

            if (timeOfDay < 0.25f)
            {
                targetColor = Color.Lerp(morningColor, dayColor, timeOfDay * 4);
            }
            else if (timeOfDay < 0.5f)
            {
                targetColor = Color.Lerp(dayColor, eveningColor, (timeOfDay - 0.25f) * 4);
            }
            else if (timeOfDay < 0.75f)
            {
                targetColor = Color.Lerp(eveningColor, nightColor, (timeOfDay - 0.5f) * 4);
            }
            else
            {
                targetColor = Color.Lerp(nightColor, morningColor, (timeOfDay - 0.75f) * 4);

            }

            _sprite.color = targetColor;
        }
    }
}