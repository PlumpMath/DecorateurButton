using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DecorateurButton
{
    public class HideEffect : IButton
    {
        public IButton ButtonOld { get; set; }

        public HideEffect(IButton button)
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

        public Color GetColor(Color color)
        {
            return ButtonOld.GetColor(color);
        }

        public int GetOpacite()
        {
            return ButtonOld.GetOpacite()*0;
        }
    }
}
