using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;



namespace Shooter
{
    class Boss :  Enemy
    {
        bool direction;
        // The rate at which the boss will change direction
        TimeSpan bossChangeDirectionTime;
        TimeSpan previousBossDirectionTime;
        TimeSpan directionChangeExpire;

        
        bool changedDirection;
        bool up;
        Random random;

        public override void SetTimers(GameTime gameTime)
        {
            // Used to determine when the boss will change direction for a period of time
            bossChangeDirectionTime = gameTime.TotalGameTime + TimeSpan.FromSeconds(1.0f);
            previousBossDirectionTime = TimeSpan.Zero;
            directionChangeExpire = TimeSpan.Zero;
        }
        public override void Initialize(Animation animation, Vector2 position)
        {
            base.Initialize(animation, position);
            changedDirection = false;
            up = false;
            random = new Random();
            if (random.Next(1) == 1)
            {
                up = true;
            }                                    
        }
        public override void Update(GameTime gameTime)
        {
            // The boss usually moves left but sometimes moves up or down
            if (gameTime.TotalGameTime > bossChangeDirectionTime)
            {
                if (!changedDirection)
                {
                    changedDirection = true;
                    directionChangeExpire = gameTime.TotalGameTime + TimeSpan.FromSeconds(0.4f);
                }
                if (up)
                {
                    Position.Y -= enemyMoveSpeed;
                }
                else
                {
                    Position.Y += enemyMoveSpeed;
                }
                Position.Y = MathHelper.Clamp(Position.Y, 0, titleSafeAreaY + titleSafeAreaHeight);

            }
            else
            {
                Position.X -= enemyMoveSpeed;
            }
            if (changedDirection && gameTime.TotalGameTime > directionChangeExpire)
            { //stop changing direction
                changedDirection = false;
                bossChangeDirectionTime = gameTime.TotalGameTime + TimeSpan.FromSeconds(3);
            }

            // Update the position of the Animation
            EnemyAnimation.Position = Position;

            // Update Animation
            EnemyAnimation.Update(gameTime);

            // If the enemy is past the screen or its health reaches 0, deactivate
            if (Position.X < -Width || Health <= 0)
            {
                // By setting the Active flag to false, the game will remove
                Active = false;
            }
        }
    }
}
