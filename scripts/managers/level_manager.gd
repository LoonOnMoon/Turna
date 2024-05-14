extends Node

#var plots: Dictionary{int,Tower}

@onready var tower = $Tower
@onready var enemy = $Enemy

# Called when the node enters the scene tree for the first time.
func _ready():
	tower.target = enemy

func _on_enemy_death():
	tower.target = null
