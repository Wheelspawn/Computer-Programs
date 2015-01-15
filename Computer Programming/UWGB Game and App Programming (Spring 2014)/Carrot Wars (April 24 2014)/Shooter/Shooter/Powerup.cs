using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shooter
{
    class Powerup
    {
        public Animation PowerupAnimation;

        public Vector2 Position;

        public bool Active;

        public int Health;

        public float titleSafeAreaY;
        public float titleSafeAreaHeight;

        public int Width
        {
            get { return PowerupAnimation.FrameWidth; }
        }

        public int Height
        {
            get { return PowerupAnimation.FrameHeight; }
        }

        public float powerupMoveSpeed;

        public virtual void SetTimers(GameTime gameTime)
        {

        }

        public virtual void Initialize(Animation animation, Vector2 position)
        {
            // Load the enemy ship texture
            PowerupAnimation = animation;

            // Set the position of the enemy
            Position = position;

            // We initialize the enemy to be active so it will be updated
            Active = true;

            Health = 100000;

            powerupMoveSpeed = 8f;
        }

        public virtual void Update(GameTime gameTime)
        {
            // Update the position of the Animation
            Position.X -= powerupMoveSpeed;

            PowerupAnimation.Position = Position;

            // Update Animation
            PowerupAnimation.Update(gameTime);

            // If the enemy is past the screen or its health reaches 0, deactivate
            if (Position.X < -Width || Health <= 0)
            {
                // By setting the Active flag to false, the game will remove
                Active = false;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            // Draw the animation
            PowerupAnimation.Draw(spriteBatch);
        }

    }
}
