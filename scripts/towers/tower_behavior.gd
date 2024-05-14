extends Node
class_name Tower

@onready var timer = $Timer

@export var target : Enemy :
	set(value):
		if (value == null):
			target = null
			timer.stop()
		else:
			target = value
			timer.start()

func attack():
	target.take_damage(1)

func _on_timer_timeout():
	attack()
