using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;

namespace DataGrid
{
public class GenderTemplateSelector : DataTemplateSelector
{
    public DataTemplate MaleTemplate { get; set; }
    public DataTemplate FemaleTemplate { get; set; }

    public override DataTemplate SelectTemplate(object item, 
                  DependencyObject container)
    {
        var customer = item as Customer;
        if (customer == null)
            return base.SelectTemplate(item, container);

        if( customer.Gender == Gender.Male)
        {
            return MaleTemplate;
        }
        return FemaleTemplate;
    }
}
}
