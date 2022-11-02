# SquidCandyInvaders
The final project for the Basics of Game Development course.

#AboutTheProject
This project was made during one-two week as a final project for the Basics of Game Development course at Tallinn University.

The project's primary focus is to create a Space Invaders game from scratch.

The important keys are

1. Graphics - 
Use different graphics
Correct image file types are fully compatible* with the Unity game engine.
Dynamic background effect with the particle system.
*The dimensions/resolutions for the images need to be corrected and adjusted.

2. Audio -
- Different SFX and BGM
- Correct audio file types for SFX and loops fully compatible with the Unity game engine.

3. UI 
- Multiple UI elements used.
- Different ending UI elements, which have dynamically changed the value in it. 

4. Mechanics
- Enemies attack.
- Enemies approach the player.
- Player can move up/down.
- The player has multiple lives/tries.
- Enemies don't shoot after the player loses a life.
- Game win/over endings.
- Easter Egg.
- Different Endings.

#AboutAssets

All assets (graphics, sound, and music) are downloaded free from the websites providing free assets. One of the music is originally made by me.

#FurtherContributionsAndCurrentBugs
- The enemy movement shifts outside the screen bounds to the right side.
- Clean up the code from unused parts.
- Hard-coded magic numbers that affect the game design element.
- In the KillerDoll script, the upScreenEdge value isn't defined and is 0 by default.
- In KillerDoll script, since the audioShoot variable overrides the inspector anyway.
- Inconsistent function naming. 
- There's no need for scripts to have an extra variable to store a reference to the game object they're on, 
- The candyProjectile variable in the CandyProjectile script isn't assigned a value, and thus the enemy projectiles need to be removed from the screen properly.
- It's better for the "lives" and "playGame" variables in the GameManager to be encapsulated in functions for proper separation between the GameManager.
- It's better to move the respawn and reset audio sounds from CandyProjectile to another, more meaningful, script. 
- In Candies script, the number 18 is a magic number and should be placed in a variable.
- In Candies script, in candyFiresOnTheDoll function, since the second argument of the Random.Range() function affects the game's difficulty; it's better to have it as a variable that can be set free from the inspector or stored as a variable in some way, not to have it as a magic number.

#RunTheGame
Play the game here: http://www.tlu.ee/~artyom/BOGD/SquidCandyVSDoll/
The game is created on Unity/C# for WebGL.
