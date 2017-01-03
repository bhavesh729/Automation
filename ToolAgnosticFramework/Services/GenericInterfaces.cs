using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IFindElement<T>
    {
        T ByAttributeValue(string name, string value, T parent); 
        T ByCSS(string selector, T parent);
        T ByXpath(string xpath, T parent);
    }

    public interface IMouse<T>
    {
        void Click(T element);
        void DoubleClick(T element);
        void RightClick(T element);
        void Drag(T element, int x, int y);
        void Hover(T element);
    }

    public interface IKeyboard<T>
    {
        void SetText(T Element, string value);        
    }

    public interface IRead<T>
    {
        string GetText(T Element);
        bool IsVisible(T Element);
        bool IsEnabled(T Element);
    }
}
