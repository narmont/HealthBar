using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private TextMeshProUGUI _healthText;

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
        HealthChanged?.Invoke(_currentHealth, _health);

        if (_currentHealth <= 0)
        {
            _currentHealth = 0;
        }
        else if (_currentHealth >= _health)
        {
            _currentHealth = _health;
        }

        _healthText.text = $"{_currentHealth} / {_health}";
    }
}
