using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace space
{
    public class StarView : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer[] stars;
        private float _minAlpha = 0f;
        private float _maxAlpha = 1f;

        public void ChangeStarsAlpha(float timeOfDay)
        {
            float alpha;

            if (timeOfDay < 0.25f)
            {
                alpha = Mathf.Lerp(1f, 0f, timeOfDay * 4);

            }
            else if (timeOfDay < 0.5f)
            {
                alpha = 0f;

            }
            else if (timeOfDay < 0.75f)
            {
                alpha = Mathf.Lerp(0f, 1f, (timeOfDay - 0.5f) * 4);

            }
            else
            {
                alpha = 1f; ;
            }

            foreach (SpriteRenderer star in stars)
            {
                Color starColor = star.color;
                star.color = new Color(starColor.r, starColor.g, starColor.b, alpha);
            }
        }
    }
}