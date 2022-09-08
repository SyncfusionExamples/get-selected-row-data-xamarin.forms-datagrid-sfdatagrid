using Syncfusion.SfDataGrid.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DataGridXamarin
{
    public class CustomBehavior:Behavior<SfDataGrid>
    {
        #region Overrides
        protected override void OnAttachedTo(SfDataGrid bindable)
        {
            bindable.SelectionChanged += Bindable_SelectionChanged;
            base.OnAttachedTo(bindable);
        }

        private void Bindable_SelectionChanged(object sender, GridSelectionChangedEventArgs e)
        {
            OrderInfo selectedBatchRecord = (e.AddedItems[0] as OrderInfo);
        }

        protected override void OnDetachingFrom(SfDataGrid bindable)
        {
            bindable.SelectionChanged -= Bindable_SelectionChanged;
            base.OnDetachingFrom(bindable);
        }
        #endregion
    }
}
