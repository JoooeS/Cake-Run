using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cake_Run
{
    class Cloud
    {
        public int colour, xLoc, yLoc, xSize, ySize;
        public Image cloudColour;

        /// <summary>
        /// Constructor Method for target clouds
        /// </summary>
        /// <param name="_colour">R,G,B, or Y</param>
        /// <param name="_xLoc">X Location</param>
        /// <param name="_yLoc">Y Location</param>
        /// <param name="_xSize">X Size </param>
        /// <param name="_ySize">Y Size</param>
        /// <param name="_cloudColour">Iamge file with corresponding colour</param>
        public Cloud (int _colour, int _xLoc, int _yLoc, int _xSize, int _ySize, Image _cloudColour)
        {
            colour = _colour;
            xLoc = _xLoc;
            yLoc = _yLoc;
            xSize = _xSize;
            ySize = _ySize;
            cloudColour = _cloudColour;
        }
    }
}
