using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp1.Class;

namespace MauiApp1.Selector
{
    public class StudentSelector : DataTemplateSelector
    {
        public DataTemplate ManTemplate { get; set; }
        public DataTemplate WomanTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((Student)item).Gender.Equals("M") ? ManTemplate : WomanTemplate;
        }
    }
}
