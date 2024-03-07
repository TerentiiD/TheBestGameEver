using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float value = 100;
    public RectTransform valueRectTransform;

    public GameObject gameplayUI;
    public GameObject gameOverScreen;

    private float _maxValue;
    private void Start()
    {
        _maxValue = value;
        valueRectTransform.anchorMax = new Vector2(value / _maxValue, 1);
    }

    public void DealDamage(float damage)
    {
        value -= damage;
        if (value <= 0)
        {
            gameplayUI.SetActive(false);
            gameOverScreen.SetActive(true);
            GetComponent<PlayerController>().enabled = false;
            GetComponent<FireballCaster>().enabled = false;
            GetComponent<CameraRotation>().enabled = false;
        }

        valueRectTransform.anchorMax = new Vector2(value / _maxValue, 1);
    }
    public void AddHealth(float amount)
    {
        value += amount;
        value = Mathf.Clamp(value, 0, _maxValue);
        valueRectTransform.anchorMax = new Vector2(value / _maxValue, 1);
    }
}
