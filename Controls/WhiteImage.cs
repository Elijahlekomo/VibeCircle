using CommunityToolkit.Maui.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VibeCircle.Controls
{
    public class WhiteImage : Image
    {
        public WhiteImage()
        {
            var tintColorBehavior = Behaviors.FirstOrDefault(b => b is IconTintColorBehavior);
            if(tintColorBehavior != null)
            {
                tintColorBehavior = new IconTintColorBehavior
                {
                    TintColor = Colors.White
                };
                Behaviors.Add(tintColorBehavior);
            }
        }
    }
}
