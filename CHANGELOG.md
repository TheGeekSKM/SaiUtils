## [1.0.0] - 2024-09-21
### First Release
- Basically compiled the ScriptableVariables, GameEvents, and StateMachine into one project!

## [1.0.1] - 2024-09-21
### Singletons!!
- Added Generic Singletons to the mix. Now make any class a child of Singleton<T> and boom! Singleton!!

## [1.0.2] - 2024-09-21
### Transform Extensions
- Added SetPosition and SetLocalPosition to Transforms

## [1.0.3] - 2024-09-21
### SaiStaticUtils
- Added a static class for all my static function needs!!

## [1.0.4] - 2024-09-21
### Vector2Events and Trigger Controllers

## [1.0.5] - 2024-09-22
### Transform Extension Update -> GetClosestEntity
- Supply in a list of entities and GetClosestEntity will return the entity that is the closest to the player. 
  - It also helps that this is relatively more performant than using the Vector3.Distance since it does not use any sqrt functions!!