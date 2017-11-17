## 1. TimedAction
 
Create a class named TimedAction.
 
TimedAction contains a constructor asking for the two following parameters:
* float time_started
* float duration
 
TimedAction contains two public assessors (read only):
* float time_started: the time when the action started
* float duration: the duration of the action
 
## 2. TimeManager
 
Create a static class named TimeManager.
 
TimeManager has a public function that asks for one parameter:
* TimedAction CreateTimedAction(float duration);
 
The TimedAction object returned has its field duration with the same value as the given parameter. Its field time_started has the value of time (game time) at the moment of its creation.
 
## 3. Update
 
Update TimedAction class to add a public accessor (read only):
* float action_ratio: going from 0 to 1, describing the current state of the action (0 it has just begun, 0.5 action is half way to completion, 1 action is complete).
 
action_ration value is updated directly via TimeManager. At every tick / update TimeManager calls a new function in returned TimedAction:
* void Update(float delta_time);
 
delta_time parameter represents the time elapsed since last tick / update.
 
## 4. Resync
 
Update TimedAction to change the value time_started by a more complex object describing the date and time of its creation.
 
Update TimeManager to create a new function that asks for two parameters:
* TimedAction CreateTimedAction(float duration, _complex_object_describing_date_and_time date_time);
 
This new version of CreateTimedAction does the exact same thing that CreateTimedAction(float duration), but allows programmers to define at what date and time the TimedAction has been (or will be) started.
 
TimeManager now calls Update only on valid TimedAction (don't update not started action - with date and time in future - and don't update finished action - with ratio over -)

## 5. Recreate

Update TimeManager to create a new function that asks for one parameters:
* TimedAction CreateTimedAction(TimedAction existing_action);

This will register the TimedAction Object into TimeManager (if needed) and returns it.

## 6. Serialize

Make TimedAction class serializable and add a function to it:
* string SerializeToJSON();

This will return a JSON compliant string describing the TimedAction object.

## 7. Unserialize

Update TimeManager to add a new function that asks for one parameter:
* TimedAction CreateTimedAction(string timed_action_json);

This function takes a JSON string describing a TimedAction, create it, register it into TimeManager then returns it.