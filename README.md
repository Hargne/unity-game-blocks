# Unity GameBlocks

Blocks for modularizing variables in Unity

## Variables

```C#
public GameBlocks.FloatReference variableName;
```

In the inspector you may define this block as either a **constant**, or as a **variable**.

### As a Variable

Create a new asset -> _Assets/GameBlocks/Float_ and use this to reference the same variable within multiple scripts. The variable will be synched between all instances.

## Events

- Create a new `GameEvent` asset -> _Assets/GameBlocks/GameEvent_
- Within the script that should broadcast the event, add a variable: `public GameBlocks.GameEvent eventToBeTriggered;`
- Trigger the event using `eventToBeTriggered.Raise();`
- Target the `GameEvent` in the inspector of the broadcasting script.
- For each GameObject that should listen to the event, add a `GameEventListener`. Add the newly created `GameEvent` asset to the `Event` property, Reference the GameObject and the method that should be triggered.
