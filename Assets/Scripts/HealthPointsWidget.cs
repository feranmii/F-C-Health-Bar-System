using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPointsWidget : MonoBehaviour
{
    public GameObject healthPrefab;

    public GameObject healthParent;

    public List<GameObject> healthObjects = new List<GameObject>();

    private void Awake()
    {
        
    }

    public void Init(int maxHealth)
    {
        for (int i = 0; i < maxHealth; i++)
        {
            var hp = Instantiate(healthPrefab, healthParent.transform, true);
            healthObjects.Add(hp);
        }
    }

    [ContextMenu("Add Health")]
    public void AddHealth()
    {
        var hp = Instantiate(healthPrefab, healthParent.transform, true);
        healthObjects.Add(hp);
    }

    [ContextMenu("Remove Health")]
    public void RemoveHealth()
    {
        var hp = healthObjects[healthObjects.Count - 1];
        
        healthObjects.Remove(hp);
        Destroy(hp);
    }
}