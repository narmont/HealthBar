using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    public event UnityAction<int, int> HealthChanged;
    public event UnityAction<int, int> HealthValueChanged;

    public int Health => _health;

    private int _currentHealth;
    private int _minHealth = 0;

    private void Start()
    {
        _currentHealth = _health;
    }

    public void ApplyHealth(int value)
    {
        _currentHealth = Mathf.Clamp(_currentHealth += value, _minHealth, _health);

        HealthChanged?.Invoke(_currentHealth, _health);
        HealthValueChanged?.Invoke(_currentHealth, _health);
    }

    public void ApplyDamage(int value)
    {
        _currentHealth = Mathf.Clamp(_currentHealth -= value, _minHealth, _health);

        HealthChanged?.Invoke(_currentHealth, _health);
        HealthValueChanged?.Invoke(_currentHealth, _health);
    }
}
