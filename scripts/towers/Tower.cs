using Godot;
using System;

public partial class Tower : Node
{
	Timer attackCooldownTimer;
	private Enemy target;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		attackCooldownTimer = GetNode<Timer>("AttackCooldownTimer");
	}

	public void SetTarget(Enemy target)
	{
		this.target = target;
		if (attackCooldownTimer.IsStopped())
		{
			attackCooldownTimer.Start();
		}
	}

	public void ClearTarget()
	{
		target = null;
		attackCooldownTimer.Stop();
	}
}
