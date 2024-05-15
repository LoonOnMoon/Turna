using Godot;

public partial class Enemy : Node2D
{
	[Signal]
	public delegate void EnemyDeathEventHandler();

	[Export]
	double health;

	public Enemy()
	{
		health = 10;
	}

    private void Die()
    {
        EmitSignal(SignalName.EnemyDeath);
    }

	public void TakeDamage(double damage)
	{
		health -= damage;
		if (health <= 0)
		{
			Die();
			return;
		}
		GD.Print($"Health: {health}");
	}
}
