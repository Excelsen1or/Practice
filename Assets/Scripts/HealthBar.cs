using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour {
    public GameObject enemy;
    public int currentHealth = 30;

    public void Damage(int count) {
        currentHealth -= count;
    }

    void Update() {
        GetComponent<RectTransform>().position = Camera.main.WorldToScreenPoint(enemy.transform.position);
        GetComponent<TextMeshProUGUI>().text = currentHealth.ToString();
    }
}
