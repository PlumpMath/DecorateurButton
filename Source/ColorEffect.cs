using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DecorateurButton
{
    public class ColorEffect : IButton
    {
        public IButton ButtonOld { get; set; }

        public ColorEffect(IButton button)
        {
            this.ButtonOld = button;

        }

        public int GetHauteur()
        {
            return ButtonOld.GetHauteur();
        }

        public int GetLargeur()
        {
            return ButtonOld.GetLargeur();

        }

        public int GetOpacite()
        {
            return ButtonOld.GetOpacite();
        }

        public Color GetColor(Color color)
        {
            return ButtonOld.GetColor(color);
        }
    }
}
