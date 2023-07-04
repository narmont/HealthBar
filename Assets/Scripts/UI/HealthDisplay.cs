using TMPro;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _healthText;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.HealthValueChanged += OnValueChanged;
    }

    private void OnDisable()
    {
        _player.HealthValueChanged -= OnValueChanged;
    }

    private void Start()
    {
        _healthText.text = $"{_player.Health} / {_player.Health}";
    }

    public void OnValueChanged(int currentHealth, int health)
    {
        _healthText.text = $"{currentHealth} / {health}";
    }
}
