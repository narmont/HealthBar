using UnityEngine;

public class HealthBar : Bar
{
    [SerializeField] private Player _player;
    [SerializeField] private int _increaseHealth;
    [SerializeField] private int _reduceHealth;

    private void OnEnable()
    {
        _player.HealthChanged += OnValueChanged;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= OnValueChanged;
    }

    public void Increase(Player target)
    {
        target.ApplyHealth(_increaseHealth);
    }

    public void Reduce(Player target)
    {
        target.ApplyHealth(-_reduceHealth);
    }
}
