using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DecorateurButton
{
    public class BiggerEffect : IButton
    {
        public IButton ButtonOld{ get; set; }

        public BiggerEffect(IButton button)
        {
            this.ButtonOld = button;

        }

        public int GetHauteur()
        {
            return ButtonOld.GetHauteur() * 2;
        }

        public int GetLargeur()
        {
            return ButtonOld.GetLargeur() * 2;

        }

        public Color GetColor(Color color)
        {
            return ButtonOld.GetColor(color);
        }

        public int GetOpacite()
        {
            return ButtonOld.GetOpacite();
        }
    }
}
