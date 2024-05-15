using Godot;
using System;
using System.Collections.Generic;

public partial class LevelManager : Node
{
	List<Enemy> enemies = new List<Enemy>();
	List<Tower> towers;
	[Export] PackedScene enemyScene;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Node2D enemy1 = enemyScene.Instantiate<Node2D>();
		enemy1.GlobalPosition = new Vector2(50, 50);

		AddChild(enemy1);
		// GD.Print($"{enemy1}");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
