using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace GameScreenTest.screen
{
    public enum ScreenState
    {
        TransIn,
        Active,
        TransOut,
        Dead
    }

    public class Screen
    {
        #region Variables

        ScreenState screenState;

        bool isPopup;

        Game gameRef;

        ContentManager content;

        #endregion

        #region Properties

        public ScreenState ScreenState
        {
            get { return screenState; }
            protected set { screenState = value; }
        }

        public bool IsPopup
        {
            get { return isPopup; }
            protected set { isPopup = value; }
        }

        public Game GameRef
        {
            get { return gameRef; }
            protected set { gameRef = value; }
        }

        public ContentManager Content
        {
            get { return content; }
            protected internal set { content = value; }
        }

        #endregion

        #region Initialization

        public Screen(Game game)
        {
            GameRef = game;
            Content = new ContentManager(GameRef.Content.ServiceProvider, "Content");
        }

        #endregion

        public virtual void LoadContent() { }

        public void UnloadContent() 
        {
            Content.Unload();
        }

        public virtual void Update(GameTime gameTime) { }

        public virtual void Draw(SpriteBatch spriteBatch) { }
    }
}
