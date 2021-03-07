using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarWidget : MonoBehaviour
{
    public Image healthBarImage;


    public void UpdateHealth(int currentHealth, int maxHealth)
    {
        var ratio = (float) currentHealth / maxHealth;

        healthBarImage.fillAmount = ratio;
    }
}
