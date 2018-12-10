using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalloutVideoGameClasses
{
    class GameList
    {
        public enum GameGenre
        {
            FPS,
            RPG,
            PLATFORM,
            ADVENTURE
        }

        #region FIELDS
        private string _name;
        private double _gameRating;
        private bool _splitscreenCoOp;
        private GameGenre _videoGameGenre;
        private string _creatorOfGame;
        #endregion


        #region PROPERTIES
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double GameRating
        {
            get { return _gameRating; }
            set { _gameRating = value; }
        }

        public bool SplitScreenCoOp
        {
            get { return _splitscreenCoOp; }
            set { _splitscreenCoOp = value; }
        }

        public GameGenre VideoGameGenre
        {
            get { return _videoGameGenre; }
            set { _videoGameGenre = value; }
        }

        public string CreatorOfGame
        {
            get { return _creatorOfGame; }
            set { _creatorOfGame = value; }
        }
        #endregion

        #region CONSTRUCTORS
        public GameList()
        {

        }

        public GameList(string name)
        {
            _name = name;
        }

        #endregion

        #region METHODS

        public string GameInfo()
        {
            if (_splitscreenCoOp == true)
            {
                return "\t\t" + _name + " is a " + _videoGameGenre + " style game,\n\t\t the game rating opinion is " + _gameRating + "\n\t\tit has Splitscreen Co-op Combatibility,\n\t\tand the Creator is " + _creatorOfGame + ".";
            }
            else
            {
                return "\t\t" + _name + " is a " + _videoGameGenre + " style game,\n\t\t the game rating opinion is " + _gameRating + "\n\t\tit does not have Splitscreen Co-op Combatibility,\n\t\tand the Creator is " + _creatorOfGame + ".";
            }

        }

        #endregion
    }
}
