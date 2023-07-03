using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    [SerializeField] protected Player Player;
    [SerializeField] private Slider _slider;

    private Coroutine _changeHealth;
    private float _value;
    private float _speedChangesHealth = 0.5f;

    public void OnValueChanged(int currentHealth, int maxHealth)
    {
        _value = (float)currentHealth / maxHealth;
    }

    public void SwitchHealth(int value)
    {
        Player.ApplyHealth(value);

        if (_changeHealth != null)
        {
            StopCoroutine(ChangeHealth());
        }

        _changeHealth = StartCoroutine(ChangeHealth());     
    }

    private IEnumerator ChangeHealth()
    {
        while (_slider.value != _value)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _value, _speedChangesHealth * Time.deltaTime);

            yield return null;
        }
    }
}
