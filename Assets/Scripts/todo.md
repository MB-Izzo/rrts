## TODOLIST: RRTS ##

- Monobehavior (units) with TimedAction
- Factory to create TimedAction (refactor TimeManager)
	- RegisterTimedAction inside the TimeManager (add to a list)
	- Deserialization handled by factory (deseria duration and start_time, to then create a TimedAction!)
- Save manager
	- Handle seria when quit the game on all units.
	- Return type (units, enemies...) with their TimedAction
- Load Manager
	- Deserialize and create gameObject on the fly.
	- Give it the good component, and the object to deserialize.
	- Time Manager use the ratio to do shits.
