extends Node
class_name Enemy

signal death

@export var health: int = 10 :
	set(value):
		if (value <= 0):
			die()
		else:
			health = value

func take_damage(damage:int):
	health -= damage
	print(str(health))

func die():
	emit_signal("death")
	queue_free()
