# BouncyBall
A simple interactive physics simulation with a ball.

End goal is to have the ball bounce around the form window smoothly.

### Key files:

FormMain.cs

BallPhysics.cs

Ball.cs

# Progression
---
### rev2

Got all the skeleton in place for the form layout and appearance. 

Got a feel for events such as MouseClick and got the text to successfully disappear when the mouse is held down.

Later I would realize that I can just specify that the text label is not allowed to have focus, and that will make it disappear when I click on it.

![rev2](https://i.imgur.com/v5XB4Vu.gif)

---
### rev3

Got the ball to draw upon clicking the mouse, although I didn't bother getting it centered just yet. Focusing on small steps.

![rev3](https://i.imgur.com/i5DSH3Q.gif)

---
### rev4

This is when I figured out the setting to make elements non-focusable.

As you can see, the ball correctly updates position even if I click inside it's drawbox.

![rev4](https://i.imgur.com/pkvbWxc.gif)

---
### rev5

Enlarged the ball for better visibility.

The ball now centers on the mouse pointer.

![rev5](https://i.imgur.com/bJXrqx0.gif)

---
### rev6

Implemented ball physics.

As you can see, I was having some trouble with absolute/relative mouse coordinates. Relative coordinates are not always available depending on where in the scope you try to reference them.

![rev6](https://i.imgur.com/aZ6UJJ4.gif)

---
### rev7

Ball position is now consistent with release point. I figured out how to deal with the relative/absolute mouse position stuff.

Ball physics are working ok, but not as smooth as I would like. Not sure how complicated it's going to be to fix. I'm running the physics loop at a time step of 7 milliseconds, so maybe if I increase that to be closer to 60 Hz rather than my monitor's 144 Hz.

Next step is implementing collision with the form walls.

![rev7](https://i.imgur.com/UHL9Jap.gif)
