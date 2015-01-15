using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Shooter
{
    class Eggplant
    {
        // Animation representing the enemy
        public Animation EggplantAnimation;

        // The position of the enemy ship relative to the top left corner of thescreen
        public Vector2 Position;

        // The state of the Enemy Ship
        public bool Active;

        // The hit points of the enemy, if this goes to zero the enemy dies
        public int Health;

        // The amount of damage the enemy inflicts on the player ship
        public int Damage;

        // The amount of score the enemy will give to the player
        public int Value;

        public bool isBoss;

        public float titleSafeAreaY;
        public float titleSafeAreaHeight;

        // Get the width of the enemy ship
        public int Width
        {
            get { return EggplantAnimation.FrameWidth; }
        }

        // Get the height of the enemy ship
        public int Height
        {
            get { return EggplantAnimation.FrameHeight; }
        }

        // The speed at which the enemy moves
        public float eggplantMoveSpeed;

        public virtual void SetTimers(GameTime gameTime)
        {

        }
        public virtual void Initialize(Animation animation, Vector2 position)
        {
            // Load the enemy ship texture
            EggplantAnimation = animation;

            // Set the position of the enemy

            // We initialize the enemy to be active so it will be updated
            Active = true;


            // Set the health of the enemy
            Health = 20;

            // Set the amount of damage the enemy can do
            Damage = 10;

            // Set how fast the enemy moves
            eggplantMoveSpeed = 3f;

            // Set the score value of the enemy
            Value = 200;
        }


        public virtual void Update(GameTime gameTime)
        {
            // The enemy always moves to the left so decrement x
            Position.X -= eggplantMoveSpeed;            

            // Update the position of the Animation
            EggplantAnimation.Position = Position;

            // Update Animation
            EggplantAnimation.Update(gameTime);

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
            EggplantAnimation.Draw(spriteBatch);
        }

    }
}