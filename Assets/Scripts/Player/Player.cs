using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _healthText;
    [SerializeField] private int _health;

    public event UnityAction<int, int> HealthChanged;

    private int _currentHealth;

    private void Start()
    {
        _currentHealth = _health;
        _healthText.text = $"{_currentHealth} / {_health}";
    }

    public void ApplyHealth(int value)
    {
        _currentHealth += value;

        if (_currentHealth <= 0)
        {
            _currentHealth = 0;
        }
        else if (_currentHealth >= _health)
        {
            _currentHealth = _health;
        }

        _healthText.text = $"{_currentHealth} / {_health}";

        HealthChanged?.Invoke(_currentHealth, _health);
    }
}
