public class HealthBar : Bar
{
    private void OnEnable()
    {
        Player.HealthChanged += OnValueChanged;
    }

    private void OnDisable()
    {
        Player.HealthChanged -= OnValueChanged;
    }
}
