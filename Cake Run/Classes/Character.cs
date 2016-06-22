using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using WMPLib;

namespace Cake_Run
{
    class Character
    {
        public int xLoc, yLoc, xSize, ySize, cloudsCleared, errorCount, animate, xDifference;
        public Image playerCloud;

        /// <summary>
        /// Constructor Method for player cloud
        /// </summary>
        /// <param name="_xLoc">X Location</param>
        /// <param name="_yLoc">Y Location</param>
        /// <param name="_xSize">X Size </param>
        /// <param name="_ySize">Y Size</param>
        /// <param name="_cloudsCleared">The number of clouds cleared</param>
        /// <param name="_errorCount">Count time for a mistake</param>
        /// <param name="_animate">Count time for animation</param>
        /// <param name="_xDifference">X difference between the next cloud and the player</param>
        /// <param name="_playerCloud">Iamge file with corresponding picture, cute cloud</param>
        public Character (int _xLoc, int _yLoc, int _xSize, int _ySize, int _cloudsCleared, int _errorCount, int _animate, int _xDifference, Image _playerCloud)
        {
            xLoc = _xLoc;
            yLoc = _yLoc;
            xSize = _xSize;
            ySize = _ySize;
            cloudsCleared = _cloudsCleared;
            errorCount = _errorCount;
            animate = _animate;
            xDifference = _xDifference;
            playerCloud = _playerCloud;
        }
    }
}
