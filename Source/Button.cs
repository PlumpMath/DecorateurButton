using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DecorateurButton
{
    public class Button : IButton
    {
        int hauteur;
        int largeur;
        Color color;
        int opacite;

        public Button(int H, int L, Color C, int O)
        {
            this.hauteur = H;
            this.largeur = L;
            this.color = C;
            this.opacite = O;
        }


        public int GetHauteur()
        {
            return hauteur;
        }

        public int GetLargeur()
        {
            return largeur;
            
        }

        public int GetOpacite()
        {
            return opacite;
        }

        public Color GetColor(Color color)
        {
            return color;
        }

    }
}
