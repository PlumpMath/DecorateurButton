using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DecorateurButton
{
    public interface IButton
    {
        int GetHauteur();
        int GetLargeur();
        int GetOpacite();
        Color GetColor(Color color);
    }
}
