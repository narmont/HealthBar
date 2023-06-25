using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    [SerializeField] protected Slider Slider;

    private float _value = 1;
    private float _speedChangesHealth = 0.5f;

    public void OnValueChanged(int currentHealth, int maxHealth)
    {
        _value = (float) currentHealth / maxHealth;

    }

    private void Update()
    {
        Slider.value = Mathf.MoveTowards(Slider.value, _value, _speedChangesHealth * Time.deltaTime);
    }
}
