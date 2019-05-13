using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMusic
{
    public class Theme
    {
        public string themeType;
        public int[] textColor = new int[3];
        public int[] cellColor = new int[3];
        public int[] gridColor = new int[3];
        public int[] buttonColor = new int[3];
        public int[] sidebarColor = new int[3];

        public Theme(string themeType, int textColor1, int textColor2,
            int textColor3, int cellColor1, int cellColor2, int cellColor3,
            int gridColor1, int gridColor2, int gridColor3, int buttonColor1, 
            int buttonColor2, int buttonColor3, int sidebarColor1,
            int sidebarColor2, int sidebarColor3)
        {
            this.themeType = themeType;

            this.textColor[0] = textColor1;
            this.textColor[1] = textColor2;
            this.textColor[2] = textColor3;

            this.cellColor[0] = cellColor1;
            this.cellColor[1] = cellColor2;
            this.cellColor[2] = cellColor3;

            this.gridColor[0] = gridColor1;
            this.gridColor[1] = gridColor2;
            this.gridColor[2] = gridColor3;

            this.buttonColor[0] = buttonColor1;
            this.buttonColor[1] = buttonColor2;
            this.buttonColor[2] = buttonColor3;

            this.sidebarColor[0] = sidebarColor1;
            this.sidebarColor[1] = sidebarColor2;
            this.sidebarColor[2] = sidebarColor3;
        }
    }
}
