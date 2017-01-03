using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface FindElement
    {
        object ByAttributeValue(string name, string value, object parent);
        object ByCSS(string selector, object parent);
        object ByXpath(string xpath, object parent);
    }

    public interface Mouse
    {
        void Click(object element);
        void DoubleClick(object element);
        void RightClick(object element);
        void Drag(object element, int x, int y);
        void Hover(object element);
    }

    public interface Keyboard
    {
        void SetText(object element, string value);        
    }

    public interface Read
    {
        string GetText(object element);
        bool IsVisible(object element);
        bool IsEnabled(object element);
    }
}
